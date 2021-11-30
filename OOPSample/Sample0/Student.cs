namespace OOPSample.Sample0
{
    public class Student : Person
    {
        public string IdentityNo { get; set; }

        public Student(string name, string surname, byte age) : base(name, surname, age)
        {

        }
    }
}
