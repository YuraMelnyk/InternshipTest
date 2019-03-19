namespace InternshipTest.Person
{
    public class Student
    {
        public string name { get; set; }
        public Student(string name, Knowledge studentKnowledge)
        {
            //TODO: Implementation is needed
            this.name = name;
            this.studentKnowledge = studentKnowledge;
        }
        public Student(string name)
        {
            this.name = name;
        }
        public Knowledge studentKnowledge;
        public void SetKnowledge(Knowledge knowledge)
        {
            //TODO: Implementation is needed
            try
            {
                studentKnowledge = knowledge;
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }

        }
    }
}