using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_if_else__switch_case__logical_operator_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Selection Statements----");

            /*   Console.WriteLine("Enter Any Number");
               int num = int.Parse(Console.ReadLine());

               if (num >= 5)
               {
                   Console.WriteLine("Num is greater than 5");
               }
               else
               {
                   Console.WriteLine("Num is less than 5");
               }

   */

            /* string name = "admin";
             string password = "12345";
             if (name == "admin")
             {
                 Console.WriteLine("Login Successfully");
             }
             else if (password == "1234")
             {
                 Console.WriteLine("your password is correct");
             }
             else
             {
                 Console.WriteLine("Login Failed");
             }*/

            /*   Console.WriteLine("Enter Your Username");

               string username = Console.ReadLine().ToLower();

               Console.WriteLine("Enter Your Password");

               int password = int.Parse(Console.ReadLine());

               *//* string username = "admin";
                int password = 1234;*//*

               if (username == "admin" && password == 12344)
               {
                   Console.WriteLine("Condition is true");
                   Console.WriteLine(username);

               }
               else
               {
                   Console.WriteLine("Condition is false");
               }*/

            Console.WriteLine("------Switch Case-----");
            /*       int day = 5;

                   switch (day)
                   {
                       case 1:
                           Console.WriteLine("Monday");
                           break;

                      case 2:
                           Console.WriteLine("Tuesday");
                           break;

                      case 3:
                           Console.WriteLine("Wednesday");
                           break;

                       default:
                           Console.WriteLine("Invalid value");
                           break;
                   }*/

            Console.WriteLine("Enter any letter");

        start:
            char vowel = char.Parse(Console.ReadLine());

            switch (vowel)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Its a Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel ");
                    goto start;
            }


            Console.ReadKey();
        }
    }
    }

