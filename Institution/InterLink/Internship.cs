namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public srting name { get; set; } 
        public Internship(string name)
        {
            //TODO: Implementation is needed     
            this.name = name;
        }

        public string GetStudents( University university)
        {
            //TODO: Implementation is needed
            StringBuilder res = new StringBuilder();
            foreach (var student in university.students)
            {
                if (studentKnowledge.level > university.AverageKnowledgel())
                {
                    res += student.name + "\n";
                }
            }
            return res;
        }
    }
}
