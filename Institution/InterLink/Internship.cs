namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public string name { get; set; } 
        public Internship(string name)
        {
            //TODO: Implementation is needed     
            this.name = name;
        }

        public string GetStudents( University university)
        {
            //TODO: Implementation is needed
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
