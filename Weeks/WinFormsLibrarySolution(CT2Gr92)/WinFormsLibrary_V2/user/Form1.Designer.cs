

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
            labelLanguage = new Label();
            comboBoxLanguage = new ComboBox();
            buttonSearch = new Button();
            labelSearch = new Label();
            labelPublishedDate = new Label();
            labelMonth = new Label();
            labelDay = new Label();
            labelYear = new Label();
            textBoxMonth = new TextBox();
            textBoxDay = new TextBox();
            textBoxYear = new TextBox();
            SuspendLayout();
            // 
            // labelBookNumber
            // 
            labelBookNumber.BorderStyle = BorderStyle.Fixed3D;
            labelBookNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelBookNumber.Location = new Point(39, 47);
            labelBookNumber.Name = "labelBookNumber";
            labelBookNumber.Size = new Size(177, 36);
            labelBookNumber.TabIndex = 0;
            labelBookNumber.Text = "Book number ? ";
            // 
            // labelBookTitle
            // 
            labelBookTitle.BorderStyle = BorderStyle.Fixed3D;
            labelBookTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelBookTitle.Location = new Point(39, 92);
            labelBookTitle.Name = "labelBookTitle";
            labelBookTitle.Size = new Size(169, 35);
            labelBookTitle.TabIndex = 1;
            labelBookTitle.Text = "Book title     ?";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(242, 54);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(265, 23);
            textBoxNumber.TabIndex = 2;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(242, 95);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(265, 23);
            textBoxTitle.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdd.Location = new Point(12, 200);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 44);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonPRINT
            // 
            buttonPRINT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPRINT.Location = new Point(107, 200);
            buttonPRINT.Name = "buttonPRINT";
            buttonPRINT.Size = new Size(75, 44);
            buttonPRINT.TabIndex = 5;
            buttonPRINT.Text = "PRINT";
            buttonPRINT.UseVisualStyleBackColor = true;
            buttonPRINT.Click += buttonPRINT_Click;
            // 
            // listBoxBookLibrary
            // 
            listBoxBookLibrary.FormattingEnabled = true;
            listBoxBookLibrary.ItemHeight = 15;
            listBoxBookLibrary.Location = new Point(12, 283);
            listBoxBookLibrary.Name = "listBoxBookLibrary";
            listBoxBookLibrary.Size = new Size(323, 124);
            listBoxBookLibrary.TabIndex = 6;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(232, 200);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(78, 44);
            buttonReset.TabIndex = 7;
            buttonReset.Text = "RESET";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(651, 346);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(78, 44);
            buttonExit.TabIndex = 8;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelLanguage
            // 
            labelLanguage.BorderStyle = BorderStyle.Fixed3D;
            labelLanguage.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelLanguage.Location = new Point(39, 142);
            labelLanguage.Name = "labelLanguage";
            labelLanguage.Size = new Size(169, 35);
            labelLanguage.TabIndex = 9;
            labelLanguage.Text = "Book language   ?";
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Location = new Point(242, 145);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(187, 23);
            comboBoxLanguage.TabIndex = 10;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSearch.Location = new Point(679, 211);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 33);
            buttonSearch.TabIndex = 11;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelSearch
            // 
            labelSearch.BorderStyle = BorderStyle.Fixed3D;
            labelSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelSearch.Location = new Point(420, 215);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(244, 33);
            labelSearch.TabIndex = 12;
            labelSearch.Text = "Search for a book by number ";
            // 
            // labelPublishedDate
            // 
            labelPublishedDate.BorderStyle = BorderStyle.Fixed3D;
            labelPublishedDate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelPublishedDate.Location = new Point(544, 9);
            labelPublishedDate.Name = "labelPublishedDate";
            labelPublishedDate.Size = new Size(244, 33);
            labelPublishedDate.TabIndex = 13;
            labelPublishedDate.Text = "Published date ?";
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.BorderStyle = BorderStyle.Fixed3D;
            labelMonth.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelMonth.Location = new Point(588, 48);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(76, 21);
            labelMonth.TabIndex = 14;
            labelMonth.Text = "Month ? : ";
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.BorderStyle = BorderStyle.Fixed3D;
            labelDay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelDay.Location = new Point(588, 80);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(59, 21);
            labelDay.TabIndex = 15;
            labelDay.Text = "Day ? : ";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.BorderStyle = BorderStyle.Fixed3D;
            labelYear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelYear.Location = new Point(588, 109);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(59, 21);
            labelYear.TabIndex = 16;
            labelYear.Text = "Year? : ";
            // 
            // textBoxMonth
            // 
            textBoxMonth.Location = new Point(697, 50);
            textBoxMonth.Name = "textBoxMonth";
            textBoxMonth.Size = new Size(100, 23);
            textBoxMonth.TabIndex = 17;
            // 
            // textBoxDay
            // 
            textBoxDay.Location = new Point(697, 78);
            textBoxDay.Name = "textBoxDay";
            textBoxDay.Size = new Size(100, 23);
            textBoxDay.TabIndex = 18;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(697, 107);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(100, 23);
            textBoxYear.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 450);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxDay);
            Controls.Add(textBoxMonth);
            Controls.Add(labelYear);
            Controls.Add(labelDay);
            Controls.Add(labelMonth);
            Controls.Add(labelPublishedDate);
            Controls.Add(labelSearch);
            Controls.Add(buttonSearch);
            Controls.Add(comboBoxLanguage);
            Controls.Add(labelLanguage);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(listBoxBookLibrary);
            Controls.Add(buttonPRINT);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxNumber);
            Controls.Add(labelBookTitle);
            Controls.Add(labelBookNumber);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
        private Label labelLanguage;
        private ComboBox comboBoxLanguage;
        private Button buttonSearch;
        private Label labelSearch;
        private Label labelPublishedDate;
        private Label labelMonth;
        private Label labelDay;
        private Label labelYear;
        private TextBox textBoxMonth;
        private TextBox textBoxDay;
        private TextBox textBoxYear;
    }
}
