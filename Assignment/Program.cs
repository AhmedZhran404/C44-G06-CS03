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

            #region Question2
            /*
                 Write C# program that converts a string to an 
                  integer, but the string contains non-numeric 
                  characters. And mention what will happen 
           */

            string name = "ahmed";
            // int num = (int)name; // Error can not conver

            // int num = Convert.ToInt32(name); // Exception

            // All conversion methods will throw an exception except TryParse, which handles the conversion safely.
            #endregion

            #region Question3
            /*
              Write C# program that Perform a simple arithmetic 
              operation with floating-point numbers And mention 
              what will happen 
             */


            double num1 = 4.56;
            double num2 = 5.55677;
            
            Console.WriteLine("Result Is: " +  num1 * num2);   //  25.3388712
            //----------------------------------------
            float number1 = 4.56f;
            float number2 = 5.55677f;

            Console.WriteLine("Result Is: " + number1 * number2); // 25.338871


            /*
             he result is slightly different because float has lower precision than double.
                double gives a more accurate result with more digits after the decimal point.
             */

            #endregion

            



        }
    }
}
