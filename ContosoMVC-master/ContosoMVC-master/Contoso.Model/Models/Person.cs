namespace Contoso.Model
{
    public class Person
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string FullName => LastName + ", " + FirstName;
        public int Age { get; set; }
    }
}