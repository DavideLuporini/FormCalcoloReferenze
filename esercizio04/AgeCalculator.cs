namespace esercizio04
{
    abstract class AgeCalculator
    {
        private const int DaysPerYear = 365;
        private const int DaysPerMonth = 30;
        public string CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int totalDays = GetTotalDays(birthDate, today);
            int totalYears = GetTotalYears(totalDays);
            int totalMonths = GetTotalMonths(totalDays);
            return $"{totalYears} year(s), {totalMonths} month(s)";
        }

        private static int GetTotalDays(DateTime startDate, DateTime endDate)
        {
            TimeSpan span = endDate.Subtract(startDate);
            return (int)span.TotalDays;
        }

        private static int GetTotalYears(int totalDays)
        {
            return totalDays / DaysPerYear;
        }

        private static int GetTotalMonths(int totalDays)
        {
            int remainingDays = totalDays % DaysPerYear;
            return remainingDays / DaysPerMonth;
        }
    }
}
