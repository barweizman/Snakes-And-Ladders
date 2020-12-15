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
    class Board
    {
        private Cell[] b;
        int[] cellGoto = new int[101];
        public int getcellGoto(int i)
        {
            return cellGoto[i];
        }

        public Board(frmStart frm)
        {
            for (int m = 0; m < cellGoto.Length; m++)
            {
                cellGoto[m] =m; //השחקן יילך לתא במערך שהוא מצביע עליו
            }

            cellGoto[2] = 24;  //הגדרה של הסולמות
            cellGoto[11] = 33;
            cellGoto[37] = 61;
            cellGoto[25] = 85;
            cellGoto[68] = 90;
            cellGoto[79] = 97;

            cellGoto[99] = 3; //הגדרה של הנחשים
            cellGoto[23] = 7;
            cellGoto[55] = 13;
            cellGoto[70] = 32;
            cellGoto[93] = 67;

            int starti = 1; // משתנה שיכיל כל פעם את מיקום התא על הלוח
            this.b = new Cell[101]; //(יוצר לוח בעל 101 תאים (הספירה תחל מ-1 עד 100
            int x = 13, y = 501, i; // מיקום התא הראשון בלוח
            b[0] = new Cell(0, 600, 500,frm.twoPlayers,2);
            b[0].SetPic(Properties.Resources.players);
            frm.Controls.Add(b[0].GetPic());
            for (int k = 0; k < 10; k++) // מס' התאים בכל שורה 
            {
                for (i = starti; i < starti + 10; i++) //לולאה שרצה על כל השורה מהתחלתה עד לסופה מהמיקום האחרון שנשמר
                {
                    this.b[i] = new Cell(i, x, y); // יוצר תא חדש על הלוח
                    if (k % 2 == 0)            // בודק האם התא נמצא במיקום זוגי
                        x = x + 52;       // במידה ונמצא במיקום זוגי, ייקדם את התא במס הצעדים המצוין
                    else
                        x = x - 52;       // כשהתא נמצא במיקום אי זוגי , הוא יפחית את התא במס הצעדים 


                    frm.Controls.Add(b[i].GetPic());
                }

                y = y - 54;
                if (k % 2 != 0)
                    x = x + 52;
                else
                    x = x - 52;
                starti += 10;
            }


            b[0].CellValue = 2;
                
        }

        public int getCellVal(int i)
        {
            return b[i].CellValue;
        }
        public void setCellVal(int i,int x)
        {
             b[i].CellValue=x;
        }
            public void SetPic(Image pic,int i,int val) //הגדרת התמונה 
        {
           b[i].SetPic( pic);
           b[i].CellValue = val;
        }

       
        }
    }


