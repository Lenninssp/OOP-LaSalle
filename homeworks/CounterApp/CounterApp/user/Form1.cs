using CounterApp.bus;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System;
using System.Xml.Serialization;
using System.Diagnostics.Metrics;

namespace CounterApp
{
    public partial class Form1 : Form
    {
        Counter currentCounter;

        List<Counter> listOfCounters = new List<Counter>();

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBoxColor.Items.AddRange(Enum.GetNames(typeof(EnumColor)));
            comboBoxType.Items.AddRange(Enum.GetNames(typeof(EnumCounterType)));

        }


        private Counter CreateCounter(int serial, int value, EnumColor color, EnumCounterType counterType, int day, int month, int year)
        {
            switch (counterType)
            {
                case EnumCounterType.STEP:
                    if (!int.TryParse(textBoxStep.Text, out int steps))
                    {
                        MessageBox.Show("Invalid input for steps. Please enter a valid numeric value.");
                        return null;
                    }
                    return new StepCounter(serial, value, color, new Date(day, month, year), counterType, steps);

                case EnumCounterType.ModuleNCounter:
                    if (!int.TryParse(textBoxMaxLimit.Text, out int maxLimit))
                    {
                        MessageBox.Show("Invalid input for max limit. Please enter a valid numeric value.");
                        return null;
                    }
                    return new ModuloNCounter(serial, value, color, new Date(day, month, year), counterType, maxLimit);

                case EnumCounterType.NONE:
                    return new Counter(serial, value, color, new Date(day, month, year), counterType);

                default:
                    MessageBox.Show("Unsupported counter type.");
                    return null;
            }
        }

        private void ClearTextBoxes()
        {

            textBoxSerial.Clear();
            textBoxValue.Clear();
            textBoxDay.Clear();
            textBoxMonth.Clear();
            textBoxYear.Clear();
            textBoxMaxLimit.Clear();
            textBoxStep.Clear();
            comboBoxColor.SelectedItem = null;
            comboBoxType.SelectedItem = null;

        }



        private void buttonWrite_Click(object sender, EventArgs e)
        {
            if (DataCollection.ListOfCounters != null)
            {
                FileManager.WriteToXMLFile(DataCollection.ListOfCounters);
                MessageBox.Show("Data written to XML file successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            DataCollection.ListOfCounters = FileManager.ReadFromXMLFile();

            foreach (Counter counter in DataCollection.ListOfCounters)
            {
                richTextBox.AppendText(counter.GetState() + "\n");
            }

            if (this.listOfCounters != null)
            {
                MessageBox.Show("Data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to load data from XML file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnumCounterType currentCounterType;

            Enum.TryParse(this.comboBoxType.Text, out currentCounterType);

            if (currentCounterType == EnumCounterType.STEP)
            {
                this.textBoxStep.Enabled = true;
                this.textBoxMaxLimit.Enabled = false;
            }

            if (currentCounterType == EnumCounterType.ModuleNCounter)
            {
                this.textBoxStep.Enabled = false;
                this.textBoxMaxLimit.Enabled = true;
            }
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxSerial.Text, out int serial) ||
                !int.TryParse(textBoxValue.Text, out int value) ||
                !int.TryParse(textBoxDay.Text, out int day) ||
                !int.TryParse(textBoxMonth.Text, out int month) ||
                !int.TryParse(textBoxYear.Text, out int year))
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values.");
                return;
            }

            Enum.TryParse(comboBoxColor.Text, out EnumColor color);
            Enum.TryParse(comboBoxType.Text, out EnumCounterType counterType);

            Counter newCounter = CreateCounter(serial, value, color, counterType, day, month, year);
            if (newCounter != null)
            {
                DataCollection.Add(newCounter);

            }
            else
            {
                MessageBox.Show("Failed to create counter. Please check the input values.");
            }
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Application written by Lennin Sabogal 202330544", "Thanks :)", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxSerial.Text, out int serial) ||
                !int.TryParse(textBoxValue.Text, out int vaalue) ||
                !int.TryParse(textBoxDay.Text, out int day) ||
                !int.TryParse(textBoxMonth.Text, out int month) ||
                !int.TryParse(textBoxYear.Text, out int year))
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values.");
                return;
            }

            Enum.TryParse(comboBoxColor.Text, out EnumColor color);
            Enum.TryParse(comboBoxType.Text, out EnumCounterType counterType);

            currentCounter.Serial = serial;
            currentCounter.Vaalue = vaalue;
            currentCounter.Color = color;
            currentCounter.Type = counterType;
            currentCounter.Daate = new Date(day, month, year);

            DataCollection.InsertAt(DataCollection.ListOfCounters.IndexOf(currentCounter), currentCounter);


            MessageBox.Show("Counter updated successfully.");
        }

        private void buttonReset_Click_1(object sender, EventArgs e)
        {
            ClearTextBoxes();

        }

        private void buttonRemove_Click_1(object sender, EventArgs e)
        {
            listOfCounters.Remove(currentCounter);
            DataCollection.Remove(currentCounter);
            ClearTextBoxes();
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {

            int searchCode = int.Parse(textBoxSerial.Text);

            Counter searchedCounter = DataCollection.Search(searchCode);

            if (searchedCounter != null)
            {
                MessageBox.Show("Counter found \n  " + searchedCounter.GetState(), "Event programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);

                currentCounter = searchedCounter;

                textBoxSerial.Text = searchedCounter.Serial.ToString();
                textBoxValue.Text = searchedCounter.Vaalue.ToString();
                comboBoxColor.SelectedItem = searchedCounter.Color.ToString();
                comboBoxType.SelectedItem = searchedCounter.Type.ToString();
                textBoxDay.Text = searchedCounter.Daate.Day.ToString();
                textBoxMonth.Text = searchedCounter.Daate.Month.ToString();
                textBoxYear.Text = searchedCounter.Daate.Year.ToString();
            }
            else
            {
                MessageBox.Show("Counter not found", "Event programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void buttonPrint_Click_1(object sender, EventArgs e)
        {
            richTextBox.Clear();

            if (DataCollection.GetCounterList() != null && DataCollection.GetCounterList().Count > 0)
            {
                foreach (Counter counter in DataCollection.ListOfCounters)
                {
                    richTextBox.AppendText(counter.GetState() + "\n");
                }
            }
            else
            {
                MessageBox.Show("The list of Counters already printed in the listBox or the list of Counterss in memory is empty....");
            }
        }
    }
}
