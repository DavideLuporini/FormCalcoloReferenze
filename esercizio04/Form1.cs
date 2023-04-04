namespace esercizio04
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string surname = textBox_surname.Text;
            DateTime birthDay = dateTimePicker_birthday.Value;
            string city = textBox_city.Text;
            User user = new User(name, surname, birthDay, city);

            string completeName = user.getCompleteName(name, surname);
            string currentAge = user.CalculateAge(birthDay);
            string letterCount = user.DisplayLetterCount(name, surname, city);

            label_risultato.Text = $"il nome completo � : {completeName}\net�: {currentAge} \n{letterCount}";
        }

        private void dateTimePicker_birthday_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today < dateTimePicker_birthday.Value)
            {
                MessageBox.Show("Ma vieni dal futuro?");
                dateTimePicker_birthday.Value = DateTime.Today;
            }
        }
    }
}