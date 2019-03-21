using System.Collections.Generic;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Internship(string name)
        {   
            this.name = name;
        }

        private List<Student> bestStudents = new List<Student>();

        public void GetStudents( University university)
        {
            
            foreach (var student in university.students)
            {
                if (student.studentKnowledge.level > university.averageKnowledge)
                {
                    bestStudents.Add(student);
                }
            }            
        }

        public string ShowBestStudents()
        {
            string res = "";
            foreach (var student in bestStudents)
            {
                res += student.name;
            }
            return res;
        }
    }
}
