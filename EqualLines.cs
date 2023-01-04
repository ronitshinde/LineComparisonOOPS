

namespace LineComparisonOOPS
{
    public class EqualLines
    {
        public static void TwoLines()
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

            bool Result = Line1.Equals(Line2);


            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine(Result);

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");

            String result = Result.ToString();

            if (result == "False")
            {
                Console.WriteLine("Line1 and Line2 are unequal");
            }
            else
            {
                Console.WriteLine("Line1 and Line2 are equal");
            }

        }
    }
}
      