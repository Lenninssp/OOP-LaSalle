

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
            fontDialog1 = new FontDialog();
            labelBookNumber = new Label();
            labelBookTitle = new Label();
            textBoxNumber = new TextBox();
            textBoxTitle = new TextBox();
            buttonAdd = new Button();
            buttonPRINT = new Button();
            listBoxBookLibrary = new ListBox();
            buttonReset = new Button();
            buttonExit = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxISBN = new TextBox();
            textBoxPages = new TextBox();
            SuspendLayout();
            // 
            // labelBookNumber
            // 
            labelBookNumber.BorderStyle = BorderStyle.Fixed3D;
            labelBookNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelBookNumber.Location = new Point(45, 63);
            labelBookNumber.Name = "labelBookNumber";
            labelBookNumber.Size = new Size(202, 48);
            labelBookNumber.TabIndex = 0;
            labelBookNumber.Text = "Book number ? ";
            labelBookNumber.Click += labelBookNumber_Click;
            // 
            // labelBookTitle
            // 
            labelBookTitle.BorderStyle = BorderStyle.Fixed3D;
            labelBookTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelBookTitle.Location = new Point(45, 111);
            labelBookTitle.Name = "labelBookTitle";
            labelBookTitle.Size = new Size(193, 47);
            labelBookTitle.TabIndex = 1;
            labelBookTitle.Text = "Book title     ?";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(277, 72);
            textBoxNumber.Margin = new Padding(3, 4, 3, 4);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(302, 27);
            textBoxNumber.TabIndex = 2;
            textBoxNumber.TextChanged += textBoxNumber_TextChanged;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(277, 111);
            textBoxTitle.Margin = new Padding(3, 4, 3, 4);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(302, 27);
            textBoxTitle.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdd.Location = new Point(45, 323);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(86, 59);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonPRINT
            // 
            buttonPRINT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPRINT.Location = new Point(176, 301);
            buttonPRINT.Margin = new Padding(3, 4, 3, 4);
            buttonPRINT.Name = "buttonPRINT";
            buttonPRINT.Size = new Size(86, 59);
            buttonPRINT.TabIndex = 5;
            buttonPRINT.Text = "PRINT";
            buttonPRINT.UseVisualStyleBackColor = true;
            buttonPRINT.Click += buttonPRINT_Click;
            // 
            // listBoxBookLibrary
            // 
            listBoxBookLibrary.FormattingEnabled = true;
            listBoxBookLibrary.Location = new Point(176, 395);
            listBoxBookLibrary.Margin = new Padding(3, 4, 3, 4);
            listBoxBookLibrary.Name = "listBoxBookLibrary";
            listBoxBookLibrary.Size = new Size(369, 164);
            listBoxBookLibrary.TabIndex = 6;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(326, 301);
            buttonReset.Margin = new Padding(3, 4, 3, 4);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(89, 59);
            buttonReset.TabIndex = 7;
            buttonReset.Text = "RESET";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(456, 301);
            buttonExit.Margin = new Padding(3, 4, 3, 4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(89, 59);
            buttonExit.TabIndex = 8;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(45, 158);
            label1.Name = "label1";
            label1.Size = new Size(193, 47);
            label1.TabIndex = 9;
            label1.Text = "Book ISBN     ?";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(45, 205);
            label2.Name = "label2";
            label2.Size = new Size(193, 47);
            label2.TabIndex = 10;
            label2.Text = "Book pages     ?";
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(277, 163);
            textBoxISBN.Margin = new Padding(3, 4, 3, 4);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(302, 27);
            textBoxISBN.TabIndex = 11;
            // 
            // textBoxPages
            // 
            textBoxPages.Location = new Point(277, 210);
            textBoxPages.Margin = new Padding(3, 4, 3, 4);
            textBoxPages.Name = "textBoxPages";
            textBoxPages.Size = new Size(302, 27);
            textBoxPages.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(textBoxPages);
            Controls.Add(textBoxISBN);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(listBoxBookLibrary);
            Controls.Add(buttonPRINT);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxNumber);
            Controls.Add(labelBookTitle);
            Controls.Add(labelBookNumber);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontDialog fontDialog1;
        private Label labelBookNumber;
        private Label labelBookTitle;
        private TextBox textBoxNumber;
        private TextBox textBoxTitle;
        private Button buttonAdd;
        private Button buttonPRINT;
        private ListBox listBoxBookLibrary;
        private Button buttonReset;
        private Button buttonExit;
        private Label label1;
        private Label label2;
        private TextBox textBoxISBN;
        private TextBox textBoxPages;
    }
}
