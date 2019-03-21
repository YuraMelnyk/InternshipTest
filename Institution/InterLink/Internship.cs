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

        public string GetStudents( University university)
        {
            string res = "";
            foreach (var student in university.students)
            {
                if (student.studentKnowledge.level > university.AverageKnowledgel())
                {
                    res += student.name + "\n";
                }
            }
            return res;
        }
    }
}
