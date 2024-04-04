namespace MIdterm
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
            labelCode = new Label();
            labelTitle = new Label();
            labelCategory = new Label();
            labelLanguage = new Label();
            labelDuration = new Label();
            labelActor = new Label();
            CodeBox = new TextBox();
            TitleBox = new TextBox();
            HourBox = new TextBox();
            MinBox = new TextBox();
            ActorBox1 = new TextBox();
            addButton = new Button();
            buttonPrint = new Button();
            buttonSearch = new Button();
            ActorBox2 = new TextBox();
            buttonUpdate = new Button();
            buttonRemove = new Button();
            buttonReset = new Button();
            buttonExit = new Button();
            PrintBox = new RichTextBox();
            comboBoxLang = new ComboBox();
            comboBoxCat = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.ImageAlign = ContentAlignment.BottomRight;
            labelCode.Location = new Point(29, 29);
            labelCode.Margin = new Padding(3, 0, 3, 10);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(44, 20);
            labelCode.TabIndex = 0;
            labelCode.Text = "Code";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.ImageAlign = ContentAlignment.BottomRight;
            labelTitle.Location = new Point(29, 59);
            labelTitle.Margin = new Padding(3, 0, 3, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(38, 20);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Title";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.ImageAlign = ContentAlignment.BottomRight;
            labelCategory.Location = new Point(29, 89);
            labelCategory.Margin = new Padding(3, 0, 3, 10);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(69, 20);
            labelCategory.TabIndex = 2;
            labelCategory.Text = "Category";
            // 
            // labelLanguage
            // 
            labelLanguage.AutoSize = true;
            labelLanguage.ImageAlign = ContentAlignment.BottomRight;
            labelLanguage.Location = new Point(29, 119);
            labelLanguage.Margin = new Padding(3, 0, 3, 10);
            labelLanguage.Name = "labelLanguage";
            labelLanguage.Size = new Size(74, 20);
            labelLanguage.TabIndex = 3;
            labelLanguage.Text = "Language";
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.ImageAlign = ContentAlignment.BottomRight;
            labelDuration.Location = new Point(29, 149);
            labelDuration.Margin = new Padding(3, 0, 3, 10);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(67, 20);
            labelDuration.TabIndex = 4;
            labelDuration.Text = "Duration";
            // 
            // labelActor
            // 
            labelActor.AutoSize = true;
            labelActor.ImageAlign = ContentAlignment.BottomRight;
            labelActor.Location = new Point(29, 179);
            labelActor.Margin = new Padding(3, 0, 3, 10);
            labelActor.Name = "labelActor";
            labelActor.Size = new Size(45, 20);
            labelActor.TabIndex = 5;
            labelActor.Text = "Actor";
            // 
            // CodeBox
            // 
            CodeBox.Location = new Point(142, 22);
            CodeBox.Name = "CodeBox";
            CodeBox.Size = new Size(149, 27);
            CodeBox.TabIndex = 6;
            CodeBox.TextChanged += CodeBox_TextChanged;
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(142, 52);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(149, 27);
            TitleBox.TabIndex = 7;
            // 
            // HourBox
            // 
            HourBox.Location = new Point(142, 142);
            HourBox.Name = "HourBox";
            HourBox.Size = new Size(81, 27);
            HourBox.TabIndex = 10;
            // 
            // MinBox
            // 
            MinBox.Location = new Point(229, 142);
            MinBox.Name = "MinBox";
            MinBox.Size = new Size(61, 27);
            MinBox.TabIndex = 11;
            // 
            // ActorBox1
            // 
            ActorBox1.Location = new Point(142, 172);
            ActorBox1.Name = "ActorBox1";
            ActorBox1.Size = new Size(81, 27);
            ActorBox1.TabIndex = 12;
            // 
            // addButton
            // 
            addButton.Location = new Point(29, 237);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 13;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // buttonPrint
            // 
            buttonPrint.Location = new Point(208, 237);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(94, 29);
            buttonPrint.TabIndex = 14;
            buttonPrint.Text = "Print";
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(208, 343);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 15;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // ActorBox2
            // 
            ActorBox2.Location = new Point(229, 172);
            ActorBox2.Name = "ActorBox2";
            ActorBox2.Size = new Size(73, 27);
            ActorBox2.TabIndex = 16;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(29, 289);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 17;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(29, 343);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(94, 29);
            buttonRemove.TabIndex = 18;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(208, 289);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 19;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(118, 395);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 20;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // PrintBox
            // 
            PrintBox.Location = new Point(427, 13);
            PrintBox.Name = "PrintBox";
            PrintBox.Size = new Size(222, 359);
            PrintBox.TabIndex = 21;
            PrintBox.Text = "";
            // 
            // comboBoxLang
            // 
            comboBoxLang.FormattingEnabled = true;
            comboBoxLang.Location = new Point(142, 111);
            comboBoxLang.Name = "comboBoxLang";
            comboBoxLang.Size = new Size(149, 28);
            comboBoxLang.TabIndex = 22;
            // 
            // comboBoxCat
            // 
            comboBoxCat.FormattingEnabled = true;
            comboBoxCat.Location = new Point(141, 81);
            comboBoxCat.Name = "comboBoxCat";
            comboBoxCat.Size = new Size(149, 28);
            comboBoxCat.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(439, 398);
            label1.Name = "label1";
            label1.Size = new Size(187, 20);
            label1.TabIndex = 24;
            label1.Text = "Lennin Sabogal 202330544";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(comboBoxCat);
            Controls.Add(comboBoxLang);
            Controls.Add(PrintBox);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(buttonRemove);
            Controls.Add(buttonUpdate);
            Controls.Add(ActorBox2);
            Controls.Add(buttonSearch);
            Controls.Add(buttonPrint);
            Controls.Add(addButton);
            Controls.Add(ActorBox1);
            Controls.Add(MinBox);
            Controls.Add(HourBox);
            Controls.Add(TitleBox);
            Controls.Add(CodeBox);
            Controls.Add(labelActor);
            Controls.Add(labelDuration);
            Controls.Add(labelLanguage);
            Controls.Add(labelCategory);
            Controls.Add(labelTitle);
            Controls.Add(labelCode);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCode;
        private Label labelTitle;
        private Label labelCategory;
        private Label labelLanguage;
        private Label labelDuration;
        private Label labelActor;
        private TextBox CodeBox;
        private TextBox TitleBox;
        private TextBox HourBox;
        private TextBox MinBox;
        private TextBox ActorBox1;
        private Button addButton;
        private Button buttonPrint;
        private Button buttonSearch;
        private TextBox ActorBox2;
        private Button buttonUpdate;
        private Button buttonRemove;
        private Button buttonReset;
        private Button buttonExit;
        private RichTextBox PrintBox;
        private ComboBox comboBoxLang;
        private ComboBox comboBoxCat;
        private Label label1;
    }
}
