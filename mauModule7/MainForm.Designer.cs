namespace mauModule7
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblShowTitle = new Label();
            btnAdd = new Button();
            lstShowEntries = new ListBox();
            btnDelete = new Button();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            entryToolTip = new ToolTip(components);
            lblType = new Label();
            lblStatus = new Label();
            lblProgress = new Label();
            lblScore = new Label();
            txtCurrentShow = new TextBox();
            lblCurrShowTitle = new Label();
            lblEpisodeswatched = new Label();
            lblTotalEpisodes = new Label();
            txtTotalEpisodes = new TextBox();
            grpSelectedShow = new GroupBox();
            numShowScore = new NumericUpDown();
            lblShowScore = new Label();
            numEpisodesWatched = new NumericUpDown();
            label1 = new Label();
            cmbWachStatus = new ComboBox();
            menuStrip.SuspendLayout();
            grpSelectedShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numShowScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEpisodesWatched).BeginInit();
            SuspendLayout();
            // 
            // lblShowTitle
            // 
            lblShowTitle.AutoSize = true;
            lblShowTitle.Location = new Point(82, 142);
            lblShowTitle.Name = "lblShowTitle";
            lblShowTitle.Size = new Size(61, 15);
            lblShowTitle.TabIndex = 0;
            lblShowTitle.Text = "Show Title";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(66, 440);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstShowEntries
            // 
            lstShowEntries.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lstShowEntries.FormattingEnabled = true;
            lstShowEntries.ItemHeight = 15;
            lstShowEntries.Location = new Point(41, 169);
            lstShowEntries.Name = "lstShowEntries";
            lstShowEntries.Size = new Size(755, 244);
            lstShowEntries.TabIndex = 2;
            lstShowEntries.SelectedIndexChanged += lstShowEntries_SelectedIndexChanged;
            lstShowEntries.MouseMove += lstShowEntries_MouseMove;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(208, 442);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(836, 24);
            menuStrip.TabIndex = 4;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(103, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(103, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // entryToolTip
            // 
            entryToolTip.Popup += entryToolTip_Popup;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(368, 142);
            lblType.Name = "lblType";
            lblType.Size = new Size(31, 15);
            lblType.TabIndex = 5;
            lblType.Text = "Type";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(430, 142);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status";
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(494, 142);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(52, 15);
            lblProgress.TabIndex = 7;
            lblProgress.Text = "Progress";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(584, 142);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(36, 15);
            lblScore.TabIndex = 8;
            lblScore.Text = "Score";
            // 
            // txtCurrentShow
            // 
            txtCurrentShow.Location = new Point(132, 22);
            txtCurrentShow.Name = "txtCurrentShow";
            txtCurrentShow.ReadOnly = true;
            txtCurrentShow.Size = new Size(226, 23);
            txtCurrentShow.TabIndex = 10;
            // 
            // lblCurrShowTitle
            // 
            lblCurrShowTitle.AutoSize = true;
            lblCurrShowTitle.Location = new Point(22, 26);
            lblCurrShowTitle.Name = "lblCurrShowTitle";
            lblCurrShowTitle.Size = new Size(104, 15);
            lblCurrShowTitle.TabIndex = 11;
            lblCurrShowTitle.Text = "Current Show Title";
            // 
            // lblEpisodeswatched
            // 
            lblEpisodeswatched.AutoSize = true;
            lblEpisodeswatched.Location = new Point(366, 26);
            lblEpisodeswatched.Name = "lblEpisodeswatched";
            lblEpisodeswatched.Size = new Size(103, 15);
            lblEpisodeswatched.TabIndex = 12;
            lblEpisodeswatched.Text = "Episodes Watched";
            // 
            // lblTotalEpisodes
            // 
            lblTotalEpisodes.AutoSize = true;
            lblTotalEpisodes.Location = new Point(366, 63);
            lblTotalEpisodes.Name = "lblTotalEpisodes";
            lblTotalEpisodes.Size = new Size(81, 15);
            lblTotalEpisodes.TabIndex = 13;
            lblTotalEpisodes.Text = "Total Episodes";
            // 
            // txtTotalEpisodes
            // 
            txtTotalEpisodes.Location = new Point(475, 60);
            txtTotalEpisodes.Name = "txtTotalEpisodes";
            txtTotalEpisodes.ReadOnly = true;
            txtTotalEpisodes.Size = new Size(58, 23);
            txtTotalEpisodes.TabIndex = 14;
            // 
            // grpSelectedShow
            // 
            grpSelectedShow.Controls.Add(numShowScore);
            grpSelectedShow.Controls.Add(lblShowScore);
            grpSelectedShow.Controls.Add(numEpisodesWatched);
            grpSelectedShow.Controls.Add(label1);
            grpSelectedShow.Controls.Add(cmbWachStatus);
            grpSelectedShow.Controls.Add(lblEpisodeswatched);
            grpSelectedShow.Controls.Add(txtTotalEpisodes);
            grpSelectedShow.Controls.Add(lblTotalEpisodes);
            grpSelectedShow.Controls.Add(txtCurrentShow);
            grpSelectedShow.Controls.Add(lblCurrShowTitle);
            grpSelectedShow.Location = new Point(41, 27);
            grpSelectedShow.Name = "grpSelectedShow";
            grpSelectedShow.Size = new Size(755, 103);
            grpSelectedShow.TabIndex = 15;
            grpSelectedShow.TabStop = false;
            grpSelectedShow.Text = "Selected Show";
            // 
            // numShowScore
            // 
            numShowScore.Location = new Point(641, 22);
            numShowScore.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numShowScore.Name = "numShowScore";
            numShowScore.Size = new Size(50, 23);
            numShowScore.TabIndex = 19;
            numShowScore.ValueChanged += numShowScore_ValueChanged;
            // 
            // lblShowScore
            // 
            lblShowScore.AutoSize = true;
            lblShowScore.Location = new Point(567, 26);
            lblShowScore.Name = "lblShowScore";
            lblShowScore.Size = new Size(68, 15);
            lblShowScore.TabIndex = 18;
            lblShowScore.Text = "Show Score";
            // 
            // numEpisodesWatched
            // 
            numEpisodesWatched.Location = new Point(475, 22);
            numEpisodesWatched.Name = "numEpisodesWatched";
            numEpisodesWatched.Size = new Size(58, 23);
            numEpisodesWatched.TabIndex = 17;
            numEpisodesWatched.ValueChanged += numEpisodesWatched_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 63);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 16;
            label1.Text = "Watch Status";
            // 
            // cmbWachStatus
            // 
            cmbWachStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWachStatus.FormattingEnabled = true;
            cmbWachStatus.Location = new Point(132, 60);
            cmbWachStatus.Name = "cmbWachStatus";
            cmbWachStatus.Size = new Size(121, 23);
            cmbWachStatus.TabIndex = 15;
            cmbWachStatus.SelectedIndexChanged += cmbWachStatus_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 529);
            Controls.Add(grpSelectedShow);
            Controls.Add(lblScore);
            Controls.Add(lblProgress);
            Controls.Add(lblStatus);
            Controls.Add(lblType);
            Controls.Add(btnDelete);
            Controls.Add(lstShowEntries);
            Controls.Add(btnAdd);
            Controls.Add(lblShowTitle);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "Form1";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            grpSelectedShow.ResumeLayout(false);
            grpSelectedShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numShowScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEpisodesWatched).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShowTitle;
        private Button btnAdd;
        private ListBox lstShowEntries;
        private Button btnDelete;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label lblEpisodeswatched;
        private ToolTip entryToolTip;
        private Label lblType;
        private Label lblStatus;
        private Label lblProgress;
        private Label lblScore;
        private TextBox txtCurrentShow;
        private Label lblCurrShowTitle;
        private Label lblTotalEpisodes;
        private TextBox textBox2;
        private GroupBox grpSelectedShow;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox cmbWachStatus;
        private TextBox txtTotalEpisodes;
        private NumericUpDown numEpisodesWatched;
        private NumericUpDown numShowScore;
        private Label lblShowScore;
    }
}