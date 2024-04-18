namespace StudentMngtClientLayer
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
            showStudent = new Button();
            Deserialize = new Button();
            Serialize = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // showStudent
            // 
            showStudent.Location = new Point(131, 181);
            showStudent.Name = "showStudent";
            showStudent.Size = new Size(94, 29);
            showStudent.TabIndex = 0;
            showStudent.Text = "show student";
            showStudent.UseVisualStyleBackColor = true;
            showStudent.Click += showStudent_Click;
            // 
            // Deserialize
            // 
            Deserialize.Location = new Point(608, 216);
            Deserialize.Name = "Deserialize";
            Deserialize.Size = new Size(94, 29);
            Deserialize.TabIndex = 1;
            Deserialize.Text = "Deserialize";
            Deserialize.UseVisualStyleBackColor = true;
            Deserialize.Click += Deserialize_Click;
            // 
            // Serialize
            // 
            Serialize.Location = new Point(608, 159);
            Serialize.Name = "Serialize";
            Serialize.Size = new Size(94, 29);
            Serialize.TabIndex = 2;
            Serialize.Text = "Serialize";
            Serialize.UseVisualStyleBackColor = true;
            Serialize.Click += Serialize_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(309, 132);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(188, 169);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(Serialize);
            Controls.Add(Deserialize);
            Controls.Add(showStudent);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button showStudent;
        private Button Deserialize;
        private Button Serialize;
        private RichTextBox richTextBox1;
    }
}
