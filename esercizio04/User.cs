using System.Text;

namespace esercizio04
{
    internal class User : AgeCalculator
    {

        private string Name { get; set; }
        public string Surname { get; set; }
        private DateTime BirthDay { get; set; }
        private string City { get; set; }

        public User(string name, string surname, DateTime birthDay, string city)
        {
            Name = name;
            Surname = surname;
            BirthDay = birthDay;
            City = city;
        }

        public string getCompleteName(string nome, string cognome)
        {
            string completeName = $"{nome} {cognome}";
            return completeName;
        }

        public string DisplayLetterCount(string name, string surname, string city)
        {
            string completeString = (name + surname + city).ToLower().Replace(" ", "");
            string result = string.Empty;
            List<char> charList = new List<char>();
            StringBuilder sb = new StringBuilder();
            foreach (char c in completeString)
            {
                if (!charList.Contains(c))
                {
                    charList.Add(c);
                    int freq = completeString.Count(f => (f == c));
                    sb.Append($"il carattere {c} è presente: {freq} volte\n");
                    result = sb.ToString();
                }
            }
            return result;
        }

    }
}
