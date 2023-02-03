namespace HelloWorld
{
    // PascalCase
    class Program
    {
        static void Main(string[] args)
        {
            double a = 20;
            double b = 10;

           Mssath math = new Mssath();

            double addResult = math.Add(a, b);
            double substractResult = math.Substract(a, b);
            double multiplicationResult = math.Multiplication(a, b);

            Console.WriteLine(addResult.ToString());
            Console.WriteLine(substractResult);
            Console.WriteLine(multiplicationResult);


            //// camelCase
            //string imie = "Tadeusz";

            ////UPPER_CASE
            //const double PI_NUMBER = 3.14;

            //Console.WriteLine("Hello, World! {0}", PI_NUMBER);
            //Console.WriteLine("Nazywam się Tadeusz Kobroń, {0}", imie);





         }


    }

}



