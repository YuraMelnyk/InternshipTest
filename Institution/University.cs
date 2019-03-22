using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int averageKnowledge
        {
            get { return AverageKnowledge(); }
        }

        public University(string name)
        {
            this.name = name;
        }
        
        public List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {            
            students.Add(student);
        }
        
        private int AverageKnowledge()
        {
            int sum = 0;
            int res;
            if (students.Count != 0)
            {
                foreach (var student in students)
                {
                    sum += student.studentKnowledge.level;
                }
                res = sum / students.Count;
                return res;
            }
            else
            {
                return 0;
            }
            
        }
    }
}
