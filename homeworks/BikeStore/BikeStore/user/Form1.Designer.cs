namespace MyBikes
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
            groupBoxBikeInfo = new GroupBox();
            labelFrameType = new Label();
            comboBoxFrameType = new ComboBox();
            labelWheelSize = new Label();
            textBoxWheelSize = new TextBox();
            labelColor = new Label();
            labelSpeed = new Label();
            textBoxSpeed = new TextBox();
            labelModel = new Label();
            textBoxModel = new TextBox();
            labelBikeType = new Label();
            labelSerialNumber = new Label();
            labelMade = new Label();
            comboBoxBikeType = new ComboBox();
            comboBoxColor = new ComboBox();
            textBoxSerialNumber = new TextBox();
            textBoxMade = new TextBox();
            groupMountainBike = new GroupBox();
            comboBoxSuspension = new ComboBox();
            labelSuspension = new Label();
            labelHeightFromGround = new Label();
            textBoxHeightFromGround = new TextBox();
            labelSeatHight = new Label();
            textBoxSeatHeight = new TextBox();
            groupBoxMadeDate = new GroupBox();
            labelMonth = new Label();
            labelDay = new Label();
            labelYear = new Label();
            textBoxMonth = new TextBox();
            textBoxDay = new TextBox();
            textBoxYear = new TextBox();
            groupBox1 = new GroupBox();
            buttonWriteToXmlFile = new Button();
            buttonReadFromXmlFile = new Button();
            listBoxBikes = new ListBox();
            buttonPrintMountainBike = new Button();
            buttonPrintRoadBike = new Button();
            buttonReset = new Button();
            buttonPrintBike = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            labelDelete = new Label();
            buttonExit = new Button();
            groupBox3 = new GroupBox();
            buttonPrintHybridBike = new Button();
            buttonPrintElectricBike = new Button();
            groupBoxRoadBike = new GroupBox();
            groupBoxElectricBike = new GroupBox();
            textBoxBatteryIndicator = new TextBox();
            labelBatteryIndicator = new Label();
            groupBoxHybridBike = new GroupBox();
            comboBoxHybridType = new ComboBox();
            labelHybridType = new Label();
            buttonUpdate = new Button();
            labelUpdate = new Label();
            labelSearch = new Label();
            buttonSearch = new Button();
            groupBoxBikeInfo.SuspendLayout();
            groupMountainBike.SuspendLayout();
            groupBoxMadeDate.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBoxRoadBike.SuspendLayout();
            groupBoxElectricBike.SuspendLayout();
            groupBoxHybridBike.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxBikeInfo
            // 
            groupBoxBikeInfo.Controls.Add(labelFrameType);
            groupBoxBikeInfo.Controls.Add(comboBoxFrameType);
            groupBoxBikeInfo.Controls.Add(labelWheelSize);
            groupBoxBikeInfo.Controls.Add(textBoxWheelSize);
            groupBoxBikeInfo.Controls.Add(labelColor);
            groupBoxBikeInfo.Controls.Add(labelSpeed);
            groupBoxBikeInfo.Controls.Add(textBoxSpeed);
            groupBoxBikeInfo.Controls.Add(labelModel);
            groupBoxBikeInfo.Controls.Add(textBoxModel);
            groupBoxBikeInfo.Controls.Add(labelBikeType);
            groupBoxBikeInfo.Controls.Add(labelSerialNumber);
            groupBoxBikeInfo.Controls.Add(labelMade);
            groupBoxBikeInfo.Controls.Add(comboBoxBikeType);
            groupBoxBikeInfo.Controls.Add(comboBoxColor);
            groupBoxBikeInfo.Controls.Add(textBoxSerialNumber);
            groupBoxBikeInfo.Controls.Add(textBoxMade);
            groupBoxBikeInfo.Location = new Point(25, 23);
            groupBoxBikeInfo.Margin = new Padding(2);
            groupBoxBikeInfo.Name = "groupBoxBikeInfo";
            groupBoxBikeInfo.Padding = new Padding(2);
            groupBoxBikeInfo.Size = new Size(332, 320);
            groupBoxBikeInfo.TabIndex = 54;
            groupBoxBikeInfo.TabStop = false;
            groupBoxBikeInfo.Text = "Bike Info";
            // 
            // labelFrameType
            // 
            labelFrameType.BackColor = Color.FromArgb(192, 192, 255);
            labelFrameType.BorderStyle = BorderStyle.Fixed3D;
            labelFrameType.Cursor = Cursors.No;
            labelFrameType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelFrameType.ForeColor = Color.Black;
            labelFrameType.Location = new Point(17, 237);
            labelFrameType.Margin = new Padding(2, 0, 2, 0);
            labelFrameType.Name = "labelFrameType";
            labelFrameType.Size = new Size(141, 35);
            labelFrameType.TabIndex = 16;
            labelFrameType.Text = "Frame Type?";
            labelFrameType.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBoxFrameType
            // 
            comboBoxFrameType.FormattingEnabled = true;
            comboBoxFrameType.Location = new Point(172, 239);
            comboBoxFrameType.Margin = new Padding(2);
            comboBoxFrameType.Name = "comboBoxFrameType";
            comboBoxFrameType.Size = new Size(143, 28);
            comboBoxFrameType.TabIndex = 15;
            // 
            // labelWheelSize
            // 
            labelWheelSize.BackColor = Color.FromArgb(192, 192, 255);
            labelWheelSize.BorderStyle = BorderStyle.Fixed3D;
            labelWheelSize.Cursor = Cursors.No;
            labelWheelSize.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelWheelSize.ForeColor = Color.Black;
            labelWheelSize.Location = new Point(17, 205);
            labelWheelSize.Margin = new Padding(2, 0, 2, 0);
            labelWheelSize.Name = "labelWheelSize";
            labelWheelSize.Size = new Size(141, 35);
            labelWheelSize.TabIndex = 13;
            labelWheelSize.Text = "Wheel Size?";
            labelWheelSize.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxWheelSize
            // 
            textBoxWheelSize.Location = new Point(172, 207);
            textBoxWheelSize.Margin = new Padding(2);
            textBoxWheelSize.Name = "textBoxWheelSize";
            textBoxWheelSize.Size = new Size(143, 27);
            textBoxWheelSize.TabIndex = 14;
            // 
            // labelColor
            // 
            labelColor.BackColor = Color.FromArgb(192, 192, 255);
            labelColor.BorderStyle = BorderStyle.Fixed3D;
            labelColor.Cursor = Cursors.No;
            labelColor.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelColor.ForeColor = Color.Black;
            labelColor.Location = new Point(17, 272);
            labelColor.Margin = new Padding(2, 0, 2, 0);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(141, 35);
            labelColor.TabIndex = 12;
            labelColor.Text = "Color?";
            labelColor.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelSpeed
            // 
            labelSpeed.BackColor = Color.FromArgb(192, 192, 255);
            labelSpeed.BorderStyle = BorderStyle.Fixed3D;
            labelSpeed.Cursor = Cursors.No;
            labelSpeed.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelSpeed.ForeColor = Color.Black;
            labelSpeed.Location = new Point(17, 171);
            labelSpeed.Margin = new Padding(2, 0, 2, 0);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(141, 35);
            labelSpeed.TabIndex = 10;
            labelSpeed.Text = "Speed?";
            labelSpeed.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxSpeed
            // 
            textBoxSpeed.Location = new Point(172, 173);
            textBoxSpeed.Margin = new Padding(2);
            textBoxSpeed.Name = "textBoxSpeed";
            textBoxSpeed.Size = new Size(143, 27);
            textBoxSpeed.TabIndex = 11;
            // 
            // labelModel
            // 
            labelModel.BackColor = Color.FromArgb(192, 192, 255);
            labelModel.BorderStyle = BorderStyle.Fixed3D;
            labelModel.Cursor = Cursors.No;
            labelModel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelModel.ForeColor = Color.Black;
            labelModel.Location = new Point(17, 136);
            labelModel.Margin = new Padding(2, 0, 2, 0);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(141, 35);
            labelModel.TabIndex = 8;
            labelModel.Text = "Model?";
            labelModel.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(173, 140);
            textBoxModel.Margin = new Padding(2);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(143, 27);
            textBoxModel.TabIndex = 9;
            // 
            // labelBikeType
            // 
            labelBikeType.BackColor = Color.FromArgb(192, 192, 255);
            labelBikeType.BorderStyle = BorderStyle.Fixed3D;
            labelBikeType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelBikeType.ForeColor = Color.Black;
            labelBikeType.Location = new Point(17, 32);
            labelBikeType.Margin = new Padding(2, 0, 2, 0);
            labelBikeType.Name = "labelBikeType";
            labelBikeType.Size = new Size(141, 35);
            labelBikeType.TabIndex = 0;
            labelBikeType.Text = "Bike Type?";
            labelBikeType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSerialNumber
            // 
            labelSerialNumber.BackColor = Color.FromArgb(192, 192, 255);
            labelSerialNumber.BorderStyle = BorderStyle.Fixed3D;
            labelSerialNumber.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelSerialNumber.ForeColor = Color.Black;
            labelSerialNumber.Location = new Point(17, 67);
            labelSerialNumber.Margin = new Padding(2, 0, 2, 0);
            labelSerialNumber.Name = "labelSerialNumber";
            labelSerialNumber.Size = new Size(141, 35);
            labelSerialNumber.TabIndex = 1;
            labelSerialNumber.Text = "Serial Number?";
            labelSerialNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMade
            // 
            labelMade.BackColor = Color.FromArgb(192, 192, 255);
            labelMade.BorderStyle = BorderStyle.Fixed3D;
            labelMade.Cursor = Cursors.No;
            labelMade.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelMade.ForeColor = Color.Black;
            labelMade.Location = new Point(17, 101);
            labelMade.Margin = new Padding(2, 0, 2, 0);
            labelMade.Name = "labelMade";
            labelMade.Size = new Size(141, 35);
            labelMade.TabIndex = 2;
            labelMade.Text = "Made?";
            labelMade.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBoxBikeType
            // 
            comboBoxBikeType.FormattingEnabled = true;
            comboBoxBikeType.Location = new Point(173, 39);
            comboBoxBikeType.Margin = new Padding(2);
            comboBoxBikeType.Name = "comboBoxBikeType";
            comboBoxBikeType.Size = new Size(143, 28);
            comboBoxBikeType.TabIndex = 4;
            comboBoxBikeType.SelectedIndexChanged += comboBoxBikeType_SelectedIndexChanged;
            // 
            // comboBoxColor
            // 
            comboBoxColor.FormattingEnabled = true;
            comboBoxColor.Location = new Point(172, 274);
            comboBoxColor.Margin = new Padding(2);
            comboBoxColor.Name = "comboBoxColor";
            comboBoxColor.Size = new Size(143, 28);
            comboBoxColor.TabIndex = 5;
            // 
            // textBoxSerialNumber
            // 
            textBoxSerialNumber.Location = new Point(173, 73);
            textBoxSerialNumber.Margin = new Padding(2);
            textBoxSerialNumber.Name = "textBoxSerialNumber";
            textBoxSerialNumber.Size = new Size(143, 27);
            textBoxSerialNumber.TabIndex = 6;
            // 
            // textBoxMade
            // 
            textBoxMade.Location = new Point(173, 105);
            textBoxMade.Margin = new Padding(2);
            textBoxMade.Name = "textBoxMade";
            textBoxMade.Size = new Size(143, 27);
            textBoxMade.TabIndex = 7;
            // 
            // groupMountainBike
            // 
            groupMountainBike.Controls.Add(comboBoxSuspension);
            groupMountainBike.Controls.Add(labelSuspension);
            groupMountainBike.Controls.Add(labelHeightFromGround);
            groupMountainBike.Controls.Add(textBoxHeightFromGround);
            groupMountainBike.Location = new Point(418, 174);
            groupMountainBike.Margin = new Padding(2);
            groupMountainBike.Name = "groupMountainBike";
            groupMountainBike.Padding = new Padding(2);
            groupMountainBike.Size = new Size(385, 103);
            groupMountainBike.TabIndex = 53;
            groupMountainBike.TabStop = false;
            groupMountainBike.Text = "Mountain Bike Features";
            // 
            // comboBoxSuspension
            // 
            comboBoxSuspension.FormattingEnabled = true;
            comboBoxSuspension.Location = new Point(235, 28);
            comboBoxSuspension.Margin = new Padding(2);
            comboBoxSuspension.Name = "comboBoxSuspension";
            comboBoxSuspension.Size = new Size(131, 28);
            comboBoxSuspension.TabIndex = 13;
            // 
            // labelSuspension
            // 
            labelSuspension.BackColor = Color.FromArgb(192, 192, 255);
            labelSuspension.BorderStyle = BorderStyle.Fixed3D;
            labelSuspension.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelSuspension.ForeColor = Color.Black;
            labelSuspension.Location = new Point(10, 26);
            labelSuspension.Margin = new Padding(2, 0, 2, 0);
            labelSuspension.Name = "labelSuspension";
            labelSuspension.Size = new Size(131, 29);
            labelSuspension.TabIndex = 32;
            labelSuspension.Text = "Suspension?";
            labelSuspension.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHeightFromGround
            // 
            labelHeightFromGround.BackColor = Color.FromArgb(192, 192, 255);
            labelHeightFromGround.BorderStyle = BorderStyle.Fixed3D;
            labelHeightFromGround.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelHeightFromGround.ForeColor = Color.Black;
            labelHeightFromGround.Location = new Point(10, 57);
            labelHeightFromGround.Margin = new Padding(2, 0, 2, 0);
            labelHeightFromGround.Name = "labelHeightFromGround";
            labelHeightFromGround.Size = new Size(210, 29);
            labelHeightFromGround.TabIndex = 8;
            labelHeightFromGround.Text = "Height From Ground?";
            labelHeightFromGround.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxHeightFromGround
            // 
            textBoxHeightFromGround.Location = new Point(235, 61);
            textBoxHeightFromGround.Margin = new Padding(2);
            textBoxHeightFromGround.Name = "textBoxHeightFromGround";
            textBoxHeightFromGround.Size = new Size(131, 27);
            textBoxHeightFromGround.TabIndex = 10;
            // 
            // labelSeatHight
            // 
            labelSeatHight.BackColor = Color.FromArgb(192, 192, 255);
            labelSeatHight.BorderStyle = BorderStyle.Fixed3D;
            labelSeatHight.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelSeatHight.ForeColor = Color.Black;
            labelSeatHight.Location = new Point(10, 27);
            labelSeatHight.Margin = new Padding(2, 0, 2, 0);
            labelSeatHight.Name = "labelSeatHight";
            labelSeatHight.Size = new Size(166, 31);
            labelSeatHight.TabIndex = 9;
            labelSeatHight.Text = "Seat Height?";
            labelSeatHight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxSeatHeight
            // 
            textBoxSeatHeight.Location = new Point(191, 31);
            textBoxSeatHeight.Margin = new Padding(2);
            textBoxSeatHeight.Name = "textBoxSeatHeight";
            textBoxSeatHeight.Size = new Size(131, 27);
            textBoxSeatHeight.TabIndex = 31;
            // 
            // groupBoxMadeDate
            // 
            groupBoxMadeDate.Controls.Add(labelMonth);
            groupBoxMadeDate.Controls.Add(labelDay);
            groupBoxMadeDate.Controls.Add(labelYear);
            groupBoxMadeDate.Controls.Add(textBoxMonth);
            groupBoxMadeDate.Controls.Add(textBoxDay);
            groupBoxMadeDate.Controls.Add(textBoxYear);
            groupBoxMadeDate.Location = new Point(418, 374);
            groupBoxMadeDate.Margin = new Padding(2);
            groupBoxMadeDate.Name = "groupBoxMadeDate";
            groupBoxMadeDate.Padding = new Padding(2);
            groupBoxMadeDate.Size = new Size(481, 117);
            groupBoxMadeDate.TabIndex = 52;
            groupBoxMadeDate.TabStop = false;
            groupBoxMadeDate.Text = "Made Date";
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.BackColor = Color.FromArgb(192, 192, 255);
            labelMonth.BorderStyle = BorderStyle.Fixed3D;
            labelMonth.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelMonth.ForeColor = Color.Black;
            labelMonth.Location = new Point(209, 35);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(65, 22);
            labelMonth.TabIndex = 19;
            labelMonth.Text = "Month?";
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.BackColor = Color.FromArgb(192, 192, 255);
            labelDay.BorderStyle = BorderStyle.Fixed3D;
            labelDay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelDay.ForeColor = Color.Black;
            labelDay.Location = new Point(15, 37);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(49, 22);
            labelDay.TabIndex = 20;
            labelDay.Text = "Day? ";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.BackColor = Color.FromArgb(192, 192, 255);
            labelYear.BorderStyle = BorderStyle.Fixed3D;
            labelYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelYear.ForeColor = Color.Black;
            labelYear.Location = new Point(15, 77);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(52, 22);
            labelYear.TabIndex = 21;
            labelYear.Text = "Year? ";
            labelYear.Click += labelYear_Click;
            // 
            // textBoxMonth
            // 
            textBoxMonth.Location = new Point(279, 35);
            textBoxMonth.Margin = new Padding(3, 4, 3, 4);
            textBoxMonth.Name = "textBoxMonth";
            textBoxMonth.Size = new Size(121, 27);
            textBoxMonth.TabIndex = 22;
            // 
            // textBoxDay
            // 
            textBoxDay.Location = new Point(69, 35);
            textBoxDay.Margin = new Padding(3, 4, 3, 4);
            textBoxDay.Name = "textBoxDay";
            textBoxDay.Size = new Size(121, 27);
            textBoxDay.TabIndex = 23;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(72, 78);
            textBoxYear.Margin = new Padding(3, 4, 3, 4);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(121, 27);
            textBoxYear.TabIndex = 24;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonWriteToXmlFile);
            groupBox1.Controls.Add(buttonReadFromXmlFile);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(11, 751);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(319, 85);
            groupBox1.TabIndex = 61;
            groupBox1.TabStop = false;
            groupBox1.Text = "Serialize/Deserialize XMI File";
            // 
            // buttonWriteToXmlFile
            // 
            buttonWriteToXmlFile.BackColor = Color.DimGray;
            buttonWriteToXmlFile.FlatAppearance.BorderColor = Color.Black;
            buttonWriteToXmlFile.FlatAppearance.BorderSize = 0;
            buttonWriteToXmlFile.ForeColor = Color.Transparent;
            buttonWriteToXmlFile.Location = new Point(29, 25);
            buttonWriteToXmlFile.Margin = new Padding(3, 4, 3, 4);
            buttonWriteToXmlFile.Name = "buttonWriteToXmlFile";
            buttonWriteToXmlFile.Size = new Size(121, 47);
            buttonWriteToXmlFile.TabIndex = 39;
            buttonWriteToXmlFile.Text = "Write Xml File";
            buttonWriteToXmlFile.UseVisualStyleBackColor = false;
            buttonWriteToXmlFile.Click += buttonWriteToXmlFile_Click;
            // 
            // buttonReadFromXmlFile
            // 
            buttonReadFromXmlFile.BackColor = Color.DimGray;
            buttonReadFromXmlFile.FlatAppearance.BorderColor = Color.Black;
            buttonReadFromXmlFile.FlatAppearance.BorderSize = 0;
            buttonReadFromXmlFile.ForeColor = Color.Transparent;
            buttonReadFromXmlFile.Location = new Point(157, 25);
            buttonReadFromXmlFile.Margin = new Padding(3, 4, 3, 4);
            buttonReadFromXmlFile.Name = "buttonReadFromXmlFile";
            buttonReadFromXmlFile.Size = new Size(137, 47);
            buttonReadFromXmlFile.TabIndex = 40;
            buttonReadFromXmlFile.Text = "Read Xml File";
            buttonReadFromXmlFile.UseVisualStyleBackColor = false;
            buttonReadFromXmlFile.Click += buttonReadFromXmlFile_Click;
            // 
            // listBoxBikes
            // 
            listBoxBikes.BackColor = Color.White;
            listBoxBikes.Font = new Font("Segoe UI", 10F);
            listBoxBikes.ForeColor = Color.Black;
            listBoxBikes.FormattingEnabled = true;
            listBoxBikes.ItemHeight = 23;
            listBoxBikes.Location = new Point(10, 619);
            listBoxBikes.Margin = new Padding(3, 4, 3, 4);
            listBoxBikes.Name = "listBoxBikes";
            listBoxBikes.Size = new Size(1328, 73);
            listBoxBikes.TabIndex = 60;
            listBoxBikes.SelectedIndexChanged += listBoxBikes_SelectedIndexChanged;
            // 
            // buttonPrintMountainBike
            // 
            buttonPrintMountainBike.BackColor = Color.FromArgb(128, 128, 255);
            buttonPrintMountainBike.FlatAppearance.BorderColor = Color.Black;
            buttonPrintMountainBike.FlatAppearance.BorderSize = 0;
            buttonPrintMountainBike.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            buttonPrintMountainBike.ForeColor = Color.Transparent;
            buttonPrintMountainBike.Location = new Point(211, 26);
            buttonPrintMountainBike.Margin = new Padding(3, 4, 3, 4);
            buttonPrintMountainBike.Name = "buttonPrintMountainBike";
            buttonPrintMountainBike.Size = new Size(120, 63);
            buttonPrintMountainBike.TabIndex = 59;
            buttonPrintMountainBike.Text = "PRINT Mountain Bike";
            buttonPrintMountainBike.UseVisualStyleBackColor = false;
            buttonPrintMountainBike.Click += buttonPrintMountainBike_Click;
            // 
            // buttonPrintRoadBike
            // 
            buttonPrintRoadBike.BackColor = Color.FromArgb(128, 128, 255);
            buttonPrintRoadBike.FlatAppearance.BorderColor = Color.Black;
            buttonPrintRoadBike.FlatAppearance.BorderSize = 0;
            buttonPrintRoadBike.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPrintRoadBike.ForeColor = Color.Transparent;
            buttonPrintRoadBike.Location = new Point(103, 26);
            buttonPrintRoadBike.Margin = new Padding(3, 4, 3, 4);
            buttonPrintRoadBike.Name = "buttonPrintRoadBike";
            buttonPrintRoadBike.Size = new Size(101, 63);
            buttonPrintRoadBike.TabIndex = 58;
            buttonPrintRoadBike.Text = "PRINT Road Bike";
            buttonPrintRoadBike.UseVisualStyleBackColor = false;
            buttonPrintRoadBike.Click += buttonPrintRoadBike_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.DimGray;
            buttonReset.FlatAppearance.BorderColor = Color.Black;
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonReset.ForeColor = Color.Transparent;
            buttonReset.Location = new Point(1117, 751);
            buttonReset.Margin = new Padding(3, 4, 3, 4);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(79, 47);
            buttonReset.TabIndex = 57;
            buttonReset.Text = "RESET";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonPrintBike
            // 
            buttonPrintBike.BackColor = Color.FromArgb(128, 128, 255);
            buttonPrintBike.FlatAppearance.BorderColor = Color.Black;
            buttonPrintBike.FlatAppearance.BorderSize = 0;
            buttonPrintBike.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPrintBike.ForeColor = Color.Transparent;
            buttonPrintBike.Location = new Point(28, 26);
            buttonPrintBike.Margin = new Padding(3, 4, 3, 4);
            buttonPrintBike.Name = "buttonPrintBike";
            buttonPrintBike.Size = new Size(69, 61);
            buttonPrintBike.TabIndex = 56;
            buttonPrintBike.Text = "PRINT Bike";
            buttonPrintBike.UseVisualStyleBackColor = false;
            buttonPrintBike.Click += buttonPrintBikes_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(128, 128, 255);
            buttonAdd.FlatAppearance.BorderColor = Color.Black;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.Transparent;
            buttonAdd.Location = new Point(9, 564);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(79, 47);
            buttonAdd.TabIndex = 55;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.DimGray;
            buttonDelete.FlatAppearance.BorderColor = Color.Black;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.Transparent;
            buttonDelete.Location = new Point(1217, 747);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(79, 44);
            buttonDelete.TabIndex = 67;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelDelete
            // 
            labelDelete.BackColor = Color.Transparent;
            labelDelete.BorderStyle = BorderStyle.Fixed3D;
            labelDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            labelDelete.ForeColor = Color.Black;
            labelDelete.Location = new Point(1217, 706);
            labelDelete.Name = "labelDelete";
            labelDelete.Size = new Size(355, 37);
            labelDelete.TabIndex = 66;
            labelDelete.Text = "Choose a bike to remove from the listBox";
            labelDelete.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.DimGray;
            buttonExit.FlatAppearance.BorderColor = Color.Black;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonExit.ForeColor = Color.Transparent;
            buttonExit.Location = new Point(1494, 773);
            buttonExit.Margin = new Padding(3, 4, 3, 4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(79, 68);
            buttonExit.TabIndex = 68;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonPrintHybridBike);
            groupBox3.Controls.Add(buttonPrintElectricBike);
            groupBox3.Controls.Add(buttonPrintMountainBike);
            groupBox3.Controls.Add(buttonPrintBike);
            groupBox3.Controls.Add(buttonPrintRoadBike);
            groupBox3.Location = new Point(416, 505);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(582, 95);
            groupBox3.TabIndex = 69;
            groupBox3.TabStop = false;
            groupBox3.Text = "Printing Bikes";
            // 
            // buttonPrintHybridBike
            // 
            buttonPrintHybridBike.BackColor = Color.FromArgb(128, 128, 255);
            buttonPrintHybridBike.FlatAppearance.BorderColor = Color.Black;
            buttonPrintHybridBike.FlatAppearance.BorderSize = 0;
            buttonPrintHybridBike.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            buttonPrintHybridBike.ForeColor = Color.Transparent;
            buttonPrintHybridBike.Location = new Point(444, 26);
            buttonPrintHybridBike.Margin = new Padding(3, 4, 3, 4);
            buttonPrintHybridBike.Name = "buttonPrintHybridBike";
            buttonPrintHybridBike.Size = new Size(120, 63);
            buttonPrintHybridBike.TabIndex = 61;
            buttonPrintHybridBike.Text = "PRINT Hybrid Bike";
            buttonPrintHybridBike.UseVisualStyleBackColor = false;
            buttonPrintHybridBike.Click += buttonPrintHybridBike_Click;
            // 
            // buttonPrintElectricBike
            // 
            buttonPrintElectricBike.BackColor = Color.FromArgb(128, 128, 255);
            buttonPrintElectricBike.FlatAppearance.BorderColor = Color.Black;
            buttonPrintElectricBike.FlatAppearance.BorderSize = 0;
            buttonPrintElectricBike.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPrintElectricBike.ForeColor = Color.Transparent;
            buttonPrintElectricBike.Location = new Point(337, 26);
            buttonPrintElectricBike.Margin = new Padding(3, 4, 3, 4);
            buttonPrintElectricBike.Name = "buttonPrintElectricBike";
            buttonPrintElectricBike.Size = new Size(101, 63);
            buttonPrintElectricBike.TabIndex = 60;
            buttonPrintElectricBike.Text = "PRINT Electric Bike";
            buttonPrintElectricBike.UseVisualStyleBackColor = false;
            buttonPrintElectricBike.Click += buttonPrintElectricBike_Click;
            // 
            // groupBoxRoadBike
            // 
            groupBoxRoadBike.Controls.Add(textBoxSeatHeight);
            groupBoxRoadBike.Controls.Add(labelSeatHight);
            groupBoxRoadBike.Location = new Point(418, 103);
            groupBoxRoadBike.Margin = new Padding(2);
            groupBoxRoadBike.Name = "groupBoxRoadBike";
            groupBoxRoadBike.Padding = new Padding(2);
            groupBoxRoadBike.Size = new Size(338, 67);
            groupBoxRoadBike.TabIndex = 33;
            groupBoxRoadBike.TabStop = false;
            groupBoxRoadBike.Text = "Road Bike Feature";
            // 
            // groupBoxElectricBike
            // 
            groupBoxElectricBike.Controls.Add(textBoxBatteryIndicator);
            groupBoxElectricBike.Controls.Add(labelBatteryIndicator);
            groupBoxElectricBike.Location = new Point(418, 281);
            groupBoxElectricBike.Margin = new Padding(2);
            groupBoxElectricBike.Name = "groupBoxElectricBike";
            groupBoxElectricBike.Padding = new Padding(2);
            groupBoxElectricBike.Size = new Size(338, 67);
            groupBoxElectricBike.TabIndex = 34;
            groupBoxElectricBike.TabStop = false;
            groupBoxElectricBike.Text = "Electric Bike Feature";
            // 
            // textBoxBatteryIndicator
            // 
            textBoxBatteryIndicator.Location = new Point(191, 31);
            textBoxBatteryIndicator.Margin = new Padding(2);
            textBoxBatteryIndicator.Name = "textBoxBatteryIndicator";
            textBoxBatteryIndicator.Size = new Size(131, 27);
            textBoxBatteryIndicator.TabIndex = 31;
            // 
            // labelBatteryIndicator
            // 
            labelBatteryIndicator.BackColor = Color.FromArgb(192, 192, 255);
            labelBatteryIndicator.BorderStyle = BorderStyle.Fixed3D;
            labelBatteryIndicator.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelBatteryIndicator.ForeColor = Color.Black;
            labelBatteryIndicator.Location = new Point(10, 24);
            labelBatteryIndicator.Margin = new Padding(2, 0, 2, 0);
            labelBatteryIndicator.Name = "labelBatteryIndicator";
            labelBatteryIndicator.Size = new Size(166, 31);
            labelBatteryIndicator.TabIndex = 9;
            labelBatteryIndicator.Text = "Battery Indicator?";
            labelBatteryIndicator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxHybridBike
            // 
            groupBoxHybridBike.Controls.Add(comboBoxHybridType);
            groupBoxHybridBike.Controls.Add(labelHybridType);
            groupBoxHybridBike.Location = new Point(418, 32);
            groupBoxHybridBike.Margin = new Padding(2);
            groupBoxHybridBike.Name = "groupBoxHybridBike";
            groupBoxHybridBike.Padding = new Padding(2);
            groupBoxHybridBike.Size = new Size(338, 67);
            groupBoxHybridBike.TabIndex = 35;
            groupBoxHybridBike.TabStop = false;
            groupBoxHybridBike.Text = "Hybrid Bike Feature";
            // 
            // comboBoxHybridType
            // 
            comboBoxHybridType.FormattingEnabled = true;
            comboBoxHybridType.Location = new Point(191, 29);
            comboBoxHybridType.Margin = new Padding(2);
            comboBoxHybridType.Name = "comboBoxHybridType";
            comboBoxHybridType.Size = new Size(131, 28);
            comboBoxHybridType.TabIndex = 33;
            // 
            // labelHybridType
            // 
            labelHybridType.BackColor = Color.FromArgb(192, 192, 255);
            labelHybridType.BorderStyle = BorderStyle.Fixed3D;
            labelHybridType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelHybridType.ForeColor = Color.Black;
            labelHybridType.Location = new Point(10, 24);
            labelHybridType.Margin = new Padding(2, 0, 2, 0);
            labelHybridType.Name = "labelHybridType";
            labelHybridType.Size = new Size(166, 31);
            labelHybridType.TabIndex = 9;
            labelHybridType.Text = "Type?";
            labelHybridType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(128, 128, 255);
            buttonUpdate.FlatAppearance.BorderColor = Color.Black;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.Transparent;
            buttonUpdate.Location = new Point(40, 493);
            buttonUpdate.Margin = new Padding(3, 4, 3, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(79, 44);
            buttonUpdate.TabIndex = 73;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // labelUpdate
            // 
            labelUpdate.BackColor = Color.FromArgb(192, 192, 255);
            labelUpdate.BorderStyle = BorderStyle.Fixed3D;
            labelUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            labelUpdate.ForeColor = Color.Black;
            labelUpdate.Location = new Point(40, 461);
            labelUpdate.Name = "labelUpdate";
            labelUpdate.Size = new Size(353, 30);
            labelUpdate.TabIndex = 72;
            labelUpdate.Text = "Choose a bike to update from the listBox";
            labelUpdate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSearch
            // 
            labelSearch.BackColor = Color.FromArgb(192, 192, 255);
            labelSearch.BorderStyle = BorderStyle.Fixed3D;
            labelSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            labelSearch.ForeColor = Color.Black;
            labelSearch.Location = new Point(40, 354);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(323, 37);
            labelSearch.TabIndex = 71;
            labelSearch.Text = "Search for a bike by the serial number";
            labelSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(128, 128, 255);
            buttonSearch.FlatAppearance.BorderColor = Color.Black;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSearch.ForeColor = Color.Transparent;
            buttonSearch.Location = new Point(40, 395);
            buttonSearch.Margin = new Padding(3, 4, 3, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(79, 44);
            buttonSearch.TabIndex = 70;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1350, 703);
            Controls.Add(buttonUpdate);
            Controls.Add(labelUpdate);
            Controls.Add(labelSearch);
            Controls.Add(buttonSearch);
            Controls.Add(groupBoxHybridBike);
            Controls.Add(groupBoxElectricBike);
            Controls.Add(groupBoxRoadBike);
            Controls.Add(groupBox3);
            Controls.Add(buttonExit);
            Controls.Add(buttonDelete);
            Controls.Add(labelDelete);
            Controls.Add(groupBox1);
            Controls.Add(listBoxBikes);
            Controls.Add(buttonReset);
            Controls.Add(buttonAdd);
            Controls.Add(groupBoxBikeInfo);
            Controls.Add(groupMountainBike);
            Controls.Add(groupBoxMadeDate);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Lennin Steven Sabogal Prieto 202330544";
            Load += Form1_Load;
            groupBoxBikeInfo.ResumeLayout(false);
            groupBoxBikeInfo.PerformLayout();
            groupMountainBike.ResumeLayout(false);
            groupMountainBike.PerformLayout();
            groupBoxMadeDate.ResumeLayout(false);
            groupBoxMadeDate.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBoxRoadBike.ResumeLayout(false);
            groupBoxRoadBike.PerformLayout();
            groupBoxElectricBike.ResumeLayout(false);
            groupBoxElectricBike.PerformLayout();
            groupBoxHybridBike.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxBikeInfo;
        private Label labelBikeType;
        private Label labelSerialNumber;
        private Label labelMade;
        private ComboBox comboBoxBikeType;
        private ComboBox comboBoxColor;
        private TextBox textBoxSerialNumber;
        private TextBox textBoxMade;
        private GroupBox groupMountainBike;
        private Label labelHeightFromGround;
        private Label labelSeatHight;
        private TextBox textBoxHeightFromGround;
        private TextBox textBoxSeatHeight;
        private GroupBox groupBoxMadeDate;
        private Label labelMonth;
        private Label labelDay;
        private Label labelYear;
        private TextBox textBoxMonth;
        private TextBox textBoxDay;
        private TextBox textBoxYear;
        private GroupBox groupBox1;
        private Button buttonWriteToXmlFile;
        private Button buttonReadFromXmlFile;
        private ListBox listBoxBikes;
        private Button buttonPrintMountainBike;
        private Button buttonPrintRoadBike;
        private Button buttonReset;
        private Button buttonPrintBike;
        private Button buttonAdd;
        private Button buttonDelete;
        private Label labelDelete;
        private Button buttonExit;
        private Label labelModel;
        private TextBox textBoxModel;
        private Label labelSpeed;
        private TextBox textBoxSpeed;
        private Label labelColor;
        private ComboBox comboBoxSuspension;
        private Label labelSuspension;
        private Label labelWheelSize;
        private TextBox textBoxWheelSize;
        private Label labelFrameType;
        private ComboBox comboBoxFrameType;
        private GroupBox groupBox3;
        private GroupBox groupBoxRoadBike;
        private GroupBox groupBoxElectricBike;
        private TextBox textBoxBatteryIndicator;
        private Label labelBatteryIndicator;
        private GroupBox groupBoxHybridBike;
        private Label labelHybridType;
        private ComboBox comboBoxHybridType;
        private Button buttonPrintHybridBike;
        private Button buttonPrintElectricBike;
        private Button buttonUpdate;
        private Label labelUpdate;
        private Label labelSearch;
        private Button buttonSearch;
    }
}
