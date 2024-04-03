using static System.Runtime.InteropServices.JavaScript.JSType;
using MIdterm.bus;

namespace MIdterm
{
    public partial class Form1 : Form
    {

        Film currentFilm;

        List<Film> listOfFilms = new List<Film>();


        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBoxLang.Items.AddRange(Enum.GetNames(typeof(EnumLanguage)));
            comboBoxCat.Items.AddRange(Enum.GetNames(typeof(EnumCategory)));

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                int hours = int.Parse(HourBox.Text);
                int minutes = int.Parse(MinBox.Text);

                if (hours < 2 || (hours == 2 && minutes > 0) || hours > 2)
                {
                    MessageBox.Show("Film duration must be exactly 2 hours.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Film newFilm = new Film();
                newFilm.Code = int.Parse(CodeBox.Text);
                newFilm.Title = TitleBox.Text;
                newFilm.Category = (EnumCategory)Enum.Parse(typeof(EnumCategory), comboBoxCat.Text);
                newFilm.Language = (EnumLanguage)Enum.Parse(typeof(EnumLanguage), comboBoxLang.Text);
                newFilm.Duration = new Time(hours, minutes);
                newFilm.Actor = new Person(ActorBox1.Text, ActorBox2.Text);

                listOfFilms.Add(newFilm);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please enter valid values for hours and minutes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Invalid category or language selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintBox.Clear();
            foreach (Film film in listOfFilms)
            {
                PrintBox.AppendText(film.GetState() + "\n");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int searchCode = int.Parse(CodeBox.Text);

            bool found = false;
            Film searchedFilm = null;

            foreach (Film item in this.listOfFilms)
            {
                if (item.Code == Convert.ToInt32(this.CodeBox.Text))
                {
                    found = true;
                    searchedFilm = item;
                    break;
                }
            }

            if (found)
            {
                MessageBox.Show("Film found \n  " + searchedFilm.GetState(), "Event programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);

                currentFilm = searchedFilm;

                CodeBox.Text = searchedFilm.Code.ToString();
                TitleBox.Text = searchedFilm.Title;
                comboBoxCat.SelectedItem = searchedFilm.Category.ToString();
                HourBox.Text = searchedFilm.Duration.Hours.ToString();
                MinBox.Text = searchedFilm.Duration.Minutes.ToString();
                ActorBox1.Text = searchedFilm.Actor.FirstName;
                ActorBox2.Text = searchedFilm.Actor.LastName;

                comboBoxLang.SelectedItem = searchedFilm.Language.ToString();
                comboBoxCat.SelectedItem = searchedFilm.Category.ToString();

            }
            else
            {
                MessageBox.Show("Film not found", "Event programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            currentFilm.Code = int.Parse(CodeBox.Text);
            currentFilm.Title = TitleBox.Text;
            currentFilm.Category = (EnumCategory)Enum.Parse(typeof(EnumCategory), comboBoxCat.Text);
            currentFilm.Language = (EnumLanguage)Enum.Parse(typeof(EnumLanguage), comboBoxLang.Text);
            currentFilm.Duration = new Time(Convert.ToInt16(HourBox.Text), Convert.ToInt16(MinBox.Text));
            currentFilm.Actor = new Person(ActorBox1.Text, ActorBox2.Text);

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            listOfFilms.Remove(currentFilm);
            ClearTextBoxes();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {

            CodeBox.Clear();
            TitleBox.Clear();
            HourBox.Clear();
            MinBox.Clear();
            ActorBox1.Clear();
            ActorBox2.Clear();
            PrintBox.Clear();
            comboBoxLang.SelectedItem = null;
            comboBoxCat.SelectedItem = null;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application written by Lennin Sabogal 202330544", "Thanks :)", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

