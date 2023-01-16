namespace Interpreter
{
	class Program
	{
		static void Main(string[] args)
		{
            //string roman = "MCMXXVIII";
            string roman = "MCMLXXXVI";
            Context context = new Context(roman);

            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} = {1}", roman, context.Output);

			Console.ReadKey();
		}
	}
}