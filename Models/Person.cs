using PersonCrud.Data;

namespace PersonCrud.Models
{
    public class Person
    {
        public int Id { get; }
        public int Document { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public bool Married { get; set; }

        private static int _idCount = 0;

        public Person()
        {
            _idCount++;
            Id = this.GenId();
        }

        public int GetAge(Person p)
        {
            TimeSpan aux = DateTime.Now - p.Birthdate;
            return (int)Math.Truncate(aux.TotalDays / 365.25);
        }

        public override string ToString()
        {
            return String.Format("ID: {0}\n" +
                "Doc: {1}\n" +
                "FName: {2}\n" +
                "LName: {3}\n" +
                "BDate: {4}\n" +
                "Married: {5}",
                Id, Document, FirstName, LastName, Birthdate.ToShortDateString(), Married);
        }

        public int GenId()
        {
            return _idCount;
        }
    }
}

