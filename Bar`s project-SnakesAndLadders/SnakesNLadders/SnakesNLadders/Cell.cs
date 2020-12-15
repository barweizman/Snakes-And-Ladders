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
    class Cell
    {
        private int i; // מיקום התא במערך
        private int x; // מיקום X על הטופס
        private int y; // מיקום Y על הטופס
        private PictureBox pic; // התמונה שנמצאת בתא
        private int number; // מס' התא
        
        private int cellValue=5;//ערך 5 זה תא ריק
        //ערך 0 זה השחקן הראשון
        //ערך 1 זה השחקן השני
        //ערך 2 זה שני השחקנים יחד

        public int CellValue
        {
            get { return cellValue; }
            set { cellValue = value; }
        }
        
        private void definePic()
        {
            pic=new PictureBox();
            this.pic.Location = new Point(x, y);
            this.pic.Size = new Size(45, 45);
           this.pic.SizeMode = PictureBoxSizeMode.StretchImage;
           pic.BackColor = Color.Transparent;

        }

        public Cell(int i, int x, int y)
        {
            this.i = i;
            this.x = x;
            this.y = y;

            definePic();
           
        }
        public Cell(int i, int x, int y, PictureBox pic, int number)
        {
            this.i = i;
            this.x = x;
            this.y = y;
            this.pic = pic;
            definePic();
            this.number = number;
        }

        public int GetI()
        {
            return this.i;
        }
        
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
        public PictureBox GetPic()
        {
            return this.pic;
        }
        public int GetNumber()
        {
            return this.number;
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public void SetI(int i)
        {
            this.i = i;
        }
       
        public void SetPic(Image pic)
        {
            this.pic.Image = pic;
        }

        public void SetNumber(int number)
        {
            this.number = number;
        }


    }
}

   
