using System;

namespace Lesson_07_Exercises.App
{
    public class ChessPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public int AgeInYears
        {
            get
            {
                var age = DateTime.Now.Year - Birthdate.Year;

                if (Birthdate.Date > (DateTime.Now.AddYears(-age).Date))
                {
                    age--;
                }

                return age;
            }
        }
        public int EloRating { get; set; }
        public TimeSpan ThisYearTrainingTime { get; set; }
        public Country Country { get; set; }
    }
}
