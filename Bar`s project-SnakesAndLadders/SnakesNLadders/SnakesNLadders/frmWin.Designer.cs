namespace SnakesNLadders
{
    partial class frmWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWin));
            this.lblWin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWinnerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("Gisha", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(147, 32);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(103, 24);
            this.lblWin.TabIndex = 0;
            this.lblWin.Text = "כל הכבוד ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gisha", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(41, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ניצחת במשחק , יא תותח ";
            // 
            // lblWinnerName
            // 
            this.lblWinnerName.BackColor = System.Drawing.Color.Transparent;
            this.lblWinnerName.Font = new System.Drawing.Font("Gisha", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWinnerName.Location = new System.Drawing.Point(55, 32);
            this.lblWinnerName.Name = "lblWinnerName";
            this.lblWinnerName.Size = new System.Drawing.Size(86, 24);
            this.lblWinnerName.TabIndex = 2;
            // 
            // frmWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(285, 232);
            this.Controls.Add(this.lblWinnerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWin);
            this.Name = "frmWin";
            this.Text = "מזל טוב";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmWin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWinnerName;
    }
}