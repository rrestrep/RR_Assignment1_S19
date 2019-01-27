/*
	Author: Rafael Restrepo
	Date: 1/27/2019
	Comments: This C# Assigment 1 - ISM6225 Spring 2019
	*/

using System;

namespace RR_Assignment1_S19

{
    class Program
    {
        public static void Main()

        {

            //****************************************************************************************************************************************************
            //*******************************************************    Excercise 1        **********************************************************************
            //****************************************************************************************************************************************************
            //****************************************************************************************************************************************************

            //This method prints all the prime numbers between x and y
            //*For example 5, 25 will print all the prime numbers between 5 and 25


            // Printing a Owner and Assigment 
            Console.WriteLine("Rafael Restrepo | Assigment 1 - ISM6225 Spring 2019");
            Console.WriteLine("");
            Console.WriteLine("");

            // Printing a message that will indicate what the program is doing and an Additional line  before requesting input

            Console.WriteLine("Excersice 1: This method prints all the prime numbers between two Numbers (x and y):");




            try // Beggining of Try Catch 
            {

                // Request User to enter First Number
                Console.Write("Input Numeber 1 (X):  ");

                //Set first Varaible as an Integer name "first_value" ---  we convert this  to an INT32 that is equivalent to the number in Value or 0 (ZERO) if Value is NUll
                int first_value = Convert.ToInt32(Console.ReadLine());

                // Request User to enter Second Number
                Console.Write("Input eNumber 2 (Y):  ");

                //Set first Varaible as an Integer name "last_value" ---  we convert this  to an INT32 that is equivalent to the number in Value or 0 (ZERO) if Value is NUll
                int last_value = Convert.ToInt32(Console.ReadLine());

                //Additional lines  before Producing OUtput


                Console.Write("ANSWER: The prime numbers between {0} and {1} are : ", first_value, last_value);


                //Set Variables to run in the for loops 
                int num;  // Variable will Start at the first Numner until the last Numert and will add 1 to the loop
                int ctr;  // Varaible Will set a counter for the value of  the Second for loop that will calculate the integers
                int i;    // internal for loop maintain value integers till  the end number

                //for Loop  Initial Number  to the last Numers  and Counter by 1
                for (num = first_value; num <= last_value; num++)
                {

                    //Return Counter
                    ctr = 0;

                    // for Lopp  
                    for (i = 2; i <= num / 2; i++)
                    {

                        // If expression look: % is a boolean expression that checks whether number  of the variable i is equivalent to 0.
                        if (num % i == 0)
                        {
                            //Varielbe  that returns to the next loop
                            ctr++;
                            break;
                        }
                    }

                    // if statments compare of counter equals 0 and checks if the mumber is not 1  and write the nober in memory
                    if (ctr == 0 && num != 1)
                        Console.Write("{0} ", num);

                }

            }//End Try 

            catch
            {
                Console.WriteLine("PLase Enter an Integer");
            }



            // write your self-reflection here as a comment:
            //Ithought this was going to be easier - it took me about 4 hours to get the number 1
            // Instructions doesn’t make sense.  Have to google to obtain a method that works -


            //****************************************************************************************************************************************************
            //*******************************************************    Excercise 2        **********************************************************************
            //****************************************************************************************************************************************************
            //****************************************************************************************************************************************************




            //This method computes the series 1/2 – 2!/3 + 3!/4 – 4!/5 --- n     * where ! means factorial, i.e., 4! = 4*3*2*1 = 24. Round off the results to three decimal places

            try   // Beggining of Try Catch 
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Excersice 2: This method computes the series 1/2 – 2!/3 + 3!/4 – 4!/5 --- n     * where ! means factorial, i.e., 4! = 4*3*2*1 = 24. Round off the results to");
                Console.WriteLine("three decimal places. ");
                //Request the USer to enter a number to be factored
                Console.Write("Input Numeber to be factored:  ");

                //Assign the USer entry to a Double Variable name n
                double Number_to_be_factored = double.Parse(Console.ReadLine());

                // "dDeclare a variable double  name factorial and set the value at 1
                double factorial = 1;


                // Pperform a while loop while is true"
                while (true)
                {
                    if (Number_to_be_factored <= 1)
                    {
                        break;
                    }

                    //formula that keep calculating the factorial until the while loop is completed
                    factorial *= Number_to_be_factored;
                    Number_to_be_factored--;
                }

                //Write output  and convert  output with 3 decimals
                Console.WriteLine("Result of Computation = " + (Math.Round(Convert.ToDecimal(factorial), 3)));

            }//End Try
            catch
            {
                Console.WriteLine("PLase Enter an Integer Numner or a number with decimals");
            }


            //****************************************************************************************************************************************************
            //*******************************************************    Excercise 3        **********************************************************************
            //****************************************************************************************************************************************************
            //****************************************************************************************************************************************************

            //This method converts a number from decimal (base 10) to binary (base 2).



