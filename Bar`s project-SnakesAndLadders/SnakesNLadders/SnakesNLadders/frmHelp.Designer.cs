namespace SnakesNLadders
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblExithelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHelp
            // 
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.Font = new System.Drawing.Font("Gisha", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHelp.Location = new System.Drawing.Point(84, 84);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHelp.Size = new System.Drawing.Size(274, 187);
            this.lblHelp.TabIndex = 0;
            this.lblHelp.Text = resources.GetString("lblHelp.Text");
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHelp.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblExithelp
            // 
            this.lblExithelp.BackColor = System.Drawing.Color.Transparent;
            this.lblExithelp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExithelp.Location = new System.Drawing.Point(344, 41);
            this.lblExithelp.Name = "lblExithelp";
            this.lblExithelp.Size = new System.Drawing.Size(29, 28);
            this.lblExithelp.TabIndex = 1;
            this.lblExithelp.Click += new System.EventHandler(this.lblExithelp_Click);
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 323);
            this.Controls.Add(this.lblExithelp);
            this.Controls.Add(this.lblHelp);
            this.DoubleBuffered = true;
            this.Name = "frmHelp";
            this.Text = "הוראות";
            this.Load += new System.EventHandler(this.frmHelp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblExithelp;
    }
}