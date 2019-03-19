namespace InternshipTest
{
    public class Knowledge
    {
        private int _mark;
        private int _level;

        public int mark
        {
            get { return _mark; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new System.Exception("{0} isn't correct input. ");
                }
                else
                {
                    _mark = value;
                }

                if (_mark <= 30)
                    level = 1;
                else if (_mark > 30 && _mark <= 50)
                {
                    level = 2;
                }
                else if (_mark > 50 && _mark <= 70)
                {
                    level = 3;
                }
                else if (_mark > 70 && _mark <= 80)
                {
                    level = 4;
                }
                else
                {
                    level = 5;
                }
            }
        } 

        public int level
        {
            get { return _level; }
            set
            {
                _level = value;
            }
        }
        public Knowledge(int mark)
        {
            //TODO: Implementation is needed
            this.mark = mark;
        }
    }
}
