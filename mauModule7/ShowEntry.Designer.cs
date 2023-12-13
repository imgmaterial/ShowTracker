namespace mauModule7
{
    partial class ShowEntry
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
            lblShowEntry = new Label();
            lblShowTitle = new Label();
            lblShowType = new Label();
            lblWatchStatus = new Label();
            lblEpisodesWatched = new Label();
            lblTotalEpisodes = new Label();
            lblUserScore = new Label();
            txtShowTitle = new TextBox();
            cmbShowType = new ComboBox();
            cmbWatchStatus = new ComboBox();
            txtEpisodesWatched = new TextBox();
            txtTotalEpisodes = new TextBox();
            txtUserScore = new TextBox();
            grpShowInfo = new GroupBox();
            btnOk = new Button();
            btnCancel = new Button();
            grpShowInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblShowEntry
            // 
            lblShowEntry.AutoSize = true;
            lblShowEntry.Location = new Point(157, 22);
            lblShowEntry.Name = "lblShowEntry";
            lblShowEntry.Size = new Size(66, 15);
            lblShowEntry.TabIndex = 0;
            lblShowEntry.Text = "Show Entry";
            // 
            // lblShowTitle
            // 
            lblShowTitle.AutoSize = true;
            lblShowTitle.Location = new Point(15, 37);
            lblShowTitle.Name = "lblShowTitle";
            lblShowTitle.Size = new Size(61, 15);
            lblShowTitle.TabIndex = 1;
            lblShowTitle.Text = "Show Title";
            // 
            // lblShowType
            // 
            lblShowType.AutoSize = true;
            lblShowType.Location = new Point(15, 81);
            lblShowType.Name = "lblShowType";
            lblShowType.Size = new Size(63, 15);
            lblShowType.TabIndex = 2;
            lblShowType.Text = "Show Type";
            // 
            // lblWatchStatus
            // 
            lblWatchStatus.AutoSize = true;
            lblWatchStatus.Location = new Point(15, 125);
            lblWatchStatus.Name = "lblWatchStatus";
            lblWatchStatus.Size = new Size(76, 15);
            lblWatchStatus.TabIndex = 3;
            lblWatchStatus.Text = "Watch Status";
            // 
            // lblEpisodesWatched
            // 
            lblEpisodesWatched.AutoSize = true;
            lblEpisodesWatched.Location = new Point(15, 168);
            lblEpisodesWatched.Name = "lblEpisodesWatched";
            lblEpisodesWatched.Size = new Size(103, 15);
            lblEpisodesWatched.TabIndex = 4;
            lblEpisodesWatched.Text = "Episodes Watched";
            // 
            // lblTotalEpisodes
            // 
            lblTotalEpisodes.AutoSize = true;
            lblTotalEpisodes.Location = new Point(15, 211);
            lblTotalEpisodes.Name = "lblTotalEpisodes";
            lblTotalEpisodes.Size = new Size(81, 15);
            lblTotalEpisodes.TabIndex = 5;
            lblTotalEpisodes.Text = "Total Episodes";
            // 
            // lblUserScore
            // 
            lblUserScore.AutoSize = true;
            lblUserScore.Location = new Point(15, 258);
            lblUserScore.Name = "lblUserScore";
            lblUserScore.Size = new Size(62, 15);
            lblUserScore.TabIndex = 6;
            lblUserScore.Text = "User Score";
            // 
            // txtShowTitle
            // 
            txtShowTitle.Location = new Point(124, 34);
            txtShowTitle.Name = "txtShowTitle";
            txtShowTitle.Size = new Size(223, 23);
            txtShowTitle.TabIndex = 7;
            // 
            // cmbShowType
            // 
            cmbShowType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbShowType.FormattingEnabled = true;
            cmbShowType.Location = new Point(124, 78);
            cmbShowType.Name = "cmbShowType";
            cmbShowType.Size = new Size(223, 23);
            cmbShowType.TabIndex = 8;
            // 
            // cmbWatchStatus
            // 
            cmbWatchStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWatchStatus.FormattingEnabled = true;
            cmbWatchStatus.Location = new Point(124, 122);
            cmbWatchStatus.Name = "cmbWatchStatus";
            cmbWatchStatus.Size = new Size(223, 23);
            cmbWatchStatus.TabIndex = 9;
            // 
            // txtEpisodesWatched
            // 
            txtEpisodesWatched.Location = new Point(124, 165);
            txtEpisodesWatched.Name = "txtEpisodesWatched";
            txtEpisodesWatched.Size = new Size(223, 23);
            txtEpisodesWatched.TabIndex = 10;
            // 
            // txtTotalEpisodes
            // 
            txtTotalEpisodes.Location = new Point(124, 208);
            txtTotalEpisodes.Name = "txtTotalEpisodes";
            txtTotalEpisodes.Size = new Size(223, 23);
            txtTotalEpisodes.TabIndex = 11;
            // 
            // txtUserScore
            // 
            txtUserScore.Location = new Point(124, 255);
            txtUserScore.Name = "txtUserScore";
            txtUserScore.Size = new Size(223, 23);
            txtUserScore.TabIndex = 12;
            // 
            // grpShowInfo
            // 
            grpShowInfo.Controls.Add(lblShowTitle);
            grpShowInfo.Controls.Add(txtUserScore);
            grpShowInfo.Controls.Add(lblShowType);
            grpShowInfo.Controls.Add(txtTotalEpisodes);
            grpShowInfo.Controls.Add(lblWatchStatus);
            grpShowInfo.Controls.Add(txtEpisodesWatched);
            grpShowInfo.Controls.Add(lblEpisodesWatched);
            grpShowInfo.Controls.Add(cmbWatchStatus);
            grpShowInfo.Controls.Add(lblTotalEpisodes);
            grpShowInfo.Controls.Add(cmbShowType);
            grpShowInfo.Controls.Add(lblUserScore);
            grpShowInfo.Controls.Add(txtShowTitle);
            grpShowInfo.Location = new Point(12, 40);
            grpShowInfo.Name = "grpShowInfo";
            grpShowInfo.Size = new Size(369, 316);
            grpShowInfo.TabIndex = 13;
            grpShowInfo.TabStop = false;
            grpShowInfo.Text = "Show Info";
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(45, 382);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(129, 42);
            btnOk.TabIndex = 14;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(219, 382);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 42);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // ShowEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(grpShowInfo);
            Controls.Add(lblShowEntry);
            Name = "ShowEntry";
            Text = "ShowEntry";
            grpShowInfo.ResumeLayout(false);
            grpShowInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShowEntry;
        private Label lblShowTitle;
        private Label lblShowType;
        private Label lblWatchStatus;
        private Label lblEpisodesWatched;
        private Label lblTotalEpisodes;
        private Label lblUserScore;
        private TextBox txtShowTitle;
        private ComboBox cmbShowType;
        private ComboBox cmbWatchStatus;
        private TextBox txtEpisodesWatched;
        private TextBox txtTotalEpisodes;
        private TextBox txtUserScore;
        private GroupBox grpShowInfo;
        private Button btnOk;
        private Button btnCancel;
    }
}