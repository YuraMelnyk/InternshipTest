namespace InternshipTest.Person
{
    public class Student
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Student(string name, Knowledge studentKnowledge)
        {
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