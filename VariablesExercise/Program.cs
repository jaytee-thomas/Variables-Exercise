namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Variable Assignment

            string myName = "Jason Thomas";
            int myAge = 49;
            char middleInitial = 'S'; // Corrected the variable name and assigned a character 'S'
            bool isSingle = true; // Corrected the variable name
            double randomDbl = 29.292929;
            decimal randomDec = 3.3m; // Added 'm' to specify that it's a decimal

            Console.WriteLine($"Hello, my name is {myName}, and I am {myAge} years old, my middle initial is {middleInitial}, marital status single {isSingle}, random number {randomDbl}, and decimal {randomDec}");
        }
    }
}