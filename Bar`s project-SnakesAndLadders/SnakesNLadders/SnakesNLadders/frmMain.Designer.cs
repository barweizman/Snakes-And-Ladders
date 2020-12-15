namespace SnakesNLadders
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.BackColor = System.Drawing.Color.Transparent;
            this.lblEnter.Location = new System.Drawing.Point(319, 432);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(54, 42);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Click += new System.EventHandler(this.lblEnter_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.Location = new System.Drawing.Point(379, 413);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(70, 61);
            this.lblHelp.TabIndex = 1;
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 483);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblEnter);
            this.DoubleBuffered = true;
            this.Name = "frmMain";
            this.Text = "סולמות ונחשים";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblHelp;
    }
}

