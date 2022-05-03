partial class MathOperations
{
    public class Expression
    {
        public Expression(string val1, string val2, string oper)
        {
            this.val1 = val1;
            this.val2 = val2;
            this.oper = oper;
        }

        public  string val1 { get; set; }
        public   string val2 { get; set; }
        public  string oper { get; set; }       
    }
}