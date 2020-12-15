namespace SnakesNLadders
{
    partial class frmStart
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.picDice = new System.Windows.Forms.PictureBox();
            this.lblCLICKtoroll = new System.Windows.Forms.Label();
            this.lblArrow = new System.Windows.Forms.Label();
            this.lblArrow2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.timeDice = new System.Windows.Forms.Timer(this.components);
            this.timeMovePlayer = new System.Windows.Forms.Timer(this.components);
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblturn1 = new System.Windows.Forms.Label();
            this.PicPlayers = new System.Windows.Forms.PictureBox();
            this.PicPlayer1 = new System.Windows.Forms.PictureBox();
            this.PicPlayer2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // picDice
            // 
            this.picDice.BackColor = System.Drawing.Color.Transparent;
            this.picDice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDice.Location = new System.Drawing.Point(638, 320);
            this.picDice.Name = "picDice";
            this.picDice.Size = new System.Drawing.Size(82, 80);
            this.picDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDice.TabIndex = 0;
            this.picDice.TabStop = false;
            this.picDice.Click += new System.EventHandler(this.picDice_Click);
            // 
            // lblCLICKtoroll
            // 
            this.lblCLICKtoroll.BackColor = System.Drawing.Color.Transparent;
            this.lblCLICKtoroll.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCLICKtoroll.Location = new System.Drawing.Point(762, 343);
            this.lblCLICKtoroll.Name = "lblCLICKtoroll";
            this.lblCLICKtoroll.Size = new System.Drawing.Size(65, 51);
            this.lblCLICKtoroll.TabIndex = 1;
            this.lblCLICKtoroll.Text = "לחץ בכדי לגלגל את הקוביה";
            this.lblCLICKtoroll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblArrow
            // 
            this.lblArrow.BackColor = System.Drawing.Color.Transparent;
            this.lblArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblArrow.Location = new System.Drawing.Point(722, 357);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(45, 43);
            this.lblArrow.TabIndex = 2;
            this.lblArrow.Text = "←";
            // 
            // lblArrow2
            // 
            this.lblArrow2.BackColor = System.Drawing.Color.Transparent;
            this.lblArrow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblArrow2.Location = new System.Drawing.Point(726, 335);
            this.lblArrow2.Name = "lblArrow2";
            this.lblArrow2.Size = new System.Drawing.Size(35, 43);
            this.lblArrow2.TabIndex = 3;
            this.lblArrow2.Text = "←";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.Font = new System.Drawing.Font("Felix Titling", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(621, 65);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(118, 23);
            this.lblPlayer1.TabIndex = 4;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.Font = new System.Drawing.Font("Felix Titling", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(594, 165);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(140, 25);
            this.lblPlayer2.TabIndex = 5;
            // 
            // timeDice
            // 
            this.timeDice.Interval = 50;
            this.timeDice.Tick += new System.EventHandler(this.timeDice_Tick);
            // 
            // timeMovePlayer
            // 
            this.timeMovePlayer.Interval = 50;
            this.timeMovePlayer.Tick += new System.EventHandler(this.timeMovePlayer_Tick);
            // 
            // lstUsers
            // 
            this.lstUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstUsers.Font = new System.Drawing.Font("Gisha", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(726, 446);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(86, 41);
            this.lstUsers.TabIndex = 16;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.Location = new System.Drawing.Point(767, 308);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(56, 22);
            this.btnLogIn.TabIndex = 20;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Visible = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLogOut.Location = new System.Drawing.Point(733, 489);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(74, 29);
            this.btnLogOut.TabIndex = 19;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Gisha", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTurn.Location = new System.Drawing.Point(737, 20);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(79, 22);
            this.lblTurn.TabIndex = 21;
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblturn1
            // 
            this.lblturn1.AutoSize = true;
            this.lblturn1.BackColor = System.Drawing.Color.Transparent;
            this.lblturn1.Font = new System.Drawing.Font("Gisha", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblturn1.Location = new System.Drawing.Point(677, 18);
            this.lblturn1.Name = "lblturn1";
            this.lblturn1.Size = new System.Drawing.Size(62, 24);
            this.lblturn1.TabIndex = 23;
            this.lblturn1.Text = "Turn:";
            // 
            // PicPlayers
            // 
            this.PicPlayers.BackColor = System.Drawing.Color.Transparent;
            this.PicPlayers.Image = global::SnakesNLadders.Properties.Resources.players;
            this.PicPlayers.Location = new System.Drawing.Point(765, 257);
            this.PicPlayers.Name = "PicPlayers";
            this.PicPlayers.Size = new System.Drawing.Size(56, 50);
            this.PicPlayers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPlayers.TabIndex = 24;
            this.PicPlayers.TabStop = false;
            this.PicPlayers.Visible = false;
            // 
            // PicPlayer1
            // 
            this.PicPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.PicPlayer1.Location = new System.Drawing.Point(561, 56);
            this.PicPlayer1.Name = "PicPlayer1";
            this.PicPlayer1.Size = new System.Drawing.Size(65, 76);
            this.PicPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPlayer1.TabIndex = 26;
            this.PicPlayer1.TabStop = false;
            this.PicPlayer1.Visible = false;
            // 
            // PicPlayer2
            // 
            this.PicPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.PicPlayer2.Location = new System.Drawing.Point(735, 155);
            this.PicPlayer2.Name = "PicPlayer2";
            this.PicPlayer2.Size = new System.Drawing.Size(58, 76);
            this.PicPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPlayer2.TabIndex = 27;
            this.PicPlayer2.TabStop = false;
            this.PicPlayer2.Visible = false;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 553);
            this.Controls.Add(this.PicPlayer2);
            this.Controls.Add(this.PicPlayer1);
            this.Controls.Add(this.PicPlayers);
            this.Controls.Add(this.lblturn1);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblArrow2);
            this.Controls.Add(this.lblArrow);
            this.Controls.Add(this.lblCLICKtoroll);
            this.Controls.Add(this.picDice);
            this.DoubleBuffered = true;
            this.Name = "frmStart";
            this.Text = "סולמות ונחשים";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStart_FormClosing);
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.frmStart_GiveFeedback);
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDice;
        private System.Windows.Forms.Label lblCLICKtoroll;
        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.Label lblArrow2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Timer timeDice;
        private System.Windows.Forms.Timer timeMovePlayer;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblturn1;
        private System.Windows.Forms.PictureBox PicPlayers;
        private System.Windows.Forms.PictureBox PicPlayer1;
        private System.Windows.Forms.PictureBox PicPlayer2;

    }
}