using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        private string _name;
        private List<Student> bestStudents = new List<Student>();

        public List<Student> candidates = new List<Student>();

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Internship(string name)
        {   
            this.name = name;
        }

        public void GetStudents( University university, List<Student> Candidates)
        {
            
            foreach (var student in Candidates)
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
                res += student.name + "\n";
            }
            return res;
        }

        public void GetCandidatesFrom(FileStream fs)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Student[]));
            using (fs)
            {
                Student[] newStudents = (Student[])formatter.Deserialize(fs);

                foreach (Student p in newStudents)
                {
                    candidates.Add(p);
                }
            }
        }
    }
}
