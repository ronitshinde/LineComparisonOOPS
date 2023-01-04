

namespace LineComparisonOOPS
{
    public class CalculateLength
    {
        public static void LengthOfLine()
        {
            int X1, Y1, X2, Y2;

            Console.WriteLine("Give value of X1");
            X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give value of X2");
            Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give value of Y1");
            X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give value of Y2");
            Y2 = Convert.ToInt32(Console.ReadLine());

            Double a = (Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Value after squaring and adding : " + a);

            Double Line1 = Math.Sqrt(a);
            Console.WriteLine("Length of the line : " + Line1);

        }
    }
}

        