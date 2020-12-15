using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnakesNLadders
{
    public partial class frmStart : Form
    {
        public delegate void deleForm();
        public static deleForm myDelegate;
        public frmStart frmChat;
        ServerData sd;
        //*********************************************הגדרת משתנים
        public string IPAddress, UserName, Port;  
        public static string mess;
        public static bool theGameIsOn = true;
        public static int InfoRes = 1;
        public string firstCharInfoRes;
        //*********************************************
        
        
        public frmStart()
        {
            InitializeComponent();
            lblPlayer1.Text = frmLogin.username;
            myDelegate = new deleForm(MyProtocol);
        }

    public PictureBox twoPlayers;
        Random random = new Random();
        Board gameBoard; //יוצר לוח משחק
        int timetoroll = 0;   int randomDiceNum; 
        Image player=Properties.Resources.p1; //מכיל את התמונה של השחקן
        int movePlayerTime; //כמה צעדים יתקדם השחקן על הלוח
        
private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void frmStart_Load(object sender, EventArgs e)
        {
            twoPlayers = PicPlayers;
            gameBoard = new Board(this);
            IPAddress = frmMain.IPAddress;
            UserName = frmMain.UserName;
            Port = frmMain.Port;

            frmChat = (frmStart)this;//הגדרת מצביע לטופס הנוכחי
            sd = new ServerData(frmChat);//יצירת אובייקט חדש של המחלקה
            btnLogIn_Click(null, null);
           
        }
        private void frmStart_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }
        private void frmStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //*******************************************************
        private void picDice_Click(object sender, EventArgs e)
        {
           
            timetoroll = 0; // כלומר כמה פעמים תתגלגל- משתנה שיכיל את הזמן לגלגול הקוביה
             randomDiceNum = random.Next(1, 7); //מגריל מספר בין 1 ל6 שיישמר במשתנה
             timeDice.Enabled = true; // מפעיל את הטיימר של הקוביה
  
           }

        private void timeDice_Tick(object sender, EventArgs e)
        {   
             int tmpDiceNum; // מס התמונות שיתחלפו בין לבין עד להצגת המספר שהוגרל באמת
             
            if (timetoroll < 10)
             {
                    tmpDiceNum = random.Next(1, 7); //מגריל מספר בין 1 ל6 שיישמר במשתנה
                    timetoroll++; //מגדיל את משתנה הזמן שהתמונות יתחלפו ב1
                    picDice.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + tmpDiceNum.ToString());
             }
             else
            {
                 timeDice.Enabled = false; //עוצר את ההתגלגלות של הקוביה כלומר מפסיק את הטיימר
                 picDice.Image = (Image)Properties.Resources.ResourceManager.GetObject("dice" + randomDiceNum.ToString()); //שומר את התמונה המתאימה לפי המספר שהוגרל
                 movePlayerTime = randomDiceNum; //השחקן מתקדם על הלוח כמספר התאים שהוגרלו על הקוביה
                 sd.WriteToServer("%" + UserName + " " + randomDiceNum); //מעביר אל הסרבר את שם המשתמש עם המספר שהוגרל 
               }

        
        }
            
        private void timeMovePlayer_Tick(object sender, EventArgs e)
        {
            if (movsToPlay > 0)
            {
                //ערך 5 זה תא ריק
                //ערך 0 זה השחקן הראשון
                //ערך 1 זה השחקן השני
                //ערך 2 זה שני השחקנים יחד

                //טיפול בתא שיוצאים ממנו
                if (allPlayers[currentPlayerNum].PlayerPlace >= 0)
                {
                    // אם בתא נמצא אחד השחקנים(שחקן 1 או שחקן 2), אז שהתא יתפנה לאחר שאותו השחקן שיחק(הגריל את הקוביה) ויתקדם על הלוח 
                    if (gameBoard.getCellVal(allPlayers[currentPlayerNum].PlayerPlace) == 1 || gameBoard.getCellVal(allPlayers[currentPlayerNum].PlayerPlace) == 0)
                        gameBoard.SetPic(null, allPlayers[currentPlayerNum].PlayerPlace, 5);
                    else
                        // אם בתא נמצאים שני השחקנים, אז שהתא יתפנה לאחר שאחד השחקנים הגריל את הקוביה וישאיר את התמונה של השחקן שלא שיחק עדיין 
                        if (gameBoard.getCellVal(allPlayers[currentPlayerNum].PlayerPlace) == 2)
                        {
                            if (currentPlayerNum == 0)
                                gameBoard.SetPic(allPlayers[1].PlayerPic, allPlayers[currentPlayerNum].PlayerPlace, 1);
                            else
                                gameBoard.SetPic(allPlayers[0].PlayerPic, allPlayers[currentPlayerNum].PlayerPlace, 0);
                        }
                }
               
                allPlayers[currentPlayerNum].PlayerPlace++;
                
                //טיפול בתא שמגיעים אליו 
                     //אם התא מכיל שחקן אחד כבר , ועוד שחקן הגיע אל אותו התא אז שישים תמונה של שני השחקנים יחד באותו התא וישנה את ערכו 
                if (gameBoard.getCellVal(allPlayers[currentPlayerNum].PlayerPlace) == 1 || gameBoard.getCellVal(allPlayers[currentPlayerNum].PlayerPlace) == 0)
                    gameBoard.SetPic(Properties.Resources.players, allPlayers[currentPlayerNum].PlayerPlace, 2);
                else
                     //אם התא ריק , והגיע אליו אחד מהשחקנים אז שישנה את ערך התא לערך השחקן ואת התמונה בתא לתמונה המתאימה
                    if (gameBoard.getCellVal(allPlayers[currentPlayerNum].PlayerPlace) == 5)
                        gameBoard.SetPic(allPlayers[currentPlayerNum].PlayerPic, allPlayers[currentPlayerNum].PlayerPlace, currentPlayerNum);
       
   
                //////אם אחד השחקנים מגיע ל100 נגמר המשחק והוא מנצח
            if ((allPlayers[0].PlayerPlace >= 100) || (allPlayers[1].PlayerPlace >= 100))
            {
                winnerName = allPlayers[currentPlayerNum].Name;
                frmWin f2 = new frmWin();
                f2.Show();
                timeMovePlayer.Enabled = false;

            }
                movsToPlay--;
               
            }
            else
            {
                //שוב טיפול בתא שיוצאים ממנו
                if (allPlayers[currentPlayerNum].PlayerPlace != gameBoard.getcellGoto(allPlayers[currentPlayerNum].PlayerPlace))
                {
                    if (gameBoard.getCellVal(allPlayers[currentPlayerNum].PlayerPlace) == 1 || gameBoard.getCellVal(allPlayers[currentPlayerNum].PlayerPlace) == 0)
                        gameBoard.SetPic(null, allPlayers[currentPlayerNum].PlayerPlace, 5);
                    else
                        if (gameBoard.getCellVal(allPlayers[currentPlayerNum].PlayerPlace) == 2)
                        {
                            if (currentPlayerNum == 0)
                                gameBoard.SetPic(allPlayers[1].PlayerPic, allPlayers[currentPlayerNum].PlayerPlace, 1);
                            else
                                gameBoard.SetPic(allPlayers[0].PlayerPic, allPlayers[currentPlayerNum].PlayerPlace, 0);
                        }
                    
                    allPlayers[currentPlayerNum].PlayerPlace = gameBoard.getcellGoto(allPlayers[currentPlayerNum].PlayerPlace);

                    //שוב טיפול בתא שמגיעים אליו
                    if (gameBoard.getCellVal(allPlayers[currentPlayerNum].PlayerPlace) == 1 || gameBoard.getCellVal(allPlayers[currentPlayerNum].PlayerPlace) == 0)
                        gameBoard.SetPic(Properties.Resources.players, allPlayers[currentPlayerNum].PlayerPlace, 2);
                    else
                        if (gameBoard.getCellVal(allPlayers[currentPlayerNum].PlayerPlace) == 5)
                            gameBoard.SetPic(allPlayers[currentPlayerNum].PlayerPic, allPlayers[currentPlayerNum].PlayerPlace, currentPlayerNum);

                }
              
                switchTurn();
                timeMovePlayer.Enabled = false;
            }

           
           

        }
        public static string winnerName;
        bool myTurn;
        string curentPlayerName;
        int currentPlayerNum;
        int movsToPlay;
        Player[] allPlayers = new Player[2]; //יוצר מערך של 2 שחקנים שייתחברו למשחק
       
        public void MyProtocol()
        {
            string s;
            firstCharInfoRes = mess;
           
            switch (firstCharInfoRes[0])
            {// חלק זה יתבצע כל פעם שיתחבר לקוח חדש ואז נמחקת  רשימת המשתמשים שאונליין והיא נבנית מחדש 
                case '@': lstUsers.Items.Clear();
                    //lstUsers.Items.Add("All Users");
                   // lstUsers.SetSelected(0, true);
                    firstCharInfoRes = firstCharInfoRes.Substring(2);// מוריד גם @ וגם רווח
                    firstCharInfoRes += " ";
                    //  allconversations.Add(new ConManger(UserName, "All Users", this)); 
                    while (firstCharInfoRes != " ")
                    {
                        s = firstCharInfoRes.Substring(0, firstCharInfoRes.IndexOf(" "));// ממקום 0 עד לרווח הראשון
                        lstUsers.Items.Add(s);
                        firstCharInfoRes = firstCharInfoRes.Substring(firstCharInfoRes.IndexOf(" ") + 1);
                    }

                    if (lstUsers.Items.Count == 2) //בודק האם מחוברים 2 שחקנים
                    {
                        allPlayers[0] = new Player(lstUsers.Items[0].ToString(), 0, true, Properties.Resources.p1,0); // השחקן שייתחבר לשרת ראשון יהיה הראשון בתורו ומשתניו יקבלו ערכים
                        allPlayers[1] = new Player(lstUsers.Items[1].ToString(),1, false, Properties.Resources.p2, 0); // השחקן שייתחבר לשרת שני יהיה השני בתורו ומשתניו יקבלו ערכים
                        //allPlayers[1].PlayerPlace = 12; 
                        PicPlayer1.Image = allPlayers[0].PlayerPic;
                        PicPlayer2.Image = allPlayers[1].PlayerPic;
                        lblTurn.Text = allPlayers[0].Name; //תורו של איזה מהשחקנים יוצג בצג ה "תורו שלו
                

                        if (lblTurn.Text == UserName) 
                        {
                            myTurn = true;
                            picDice.Enabled = true;
                         
                        }
                        else
                        {
                            myTurn = false;
                            picDice.Enabled = false;
                           
                        }


                        lblPlayer1.Text = allPlayers[0].Name;
                        lblPlayer2.Text = allPlayers[1].Name;

                    }

                    break;

                case '%': curentPlayerName=firstCharInfoRes.Substring(1,firstCharInfoRes.IndexOf(" ")-1);
                    movsToPlay = int.Parse(firstCharInfoRes.Substring(firstCharInfoRes.IndexOf(" ")+1));
                    

                    if (curentPlayerName == allPlayers[0].Name)
                        currentPlayerNum = 0;
                    else
                        currentPlayerNum = 1;
                    timeMovePlayer.Enabled = true;
                    
                    break;



                // חלק זה יתבצע כשאר לקוח מתנתק מהצ'אט ואז רשימת השתמשים תעודכן בלעדיו
                case '!': lstUsers.Items.Remove(firstCharInfoRes.Substring(1));
                    break;
                // חלק זה מציג את ההודעה לכל המשתמשים בחלון הצאט
                case '#':
                    string tmp = firstCharInfoRes.Substring(1) + "\n";
                    //  messages.Add(tmp);
                  //  lblInfo.Text += tmp;
                    break;

                //case '$': // הודעות פרטיותfirstCharInfoRes = firstCharInfoRes.Substring(2);
                //    string[] parts = firstCharInfoRes.Substring(1).Split('&');

                //    if (UserName == parts[0] || UserName == parts[2])
                //    {
                //        //בודק האם כבר קיימת שיחה פרטית בין המשתמשים האלו 
                //        Existconversation(parts[0], parts[2], parts[3]);
                //        if (UserName == parts[0])
                //            lstUsers.SetSelected(lstUsers.Items.IndexOf(parts[2]), true);
                //        else
                //            lstUsers.SetSelected(lstUsers.Items.IndexOf(parts[0]), true);


                //    }
                //    break;
            }
        }

        //זוהי פונקציה המחליפה תור
        private void switchTurn()
        {
            if (currentPlayerNum == 1) //אם השחקן הנוכחי הוא השחקן השני, אז שיחליף תור לשחק 1
            { currentPlayerNum = 0; }
            else
            { currentPlayerNum = 1; } //אם השחקן הנוכחי הוא השחקן הראשון, אז שיחליף תור לשחק 2
            lblTurn.Text = allPlayers[currentPlayerNum].Name;
            if (lblTurn.Text == UserName)
            {
                myTurn = true;
                picDice.Enabled = true;
            }
            else
            {
                myTurn = false;
                picDice.Enabled = false;
            }

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (btnLogIn.Enabled == true)
            {

                btnLogIn.Enabled = false;
               
                
                if (IPAddress != null && Port != null && UserName != null)
                {


                    sd.StartServer(UserName, IPAddress, int.Parse(Port));
                    this.Text = UserName;//הכותרת של הטקסט תהיה השם של המשתמש
                }
                else
                    MessageBox.Show("לא הזנת נתוני התחברות", "שגיאה");
            }
            else
            {
                sd.WriteToServer("!" + UserName);
                sd.OnClosing();
                sd.stm = null;
                this.Close();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            sd.WriteToServer("!" + UserName);
            sd.OnClosing();

            sd.stm = null;
            this.Close();
        }
    }
}
