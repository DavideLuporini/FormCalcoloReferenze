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
            User utente = new User(name, surname, birthDay, city);

            string nomeCompleto = utente.getCompleteName(name, surname);
            string currentAge = utente.CalculateAge(birthDay);
            string letterCount = utente.DisplayLetterCount(name, surname, city);

            label_risultato.Text = $"il nome completo è : {nomeCompleto}\netà: {currentAge} \n{letterCount}";
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