using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            AgeCalculator calc = new AgeCalculator();
            string nomeCompleto = $"{textBox_name.Text} {textBox_surname.Text}";
            string currentAge = calc.CalculateAge(dateTimePicker_birthday.Value);
            string città = textBox_city.Text;
            label_risultato.Text = $"il nome completo è : {nomeCompleto}\netà: {currentAge} \n{letterCount(nomeCompleto, città)}";
        }

        private string letterCount(string completeName, string città)
        {
            string completeString = (completeName + città).ToLower().Replace(" " , "");
            string risultato = string.Empty;
            List<char> charList = new List<char>();

            foreach (char c in completeString)
            {
                if (!charList.Contains(c))
                {
                    int freq = completeString.Count(f => (f == c));
                    charList.Add(c);
                    StringBuilder sb = new StringBuilder();
                    sb.Append($"il carattere {c} è presente: {freq} volte\n");
                    risultato = sb.ToString();
                }
            }
            return risultato;
        }

        private void dateTimePicker_birthday_ValueChanged(object sender, EventArgs e)
        {
            if(DateTime.Today < dateTimePicker_birthday.Value)
            {
                MessageBox.Show("Ma vieni dal futuro?");
                dateTimePicker_birthday.Value = DateTime.Today;
            }
        }
    }
}