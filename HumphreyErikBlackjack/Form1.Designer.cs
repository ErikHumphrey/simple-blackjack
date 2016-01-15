namespace HumphreyErikBlackjack
{
    partial class frmBlackjack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBlackjack));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mniTitleGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCardUser1 = new System.Windows.Forms.Label();
            this.lblCardUser2 = new System.Windows.Forms.Label();
            this.lblCardUser3 = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.lblCardCPU3 = new System.Windows.Forms.Label();
            this.lblCardCPU2 = new System.Windows.Forms.Label();
            this.lblCardCPU1 = new System.Windows.Forms.Label();
            this.lblTitleBetUser = new System.Windows.Forms.Label();
            this.txtUserBetEntry = new System.Windows.Forms.TextBox();
            this.btnPlaceBet = new System.Windows.Forms.Button();
            this.txtCPUBetEntry = new System.Windows.Forms.TextBox();
            this.lblTitleBetCPU = new System.Windows.Forms.Label();
            this.lblJackpot = new System.Windows.Forms.Label();
            this.lblChildrenCantGamble = new System.Windows.Forms.Label();
            this.lblBlackjackSplash = new System.Windows.Forms.Label();
            this.lblCardUser4 = new System.Windows.Forms.Label();
            this.lblCardCPU4 = new System.Windows.Forms.Label();
            this.lblObstructCPU1 = new System.Windows.Forms.Label();
            this.lblObstructCPU2 = new System.Windows.Forms.Label();
            this.lblObstructCPU3 = new System.Windows.Forms.Label();
            this.lblScoreUser = new System.Windows.Forms.Label();
            this.lblScoreCPU = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.Brown;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniTitleGame});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(494, 24);
            this.mnuMain.TabIndex = 0;
            // 
            // mniTitleGame
            // 
            this.mniTitleGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNewGame,
            this.mniExit});
            this.mniTitleGame.ForeColor = System.Drawing.Color.White;
            this.mniTitleGame.Name = "mniTitleGame";
            this.mniTitleGame.Padding = new System.Windows.Forms.Padding(0);
            this.mniTitleGame.Size = new System.Drawing.Size(42, 20);
            this.mniTitleGame.Text = "Game";
            // 
            // mniNewGame
            // 
            this.mniNewGame.BackColor = System.Drawing.Color.Brown;
            this.mniNewGame.ForeColor = System.Drawing.Color.White;
            this.mniNewGame.Name = "mniNewGame";
            this.mniNewGame.Padding = new System.Windows.Forms.Padding(0);
            this.mniNewGame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mniNewGame.Size = new System.Drawing.Size(174, 20);
            this.mniNewGame.Text = "New game";
            this.mniNewGame.Click += new System.EventHandler(this.mniNewGame_Click);
            // 
            // mniExit
            // 
            this.mniExit.BackColor = System.Drawing.Color.Brown;
            this.mniExit.ForeColor = System.Drawing.Color.White;
            this.mniExit.Name = "mniExit";
            this.mniExit.Padding = new System.Windows.Forms.Padding(0);
            this.mniExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mniExit.Size = new System.Drawing.Size(174, 20);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // lblCardUser1
            // 
            this.lblCardUser1.BackColor = System.Drawing.Color.Brown;
            this.lblCardUser1.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardUser1.ForeColor = System.Drawing.Color.White;
            this.lblCardUser1.Location = new System.Drawing.Point(299, 36);
            this.lblCardUser1.Name = "lblCardUser1";
            this.lblCardUser1.Size = new System.Drawing.Size(59, 74);
            this.lblCardUser1.TabIndex = 1;
            this.lblCardUser1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCardUser2
            // 
            this.lblCardUser2.BackColor = System.Drawing.Color.Brown;
            this.lblCardUser2.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardUser2.ForeColor = System.Drawing.Color.White;
            this.lblCardUser2.Location = new System.Drawing.Point(364, 36);
            this.lblCardUser2.Name = "lblCardUser2";
            this.lblCardUser2.Size = new System.Drawing.Size(59, 74);
            this.lblCardUser2.TabIndex = 2;
            this.lblCardUser2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCardUser3
            // 
            this.lblCardUser3.BackColor = System.Drawing.Color.Brown;
            this.lblCardUser3.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardUser3.ForeColor = System.Drawing.Color.White;
            this.lblCardUser3.Location = new System.Drawing.Point(429, 36);
            this.lblCardUser3.Name = "lblCardUser3";
            this.lblCardUser3.Size = new System.Drawing.Size(59, 74);
            this.lblCardUser3.TabIndex = 3;
            this.lblCardUser3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.Brown;
            this.btnHit.Enabled = false;
            this.btnHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHit.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.ForeColor = System.Drawing.Color.White;
            this.btnHit.Location = new System.Drawing.Point(315, 133);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 4;
            this.btnHit.TabStop = false;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.Brown;
            this.btnStand.Enabled = false;
            this.btnStand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStand.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.ForeColor = System.Drawing.Color.White;
            this.btnStand.Location = new System.Drawing.Point(396, 133);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(75, 23);
            this.btnStand.TabIndex = 5;
            this.btnStand.TabStop = false;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // lblCardCPU3
            // 
            this.lblCardCPU3.BackColor = System.Drawing.Color.Brown;
            this.lblCardCPU3.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardCPU3.ForeColor = System.Drawing.Color.White;
            this.lblCardCPU3.Location = new System.Drawing.Point(429, 181);
            this.lblCardCPU3.Name = "lblCardCPU3";
            this.lblCardCPU3.Size = new System.Drawing.Size(59, 74);
            this.lblCardCPU3.TabIndex = 8;
            this.lblCardCPU3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCardCPU2
            // 
            this.lblCardCPU2.BackColor = System.Drawing.Color.Brown;
            this.lblCardCPU2.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardCPU2.ForeColor = System.Drawing.Color.White;
            this.lblCardCPU2.Location = new System.Drawing.Point(364, 181);
            this.lblCardCPU2.Name = "lblCardCPU2";
            this.lblCardCPU2.Size = new System.Drawing.Size(59, 74);
            this.lblCardCPU2.TabIndex = 7;
            this.lblCardCPU2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCardCPU1
            // 
            this.lblCardCPU1.BackColor = System.Drawing.Color.Brown;
            this.lblCardCPU1.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardCPU1.ForeColor = System.Drawing.Color.White;
            this.lblCardCPU1.Location = new System.Drawing.Point(299, 181);
            this.lblCardCPU1.Name = "lblCardCPU1";
            this.lblCardCPU1.Size = new System.Drawing.Size(59, 74);
            this.lblCardCPU1.TabIndex = 6;
            this.lblCardCPU1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleBetUser
            // 
            this.lblTitleBetUser.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleBetUser.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBetUser.ForeColor = System.Drawing.Color.White;
            this.lblTitleBetUser.Location = new System.Drawing.Point(12, 40);
            this.lblTitleBetUser.Name = "lblTitleBetUser";
            this.lblTitleBetUser.Size = new System.Drawing.Size(100, 23);
            this.lblTitleBetUser.TabIndex = 9;
            this.lblTitleBetUser.Text = "Bet: $";
            // 
            // txtUserBetEntry
            // 
            this.txtUserBetEntry.BackColor = System.Drawing.Color.Brown;
            this.txtUserBetEntry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserBetEntry.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserBetEntry.Location = new System.Drawing.Point(67, 38);
            this.txtUserBetEntry.MaxLength = 4;
            this.txtUserBetEntry.Name = "txtUserBetEntry";
            this.txtUserBetEntry.ReadOnly = true;
            this.txtUserBetEntry.Size = new System.Drawing.Size(73, 22);
            this.txtUserBetEntry.TabIndex = 10;
            this.txtUserBetEntry.TabStop = false;
            this.txtUserBetEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserBetEntry.WordWrap = false;
            this.txtUserBetEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserBetEntry_KeyPress);
            // 
            // btnPlaceBet
            // 
            this.btnPlaceBet.BackColor = System.Drawing.Color.Brown;
            this.btnPlaceBet.Enabled = false;
            this.btnPlaceBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceBet.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnPlaceBet.ForeColor = System.Drawing.Color.White;
            this.btnPlaceBet.Location = new System.Drawing.Point(67, 66);
            this.btnPlaceBet.Name = "btnPlaceBet";
            this.btnPlaceBet.Size = new System.Drawing.Size(73, 23);
            this.btnPlaceBet.TabIndex = 11;
            this.btnPlaceBet.Text = "Place Bet";
            this.btnPlaceBet.UseVisualStyleBackColor = false;
            this.btnPlaceBet.Click += new System.EventHandler(this.btnPlaceBet_Click);
            // 
            // txtCPUBetEntry
            // 
            this.txtCPUBetEntry.BackColor = System.Drawing.Color.Brown;
            this.txtCPUBetEntry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPUBetEntry.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPUBetEntry.ForeColor = System.Drawing.Color.White;
            this.txtCPUBetEntry.Location = new System.Drawing.Point(67, 228);
            this.txtCPUBetEntry.MaxLength = 4;
            this.txtCPUBetEntry.Name = "txtCPUBetEntry";
            this.txtCPUBetEntry.ReadOnly = true;
            this.txtCPUBetEntry.Size = new System.Drawing.Size(73, 22);
            this.txtCPUBetEntry.TabIndex = 13;
            this.txtCPUBetEntry.TabStop = false;
            this.txtCPUBetEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPUBetEntry.WordWrap = false;
            // 
            // lblTitleBetCPU
            // 
            this.lblTitleBetCPU.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleBetCPU.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBetCPU.ForeColor = System.Drawing.Color.White;
            this.lblTitleBetCPU.Location = new System.Drawing.Point(12, 230);
            this.lblTitleBetCPU.Name = "lblTitleBetCPU";
            this.lblTitleBetCPU.Size = new System.Drawing.Size(100, 23);
            this.lblTitleBetCPU.TabIndex = 12;
            this.lblTitleBetCPU.Text = "Bet: $";
            // 
            // lblJackpot
            // 
            this.lblJackpot.AutoSize = true;
            this.lblJackpot.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJackpot.ForeColor = System.Drawing.Color.White;
            this.lblJackpot.Location = new System.Drawing.Point(19, 126);
            this.lblJackpot.Name = "lblJackpot";
            this.lblJackpot.Size = new System.Drawing.Size(120, 28);
            this.lblJackpot.TabIndex = 14;
            this.lblJackpot.Text = "Jackpot: $";
            this.lblJackpot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblJackpot.Visible = false;
            // 
            // lblChildrenCantGamble
            // 
            this.lblChildrenCantGamble.AutoSize = true;
            this.lblChildrenCantGamble.BackColor = System.Drawing.Color.Brown;
            this.lblChildrenCantGamble.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblChildrenCantGamble.Font = new System.Drawing.Font("Myriad Web Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildrenCantGamble.ForeColor = System.Drawing.Color.White;
            this.lblChildrenCantGamble.Location = new System.Drawing.Point(371, 6);
            this.lblChildrenCantGamble.Name = "lblChildrenCantGamble";
            this.lblChildrenCantGamble.Size = new System.Drawing.Size(124, 14);
            this.lblChildrenCantGamble.TabIndex = 15;
            this.lblChildrenCantGamble.Text = "Virtual gambling only.";
            // 
            // lblBlackjackSplash
            // 
            this.lblBlackjackSplash.AutoSize = true;
            this.lblBlackjackSplash.BackColor = System.Drawing.Color.DarkRed;
            this.lblBlackjackSplash.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackjackSplash.ForeColor = System.Drawing.Color.White;
            this.lblBlackjackSplash.Location = new System.Drawing.Point(34, 120);
            this.lblBlackjackSplash.Name = "lblBlackjackSplash";
            this.lblBlackjackSplash.Size = new System.Drawing.Size(175, 39);
            this.lblBlackjackSplash.TabIndex = 16;
            this.lblBlackjackSplash.Text = "Blackjack";
            // 
            // lblCardUser4
            // 
            this.lblCardUser4.BackColor = System.Drawing.Color.Brown;
            this.lblCardUser4.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardUser4.ForeColor = System.Drawing.Color.White;
            this.lblCardUser4.Location = new System.Drawing.Point(494, 36);
            this.lblCardUser4.Name = "lblCardUser4";
            this.lblCardUser4.Size = new System.Drawing.Size(59, 74);
            this.lblCardUser4.TabIndex = 18;
            this.lblCardUser4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCardCPU4
            // 
            this.lblCardCPU4.BackColor = System.Drawing.Color.Brown;
            this.lblCardCPU4.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardCPU4.ForeColor = System.Drawing.Color.White;
            this.lblCardCPU4.Location = new System.Drawing.Point(494, 181);
            this.lblCardCPU4.Name = "lblCardCPU4";
            this.lblCardCPU4.Size = new System.Drawing.Size(59, 74);
            this.lblCardCPU4.TabIndex = 19;
            this.lblCardCPU4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblObstructCPU1
            // 
            this.lblObstructCPU1.BackColor = System.Drawing.Color.Brown;
            this.lblObstructCPU1.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObstructCPU1.ForeColor = System.Drawing.Color.White;
            this.lblObstructCPU1.Location = new System.Drawing.Point(299, 181);
            this.lblObstructCPU1.Name = "lblObstructCPU1";
            this.lblObstructCPU1.Size = new System.Drawing.Size(59, 74);
            this.lblObstructCPU1.TabIndex = 20;
            this.lblObstructCPU1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblObstructCPU2
            // 
            this.lblObstructCPU2.BackColor = System.Drawing.Color.Brown;
            this.lblObstructCPU2.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObstructCPU2.ForeColor = System.Drawing.Color.White;
            this.lblObstructCPU2.Location = new System.Drawing.Point(364, 181);
            this.lblObstructCPU2.Name = "lblObstructCPU2";
            this.lblObstructCPU2.Size = new System.Drawing.Size(59, 74);
            this.lblObstructCPU2.TabIndex = 21;
            this.lblObstructCPU2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblObstructCPU3
            // 
            this.lblObstructCPU3.BackColor = System.Drawing.Color.Brown;
            this.lblObstructCPU3.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObstructCPU3.ForeColor = System.Drawing.Color.White;
            this.lblObstructCPU3.Location = new System.Drawing.Point(429, 181);
            this.lblObstructCPU3.Name = "lblObstructCPU3";
            this.lblObstructCPU3.Size = new System.Drawing.Size(59, 74);
            this.lblObstructCPU3.TabIndex = 22;
            this.lblObstructCPU3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreUser
            // 
            this.lblScoreUser.AutoSize = true;
            this.lblScoreUser.Font = new System.Drawing.Font("Myriad Web Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScoreUser.Location = new System.Drawing.Point(170, 88);
            this.lblScoreUser.Name = "lblScoreUser";
            this.lblScoreUser.Size = new System.Drawing.Size(68, 13);
            this.lblScoreUser.TabIndex = 23;
            this.lblScoreUser.Text = "Player score: ";
            // 
            // lblScoreCPU
            // 
            this.lblScoreCPU.AutoSize = true;
            this.lblScoreCPU.Font = new System.Drawing.Font("Myriad Web Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreCPU.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScoreCPU.Location = new System.Drawing.Point(170, 196);
            this.lblScoreCPU.Name = "lblScoreCPU";
            this.lblScoreCPU.Size = new System.Drawing.Size(86, 13);
            this.lblScoreCPU.TabIndex = 24;
            this.lblScoreCPU.Text = "Computer score: ";
            // 
            // frmBlackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(494, 262);
            this.Controls.Add(this.lblScoreCPU);
            this.Controls.Add(this.lblScoreUser);
            this.Controls.Add(this.lblObstructCPU3);
            this.Controls.Add(this.lblObstructCPU2);
            this.Controls.Add(this.lblObstructCPU1);
            this.Controls.Add(this.lblCardCPU4);
            this.Controls.Add(this.lblCardUser4);
            this.Controls.Add(this.lblBlackjackSplash);
            this.Controls.Add(this.lblChildrenCantGamble);
            this.Controls.Add(this.lblJackpot);
            this.Controls.Add(this.txtCPUBetEntry);
            this.Controls.Add(this.lblTitleBetCPU);
            this.Controls.Add(this.btnPlaceBet);
            this.Controls.Add(this.txtUserBetEntry);
            this.Controls.Add(this.lblTitleBetUser);
            this.Controls.Add(this.lblCardCPU3);
            this.Controls.Add(this.lblCardCPU2);
            this.Controls.Add(this.lblCardCPU1);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblCardUser3);
            this.Controls.Add(this.lblCardUser2);
            this.Controls.Add(this.lblCardUser1);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmBlackjack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erik Humphrey\'s Virtual Blackjack";
            this.Load += new System.EventHandler(this.frmBlackjack_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mniTitleGame;
        private System.Windows.Forms.ToolStripMenuItem mniNewGame;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblCardUser1;
        private System.Windows.Forms.Label lblCardUser2;
        private System.Windows.Forms.Label lblCardUser3;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Label lblCardCPU3;
        private System.Windows.Forms.Label lblCardCPU2;
        private System.Windows.Forms.Label lblCardCPU1;
        private System.Windows.Forms.Label lblTitleBetUser;
        private System.Windows.Forms.TextBox txtUserBetEntry;
        private System.Windows.Forms.Button btnPlaceBet;
        private System.Windows.Forms.TextBox txtCPUBetEntry;
        private System.Windows.Forms.Label lblTitleBetCPU;
        private System.Windows.Forms.Label lblJackpot;
        private System.Windows.Forms.Label lblChildrenCantGamble;
        private System.Windows.Forms.Label lblBlackjackSplash;
        private System.Windows.Forms.Label lblCardUser4;
        private System.Windows.Forms.Label lblCardCPU4;
        private System.Windows.Forms.Label lblObstructCPU1;
        private System.Windows.Forms.Label lblObstructCPU2;
        private System.Windows.Forms.Label lblObstructCPU3;
        private System.Windows.Forms.Label lblScoreUser;
        private System.Windows.Forms.Label lblScoreCPU;
    }
}