            try  // Beggining of Try Catch 
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Excersice 3: This method converts a number from decimal (base 10) to binary (base 2).");

                //Initializing Variables
                int n1;
                int[] r2 = new int[10];

                //Requesting User Input Number to convert
                Console.Write("Enter an Intger Numner to convert to base 2: ");
                n1 = int.Parse(Console.ReadLine());

                //for Loop to perform conversion
                int i;
                for (i = 0; n1 > 0; i++)
                {
                    r2[i] = n1 % 2;
                    n1 = n1 / 2;
                }


                Console.Write("Binary of the given number= ");
                for (i = i - 1; i >= 0; i--)
                {

                    //Output
                    Console.Write(r2[i]);

                }


            }//End Try
            catch
            {
                Console.WriteLine("PLase Enter an Integer Numner or a number with decimals");
            }



            //****************************************************************************************************************************************************
            //*******************************************************    Excercise 4        **********************************************************************
            //****************************************************************************************************************************************************
            //****************************************************************************************************************************************************

            //This method converts a number from binary (base 2) to decimal (base 10).



            try  // Beggining of Try Catch 
            {


                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Excersice 4: This method converts a number from binary (base 2) to decimal (base 10)");


                //Initializing Variables
                int num;

                //Requesting User Input Number to convert
                Console.Write("Enter a Binary Number(1s and 0s) to copnver to base 10 : ");
                num = int.Parse(Console.ReadLine());

                //ZDeclaring Varialbes to use on the while loop
                int binary_val, decimal_val = 0, base_val = 1, rem;
                binary_val = num;
                while (num > 0)
                {
                    rem = num % 10;
                    decimal_val = decimal_val + rem * base_val;
                    num = num / 10;
                    base_val = base_val * 2;
                }
                //Output
                Console.Write("The Binary Number is : " + binary_val);
                Console.Write("\nIts Decimal Equivalent is : " + decimal_val);
                Console.ReadLine();



            }//End Try
            catch
            {
                Console.WriteLine("PLase Enter an Integer Numner or a number with decimals");
            }



            //****************************************************************************************************************************************************
            //*******************************************************    Excercise 5        **********************************************************************
            //****************************************************************************************************************************************************
            //****************************************************************************************************************************************************

            //This method prints a triangle using *




            try  // Beggining of Try Catch 
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Excersice 5: This method prints an Ipnput number to a a triangle using *");



                Console.Write("Input Numeber to cobert to a Paramid of * :  ");
                int numberoflayer = int.Parse(Console.ReadLine());

                Console.WriteLine("Print paramid");

                //for loop to perfomr operation
                int Space, Number;
                for (int i = 1; i <= numberoflayer; i++) // Total number of layer for pramid  
                {
                    for (Space = 1; Space <= (numberoflayer - i); Space++) // Loop For Space  
                        Console.Write(" ");
                    for (Number = 1; Number <= i; Number++) //increase the value  
                        Console.Write('*');
                    for (Number = (i - 1); Number >= 1; Number--) //decrease the value  
                        Console.Write('*');
                    Console.WriteLine();
                }



            }//End Try
            catch
            {
                Console.WriteLine("PLase Enter an Integer Numner or a number with decimals");
            }



            //****************************************************************************************************************************************************
            //*******************************************************    Excercise 6        **********************************************************************
            //****************************************************************************************************************************************************
            //****************************************************************************************************************************************************


            //This method computes the frequency of each element in the array
            //*For example a = { 1, 2, 3, 2, 2, 1, 3, 2 } will display the output as: 


            try  // Beggining of Try Catch 
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Excersice 6: This method computes the frequency of each element in the array");


                //Initialize array   
                int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };


                //Array fr will store frequencies of element  
                int[] fr = new int[arr.Length];
                int visited = -1;

                for (int i = 0; i < arr.Length; i++)
                {
                    int count = 1;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                            //To avoid counting same element again  
                            fr[j] = visited;
                        }
                    }
                    if (fr[i] != visited)
                        fr[i] = count;
                }

                //Displays the frequency of each element present in array  

                Console.WriteLine(new int());
                Console.WriteLine("---------------------");
                Console.WriteLine(" Number  | Frequency");
                Console.WriteLine("---------------------");
                for (int i = 0; i < fr.Length; i++)
                {
                    if (fr[i] != visited)
                        Console.WriteLine("    " + arr[i] + "    |    " + fr[i]);

                }
                Console.WriteLine("---------------------");


            }//End Try
            catch
            {
                Console.WriteLine("PLase Enter an Integer Numner or a number with decimals");
            }

            Console.WriteLine("");
            Console.WriteLine("//Self Refelction: This assignment took way longer than I expected, I been working for 30 years on Business Analytics and its the first time I been programming on C# - not sure if the expectation was for students to learn all C# concepts in 3 weeks. I think I will get better on this with time. (hopefully) - ");
            Console.WriteLine("");
            Console.WriteLine("Press any Key to end");
            Console.ReadKey(true);


        }


    }
}