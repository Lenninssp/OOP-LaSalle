

namespace WinFormsSchoolLibraryV3.user
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
            labelMessage = new Label();
            buttonShowMessage = new Button();
            buttonExit = new Button();
            buttonShowIndividualBook = new Button();
            buttonShowAllBooks = new Button();
            listBoxSchoolLibrary = new ListBox();
            SuspendLayout();
            // 
            // labelMessage
            // 
            labelMessage.BackColor = Color.FromArgb(255, 128, 255);
            labelMessage.BorderStyle = BorderStyle.FixedSingle;
            labelMessage.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            labelMessage.ForeColor = Color.FromArgb(0, 0, 192);
            labelMessage.Location = new Point(208, 25);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(356, 59);
            labelMessage.TabIndex = 0;
            labelMessage.Text = "Welcome To event Programming";
            labelMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonShowMessage
            // 
            buttonShowMessage.BackColor = Color.FromArgb(128, 255, 128);
            buttonShowMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            buttonShowMessage.ForeColor = Color.Blue;
            buttonShowMessage.Location = new Point(12, 89);
            buttonShowMessage.Name = "buttonShowMessage";
            buttonShowMessage.Size = new Size(93, 50);
            buttonShowMessage.TabIndex = 1;
            buttonShowMessage.Text = "Show Message";
            buttonShowMessage.UseVisualStyleBackColor = false;
            buttonShowMessage.Click += buttonShowMessage_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(489, 232);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonShowIndividualBook
            // 
            buttonShowIndividualBook.Location = new Point(12, 145);
            buttonShowIndividualBook.Name = "buttonShowIndividualBook";
            buttonShowIndividualBook.Size = new Size(169, 46);
            buttonShowIndividualBook.TabIndex = 3;
            buttonShowIndividualBook.Text = "Show individual book";
            buttonShowIndividualBook.UseVisualStyleBackColor = true;
            buttonShowIndividualBook.Click += buttonShowIndividualBook_Click;
            // 
            // buttonShowAllBooks
            // 
            buttonShowAllBooks.Location = new Point(42, 224);
            buttonShowAllBooks.Name = "buttonShowAllBooks";
            buttonShowAllBooks.Size = new Size(127, 31);
            buttonShowAllBooks.TabIndex = 4;
            buttonShowAllBooks.Text = "Show All Books";
            buttonShowAllBooks.UseVisualStyleBackColor = true;
            buttonShowAllBooks.Click += buttonShowAllBooks_Click;
            // 
            // listBoxSchoolLibrary
            // 
            listBoxSchoolLibrary.FormattingEnabled = true;
            listBoxSchoolLibrary.ItemHeight = 15;
            listBoxSchoolLibrary.Location = new Point(229, 130);
            listBoxSchoolLibrary.Name = "listBoxSchoolLibrary";
            listBoxSchoolLibrary.Size = new Size(208, 94);
            listBoxSchoolLibrary.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(592, 267);
            Controls.Add(listBoxSchoolLibrary);
            Controls.Add(buttonShowAllBooks);
            Controls.Add(buttonShowIndividualBook);
            Controls.Add(buttonExit);
            Controls.Add(buttonShowMessage);
            Controls.Add(labelMessage);
            Name = "Form1";
            Text = "School Library -Version 01";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        /**
         * labelMessage is a reference variable of the type Label         * 
         * Here the name Label is a class data type         
         */
        private Label labelMessage;

        private Button buttonShowMessage;
        private Button buttonExit;
        private Button buttonShowIndividualBook;
        private Button buttonShowAllBooks;
        private ListBox listBoxSchoolLibrary;
    }
}
