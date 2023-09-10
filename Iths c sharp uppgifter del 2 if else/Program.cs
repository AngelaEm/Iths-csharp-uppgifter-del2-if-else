namespace Iths_c_sharp_uppgifter_del_2_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uppgift 1: Even or odd

            //Console.WriteLine("Write a number:\n");

            //int number = int.Parse(Console.ReadLine());
            //bool isNumberEven = (number % 2 == 0);

            //if (isNumberEven)
            //{
            //    Console.WriteLine($"\n{number} is even.");
            //}
            //else
            //{
            //    Console.WriteLine($"\n{number} is odd.");
            //}






            //    Uppgift 2: Age Bracket

            //Console.WriteLine("How old are you? ");
            //int age = int.Parse(Console.ReadLine());

            //if ((age < 13) && (age > 0))
            //{
            //    Console.WriteLine("You are a child!");
            //}
            //else if ((age >= 13) && (age < 19))
            //{
            //    Console.WriteLine("You are a teenager!");
            //}
            //else if ((age >= 19) && (age < 125))
            //{
            //    Console.WriteLine("You are an adult!");
            //}
            //else
            //{
            //    Console.WriteLine("You are probably not human.");
            //}






            // Uppgift 3. Ask the user to input their test score (0-100)

            //Console.WriteLine("What was your testscore?");
            //int score = int.Parse(Console.ReadLine());

            //if ((score < 60))
            //{
            //    Grade('F');
            //}
            //else if (score <= 69)
            //{
            //    Grade('D');
            //}
            //else if (score <= 79)
            //{
            //    Grade('C');
            //}
            //else if (score <= 89)
            //{
            //    Grade('B');
            //}
            //else if (score <= 100)
            //{
            //    Grade('A');
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input.");
            //}






            //Uppgift 4: Leap Year Checker

            //Console.WriteLine("What year do you want to try?");
            //int year = int.Parse(Console.ReadLine());

            //if (year % 4 == 0)
            //{

            //    if ((year % 100 != 0) || ((year % 100 == 0) && (year % 400 == 0)))
            //    {
            //        Console.WriteLine($"{year} is a leap year.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{year} is not a leap year.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{year} is not a leap year.");
            //}






            // Uppgift 5: Maximum of Three:

            //Console.Write("Write a first number: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Write a second number: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.Write("Write a third number: ");
            //int c = int.Parse(Console.ReadLine());

            //if ((a > b || a == b) && (b > c || b == c))
            //{
            //    Console.WriteLine("Maximum number is " + a);
            //}
            //else if ((b > a || b == a) && (b > c || b == c))
            //{
            //    Console.WriteLine("Maximum number is " + b);
            //}
            //else
            //{
            //    Console.WriteLine("Maximum number is " + c);
            //}





            //Uppgift 6: Positive, Negative, or Zero

            //Console.WriteLine("Input a number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number == 0)
            //{
            //    Console.WriteLine("The number is zero!");
            //}
            //else if (number > 1)
            //{
            //    Console.WriteLine("The number is positive!");
            //}
            //else
            //{
            //    Console.WriteLine("The number is negative!");
            //}




            // Uppgift 7: Discount System:

            //Console.WriteLine("Input the total amount of your purchase here: ");
            //double totalAmount = double.Parse(Console.ReadLine());

            //if (totalAmount >= 1000)
            //{
            //    Console.WriteLine("You get a discuont of 10%!");
            //    double totalAmountAfterDiscount = Discount(totalAmount);
            //    Console.WriteLine($"This is your amount after 10% discount: {totalAmountAfterDiscount} kr.");
            //}
            //else
            //{
            //    Console.WriteLine($"Total amount for you is {totalAmount}. You dont get a discount.");
            //}




            // Uppgift 8: Weekdays:

            //Console.WriteLine("What day of the week is it? Number 1-7");
            //int dayNumber = int.Parse(Console.ReadLine());

            //switch (dayNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Error! Pick a nomber between 1 and 7!");
            //        break;
            //}




            //Uppgift 9: Password Checker:

            //string password = "abc123";

            //Console.WriteLine("Write password: ");
            //string userPassword = Console.ReadLine();

            //if (password == userPassword)
            //{
            //    Console.WriteLine("Acces granted!");
            //}
            //else
            //{
            //    Console.WriteLine("Access denied!");
            //}








            // Uppgift 10: Temperature Converter

            //Console.WriteLine("\nWhat temperature do you want to convert?\n");
            //int temperature = int.Parse(Console.ReadLine());

            //Console.WriteLine("\nDo you want to convert from F to C or from C to F?");
            //Console.WriteLine("\nChoose 1 or 2 from menu:");
            //Console.WriteLine("\n1.From F to C");
            //Console.WriteLine("2.From C to F\n");
            //int userInput = int.Parse(Console.ReadLine());

            //switch (userInput)
            //{
            //    case 1:
            //        double resultFToC = FahrenheitToCelsius(temperature);
            //        Console.WriteLine($"\n{temperature} degrees Fahrenheit is {resultFToC} degrees Celsius.");
            //        break;

            //    case 2:
            //        double resultCToF = CelciusToFahrenheit(temperature);
            //        Console.WriteLine($"\n{temperature} degrees Celsius is {resultCToF} degrees Fahrenheit.");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid number. Press enter and try again.");
            //        break;
            //}


            Console.ReadKey();
        }

        static double CelciusToFahrenheit(double celcius)
        {
            double fahrenheit = ((celcius * 9) / 5) + 32;
            return fahrenheit;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            double celcius = ((fahrenheit - 32) * 5) / 9;
            return celcius;
        }

        static void Grade(char grade)
        {
            Console.WriteLine($"Grade: {grade}");
        }

        static double Discount(double totalAmount)
        {
            double result = totalAmount * 0.9;
            return result;
        }
    }
}