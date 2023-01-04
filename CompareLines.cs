
namespace LineComparisonOOPS
{
    public class CompareLines
    {
        public static void UseCompareTo()
        {
            int X1, Y1, X2, Y2;

            Console.WriteLine("Enter the Co-ordinates for Line1");

            Console.WriteLine("Give value of X1");
            X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give value of Y1");
            Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give value of X2");
            X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give value of Y2");
            Y2 = Convert.ToInt32(Console.ReadLine());

            Double a = (Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            
            Double Line1 = Math.Sqrt(a);
            Console.WriteLine("Length of the line : " + Line1);

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");

            int P1, Q1, P2, Q2;

            Console.WriteLine("Enter the Co-ordinates for Line2");

            Console.WriteLine("Give value of P1");
            P1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give value of Q1");
            Q1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give value of P2");
            P2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give value of Q2");
            Q2 = Convert.ToInt32(Console.ReadLine());

            Double b = (Math.Pow((P2 - P1), 2) + Math.Pow((Q2 - Q1), 2));
            
            Double Line2 = Math.Sqrt(b);
            Console.WriteLine("Length of the line : " + Line2);

            Double Result = Line1.CompareTo(Line2);


            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Result = " + Result);

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");

            
            if (Result > 0)
            {
                Console.WriteLine("Line1 ({0}) is greater than Line2 ({1})", Line1, Line2);
            }
            else if (Result < 0)
            {
                Console.WriteLine("Line1 ({0}) is lesser than Line2 ({1})", Line1, Line2);
            }
            else
            {
                Console.WriteLine("Line1 ({0}) is equal to Line2 ({1})", Line1, Line2);
            }

        }
    }
}


