namespace CounterApp
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
            labelSerial = new Label();
            labelValue = new Label();
            labelColor = new Label();
            labelDate = new Label();
            labelTyoe = new Label();
            comboBoxColor = new ComboBox();
            comboBoxType = new ComboBox();
            textBoxValue = new TextBox();
            textBoxSerial = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxDay = new TextBox();
            textBoxMonth = new TextBox();
            textBoxYear = new TextBox();
            richTextBox = new RichTextBox();
            buttonExit = new Button();
            buttonReset = new Button();
            buttonRemove = new Button();
            buttonUpdate = new Button();
            buttonSearch = new Button();
            buttonPrint = new Button();
            addButton = new Button();
            buttonRead = new Button();
            buttonWrite = new Button();
            textBoxStep = new TextBox();
            textBoxMaxLimit = new TextBox();
            labelMaxLimit = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // labelSerial
            // 
            labelSerial.AutoSize = true;
            labelSerial.Location = new Point(45, 62);
            labelSerial.Name = "labelSerial";
            labelSerial.Size = new Size(46, 20);
            labelSerial.TabIndex = 0;
            labelSerial.Text = "Serial";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(45, 97);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(45, 20);
            labelValue.TabIndex = 1;
            labelValue.Text = "Value";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(46, 128);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(45, 20);
            labelColor.TabIndex = 2;
            labelColor.Text = "Color";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(382, 47);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(41, 20);
            labelDate.TabIndex = 3;
            labelDate.Text = "Date";
            // 
            // labelTyoe
            // 
            labelTyoe.AutoSize = true;
            labelTyoe.Location = new Point(46, 29);
            labelTyoe.Name = "labelTyoe";
            labelTyoe.Size = new Size(40, 20);
            labelTyoe.TabIndex = 4;
            labelTyoe.Text = "Type";
            // 
            // comboBoxColor
            // 
            comboBoxColor.FormattingEnabled = true;
            comboBoxColor.Location = new Point(128, 128);
            comboBoxColor.Name = "comboBoxColor";
            comboBoxColor.Size = new Size(151, 28);
            comboBoxColor.TabIndex = 5;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(128, 21);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(151, 28);
            comboBoxType.TabIndex = 6;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(128, 90);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(151, 27);
            textBoxValue.TabIndex = 7;
            // 
            // textBoxSerial
            // 
            textBoxSerial.Location = new Point(128, 57);
            textBoxSerial.Name = "textBoxSerial";
            textBoxSerial.Size = new Size(151, 27);
            textBoxSerial.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(453, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 9;
            label1.Text = "Day";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 9);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 10;
            label2.Text = "Month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(591, 9);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 11;
            label3.Text = "Year";
            // 
            // textBoxDay
            // 
            textBoxDay.Location = new Point(453, 44);
            textBoxDay.Name = "textBoxDay";
            textBoxDay.Size = new Size(44, 27);
            textBoxDay.TabIndex = 12;
            // 
            // textBoxMonth
            // 
            textBoxMonth.Location = new Point(520, 44);
            textBoxMonth.Name = "textBoxMonth";
            textBoxMonth.Size = new Size(44, 27);
            textBoxMonth.TabIndex = 13;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(591, 44);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(44, 27);
            textBoxYear.TabIndex = 14;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(417, 154);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(292, 284);
            richTextBox.TabIndex = 15;
            richTextBox.Text = "";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(239, 250);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 27;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click_1;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(239, 301);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 26;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click_1;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(60, 355);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(94, 29);
            buttonRemove.TabIndex = 25;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click_1;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(60, 301);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 24;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click_1;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(239, 355);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 23;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click_1;
            // 
            // buttonPrint
            // 
            buttonPrint.Location = new Point(615, 119);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(94, 29);
            buttonPrint.TabIndex = 22;
            buttonPrint.Text = "Print";
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += buttonPrint_Click_1;
            // 
            // addButton
            // 
            addButton.Location = new Point(60, 249);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 21;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click_1;
            // 
            // buttonRead
            // 
            buttonRead.Location = new Point(60, 404);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(94, 29);
            buttonRead.TabIndex = 28;
            buttonRead.Text = "Read XML";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // buttonWrite
            // 
            buttonWrite.Location = new Point(239, 404);
            buttonWrite.Name = "buttonWrite";
            buttonWrite.Size = new Size(94, 29);
            buttonWrite.TabIndex = 29;
            buttonWrite.Text = "Write XML";
            buttonWrite.UseVisualStyleBackColor = true;
            buttonWrite.Click += buttonWrite_Click;
            // 
            // textBoxStep
            // 
            textBoxStep.Location = new Point(102, 183);
            textBoxStep.Name = "textBoxStep";
            textBoxStep.Size = new Size(68, 27);
            textBoxStep.TabIndex = 33;
            // 
            // textBoxMaxLimit
            // 
            textBoxMaxLimit.Location = new Point(274, 183);
            textBoxMaxLimit.Name = "textBoxMaxLimit";
            textBoxMaxLimit.Size = new Size(70, 27);
            textBoxMaxLimit.TabIndex = 32;
            // 
            // labelMaxLimit
            // 
            labelMaxLimit.AutoSize = true;
            labelMaxLimit.Location = new Point(194, 187);
            labelMaxLimit.Name = "labelMaxLimit";
            labelMaxLimit.Size = new Size(74, 20);
            labelMaxLimit.TabIndex = 31;
            labelMaxLimit.Text = "Max Limit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 186);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 30;
            label5.Text = "Step";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxStep);
            Controls.Add(textBoxMaxLimit);
            Controls.Add(labelMaxLimit);
            Controls.Add(label5);
            Controls.Add(buttonWrite);
            Controls.Add(buttonRead);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(buttonRemove);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonSearch);
            Controls.Add(buttonPrint);
            Controls.Add(addButton);
            Controls.Add(richTextBox);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxMonth);
            Controls.Add(textBoxDay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSerial);
            Controls.Add(textBoxValue);
            Controls.Add(comboBoxType);
            Controls.Add(comboBoxColor);
            Controls.Add(labelTyoe);
            Controls.Add(labelDate);
            Controls.Add(labelColor);
            Controls.Add(labelValue);
            Controls.Add(labelSerial);
            Name = "Form1";
            Text = "Lennin Steven, Sabogal Prieto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSerial;
        private Label labelValue;
        private Label labelColor;
        private Label labelDate;
        private Label labelTyoe;
        private ComboBox comboBoxColor;
        private ComboBox comboBoxType;
        private TextBox textBoxValue;
        private TextBox textBoxSerial;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxDay;
        private TextBox textBoxMonth;
        private TextBox textBoxYear;
        private RichTextBox richTextBox;
        private Button buttonExit;
        private Button buttonReset;
        private Button buttonRemove;
        private Button buttonUpdate;
        private Button buttonSearch;
        private Button buttonPrint;
        private Button addButton;
        private Button buttonRead;
        private Button buttonWrite;
        private TextBox textBoxStep;
        private TextBox textBoxMaxLimit;
        private Label labelMaxLimit;
        private Label label5;

    }
}
