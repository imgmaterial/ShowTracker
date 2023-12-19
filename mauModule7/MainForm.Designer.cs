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
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // lblShowTitle
            // 
            lblShowTitle.AutoSize = true;
            lblShowTitle.Location = new Point(92, 102);
            lblShowTitle.Name = "lblShowTitle";
            lblShowTitle.Size = new Size(61, 15);
            lblShowTitle.TabIndex = 0;
            lblShowTitle.Text = "Show Title";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(76, 400);
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
            lstShowEntries.Location = new Point(51, 129);
            lstShowEntries.Name = "lstShowEntries";
            lstShowEntries.Size = new Size(593, 244);
            lstShowEntries.TabIndex = 2;
            lstShowEntries.MouseMove += lstShowEntries_MouseMove;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(218, 402);
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
            menuStrip.Size = new Size(800, 24);
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
            lblType.Location = new Point(378, 102);
            lblType.Name = "lblType";
            lblType.Size = new Size(31, 15);
            lblType.TabIndex = 5;
            lblType.Text = "Type";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(440, 102);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status";
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(504, 102);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(52, 15);
            lblProgress.TabIndex = 7;
            lblProgress.Text = "Progress";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(594, 102);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(36, 15);
            lblScore.TabIndex = 8;
            lblScore.Text = "Score";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private Label label1;
        private ToolTip entryToolTip;
        private Label lblType;
        private Label lblStatus;
        private Label lblProgress;
        private Label lblScore;
    }
}