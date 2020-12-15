using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public partial class Form1 : Form
    {
        private bool redyToPlay = false;
        private string IpAddress; // משתנה זה בסופו של דבר יחזיק את הכתובת של המחשב 
        private TcpListener tcpLsn; // בודק האם הגיע לקוח חדש
        private Thread tcpThd; // הגדרת אובייקט של תהליך
        private static long connectId = 0; // משתנה ששומר את מספר הלקוחות שהתחברו ואת מספר הלקוח 
        private Hashtable dataHolder = new Hashtable();// טבלה שמכילה את כל נתוני הלקוחות
        private int ClientConnected = 0;
        private string NameOfUsers = "";
     
        
        public Form1()
        {
            InitializeComponent();//פונקציה שמופיעה באופן אוטומטי בפתיחת פרוייקט חדש 
            GetIpAdDress(); //פונקציה
            tcpLsn = new TcpListener(System.Net.IPAddress.Parse(IpAddress), 8002);//  יצירת מאזין- מחכה לראות מי מתחבר
            tcpLsn.Start();// מפעילה את המאזין
            lblInfo.Text = "Listen at: " + tcpLsn.LocalEndpoint.ToString();// מציג את הכתובת והפורט
            tcpThd = new Thread(new ThreadStart(NewClientConnected));// יצירת תהליך שאומרת לתוכנה כול מה שרשום בפוקציה WaitingForClient   
            tcpThd.Start();
        }
            
        public struct ClientData       
        {
            public string name;
            public Socket structSocket;
            public Thread structThread;
        }

        private void GetIpAdDress() // את כתובת המחשב IpAddress פונקציה שתשמור במשתנה IpAdress את הכתובת
        {
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
           IpAddress = Convert.ToString(localIP[localIP.Length - 1]);
          // IpAddress ="127.0.0.1";
         
        }
       
        public void NewClientConnected() //זוהי פונקציה שמתרשת כל פעם שנקלט לקוח חדש לכל לקוח הפונקציה תתבצע פעם אחת בלבד
        {

            ClientData CData;
            while (true)
            {
                try
                {
                    CData.structSocket = tcpLsn.AcceptSocket(); // שורה זו מחכה שיתחבר לקוח שיכנס לקוח רק כאשר הלקוח מתחבר הוא שומר את הסוקט שלו
                    CData.structThread = new Thread(new ThreadStart(ReadSocket)); //שומרת את הטרד 
                    Interlocked.Increment(ref connectId);
                    string strmess;// משתנה זה יחזיק את כל המידע שהלקוח שלח לו
                    Socket s = CData.structSocket;// לתוך אובייקט זה נכניס את נתוני הsocket של המחשב שהתחבר הרגע לשרת
                    int ret = 0;
                    Byte[] receive= new Byte[10];// ברשת נתונים עוברים רק בביטים
                    ret = s.Receive(receive, receive.Length, 0);// מחזיק את הכמות הבייטים שיתקבלו
                    strmess = System.Text.Encoding.UTF8.GetString(receive);// שורה זו ממירה את המערך שהוא מטיפוס בייט למחרוזת שאותה הוא שומר ב strmess
                    CData.name = strmess.Substring(0, ret);// שורה זו מחלצת את מה שכתוב עד לרווח הראשון
                    UpDateDataGrid(connectId + " : " + strmess.Substring(0, ret) + "\n");
                    lock (this)
                    {
                        dataHolder.Add(connectId, CData);// מעדכנות את הטבלה ומוסיפות לתקסטבוקס את שעת ההיתחברות
                        UpDateDataGrid("Connected > " + connectId + " " + DateTime.Now.ToLongTimeString());//
                    }
                    CData.structThread.Start();
                    //בונה את רשימת המשתמשים
                    NameOfUsers = "@ ";
                    foreach (ClientData clntData in dataHolder.Values)
                    {
                        if (clntData.structSocket.Connected)
                        {
                            NameOfUsers +=clntData.name + " ";
                        }
                    }
                    Byte[] writeBuffer;// = new Byte[100];
                    var encord = new UTF8Encoding();// הקידוד וגם תומך בעברית 
                    writeBuffer = encord.GetBytes(NameOfUsers); // ממיר את השמות של המשתתפים לבייט
                    // שולח לשרתים את רשימת המשתתפים במשחק
                    foreach (ClientData clntData in dataHolder.Values)
                    {
                        if (clntData.structSocket.Connected)
                            clntData.structSocket.Send(writeBuffer, writeBuffer.Length, SocketFlags.None);
                    }
                    //if (s.Connected)//אחרי שאני יודעת שהלקוח התחבר נשלח לו את רשימת כל המחוברים 
                    //    s.Send(receive, ret, SocketFlags.None); // אם הלקוח מחובר s.Send תשלח לו את מה שקיבלתי ב receive
                    
                }
                catch (Exception e)
                {
                    break;
                }
            }
        }

        public void UpDateDataGrid(string displayString)//אם תוך כדי תהליכים נצטרך לעדכן תיבת טקסט או כפתורים על הטופס נעשה אינבואוק
        {
            if (txtData.InvokeRequired)
             txtData.Invoke(new MethodInvoker(()=> txtData.AppendText(displayString+ "\n")));
            
        }

        private void OnClosing() // זוהי פונקציה שמחסלת תהליכים היא סוגרת את הthread ואת המאזין
        {
            if (tcpLsn != null)
            { tcpLsn.Stop(); }

            foreach (ClientData cd in dataHolder.Values)
            {
                if (cd.structSocket.Connected) cd.structSocket.Close();
                if (cd.structThread.IsAlive) cd.structThread.Abort();
            }


            if (tcpThd.IsAlive) tcpThd.Abort();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)// אירוע של סגירת הטופס 
        {
            OnClosing();
        }

        public void ReadSocket()// תהליך של כול לקוח
        {
            string strmess = "";
            long realId = connectId; // The realId saves the real number of the client that sends the info
            Byte[] receive; // In this array I'll save the info from the client
            ClientData cd = (ClientData)dataHolder[realId];//those two lines define new objects cd of ClientDate type and s of socket type
            Socket s = cd.structSocket;

            int ret = 0; // This object will contain the number of characters that are passed in the message
            ClientConnected = dataHolder.Count; //סופר את מספר המחוברים ברשת 
           
        
            while(true) // מנהל המשחק: כרגע מקבלת ממל מי כול לקוח ומוסרת אותו לכול הלקוחות
            {
                if (s.Connected) // Checking if the client is connected so there won't be problems in passing and getting info
                {
                    receive = new Byte[100]; // If the client is connected we reboot the array;

                    try
                    {
                        if (s.Connected)
                        {
                            ret = s.Receive(receive, receive.Length, 0);//s.Receive is a command that gets the info from the client and put it in the array receive
                            if (ret > 0) // If a message is rececived
                            {
                                foreach (ClientData clntData in dataHolder.Values) // This loop sends info to all clients
                                {
                                    if (clntData.structSocket.Connected)
                                        clntData.structSocket.Send(receive, ret, SocketFlags.None);
                                }
                            }

                            else { break; }
                        }// If a message was received and its' characters length is 0 we get out of the loop
                    }
                    catch (Exception e) // If an error occured we want to stop the thread
                    {
                        UpDateDataGrid(e.ToString()); // Show on the screen in the txtbox the error that occured
                        if (!s.Connected) break;// If the client is not connected we get out of the loop

                    }
                }
            }
            CloseTheThread(realId);// We'll get to this line only if an error occured, because we only get out of the loop if there was an error
                                   //that's why this function will only be summaned if an error occured
        }

        private void CloseTheThread(long realId)
        {
            //This function closes the thread - the process of the client that caused the error
            try
            {
                ClientData clientData = (ClientData)dataHolder[realId];
                clientData.structThread.Abort();
            }

            catch (Exception e)
            {
                lock (this)
                {
                    dataHolder.Remove(realId);
                    UpDateDataGrid("Disconnected>" + realId + " " + DateTime.Now.ToLongTimeString());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    
    }
}
