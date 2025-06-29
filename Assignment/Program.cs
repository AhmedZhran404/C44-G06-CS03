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

            Console.WriteLine("Result Is: " + num1 * num2);   //  25.3388712
                                                              //----------------------------------------
            float number1 = 4.56f;
            float number2 = 5.55677f;

            Console.WriteLine("Result Is: " + number1 * number2); // 25.338871


            /*
             he result is slightly different because float has lower precision than double.
                double gives a more accurate result with more digits after the decimal point.
             */

            #endregion


            #region Question4

            /*
                Write C# program that Extract a substring from a 
                given string. 
             */

            Console.Write("Enter You Text: ");
            string text = Console.ReadLine();

            Console.Write("From which position do you want to start cutting the text? ");
            bool isParse = int.TryParse(Console.ReadLine(), out int index);

            if (isParse && index < text.Length)
            {
                Console.WriteLine(text.Substring(index));
            }
            else
            {
                Console.WriteLine("The index you entered is incorrect");
            }


            #endregion


            #region Question5

            /*
              Write C# program that Assigning one value type 
              variable to another and modifying the value of one 
              variable and mention what will happen 
             */
            int numberOne = 5; // value Type Store In Stack

            int numberTwo = 20; // value Type Store In Stack

            numberOne = numberTwo;

            Console.WriteLine($"numberOne => {numberOne}"); // 20
            Console.WriteLine($"numberTwo => {numberTwo}"); // 20
            numberOne += 4;
            Console.WriteLine($"numberOne => {numberOne}"); // 24
            Console.WriteLine($"numberTwo => {numberTwo}"); // 20 

            // What Happen :
            /*
            1) When numberOne = numberTwo; is executed, the value of numberTwo (which is 20) is copied into numberOne.
              Both variables now hold the same value, but they are still independent.

             2) When numberOne is increased by 4, it becomes 24, 
                while numberTwo remains unchanged 
                because value types are stored separately in memory.
             */
            #endregion


            #region Question6

            /*
              Write C# program that Assigning one reference type 
              variable to another and modifying the object through 
              one variable and mention what will happen 
            */

            Point P1 = new Point() { x = 1, y = 2 };
            Point P2 = new Point() { x = 1, y = 2 };

            Console.WriteLine($"Object One P1 is :x -> {P1.x} , y -> {P1.y}"); // 1 , 2
            Console.WriteLine($"Object Two P2 is :x -> {P2.x} , y -> {P2.y}"); // 1 , 2

            P1.x = 20;
            P2.x = 30;

            Console.WriteLine($"P1.x => {P1.x}"); // 20
            Console.WriteLine($"P2.x => {P2.x}"); // 30

            P1 = P2;

            P2.x = 40;

            Console.WriteLine($"P1.x ==> {P1.x}"); // 40
            Console.WriteLine($"P2.x ==> {P2.x}"); // 40

            // What happen
            /*
             * When P1 = P2; is executed, both P1 and P2 now reference the same object in memory,
             * because Point is a reference type (class).
             * So when P2.x is changed to 40, P1.x also reflects that change since both variables point to the same object.
             */
            #endregion


            #region Question7

            /*
               Write C# program that take two string variables and 
               print them as one variable 
            */

            Console.Write("Enter Your Text One: ");
            string textOne = Console.ReadLine();

            Console.Write("Enter Your Text two: ");
            string textTwo = Console.ReadLine();

            string margeTwoText = $"{textOne} {textTwo}";

            Console.WriteLine($"margeTwoText => {margeTwoText}");

            #endregion



            #region Question8

            /*
              Write a program that calculates the simple interest 
              given the principal amount, rate of interest, and 
              time. The formula for simple interest is  
              Interest = (principal * rate * time ) /100.
             */

            Console.Write("Enter Your principal Amount: ");
            bool isParse01 = double.TryParse(Console.ReadLine(), out double principal);

            Console.Write("Enter your rate of interest (%): ");
            bool isParse02 = double.TryParse(Console.ReadLine(), out double rate);

            Console.Write("Enter Your Time(in years): ");
            bool isParse03 = double.TryParse(Console.ReadLine(), out double Time);

            Console.WriteLine("----------------------------------");

            if (isParse01 && isParse02 && isParse03)
            {

                double interest = (principal * rate * Time) / 100;
                Console.WriteLine($"the simple interest {interest}");

            }
            else
            {
                Console.WriteLine("One or more of the numbers you entered are not valid.");
            }



            #endregion

            #region Question9

            /*
              Write a program that calculates the Body Mass Index 
              (BMI) given a person's weight in kilograms and height 
              in meters. The formula for BMI is 
              BMI = (Weight)/(Height*Height) 
             */

            Console.Write("Enter Your Weight: ");
            bool isParse04 = float.TryParse(Console.ReadLine(), out float weight);
            Console.Write("Enter Your height: ");
            bool isParse05 = float.TryParse(Console.ReadLine(), out float height);

            Console.WriteLine("-------------------------------");

            if (isParse04 && isParse05)
            {
                float bodyMassIndex = (weight) / (height * height);
                Console.WriteLine($"bodyMassIndex(BMI) is: {bodyMassIndex}");
            }
            else
            {
                Console.WriteLine("One or more of the numbers you entered are not valid.");
            }


            #endregion


            #region Question10

            /*
             Write a program that uses the ternary operator to 
             check if the temperature is too hot, too cold, or 
             just good. Assign the result in a variable then 
             display the result. Assume that below 10 degrees is 
             "Just Cold", above 30 degrees is "Just Hot", and 
             anything else is "Just Good". 
             */

            Console.Write("Enter the temperature: ");
            bool isParse06 = float.TryParse(Console.ReadLine(), out float temperture);

            if (isParse06)
            {
                string result = (temperture < 10) ? "Just Cold" : (temperture > 30) ? "Just Hot" : "Just Good";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("The number of tempoerture is incorrect");
            }

            #endregion

            #region Question11

            /*
                Write a program that takes the date from the user 
                and displays it in various formats using string 
                interpolation. 
                Ex : 
                Today’s date : 20 , 11 , 2001 
                Today's date : 20 / 11 / 2001 
                Today's date : 20 – 11 – 2001 
             */


            Console.WriteLine("---------------- Enter today's date ----------------");
            Console.Write("Enter Day: ");
            bool isConverted01 = int.TryParse(Console.ReadLine() , out int day);
            Console.Write("Enter Month: ");
            bool isConverted02 = int.TryParse(Console.ReadLine(), out int month);
            Console.Write("Enter year: ");
            bool isConverted03 = int.TryParse(Console.ReadLine(), out int year);

            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine($"Today’s date : {day} , {month} , {year} ");
            Console.WriteLine($"Today’s date : {day} / {month} / {year} ");
            Console.WriteLine($"Today’s date : {day} - {month} - {year} ");



            #endregion
        }
    }
}
