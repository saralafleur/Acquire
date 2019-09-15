namespace Acquire
{
    partial class MainView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starrtGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelCard7 = new Acquire.Controls.HotelCardControl();
            this.hotelCard6 = new Acquire.Controls.HotelCardControl();
            this.hotelCard5 = new Acquire.Controls.HotelCardControl();
            this.hotelCard4 = new Acquire.Controls.HotelCardControl();
            this.hotelCard3 = new Acquire.Controls.HotelCardControl();
            this.hotelCard2 = new Acquire.Controls.HotelCardControl();
            this.hotelCard1 = new Acquire.Controls.HotelCardControl();
            this.Player6 = new Acquire.Controls.PlayerControl();
            this.Player5 = new Acquire.Controls.PlayerControl();
            this.Player4 = new Acquire.Controls.PlayerControl();
            this.Player3 = new Acquire.Controls.PlayerControl();
            this.Player2 = new Acquire.Controls.PlayerControl();
            this.Player1 = new Acquire.Controls.PlayerControl();
            this.board1 = new Acquire.Board();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.starrtGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // starrtGameToolStripMenuItem
            // 
            this.starrtGameToolStripMenuItem.Name = "starrtGameToolStripMenuItem";
            this.starrtGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.starrtGameToolStripMenuItem.Text = "Start Game";
            this.starrtGameToolStripMenuItem.Click += new System.EventHandler(this.starrtGameToolStripMenuItem_Click);
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // hotelCard7
            // 
            this.hotelCard7.BackColor = System.Drawing.Color.Green;
            this.hotelCard7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hotelCard7.ForeColor = System.Drawing.Color.Black;
            this.hotelCard7.HotelName = AcquireLibrary.Model.HotelEnum.Festival;
            this.hotelCard7.Location = new System.Drawing.Point(138, 613);
            this.hotelCard7.Name = "hotelCard7";
            this.hotelCard7.Size = new System.Drawing.Size(120, 50);
            this.hotelCard7.TabIndex = 13;
            // 
            // hotelCard6
            // 
            this.hotelCard6.BackColor = System.Drawing.Color.Aqua;
            this.hotelCard6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hotelCard6.ForeColor = System.Drawing.Color.White;
            this.hotelCard6.HotelName = AcquireLibrary.Model.HotelEnum.Continental;
            this.hotelCard6.Location = new System.Drawing.Point(264, 557);
            this.hotelCard6.Name = "hotelCard6";
            this.hotelCard6.Size = new System.Drawing.Size(120, 50);
            this.hotelCard6.TabIndex = 12;
            // 
            // hotelCard5
            // 
            this.hotelCard5.BackColor = System.Drawing.Color.Pink;
            this.hotelCard5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hotelCard5.ForeColor = System.Drawing.Color.White;
            this.hotelCard5.HotelName = AcquireLibrary.Model.HotelEnum.Imperial;
            this.hotelCard5.Location = new System.Drawing.Point(264, 501);
            this.hotelCard5.Name = "hotelCard5";
            this.hotelCard5.Size = new System.Drawing.Size(120, 50);
            this.hotelCard5.TabIndex = 11;
            // 
            // hotelCard4
            // 
            this.hotelCard4.BackColor = System.Drawing.Color.Brown;
            this.hotelCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hotelCard4.ForeColor = System.Drawing.Color.Black;
            this.hotelCard4.HotelName = AcquireLibrary.Model.HotelEnum.WorldWide;
            this.hotelCard4.Location = new System.Drawing.Point(138, 557);
            this.hotelCard4.Name = "hotelCard4";
            this.hotelCard4.Size = new System.Drawing.Size(120, 50);
            this.hotelCard4.TabIndex = 10;
            // 
            // hotelCard3
            // 
            this.hotelCard3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.hotelCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hotelCard3.ForeColor = System.Drawing.Color.Black;
            this.hotelCard3.HotelName = AcquireLibrary.Model.HotelEnum.American;
            this.hotelCard3.Location = new System.Drawing.Point(138, 501);
            this.hotelCard3.Name = "hotelCard3";
            this.hotelCard3.Size = new System.Drawing.Size(120, 50);
            this.hotelCard3.TabIndex = 9;
            // 
            // hotelCard2
            // 
            this.hotelCard2.BackColor = System.Drawing.Color.Red;
            this.hotelCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hotelCard2.ForeColor = System.Drawing.Color.White;
            this.hotelCard2.HotelName = AcquireLibrary.Model.HotelEnum.Luxor;
            this.hotelCard2.Location = new System.Drawing.Point(12, 557);
            this.hotelCard2.Name = "hotelCard2";
            this.hotelCard2.Size = new System.Drawing.Size(120, 50);
            this.hotelCard2.TabIndex = 8;
            // 
            // hotelCard1
            // 
            this.hotelCard1.BackColor = System.Drawing.Color.Yellow;
            this.hotelCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hotelCard1.ForeColor = System.Drawing.Color.Black;
            this.hotelCard1.HotelName = AcquireLibrary.Model.HotelEnum.Tower;
            this.hotelCard1.Location = new System.Drawing.Point(12, 501);
            this.hotelCard1.Name = "hotelCard1";
            this.hotelCard1.Size = new System.Drawing.Size(120, 50);
            this.hotelCard1.TabIndex = 7;
            // 
            // Player6
            // 
            this.Player6.Active = false;
            this.Player6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player6.Location = new System.Drawing.Point(940, 393);
            this.Player6.Name = "Player6";
            this.Player6.PlayerName = "Player 6";
            this.Player6.Size = new System.Drawing.Size(303, 173);
            this.Player6.TabIndex = 6;
            this.Player6.Visible = false;
            // 
            // Player5
            // 
            this.Player5.Active = false;
            this.Player5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player5.Location = new System.Drawing.Point(631, 393);
            this.Player5.Name = "Player5";
            this.Player5.PlayerName = "Player 5";
            this.Player5.Size = new System.Drawing.Size(303, 173);
            this.Player5.TabIndex = 5;
            this.Player5.Visible = false;
            // 
            // Player4
            // 
            this.Player4.Active = false;
            this.Player4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player4.Location = new System.Drawing.Point(940, 214);
            this.Player4.Name = "Player4";
            this.Player4.PlayerName = "Player 4";
            this.Player4.Size = new System.Drawing.Size(303, 173);
            this.Player4.TabIndex = 4;
            this.Player4.Visible = false;
            // 
            // Player3
            // 
            this.Player3.Active = false;
            this.Player3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player3.Location = new System.Drawing.Point(631, 214);
            this.Player3.Name = "Player3";
            this.Player3.PlayerName = "Player 3";
            this.Player3.Size = new System.Drawing.Size(303, 173);
            this.Player3.TabIndex = 3;
            this.Player3.Visible = false;
            // 
            // Player2
            // 
            this.Player2.Active = false;
            this.Player2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player2.Location = new System.Drawing.Point(940, 35);
            this.Player2.Name = "Player2";
            this.Player2.PlayerName = "Player 2";
            this.Player2.Size = new System.Drawing.Size(303, 173);
            this.Player2.TabIndex = 2;
            this.Player2.Visible = false;
            // 
            // Player1
            // 
            this.Player1.Active = false;
            this.Player1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player1.Location = new System.Drawing.Point(632, 36);
            this.Player1.Name = "Player1";
            this.Player1.PlayerName = "Player 1";
            this.Player1.Size = new System.Drawing.Size(303, 173);
            this.Player1.TabIndex = 1;
            this.Player1.Visible = false;
            // 
            // board1
            // 
            this.board1.Location = new System.Drawing.Point(12, 35);
            this.board1.Name = "board1";
            this.board1.Size = new System.Drawing.Size(613, 460);
            this.board1.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.hotelCard7);
            this.Controls.Add(this.hotelCard6);
            this.Controls.Add(this.hotelCard5);
            this.Controls.Add(this.hotelCard4);
            this.Controls.Add(this.hotelCard3);
            this.Controls.Add(this.hotelCard2);
            this.Controls.Add(this.hotelCard1);
            this.Controls.Add(this.Player6);
            this.Controls.Add(this.Player5);
            this.Controls.Add(this.Player4);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.board1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Acquire";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Board board1;
        private Controls.PlayerControl Player1;
        private Controls.PlayerControl Player2;
        private Controls.PlayerControl Player3;
        private Controls.PlayerControl Player4;
        private Controls.PlayerControl Player5;
        private Controls.PlayerControl Player6;
        private Controls.HotelCardControl hotelCard1;
        private Controls.HotelCardControl hotelCard2;
        private Controls.HotelCardControl hotelCard3;
        private Controls.HotelCardControl hotelCard4;
        private Controls.HotelCardControl hotelCard5;
        private Controls.HotelCardControl hotelCard6;
        private Controls.HotelCardControl hotelCard7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem starrtGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    }
}

