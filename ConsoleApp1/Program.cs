using System;
using System.ComponentModel;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        static int sum(int x ,int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {

            // ************************************** Assignment_3_C# ********************************************** //

            #region Question one
            ////1- Write a program that takes a number from the user then print yes if that number
            ////can be divided by 3 and 4 otherwise print no.

            //// Ask the user to enter a number
            //Console.WriteLine("Enter a number: ");
            //int number;

            //// Read the number and ensure it's a valid integer
            //if (int.TryParse(Console.ReadLine(), out number))
            //{
            //    // Check if the number is divisible by both 3 and 4
            //    if (number % 3 == 0 && number % 4 == 0)
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No");
            //    }
            //}
            //else
            //{
            //    // Input validation for non-numeric entries
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}


            #endregion

            #region Question two

            ////2 - Write a program that allows the user to insert an integer then print negative
            ////if it is negative number otherwise print positive.


            //// Prompt the user to enter an integer
            //Console.WriteLine("Enter an integer: ");
            //int number;

            //// Read and validate the input
            //if (int.TryParse(Console.ReadLine(), out number))
            //{
            //    // Check if the number is negative or positive
            //    if (number < 0)
            //    {
            //        Console.WriteLine("Negative");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Positive");
            //    }
            //}
            //else
            //{
            //    // Error message for invalid input
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}


            #endregion

            #region Question Three
            ////3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            //// Prompt the user to enter three integers
            //Console.WriteLine("Enter the first integer: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second integer: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the third integer: ");
            //int num3 = int.Parse(Console.ReadLine());

            //// Find the maximum value
            //int max = Math.Max(num1, Math.Max(num2, num3));

            //// Find the minimum value
            //int min = Math.Min(num1, Math.Min(num2, num3));

            //// Print the results
            //Console.WriteLine($"The maximum value is: {max}");
            //Console.WriteLine($"The minimum value is: {min}");
            #endregion

            #region Question four

            ////4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //// Prompt the user to enter an integer
            //Console.WriteLine("Enter an integer: ");
            //int number;

            //// Validate and parse the input
            //if (int.TryParse(Console.ReadLine(), out number))
            //{
            //    // Check if the number is even or odd
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine("The number is Even.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number is Odd.");
            //    }
            //}
            //else
            //{
            //    // Error message for invalid input
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            #endregion

            #region Question five

            ////5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u)
            ////then print (vowel) otherwise print (consonant).

            //Console.WriteLine("Enter a character: ");
            //char inputChar;

            //// Read input and ensure it's a valid single character
            //if (char.TryParse(Console.ReadLine(), out inputChar))
            //{
            //    // Convert the character to lowercase for easier comparison
            //    char lowerChar = char.ToLower(inputChar);

            //    // Check if the character is a vowel
            //    if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
            //    {
            //        Console.WriteLine("Vowel");
            //    }
            //    else if (char.IsLetter(inputChar))
            //    {
            //        // If it's a letter but not a vowel, it's a consonant
            //        Console.WriteLine("Consonant");
            //    }
            //    else
            //    {
            //        // If the input is not a letter
            //        Console.WriteLine("Invalid input. Please enter a letter.");
            //    }
            //}
            //else
            //{
            //    // Handle invalid input
            //    Console.WriteLine("Invalid input. Please enter a single character.");
            //}
            #endregion

            #region Question six
            ////7- Write a program that allows the user to insert an integer then 
            ////print a multiplication table up to 12.

            //// Prompt the user to enter an integer
            //Console.WriteLine("Enter an integer to display its multiplication table: ");
            //int number;

            //// Validate the input
            //if (int.TryParse(Console.ReadLine(), out number))
            //{
            //    Console.WriteLine($"\nMultiplication table for {number} up to 12:\n");

            //    // Loop to print the multiplication table up to 12
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.WriteLine($"{number} x {i} = {number * i}");
            //    }
            //}
            //else
            //{
            //    // Error message for invalid input
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}
            #endregion

            #region  Question seven


            ////9 - Write a program that takes two integers then prints the power.
            //// Prompt the user to enter the base number
            //Console.WriteLine("Enter the base number: ");
            //double baseNumber;

            //// Prompt the user to enter the exponent
            //Console.WriteLine("Enter the exponent: ");
            //double exponent;

            //// Validate inputs
            //if (double.TryParse(Console.ReadLine(), out baseNumber) && double.TryParse(Console.ReadLine(), out exponent))
            //{
            //    // Calculate the power using Math.Pow
            //    double result = Math.Pow(baseNumber, exponent);

            //    // Display the result
            //    Console.WriteLine($"{baseNumber} raised to the power of {exponent} is: {result}");
            //}
            //else
            //{
            //    // Handle invalid input
            //    Console.WriteLine("Invalid input. Please enter valid numbers.");
            //}
            #endregion

            #region Question eight

            ////10- Write a program to enter marks of five subjects and calculate total, average and percentage.

            //// Variables to store marks
            //int subject1, subject2, subject3, subject4, subject5;
            //int totalMarks;
            //double average, percentage;

            //// Input marks for five subjects
            //Console.WriteLine("Enter marks for Subject 1: ");
            //subject1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter marks for Subject 2: ");
            //subject2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter marks for Subject 3: ");
            //subject3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter marks for Subject 4: ");
            //subject4 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter marks for Subject 5: ");
            //subject5 = int.Parse(Console.ReadLine());

            //// Calculate total marks
            //totalMarks = subject1 + subject2 + subject3 + subject4 + subject5;

            //// Calculate average
            //average = totalMarks / 5.0;

            //// Assume the maximum marks for each subject is 100
            //percentage = (totalMarks / 500.0) * 100;

            //// Display results
            //Console.WriteLine($"\nTotal Marks: {totalMarks}");
            //Console.WriteLine($"Average Marks: {average}");
            //Console.WriteLine($"Percentage: {percentage}%");
            #endregion


            #region Question nine
            //// 11- Write a program to input the month number and print the number of days in that month.

            //// Prompt the user to enter the month number
            //Console.WriteLine("Enter the month number (1-12): ");
            //int month;

            //// Validate the input
            //if (int.TryParse(Console.ReadLine(), out month))
            //{
            //    // Check month and print the number of days
            //    switch (month)
            //    {
            //        case 1:  // January
            //        case 3:  // March
            //        case 5:  // May
            //        case 7:  // July
            //        case 8:  // August
            //        case 10: // October
            //        case 12: // December
            //            Console.WriteLine("The month has 31 days.");
            //            break;

            //        case 4:  // April
            //        case 6:  // June
            //        case 9:  // September
            //        case 11: // November
            //            Console.WriteLine("The month has 30 days.");
            //            break;

            //        case 2:  // February
            //            Console.WriteLine("The month has 28 days (29 days in a leap year).");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}
            #endregion

            #region Question ten
            ////17 - Create a program that asks the user to input three points(x1, y1), (x2, y2), and(x3, y3),
            ////and determines whether these points lie on a single straight line.


            //// Ask the user to input the coordinates for the three points
            //Console.WriteLine("Enter the coordinates of the first point (x1, y1): ");
            //double x1 = double.Parse(Console.ReadLine());
            //double y1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the coordinates of the second point (x2, y2): ");
            //double x2 = double.Parse(Console.ReadLine());
            //double y2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the coordinates of the third point (x3, y3): ");
            //double x3 = double.Parse(Console.ReadLine());
            //double y3 = double.Parse(Console.ReadLine());

            //// Check if the points are collinear (lie on a straight line)
            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("The points are collinear (lie on a straight line).");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a straight line.");
            //}
            #endregion

            #region  Question eleven
            //// 18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            ////-If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            ////- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            ////- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            ////- If the worker takes more than 5 hours, they are required to leave the company.
            ////To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.


            //// Ask the user to enter the time taken for the task
            //Console.WriteLine("Enter the time taken (in hours) to complete the task: ");

            //double timeTaken;

            //// Validate the input to ensure it is a valid number
            //if (double.TryParse(Console.ReadLine(), out timeTaken))
            //{
            //    // Evaluate the efficiency based on the time taken
            //    if (timeTaken >= 2 && timeTaken <= 3)
            //    {
            //        Console.WriteLine("Highly efficient worker.");
            //    }
            //    else if (timeTaken > 3 && timeTaken <= 4)
            //    {
            //        Console.WriteLine("Worker needs to increase their speed.");
            //    }
            //    else if (timeTaken > 4 && timeTaken <= 5)
            //    {
            //        Console.WriteLine("Worker needs training to enhance their speed.");
            //    }
            //    else if (timeTaken > 5)
            //    {
            //        Console.WriteLine("Worker is required to leave the company.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Time should be greater than or equal to 0.");
            //    }
            //}
            //else
            //{
            //    // Handle invalid input (not a valid number)
            //    Console.WriteLine("Invalid input. Please enter a valid number for time.");
            //}

            #endregion

            #region  Question twelve

            ////Write C# program that Assigning one value type variable to another and
            ////modifying the value of one variable and mention what will happen

            //// Declare and initialize a value type variable (int)
            //int number1 = 10;
            //Console.WriteLine("Initial value of number1: " + number1);

            //// Assign number1 to number2
            //int number2 = number1;
            //Console.WriteLine("Initial value of number2 (after assignment): " + number2);

            //// Modify number2
            //number2 = 20;
            //Console.WriteLine("Modified value of number2: " + number2);

            //// Display number1 again to see if it changed
            //Console.WriteLine("Value of number1 after modifying number2: " + number1);


            #endregion

            #region Question thirteen

            ////Write C# program that Assigning one reference type variable to another and
            ////modifying the object through one variable and mention what will happen


            //// Create a new Person object and initialize it
            //person person1 = new person { Name = "Alice", Age = 30 };
            //Console.WriteLine("Initial person1 details:");
            //Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}");

            //// Assign person1 to person2
            //person person2 = person1;
            //Console.WriteLine("\nperson2 details (after assignment from person1):");
            //Console.WriteLine($"Name: {person2.Name}, Age: {person2.Age}");

            //// Modify the object through person2
            //person2.Name = "Bob";
            //person2.Age = 25;
            //Console.WriteLine("\nperson2 details (after modification through person2):");
            //Console.WriteLine($"Name: {person2.Name}, Age: {person2.Age}");

            //// Display person1 details to see the effect
            //Console.WriteLine("\nperson1 details (after modification through person2):");
            //Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}");
            #endregion

            #region Question fourteen
            //Which of the following statements is correct about the C#.NET code snippet given below?
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //             Answer:


            //A value 1 will be assigned to d.

            #endregion


            #region Question fivteen
            //Which of the following is the correct output for the C# code given below?

            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            // 6 1

            #endregion

            #region Question sixteen
            //What will be the output of the C# code given below?

            //int num = 1, z = 5;


            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);


            //      Answer:
            // 7 7
            #endregion


            // ****************************************** Demo_Session_3_c# ********************************************//

            #region Value Type Casting

            #region  Implict Casting- Safe Casting

            //int x = 4;  // 4 byte
            //long y = x;
            #endregion

            #region Explist  Casting- Unsafe casting
            //long x = 101010101000000;
            //int y = (int)x;

            //checked
            //{
            //    y = (int)x;
            //}
            //unchecked
            //{
            //    int z = (int)x;
            //}
            //Console.WriteLine(y);


            #endregion


            #region Parse [convert from string to any datatybe]

            ////int number = int.Parse(Console.ReadLine(x));

            //Console.WriteLine("Enter Data yser");
            //Console.Write("Enter Name : ");
            //String Name = Console.ReadLine();

            //Console.Write("Enter Age :");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your Salary");
            //double salary=double.Parse(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("Name : " + Name + "Age : " + age + " Salary : " + salary);
            #endregion

            #region convert [convert from any datatybe to any datatype]
            Console.WriteLine("Enter Data yser");
            Console.Write("Enter Name : ");
            String Name = Console.ReadLine();

            Console.Write("Enter Age :");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Salary");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Name : " + Name + "Age : " + age + " Salary : " + salary);
            #endregion



            #endregion

            #region Logical OPerator
            //Console.WriteLine(!true);


            Console.WriteLine(true && false);
            //true && false=>false
            //true && true=>true
            //false && true=>false
            //false && false=>false


            //true || false=>true
            //true || true=>true
            //false || true=>true
            //false || false=>false


            //true & false=>false
            //true & true=>true
            //false & true=>false
            //false & false=>false



            //true | false=>false
            //true | true=>true
            //false | true=>false
            //false | false=>false



            #endregion

            #region oerator periority
            /*
             * 1. unary operator[prefix] ++a
             * 2.()
             * 3. * / %
             * + -
             */

            //int a = 20;
            //int b = 15;
            //int c = 10;
            //int d = 5;

            //int result;

            //result = a++ * c;

            #endregion

            #region String Formating
            //// Equation = x+y=result
            //// Equation =10+5=15

            int x = 5;
            int y = 10;
            int result = x + y;

            //Console.WriteLine("Equation :" + x + "+" + y + "=" + result);
            //// String => Imutable Datatype

            //string name = "ahmed";
            //name = "ali";
            #endregion

            #region 1.Composite Formate
            //string message=string.Format("Equation = {0} + {1} = {2}" ,x,y,result);
            //Console.WriteLine(message);
            //Console.WriteLine("Equation = {0} + {1} = {2}", x, y, result);
            #endregion

            #region 2. string manipolation
            //// string interpolation
            //Console.WriteLine($"Equation = {x} + {y} = {result}");
            #endregion


            #region if else - switch case
            //Console.WriteLine("Enter Mounth Number");
            //int MounthNumber = int.Parse(Console.ReadLine());

            // 1 =>month is jan
            // 2 =>month is feb
            // 3 =>month is mar
            // invalid input
            //if (MounthNumber == 1)
            //{
            //    Console.WriteLine("month is jan");
            //}
            //else if (MounthNumber == 2)
            //{
            //    Console.WriteLine("month is feb");
            //}
            //else if (MounthNumber == 3)
            //{
            //    Console.WriteLine("month is mar");
            //}

            //else { Console.WriteLine("invalid input"); }


            //switch(MounthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("month is jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("month is feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("month is mar");
            //        break;
            //}


            #endregion

            #region Goto
            //Console.WriteLine(" Enter OPtion");
            ////3000 => "option 01", "option 02" , "option 03"
            ////2000 => "option 01", "option 02"
            //// 1000 => "option 01"

            //int option =int.Parse(Console.ReadLine());


            //switch (option)
            //{
            //    case 3000:
            //        Console.WriteLine("option 03");
            //        //Console.WriteLine("option 02");
            //        //Console.WriteLine("option 01");
            //        goto case 2000;
            //        break;
            //    case 2000:

            //        Console.WriteLine("option 02");
            //        //Console.WriteLine("option 01");
            //        goto case 1000;
            //        break;
            //    case 1000:


            //        Console.WriteLine("option 01");
            //        break;

            //}
            #endregion

            #region Evaluation in switch case

            // go to medium website
            #endregion




        }
    }
}
