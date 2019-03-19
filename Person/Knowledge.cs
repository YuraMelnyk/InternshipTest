namespace InternshipTest
{
    public class Knowledge
    {
        public int mark
        {
            get { return mark; }
            set
            {
                if (value > 0 && value < 100)
                {
                    throw new OutOfRangeException(string.Format("{0} isn't correct input. "));
                }
                else
                {
                    mark = value;
                }
            }
        } //TODO: set

        public int level
        {
            get
            {
                if (mark <= 30)
                    level = 1;
                else if (mark > 30 && mark <= 50)
                {
                    level = 2;
                }
                else if (mark > 50 && mark <= 70)
                {
                    level = 3;
                }
                else if (mark > 70 && mark <= 80)
                {
                    level = 4;
                }
                else
                {
                    level = 5;
                }
            }
        }
        public Knowledge(int mark)
        {
            //TODO: Implementation is needed
            this.mark = mark;
        }
    }
}
