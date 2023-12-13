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
            Based = new Label();
            btnAdd = new Button();
            lstShowEntries = new ListBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // Based
            // 
            Based.AutoSize = true;
            Based.Location = new Point(187, 73);
            Based.Name = "Based";
            Based.Size = new Size(38, 15);
            Based.TabIndex = 0;
            Based.Text = "Based";
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
            lstShowEntries.FormattingEnabled = true;
            lstShowEntries.ItemHeight = 15;
            lstShowEntries.Location = new Point(51, 129);
            lstShowEntries.Name = "lstShowEntries";
            lstShowEntries.Size = new Size(490, 244);
            lstShowEntries.TabIndex = 2;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(lstShowEntries);
            Controls.Add(btnAdd);
            Controls.Add(Based);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Based;
        private Button btnAdd;
        private ListBox lstShowEntries;
        private Button btnDelete;
    }
}