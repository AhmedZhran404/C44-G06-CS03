using System.Globalization;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            #region FractionsAndDiscard

            /*
                float  : 4 bytes (32 bits), precision ≈ 7 digits
                double : 8 bytes (64 bits), precision ≈ 15-16 digits
                decimal: 16 bytes (128 bits), precision ≈ 28-29 digits
            */

            float x = 3.5677777777777f;

            Console.WriteLine("----------------------------------");
            Console.WriteLine(x); // 3.5677779 -> 7 digits After point

            double y = 4.5; // default num is double no problem

            decimal z = 5.666m;

            // Discard --> organize

            long X = 5_362_145_289_657; // readability

            Console.WriteLine($"{X:c}"); // c --> Currency

            Console.WriteLine("----------------------------------");
            CultureInfo ArabicCulture = new CultureInfo("ar-EG");
            double number = 12345.67;
            Console.WriteLine(number.ToString("N", ArabicCulture));
            #endregion
        }
    }
}