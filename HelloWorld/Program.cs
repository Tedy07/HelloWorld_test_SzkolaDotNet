namespace HelloWorld
{
    // PascalCase
    class Program
    {
        static void Main(string[] args)
        {
            double a = 20;
            double b = 10;

           Math math = new Math();

            double addResult = math.Add(a, b);
            double substractResult = math.Substract(a, b);
            double multiplicationResult = math.Multiplication(a, b);
            double divisionResult = math.Division(a, b);

            Console.WriteLine(addResult.ToString());
            Console.WriteLine(substractResult.ToString());
            Console.WriteLine(multiplicationResult.ToString());
            Console.WriteLine(divisionResult.ToString());
        
         }
    }
}



