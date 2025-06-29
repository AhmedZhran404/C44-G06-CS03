namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question1
            /*
             Write a program that allows the user to enter a number then print it.
            */
            Console.WriteLine("Enter Your Number: ");
            int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine($"The Number is: {number}");

            #endregion

        }
    }
}
