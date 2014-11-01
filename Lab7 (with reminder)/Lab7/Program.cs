﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In what month were you born (enter number or word)? ");
            String birthdayMonthString = null;
            int birthdayMonthInt = 0;
            int birthdayDayInt = 0;

            birthdayMonthString = Console.ReadLine();

            try {
                //Converts endered number into string month
                birthdayMonthInt = int.Parse(birthdayMonthString);
                switch (birthdayMonthInt) { 
                    case 1:
                        birthdayMonthString = "January";
                        break;
                    case 2:
                        birthdayMonthString = "February";
                        break;
                    case 3:
                        birthdayMonthString = "March";
                        break;
                    case 4:
                        birthdayMonthString = "April";
                        break;
                    case 5:
                        birthdayMonthString = "May";
                        break;
                    case 6:
                        birthdayMonthString = "June";
                        break;
                    case 7:
                        birthdayMonthString = "July";
                        break;
                    case 8:
                        birthdayMonthString = "August";
                        break;
                    case 9:
                        birthdayMonthString = "September";
                        break;
                    case 10:
                        birthdayMonthString = "October";
                        break;
                    case 11:
                        birthdayMonthString = "November";
                        break;
                    case 12:
                        birthdayMonthString = "December";
                        break;
                }
            }
            catch (Exception e) { 
                //This is if the user entered in a month string, nothing happens - keeps value
                switch (birthdayMonthString.ToLower()){
                    case "january":
                        birthdayMonthInt = 1;
                        break;
                    case "february":
                        birthdayMonthInt = 2;
                        break;
                    case "march":
                        birthdayMonthInt = 3;
                        break;
                    case "april":
                        birthdayMonthInt = 4;
                        break;
                    case "may":
                        birthdayMonthInt = 5;
                        break;
                    case "june":
                        birthdayMonthInt = 6;
                        break;
                    case "july":
                        birthdayMonthInt = 7;
                        break;
                    case "august":
                        birthdayMonthInt = 8;
                        break;
                    case "september":
                        birthdayMonthInt = 9;
                        break;
                    case "october":
                        birthdayMonthInt = 10;
                        break;
                    case "november":
                        birthdayMonthInt = 11;
                        break;
                    case "december":
                        birthdayMonthInt = 12;
                        break;
                }
            }

            Console.WriteLine("On what day were you born? ");
            birthdayDayInt = int.Parse(Console.ReadLine());

            //Displays birthday
            Console.WriteLine("Your birthday is " + birthdayMonthString + " " + birthdayDayInt + " ("+birthdayMonthInt+"/"+birthdayDayInt+").");

            if (birthdayDayInt == 1)
            {
                birthdayDayInt = 31;
                birthdayMonthInt -= 1;

                switch (birthdayMonthInt)
                {
                    case 1:
                        birthdayMonthString = "January";
                        break;
                    case 2:
                        birthdayMonthString = "February";
                        break;
                    case 3:
                        birthdayMonthString = "March";
                        break;
                    case 4:
                        birthdayMonthString = "April";
                        break;
                    case 5:
                        birthdayMonthString = "May";
                        break;
                    case 6:
                        birthdayMonthString = "June";
                        break;
                    case 7:
                        birthdayMonthString = "July";
                        break;
                    case 8:
                        birthdayMonthString = "August";
                        break;
                    case 9:
                        birthdayMonthString = "September";
                        break;
                    case 10:
                        birthdayMonthString = "October";
                        break;
                    case 11:
                        birthdayMonthString = "November";
                        break;
                    case 12:
                        birthdayMonthString = "December";
                        break;
                }

            }
            else{            
                birthdayDayInt--;
            }
            Console.WriteLine("You'll recieve an email reminder on " + birthdayMonthString + " " + birthdayDayInt + " (" + birthdayMonthInt + "/" + birthdayDayInt + ").");



        }
    }
}
