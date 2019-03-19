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
        
        public System.Collections.Generic.List<Student> students = new System.Collections.Generic.List<Student>();

        public void AddStudent(Student student)
        {
            //TODO: Implementation is needed
            students.Add(student);
        }
        
        public int AverageKnowledgel()
        {
            int sum = 0;
            int res;
            foreach (var student in students)
            {
                sum += student.studentKnowledge.level;
            }
            res = sum / students.lenght;
            return res;
        }
    }
}
