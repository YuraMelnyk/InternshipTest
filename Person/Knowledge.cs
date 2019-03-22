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
                    _level = 1;
                else if (_mark > 30 && _mark <= 50)
                {
                    _level = 2;
                }
                else if (_mark > 50 && _mark <= 70)
                {
                    _level = 3;
                }
                else if (_mark > 70 && _mark <= 80)
                {
                    _level = 4;
                }
                else
                {
                    _level = 5;
                }
            }
        } 

        public int level
        {
            get { return _level; }        
        }

        public Knowledge() { }

        public Knowledge(int mark)
        {
            this.mark = mark;
        }
    }
}
