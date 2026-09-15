namespace Topic_2_Assignment_Math_And_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Easton Powers");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Math and Numbers");
            Console.WriteLine();
            Console.WriteLine("My Year Of Birth Is " + (2026 - 17));
            Console.WriteLine();
            Console.WriteLine("Average of 14, 15, 16 is " + ((14 + 15 + 16) / 3));
            Console.WriteLine();
            Console.WriteLine("Average of 14, 15 ,16 ,17 is " + ((14.0 + 15.0 + 16.0 + 17.0) / 4));
            Console.WriteLine();
            //Console.Writeline("MathPow uses the 'to the power of' symbol");
            //Console.Writeline("The 1 after the 2 limits/extends the decimal point range while the 3,2 is three to the power of two using the mathpow statement.");
            Console.WriteLine("The area of a circle where r=3cm is " + Math.Round((Math.PI) * Math.Pow(3, 2), 1));
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("How does C# know when to add when the '+' operator is used instead of concatenating?");
            Console.WriteLine("");
            Console.WriteLine("C# decides whether to add or concatenate based on the data types on either side of the + operator.");
            Console.WriteLine();
            Console.WriteLine("For example: if you put two numbers beside eachother, C# will add them together mathematically. Ex. 5 + 5 + 10");
            Console.WriteLine();
            Console.WriteLine("On the other hand, if one side of the '+' is text, it will stick them together. Ex. 6 + 7 = 67");
            Console.WriteLine();
            Console.WriteLine("In short it is all dependant on the way C# and the computor interprets your inputs, making it so that there is a very specific way to input a line to get the result you want as it cannot read standard algebra, forcing you to use the inputs which helps to prevent the possibility of ambiguity.");
        }
    }
}
