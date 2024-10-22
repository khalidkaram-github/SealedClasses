namespace SealedClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    //ex1
    public sealed class MySealedClass
    {
        // Class members here
    }



    //ex2
    public sealed class Car
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving...");
        }
    }

    // Trying to inherit from Car will cause an error
    public class SportsCar : Car
    {

    } // This will not compile


}
