using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SnakesNLadders
{
    class Player
    {
        public string Name { get; set; } //מכיל את שם השחקן
        public int PlayerNumber { get; set; } //מכיל את מספרו הסידורי, ראשון או שני
        public bool Turn { get; set; } //מכיל את הערך הבוליאני - האם תורו או לא
        public Image PlayerPic { get; set; } //מכיל את תמונת השחקן
        public int PlayerPlace { get; set; } //מכיל את מיקום השחקן על הלוח

        public Player(string Name, int PlayerNum, bool Turn, Image PlayerPic, int PlayerPlace)
        {
            this.Name = Name;
            this.PlayerNumber = PlayerNumber;
            this.Turn = false;
            this.PlayerPlace = 0;
            this.PlayerPic = PlayerPic;
        }
    }
}
