using InternshipTest.Person;

namespace InternshipTest.Institution
{
    public class University
    {
        public string name { get; set; }

        public University(string name)
        {
            this.name = name;
        }
        
        public List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            //TODO: Implementation is needed
            students.Add(student);
        }
        
        public int AverageKnowledgel()
        {
            int sum = 0;
            foreach (var student in students)
            {
                sum += student.studentKnowledge.level;
            }
            return int.Parse(sum / students.lenght); //TODO: parese
        }
    }
}
