namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            char? operation = null;

            while (operation != 'q')
            {

                Console.WriteLine("\nSelect what kind of operation would you like to calculate");
                Console.WriteLine("==============================================");
                Console.Write("(+)Addition, (-)Subtraction, ((*)Multiply, (/)Divide, or (q)uit: ");
                operation = Convert.ToChar(Console.ReadLine());
                switch (operation)
                {
                    case '+':
                        int sum = a + b;
                        Console.WriteLine($"{a} + {b} = {sum}");
                        break;
                    case '-':
                        sum = a - b;
                        Console.WriteLine($"{a} - {b} = {sum}");
                        break;
                    case '*':
                        int product = a * b;
                        Console.WriteLine($"{a} * {b} = {product}");
                        break;
                    case '/':
                        int quotient = a / b;
                        int remainder = a % b;
                        Console.WriteLine($"{a} / {b} = {quotient}, remainder = {remainder}");
                        break;
                    default:
                        break;
                }
            }

            // obtain radius from user
            Console.WriteLine("What is circle radius?");
            double radius = double.Parse(Console.ReadLine());

            // calculate circle area
            Console.WriteLine($"Circular area = {AreaOfCircle(radius)}");

        }

        public static double AreaOfCircle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

    }
}
