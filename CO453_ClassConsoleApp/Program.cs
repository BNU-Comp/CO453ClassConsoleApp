﻿using CO453_ClassConsoleApp.Unit4;
using CO453_ClassConsoleApp.Unit5;
using System;

namespace CO453_ClassConsoleApp
{
    /// <summary>
    /// This class create objects for each of the tasks as
    /// defined in Part A of CO453 and tests that each object
    /// works
    /// 
    /// Objects include: DistanceConverter,  Book
    /// 
    /// Author: Dr Derek Peacock
    /// </summary>
    class Program
    {
        /// <summary>
        /// This method is called first when the program is executed
        /// </summary>
        static void Main(string[] args)
        {
            //TestDistanceConverter();    // T4.1
            //TestBook();                 // T4.2 and T4.3
            //TestTournament();           // T5.1 and 5.3
            //TestSongs();                // T5.2
            //TestMotelBooking();         // T5.6
        }

        /// <summary>
        /// Task 5.6
        /// A simple room booking system
        /// </summary>
        private static void TestMotelBooking()
        {
            BatesMotel motel = new BatesMotel();

            SimpleIO.WriteTitle("The Bates Motel", "Task 5.6");

            string[] choices =
            {
                "1. Book a Room",
                "2. Vacate a Room",
                "3. Display All Rooms",
                "4. Vacate All Rooms",
                "5. Quit"
            };

            int choice = SimpleIO.GetChoice(choices);

            switch (choice)
            {
                case 1:
                    motel.Book(1, 2);
                    break;

                default:
                    break;
            }
        }


        /// <summary>
        /// Task 5.2
        /// </summary>
        private static void TestSongs()
        {
            MP3Chart chart = new MP3Chart();

            chart.ShowSongs();
            chart.GetVotes();
            chart.ShowVotes();
        }

        /// <summary>
        /// Task 5.1
        /// </summary>
        private static void TestTournament()
        {
            Tournament tournament = new Tournament();

            tournament.GetScores();

            tournament.ShowScores();
        }


        /// <summary>
        /// Task 4.2 Create a Book object and test that it writes chapter 1 and 2
        /// Task 4.3 Add a Book Constructor method to initialise all the attributes
        /// </summary>
        private static void TestBook()
        {
            Book book = new Book();

            SimpleIO.WriteTitle("Horror Storey", "Task 4.1");

            book.GetDetails();
            book.WriteChapter1();
        }

        /// <summary>
        /// Task 4.1 Create a Converter and check that it converts between
        /// miles and feet using double numbers
        /// </summary>
        public static void TestDistanceConverter()
        {
            double miles = 1;
            double feet = 0;

            Console.WriteLine("Derek's Distance Converter");

            DistanceConverter converter = new DistanceConverter();

            miles = converter.GetDouble("Miles");
            feet = converter.ToFeet(miles);

            Console.WriteLine("The no of Miles = " + miles);
            Console.WriteLine("The no of feet = " + feet);

            feet = converter.GetDouble("Feet");
            miles = converter.ToMiles(feet);

            Console.WriteLine("The no of feet = " + feet);
            Console.WriteLine("The no of miles = " + miles);

        }

    }
}
