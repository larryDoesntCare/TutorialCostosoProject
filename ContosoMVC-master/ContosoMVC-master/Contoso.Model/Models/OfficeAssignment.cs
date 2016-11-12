namespace Contoso.Model
{
    public class OfficeAssignment
    {
        public int Id { get; set; }
        public int InstructorID { get; set; }
        public string Location { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}