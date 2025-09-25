namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            
            char? operation = null;

            while( operation != 'q' ) {
                
                switch (operation)
            {
                case '+':
                    int sum = a + b;
                    Console.WriteLine($"{a} + {b} = {sum}");
                    break;
                case '-':
                    int sum = a - b;
                    Console.WriteLine($"{a} - {b} = {sum}");
                    break;
                case '*':
                    int product = a * b;
                    Console.WriteLine($"{a} * {b} = {product}");
                    break;
                case '/':
                    int quotient  = a / b;
                    int remainder = a % b;
                    break;
                default:
                    break;
            }}
        }
    }
}
