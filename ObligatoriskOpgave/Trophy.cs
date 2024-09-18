using System.Security.Cryptography.X509Certificates;

namespace ObligatoriskOpgave
{
    public class Trophy
    {
        public int Id { get; set; }

        public string? Competition { get; set; }

        public int Year { get; set; }



        public void ValidateCompetition()
        {
            if (Competition == null)
            {
                throw new ArgumentNullException("Competition cannot be null");
            }

            if (Competition.Length > 3)
            {
                throw new ArgumentOutOfRangeException("string must be at least 3 characters");
            }

        }
        public void ValidateYear()
        {
            if (Year < 1970 || Year > 2024)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void Validate()
        {
            ValidateCompetition();
            ValidateYear();
          
        }
        public override string ToString()
        {
            return $"Id: {Id}, Competition: {Competition}, Year: {Year}";
        }



    }
}
