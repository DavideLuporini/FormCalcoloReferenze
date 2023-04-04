namespace esercizio04
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalcClick(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string surname = textBox_surname.Text;
            DateTime birthDay = dateTimePicker_birthday.Value;
            string city = textBox_city.Text;
            _ = new User(name, surname, birthDay, city);

            string completeName = User.GetCompleteName(name, surname);
            string currentAge = User.CalculateAge(birthDay);
            string letterCount = User.DisplayLetterCount(name, surname, city);

            label_risultato.Text = $"il nome completo è : {completeName}\netà: {currentAge} \n{letterCount}";
        }

        private void DateTimePickerBirthdayValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today < dateTimePicker_birthday.Value)
            {
                MessageBox.Show("Ma vieni dal futuro?");
                dateTimePicker_birthday.Value = DateTime.Today;
            }
        }
    }
}