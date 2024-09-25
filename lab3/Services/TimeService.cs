namespace lab3.Services
{
    public class TimeService
    {
        public string TimeAnalysis()
        {
            var currentTime = DateTime.Now.TimeOfDay;

            if (currentTime.Hours >= 12 && currentTime.Hours < 18)
            {
                return "Зараз день";
            }
            else if (currentTime.Hours >= 18 && currentTime.Hours < 24)
            {
                return "Зараз вечір";
            }
            else if (currentTime.Hours >= 0 && currentTime.Hours < 6)
            {
                return "Зараз ніч";
            }
            else if (currentTime.Hours >= 6 && currentTime.Hours < 12)
            {
                return "Зараз ранок";
            }

            return "Невідомий час";
        }
    }
}
