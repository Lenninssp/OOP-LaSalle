

namespace WinFormsLibrary_V2.user
{
    partial class Form1
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
            label1 = new Label();
            buttonShow = new Button();
            buttonExit = new Button();
            buttonShowBook = new Button();
            buttonShowAll = new Button();
            listBoxLibrary = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 255, 128);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(71, 18);
            label1.Name = "label1";
            label1.Size = new Size(327, 37);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO EVENT PROGRAMMING";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(2, 76);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(145, 23);
            buttonShow.TabIndex = 1;
            buttonShow.Text = "Show Message";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(55, 279);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonShowBook
            // 
            buttonShowBook.Location = new Point(4, 128);
            buttonShowBook.Name = "buttonShowBook";
            buttonShowBook.Size = new Size(126, 23);
            buttonShowBook.TabIndex = 3;
            buttonShowBook.Text = "Show books";
            buttonShowBook.UseVisualStyleBackColor = true;
            buttonShowBook.Click += buttonShowBook_Click;
            // 
            // buttonShowAll
            // 
            buttonShowAll.Location = new Point(2, 189);
            buttonShowAll.Name = "buttonShowAll";
            buttonShowAll.Size = new Size(128, 23);
            buttonShowAll.TabIndex = 4;
            buttonShowAll.Text = "Show All";
            buttonShowAll.UseVisualStyleBackColor = true;
            buttonShowAll.Click += buttonShowAll_Click;
            // 
            // listBoxLibrary
            // 
            listBoxLibrary.FormattingEnabled = true;
            listBoxLibrary.ItemHeight = 15;
            listBoxLibrary.Location = new Point(232, 165);
            listBoxLibrary.Name = "listBoxLibrary";
            listBoxLibrary.Size = new Size(185, 94);
            listBoxLibrary.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(484, 361);
            Controls.Add(listBoxLibrary);
            Controls.Add(buttonShowAll);
            Controls.Add(buttonShowBook);
            Controls.Add(buttonExit);
            Controls.Add(buttonShow);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1- Library Management System";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button buttonShow;
        private Button buttonExit;
        private Button buttonShowBook;
        private Button buttonShowAll;
        private ListBox listBoxLibrary;
    }
}
