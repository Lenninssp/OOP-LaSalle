

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
            labelNumber = new Label();
            labelTitle = new Label();
            textBoxNumber = new TextBox();
            textBoxTitle = new TextBox();
            buttonAdd = new Button();
            buttonPrint = new Button();
            buttonSearch = new Button();
            buttonReset = new Button();
            buttonExit = new Button();
            listBoxLibrary = new ListBox();
            labelLanguage = new Label();
            comboBoxLanguage = new ComboBox();
            textBoxYear = new TextBox();
            labelYear = new Label();
            textBoxDay = new TextBox();
            labelDay = new Label();
            textBoxMonth = new TextBox();
            labelMonth = new Label();
            labelPublishedDate = new Label();
            label1 = new Label();
            label2 = new Label();
            buttonUpdate = new Button();
            buttondELETE = new Button();
            labelDelete = new Label();
            buttonWriteToXmlFile = new Button();
            buttonReadFromXmlFile = new Button();
            comboBoxItemType = new ComboBox();
            labelType = new Label();
            textBoxCapacity = new TextBox();
            labelCapacity = new Label();
            textBoxPages = new TextBox();
            labelPages = new Label();
            SuspendLayout();
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.BorderStyle = BorderStyle.Fixed3D;
            labelNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelNumber.Location = new Point(12, 83);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(77, 21);
            labelNumber.TabIndex = 0;
            labelNumber.Text = "number ? ";
            labelNumber.Click += labelNumber_Click;
            // 
            // labelTitle
            // 
            labelTitle.BorderStyle = BorderStyle.Fixed3D;
            labelTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTitle.Location = new Point(12, 113);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(81, 23);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "title ?  ";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(106, 81);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(100, 23);
            textBoxNumber.TabIndex = 2;
            textBoxNumber.TextChanged += textBoxNumber_TextChanged;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(106, 119);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(135, 23);
            textBoxTitle.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdd.Location = new Point(2, 262);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(53, 35);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonPrint
            // 
            buttonPrint.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPrint.Location = new Point(61, 262);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(52, 35);
            buttonPrint.TabIndex = 5;
            buttonPrint.Text = "PRINT";
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSearch.Location = new Point(513, 219);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(69, 33);
            buttonSearch.TabIndex = 6;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonReset.Location = new Point(119, 262);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(57, 35);
            buttonReset.TabIndex = 7;
            buttonReset.Text = "RESET";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonExit.Location = new Point(689, 437);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(69, 51);
            buttonExit.TabIndex = 8;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // listBoxLibrary
            // 
            listBoxLibrary.FormattingEnabled = true;
            listBoxLibrary.ItemHeight = 15;
            listBoxLibrary.Location = new Point(2, 308);
            listBoxLibrary.Name = "listBoxLibrary";
            listBoxLibrary.Size = new Size(474, 139);
            listBoxLibrary.TabIndex = 9;
            listBoxLibrary.SelectedIndexChanged += listBoxLibrary_SelectedIndexChanged;
            // 
            // labelLanguage
            // 
            labelLanguage.AutoSize = true;
            labelLanguage.BorderStyle = BorderStyle.Fixed3D;
            labelLanguage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelLanguage.Location = new Point(6, 152);
            labelLanguage.Name = "labelLanguage";
            labelLanguage.Size = new Size(87, 21);
            labelLanguage.TabIndex = 10;
            labelLanguage.Text = "language ? ";
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Location = new Point(105, 152);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(135, 23);
            comboBoxLanguage.TabIndex = 11;
            comboBoxLanguage.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(513, 119);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(53, 23);
            textBoxYear.TabIndex = 18;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelYear.Location = new Point(442, 113);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(61, 19);
            labelYear.TabIndex = 15;
            labelYear.Text = "Year ? : ";
            // 
            // textBoxDay
            // 
            textBoxDay.Location = new Point(513, 90);
            textBoxDay.Name = "textBoxDay";
            textBoxDay.Size = new Size(53, 23);
            textBoxDay.TabIndex = 17;
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelDay.Location = new Point(442, 86);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(57, 19);
            labelDay.TabIndex = 14;
            labelDay.Text = "Day ? : ";
            // 
            // textBoxMonth
            // 
            textBoxMonth.Location = new Point(513, 62);
            textBoxMonth.Name = "textBoxMonth";
            textBoxMonth.Size = new Size(53, 23);
            textBoxMonth.TabIndex = 16;
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelMonth.Location = new Point(442, 63);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(74, 19);
            labelMonth.TabIndex = 13;
            labelMonth.Text = "Month ? : ";
            // 
            // labelPublishedDate
            // 
            labelPublishedDate.AutoSize = true;
            labelPublishedDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labelPublishedDate.Location = new Point(442, 30);
            labelPublishedDate.Name = "labelPublishedDate";
            labelPublishedDate.Size = new Size(142, 21);
            labelPublishedDate.TabIndex = 12;
            labelPublishedDate.Text = "Published date ? : ";
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(513, 186);
            label1.Name = "label1";
            label1.Size = new Size(245, 30);
            label1.TabIndex = 19;
            label1.Text = "Search for a book by number";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(513, 271);
            label2.Name = "label2";
            label2.Size = new Size(341, 36);
            label2.TabIndex = 20;
            label2.Text = "Choose a book to update from the listBox";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonUpdate.Location = new Point(513, 310);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(69, 33);
            buttonUpdate.TabIndex = 21;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttondELETE
            // 
            buttondELETE.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttondELETE.Location = new Point(513, 400);
            buttondELETE.Name = "buttondELETE";
            buttondELETE.Size = new Size(69, 33);
            buttondELETE.TabIndex = 23;
            buttondELETE.Text = "DELETE";
            buttondELETE.UseVisualStyleBackColor = true;
            buttondELETE.Click += buttondELETE_Click;
            // 
            // labelDelete
            // 
            labelDelete.BorderStyle = BorderStyle.Fixed3D;
            labelDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            labelDelete.Location = new Point(513, 361);
            labelDelete.Name = "labelDelete";
            labelDelete.Size = new Size(341, 36);
            labelDelete.TabIndex = 22;
            labelDelete.Text = "Choose a book to remove from the listBox";
            labelDelete.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonWriteToXmlFile
            // 
            buttonWriteToXmlFile.Location = new Point(2, 453);
            buttonWriteToXmlFile.Name = "buttonWriteToXmlFile";
            buttonWriteToXmlFile.Size = new Size(97, 35);
            buttonWriteToXmlFile.TabIndex = 24;
            buttonWriteToXmlFile.Text = "Write Xml File";
            buttonWriteToXmlFile.UseVisualStyleBackColor = true;
            buttonWriteToXmlFile.Click += buttonWriteToXmlFile_Click;
            // 
            // buttonReadFromXmlFile
            // 
            buttonReadFromXmlFile.Location = new Point(105, 453);
            buttonReadFromXmlFile.Name = "buttonReadFromXmlFile";
            buttonReadFromXmlFile.Size = new Size(101, 35);
            buttonReadFromXmlFile.TabIndex = 25;
            buttonReadFromXmlFile.Text = "Read Xml File";
            buttonReadFromXmlFile.UseVisualStyleBackColor = true;
            buttonReadFromXmlFile.Click += buttonReadFromXmlFile_Click;
            // 
            // comboBoxItemType
            // 
            comboBoxItemType.FormattingEnabled = true;
            comboBoxItemType.Location = new Point(111, 33);
            comboBoxItemType.Name = "comboBoxItemType";
            comboBoxItemType.Size = new Size(135, 23);
            comboBoxItemType.TabIndex = 27;
            comboBoxItemType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.BorderStyle = BorderStyle.Fixed3D;
            labelType.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelType.Location = new Point(12, 33);
            labelType.Name = "labelType";
            labelType.Size = new Size(51, 21);
            labelType.TabIndex = 26;
            labelType.Text = "type? ";
            // 
            // textBoxCapacity
            // 
            textBoxCapacity.Location = new Point(354, 205);
            textBoxCapacity.Name = "textBoxCapacity";
            textBoxCapacity.Size = new Size(100, 23);
            textBoxCapacity.TabIndex = 29;
            textBoxCapacity.TextChanged += textBox1_TextChanged;
            // 
            // labelCapacity
            // 
            labelCapacity.AutoSize = true;
            labelCapacity.BorderStyle = BorderStyle.Fixed3D;
            labelCapacity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelCapacity.Location = new Point(260, 207);
            labelCapacity.Name = "labelCapacity";
            labelCapacity.Size = new Size(81, 21);
            labelCapacity.TabIndex = 28;
            labelCapacity.Text = "capacity ? ";
            // 
            // textBoxPages
            // 
            textBoxPages.Location = new Point(106, 205);
            textBoxPages.Name = "textBoxPages";
            textBoxPages.Size = new Size(100, 23);
            textBoxPages.TabIndex = 31;
            // 
            // labelPages
            // 
            labelPages.AutoSize = true;
            labelPages.BorderStyle = BorderStyle.Fixed3D;
            labelPages.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelPages.Location = new Point(12, 207);
            labelPages.Name = "labelPages";
            labelPages.Size = new Size(65, 21);
            labelPages.TabIndex = 30;
            labelPages.Text = "pages ? ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 516);
            Controls.Add(textBoxPages);
            Controls.Add(labelPages);
            Controls.Add(textBoxCapacity);
            Controls.Add(labelCapacity);
            Controls.Add(comboBoxItemType);
            Controls.Add(labelType);
            Controls.Add(buttonReadFromXmlFile);
            Controls.Add(buttonWriteToXmlFile);
            Controls.Add(buttondELETE);
            Controls.Add(labelDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxDay);
            Controls.Add(textBoxMonth);
            Controls.Add(labelYear);
            Controls.Add(labelDay);
            Controls.Add(labelMonth);
            Controls.Add(labelPublishedDate);
            Controls.Add(comboBoxLanguage);
            Controls.Add(labelLanguage);
            Controls.Add(listBoxLibrary);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(buttonSearch);
            Controls.Add(buttonPrint);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxNumber);
            Controls.Add(labelTitle);
            Controls.Add(labelNumber);
            Name = "Form1";
            Text = "School Library  - Inheritance  - JV4- March 22 - March 25";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNumber;
        private Label labelTitle;
        private TextBox textBoxNumber;
        private TextBox textBoxTitle;
        private Button buttonAdd;
        private Button buttonPrint;
        private Button buttonSearch;
        private Button buttonReset;
        private Button buttonExit;
        private ListBox listBoxLibrary;
        private Label labelLanguage;
        private ComboBox comboBoxLanguage;
        private TextBox textBoxYear;
        private Label labelYear;
        private TextBox textBoxDay;
        private Label labelDay;
        private TextBox textBoxMonth;
        private Label labelMonth;
        private Label labelPublishedDate;
        private Label label1;
        private Label label2;
        private Button buttonUpdate;
        private Button buttondELETE;
        private Label labelDelete;
        private Button buttonWriteToXmlFile;
        private Button buttonReadFromXmlFile;
        private ComboBox comboBoxItemType;
        private Label labelType;
        private TextBox textBoxCapacity;
        private Label labelCapacity;
        private TextBox textBoxPages;
        private Label labelPages;
    }
}
