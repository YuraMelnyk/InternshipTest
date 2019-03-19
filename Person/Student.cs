namespace InternshipTest.Person
{
    public class Student
    {
        public string name { get; set; }

        public Student(string name)
        {
            //TODO: Implementation is needed
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
            catch (OutOfRangeException e)
            {
                System.Console.WriteLine(e.Message);
            }

        }
    }
}