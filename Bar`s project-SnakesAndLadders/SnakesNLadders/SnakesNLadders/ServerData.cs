using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SnakesNLadders
{
    class ServerData
    {
        public frmStart frmChat;//הגדרת אובייקט של הטופס שבתוכו יתנהל המשחק/תוכנה
        public Thread tcpThd;//טרנד של הלקוח
        public TcpClient tcpclnt;// מאזין של הלקוח
        public NetworkStream stm; //קורא רצף של מידע
        public byte[] readBuffer;//מערך של בתים שקורא מידע מהשרת
        public byte[] writeBuffer;//מערך של מידע ששולח מידע לשרת
        public ServerData(frmStart frmChat) // זהו בנאי שמקבל אובייקט של הטופס שמנהל את כל התהליך של העברת וקבלת כל הנתונים מהטופס
        {
            this.frmChat = frmChat;
        }

        public void StartServer(string user, string ip, int port)
        {
            try
            {
                tcpclnt = new TcpClient();//מאתחל את המאזין
                tcpclnt.Connect(ip.Trim(), port);//מחברים אותו לכתובות האייפי והפורט
                stm = tcpclnt.GetStream();//ככה אנחנו מקבלים מידע מן המאזין שלנו
                WriteToServer(user);//
                tcpThd = new Thread(new ThreadStart(ReadSocket));
                tcpThd.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("השרת לא מחובר", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        public void WriteToServer(string strMessage)
        {
            var encord = new UTF8Encoding();//הגדרת אובייקט
            writeBuffer = encord.GetBytes(strMessage);//המרה לבייט
            if (stm != null)
                stm.Write(writeBuffer, 0, writeBuffer.Length);//אם המאזין הופעל אז תשלח את המידע
        }

        public void OnClosing()// סוגר את כל התהליכים ומאזין ברגע שלקוח מתנתק 
        {
            Thread.Sleep(1000);//השעייה של שניה
            if (tcpThd != null && tcpThd.IsAlive) tcpThd.Abort();
            if (stm != null) stm.Close();
            if (tcpclnt != null) tcpclnt.Close();
        }

        public void ReadSocket()
        {
            int ret;
            while (true)// הלולאה אינסופית
            {
                try
                {
                    readBuffer = new Byte[100];//מערך מטיפוס בייט של מידע שהשרת ישלח לנו ישמר בתוך האובייקט readBuffer
                    ret = stm.Read(readBuffer, 0, readBuffer.Length);//קורא מהשרת ושומר ב readBuffer
                    frmStart.mess = System.Text.Encoding.UTF8.GetString(readBuffer);
                    frmStart.mess = frmStart.mess.Substring(0, ret);
                    frmChat.Invoke(frmStart.myDelegate);// כל מה שאני מוסיפה לאפס אני רוצה שהוא יוכל להשתלב יחד עם התהליך
                    //myDelegate הוא אובייקט שהוגדר בטופס המשחק
                }
                catch (Exception e)
                {
                    break;
                }
            }


        }


    }
}
