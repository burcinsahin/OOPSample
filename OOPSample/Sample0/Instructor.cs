namespace OOPSample.Sample0
{
    public class Instructor : Person
    {
        private readonly string _title;

        public string Title
        {
            get { return _title; }
        }

        public Instructor(string name, string surname, byte age, string title) : base(name, surname, age)
        {
            _title = title;
        }
    }
}
