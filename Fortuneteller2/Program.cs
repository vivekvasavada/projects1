using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuneteller2
{
    class Program
    {
        // private static readonly bool agemsg;

        //string agemsg = null;

        static void Main(string[] args)
        
            
         {
           
            {
                
                // enter user input
                Console.WriteLine("Enter your First Name");
                string FirstName = (Console.ReadLine());

                Console.WriteLine("Enter your Last Name");
                string LastName = (Console.ReadLine());

                Console.WriteLine("Enter your Age");
                int age = int.Parse(Console.ReadLine());


                //input odd or even age condition
                if (age % 2 == 0)

                {
                    string agemsg = ("You will retire in 10 years");
                    string retireage =( "10");
                    Console.WriteLine(agemsg);

                }
                else
                {
                    string agemsg = ("You will retire in 15 years");
                    Console.WriteLine(agemsg);

                }
                //begin of birthmonth logic*******
                Console.WriteLine("Enter the number of your Birth Month");
                int birthMonth = int.Parse(Console.ReadLine());


                if (birthMonth == 1 || birthMonth <= 4)
                {
                    string bankmsg = ("you have 10,0000 dollars in the bank");
                    Console.WriteLine(bankmsg);
                }
                else if (birthMonth >= 5 && birthMonth <= 8)

                {
                    string bankmsg = ("you have 20,000 dollars in the bank");
                    Console.WriteLine(bankmsg);

                }
                else if (birthMonth >= 9 && birthMonth <= 12)
                {
                    string bankmsg = ("you have 30,000 dollars in the bank");
                    Console.WriteLine(bankmsg);
                }
                else
                {
                    string bankmsg = ("you have zero dollars in the bank");
                    Console.WriteLine(bankmsg);
                }
                //begininng of siblings
                Console.WriteLine("How many sibilings do you have");
                int siblingsNumber = int.Parse(Console.ReadLine());


                if (siblingsNumber == 0)
                {
                    string siblingmsg = ("You will have a vacation home in California");
                    Console.WriteLine(siblingmsg);
                }
                else if (siblingsNumber == 1)
                {
                    string siblingmsg = ("You will have a vacation home in Florida");
                    Console.WriteLine(siblingmsg);
                }
                else if (siblingsNumber == 2)
                {
                    string siblingmsg = ("You will have a vacation home in Las Vegas");
                    Console.WriteLine(siblingmsg);
                }
                else if (siblingsNumber == 3)
                {
                    string siblingmsg = ("You will have a vacation home in Reno");
                    Console.WriteLine(siblingmsg);
                }

                else if (siblingsNumber >= 4)
                {
                    string siblingmsg = ("You will have a vacation home in Carson City");
                    Console.WriteLine(siblingmsg);

                }

                else
                {
                    string siblingsmsg = ("bad vacation home");
                    Console.WriteLine(siblingsmsg);
                }
                //end of sibling********
                //end of birthmonthlogic **********

                {
                    //begin transportation****
                    Console.WriteLine("What is your favorite ROYGBIV Color or key help for list of colors");
                    string roygbivColor = (Console.ReadLine().ToUpper());
                    string transmsg = null;
                    switch (roygbivColor)
                    {

                        case "RED":
                            transmsg = "car";
                            Console.WriteLine(transmsg);
                            break;



                        case "ORANGE":
                            transmsg = "train";
                            Console.WriteLine(transmsg);
                            break;



                        case "YELLOW":
                            transmsg = "boat";
                            Console.WriteLine(transmsg);
                            break;

                        case "BLUE":
                            transmsg = "jet";
                            Console.WriteLine(transmsg);
                            break;

                        case "GREEN":
                            transmsg = "motorcycle";
                            Console.WriteLine(transmsg);
                            break;

                        case "VIOLET":
                            transmsg = "bike";
                            Console.WriteLine(transmsg);
                            break;

                        case "INDIGO":
                            transmsg = "scooter";
                            Console.WriteLine(transmsg);
                            break;

                        case "HELP":
                            Console.WriteLine("red,orange,yellow,green,blue,indigo,violet");
                            break;
                            // End transportation logic******
                    }
                    

                     Console.WriteLine(FirstName +" "+ LastName +" "+ age);
                }

            }

               
        }

    }

}
    

