using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Decalaring an array
            // DataType[] nameOfArray = { elements};
            int[] myArray = { 1, 2, 3, 4, 5, 6 };
            string[] students = { "Brad", "Amy", "Jackie", "Ric", "Mike" };
            Console.WriteLine(students[4]);
            Console.WriteLine(students[0]);

            string[] vacaySpots = { "San Diego", "Miami", "Myrtle Beach", "Orlando", "Spain", "Costa Rica", "Hawaii", "Bahamas", "Puru", "Madrid" };
            Console.WriteLine(vacaySpots[0]);
            Console.WriteLine(vacaySpots[9]);
            Console.WriteLine(vacaySpots[vacaySpots.Length -1]);

            int[] childsAges = { 3, 7, 13 };
            Console.WriteLine(childsAges[0]);
            Console.WriteLine(childsAges[1]);
            Console.WriteLine(childsAges[2]);

            //When you DON'T know what the elements are of your array
            //datatype[] nameOfArray = new dataType[numberOfElements];
            //Declaring an array NOT initializing
            //Initializing is when you know the values upfront
            float[] gpa = new float[8];
            gpa[0] = 4.0f;

            char[] peersInitial = { 'A', 'R', 'D', 'K', 'J', };
            Console.WriteLine(peersInitial);

            string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int[] studentsAges = new int[5];
            studentsAges[0] = 15;
            studentsAges[1] = 25;
            studentsAges[2] = 28;
            Console.WriteLine(daysOfTheWeek.Length);
            daysOfTheWeek.SetValue("Funday", 0);
            Console.WriteLine(daysOfTheWeek[0]);
            string[] birthMonths = {"December", "July", "May", "July"};
            Console.WriteLine(Array.IndexOf(birthMonths, "July"));
            //Returns first index of what we are looking for
            Console.WriteLine(Array.LastIndexOf(birthMonths, "July"));
            //Returns last index of what we are looking for

            int[] numbers = { 2, 3, 5, 8, 10, -2, 4, 897, 0 };
            Console.WriteLine(numbers[0]);
            Array.Reverse(numbers);
            Console.WriteLine(numbers[0]);
            Array.Sort(numbers);
            Console.WriteLine(numbers[numbers.Length - 1]);

            string[]  firstNames = new string[4];
            firstNames[0] = "Tyler";
            firstNames[1] = "Kara";
            firstNames[2] = "Sadie";
            firstNames[3] = "Roxy";

            Console.WriteLine(Array.IndexOf(firstNames, "Tyler"));  
            
                      
            //string[] names = { "Tyler", "Kara", "Sadie", "Roxy" };
            //Console.WriteLine(Array.IndexOf(names, "Tyler"));

            int[] luckyNumbers = { 1, 3, 6, 7, 9, 13, 14, 26, 7 };
            Console.WriteLine(Array.LastIndexOf(luckyNumbers, 7));

            char[] alphabetCharacters = { 'C', 'E', 'S', 'T', 'Y' };
            Console.WriteLine(alphabetCharacters[0]);
            Array.Reverse(alphabetCharacters);
            Console.WriteLine(alphabetCharacters[0]);

            string[] randomNames = { "Sally", "Bob", "Joe", "Lucy" };
            Console.WriteLine(randomNames[0]);
            Array.Sort(randomNames);
            Console.WriteLine(randomNames[0]);
            Console.WriteLine(randomNames[3]);

            int[] favoriteNumbers = { 6, 22, 34, 45, 77, 13, 2 };
            Array.Sort(favoriteNumbers);
            Console.WriteLine(favoriteNumbers[0]);
            Console.WriteLine(favoriteNumbers[6]);
            Console.WriteLine(favoriteNumbers[favoriteNumbers.Length - 1]);










        }
    }
}
