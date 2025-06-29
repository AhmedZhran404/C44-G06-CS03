using System.Globalization;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FractionsAndDiscard
            Console.OutputEncoding = System.Text.Encoding.UTF8;

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


            #region Casting
            #region ImplicitAndExplicit
            /*
                 Casting: converting a value from one type to another.
                 There are two types of casting in C#:

                 1. Implicit Casting:
                    - Happens automatically.
                    - From a smaller type to a larger type (e.g., int to float).
                    - No risk of data loss.

                 2. Explicit Casting:
                    - Requires manual casting using syntax like (int).
                    - From a larger type to a smaller type or between incompatible types.
                    - May cause data loss or runtime errors.
             */

            int num1 = 1000; // 4 Bytes

            long num2 = num1; // 8 Bytes  -> Implicit casting

            Console.WriteLine(num2);
            Console.WriteLine("---------------------");

            long S1 = 1000;

            // int s2 = S1; // Can not Implicit Convert Invaild type related error

            long S2 = (int)S1; // Explicit Convert

            // If the value of S1 is too large to fit in an int,
            // it will cause data loss (overflow or truncated value).

            Console.WriteLine("-------------------------");

            //checked
            //{
            //long s4 = 547334946739464;

            //int s5 = (int)s4;

            //Console.WriteLine(s5);

            //}

            unchecked
            {
                long s4 = 547334;

                int s5 = (int)s4;

                Console.WriteLine(s5);
            }

            long number01 = 46758;
            if (number01 > int.MaxValue || number01 < int.MinValue)
            {
                Console.WriteLine("Exception Will be Occuer");
            }
            else
            {
                int number02 = (int)number01;
                Console.WriteLine(number02);
            }

            #endregion

            #region MethodsOFCasting

            #region Convert
            Console.WriteLine("Please Enter Your Name: ");
            string? name = Console.ReadLine(); // Read input From User by console
            Console.WriteLine("------------------------");
            Console.WriteLine("Pleasse Enter Your Age");
            // int age  = Console.ReadLine(); // Error ReadLine -> Always Take Input String
            // int age = (int)Console.ReadLine(); // Explicit Casting -> Invalid
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("Pleasse Enter Your Salary");
            decimal Salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("------------------------");

            Console.Clear();
            Console.WriteLine("Employee Date :");
            Console.WriteLine($"Name is: {name}");
            Console.WriteLine($"Age is: {age}");
            Console.WriteLine($"Salary is: {Salary}");

            #endregion



            #region Parse
            Console.WriteLine("Please Enter Your Name: ");
            string? name1 = Console.ReadLine(); // Read input From User by console
            Console.WriteLine("------------------------");
            Console.WriteLine("Pleasse Enter Your Age");
            // int age  = Console.ReadLine(); // Error ReadLine -> Always Take Input String
            // int age = (int)Console.ReadLine(); // Explicit Casting -> Invalid
            int age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("Pleasse Enter Your Salary");
            decimal Salary1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");

            Console.Clear();
            Console.WriteLine("Employee Date :");
            Console.WriteLine($"Name is: {name1}");
            Console.WriteLine($"Age is: {age1}");
            Console.WriteLine($"Salary is: {Salary1}");

            #endregion


            #region TryParse
            string number04 = "100";
            bool isParse1 = int.TryParse(number04, out int x01);
            Console.WriteLine("isParse = " + isParse1 + " And X01 = " + x01);

            Console.WriteLine("-------------------------------");
            string number03 = "0";
            bool isParse2 = int.TryParse(number03, out int x02);


            if (isParse2)
            {
                Console.WriteLine("Converted and zero in x from number03"); ;
            }
            else
            {
                Console.WriteLine("Zero in x beacuse can not convert");
            }

            #region ExampleTryParse
            Console.WriteLine("Please Enter Your Name: ");
            string? name02 = Console.ReadLine(); // Read input From User by console
            Console.WriteLine("------------------------");
            Console.WriteLine("Pleasse Enter Your Age");
            // int age  = Console.ReadLine(); // Error ReadLine -> Always Take Input String
            // int age = (int)Console.ReadLine(); // Explicit Casting -> Invalid
            int.TryParse(Console.ReadLine(), out int age02);
            Console.WriteLine("------------------------");
            Console.WriteLine("Pleasse Enter Your Salary");
            decimal.TryParse(Console.ReadLine(), out decimal Salary02);
            Console.WriteLine("------------------------");

            Console.Clear();
            Console.WriteLine("Employee Date :");
            Console.WriteLine($"Name is: {name02}");
            Console.WriteLine($"Age is: {age02}");
            Console.WriteLine($"Salary is: {Salary02}");

            #endregion

            #endregion

            #endregion


            #endregion



            #region Operators

            #region Unary++,--
            // Unary Operator -> one operand 
            // ++ (prefix and postfix)
            //  prefix -> ++x , Postfix --> x++ => x = x + 1
            //int x04 = 5;
            //Console.WriteLine(++x04); // 6
            //Console.WriteLine(x04++); // 6
            //Console.WriteLine(x04); // 7

            //int y04 = 5;
            //Console.WriteLine(--y04); // 4
            //Console.WriteLine(y04--); // 4
            //Console.WriteLine(y04); // 3
            #endregion

            #region Binary | Arithmetic operatos [+,-,*,/,%]

            #endregion

            #region Assignment Operator
            int x05;
            x05 = 6;
            x05 += 3;
            x05 -= 3;
            x05 *= 3;
            x05 %= 3;
            x05 /= 3;

            #endregion

            #region Comparision operator
            int X01 = 10, Y01 = 10;

            Console.WriteLine(X01 == Y01);
            Console.WriteLine(X01 != Y01);
            Console.WriteLine(X01 > Y01);
            Console.WriteLine(X01 < Y01);
            Console.WriteLine(X01 >= Y01);
            Console.WriteLine(X01 <= Y01);
            #endregion

            #region Logical operator[! , && , ||]
            Console.WriteLine(!true);
            Console.WriteLine(true && false);
            Console.WriteLine(true || false);

            Console.WriteLine(4 < 5 && 7 < 9);
            Console.WriteLine(4 < 5 && 7 > 9);
            Console.WriteLine(4 > 5 && 7 < 9);

            #endregion

            #region BitWise Operators [& , | , ^ , ~ , << , >> ]

            // Logical Bitwise Operators (non-short-circuiting)
            Console.WriteLine(false & true);  // False (AND - evaluates both sides)
            Console.WriteLine(true | false); // True  (OR - evaluates both sides)
            Console.WriteLine(false ^ true); // True  (XOR - true when different)

            // Numeric Bitwise Operations
            int X = 5, Y = 3;  // X = 0101 (5), Y = 0011 (3)
            Console.WriteLine(X & Y);  // 1 (0101 & 0011 = 0001) - AND
            Console.WriteLine(X | Y);  // 7 (0101 | 0011 = 0111) - OR
            Console.WriteLine(X ^ Y);  // 6 (0101 ^ 0011 = 0110) - XOR
            Console.WriteLine(~X);     // -6 (Two's complement of 0101)
            Console.WriteLine(X << 1); // 10 (0101 << 1 = 1010) - Left shift
            Console.WriteLine(X >> 1); // 2 (0101 >> 1 = 0010) - Right shift

            #endregion

            #region TernaryOperator
                int n1 = 10, n2 = 20;
                string message = (n1 > n2) ? "true" : "false";
            Console.WriteLine(message);
            #endregion

            #region Operator Precedence

            // Operator precedence determines the order in which operators are evaluated in expressions.

            // From highest to lowest precedence:

            // 1. Postfix:          x++, x--
            // 2. Unary:            ++x, --x, +x, -x, !x, ~x, (type)x
            // 3. Multiplicative:   *, /, %
            // 4. Additive:         +, -
            // 5. Shift:            <<, >>
            // 6. Relational:       <, >, <=, >=, is, as
            // 7. Equality:         ==, !=
            // 8. Logical AND:      &
            // 9. Logical XOR:      ^
            // 10. Logical OR:      |
            // 11. Conditional AND: &&
            // 12. Conditional OR:  ||
            // 13. Null coalescing: ??, ??=
            // 14. Conditional:     ? :
            // 15. Assignment:      =, +=, -=, *=, /=, %=, <<=, >>=, &=, |=, ^=

            #endregion

            #endregion

        }
    }
}