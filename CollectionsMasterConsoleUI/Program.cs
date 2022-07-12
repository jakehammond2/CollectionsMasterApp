using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            Console.WriteLine("Top of terminal!\n");
            int[] myArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(myArray);



            //TODO: Print the first number of the array

            Console.WriteLine($"The first number of the array is {myArray[0]}");

            //TODO: Print the last number of the array            

            Console.WriteLine($"The last number of the array is { myArray[myArray.Length - 1]}\n");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myArray);
            Console.WriteLine("-------------------\n");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

          

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            var myArray2 = myArray;

            ReverseArray(myArray2);

            NumberPrinter(myArray2); 

            Console.WriteLine("-------------------\n");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(myArray);
            NumberPrinter(myArray);

            Console.WriteLine("-------------------\n");

            //TODO: Sort the array in order now

            Array.Sort(myArray);
            
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            NumberPrinter(myArray); 



            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            var myList = new List<int>();

            //TODO: Print the capacity of the list to the console

            Console.WriteLine($"The capacity of the list is{myList.Capacity}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(myList);

            //TODO: Print the new capacity

            Console.WriteLine($"The new capacity of the list after populating it is{myList.Capacity}");

            Console.WriteLine("---------------------\n");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            
            Console.WriteLine("-------------------");


            int randomNumber;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(),out randomNumber))
                {
                    break; 
                }

                Console.WriteLine("Invalid Entry Try Again.");
            }

            NumberChecker(myList, randomNumber); 

            Console.WriteLine("All Numbers in the list:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only in the list!!");
            OddKiller(myList);
            NumberPrinter(myList);
            Console.WriteLine("------------------\n");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens in the list!!");

            myList.Sort();
            NumberPrinter(myList);

            Console.WriteLine("------------------\n");

            //TODO: Convert the list to an array and store that into a variable

            int[] Transformers = myList.ToArray();

            //TODO: Clear the list

            myList.Clear();

            Console.WriteLine("The list has been cleared");


            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%3 ==0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {

            for (int i = 0; i < numberList.Count; i++)
            {

                if (numberList[i]%2 != 0)
                {

                    numberList.Remove(numberList[i]);
                    i--; 
                }

            }

        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (searchNumber == numberList[i])
                {
                    Console.WriteLine("You have a match");
                }
            }

        }

        private static void Populater(List<int> numberList)
        {
           
            Random rng = new Random();

            for (int i = 0; i < 51; i++)
            {
                numberList.Add(rng.Next(0, 50)); 
            }
          
        }


        private static void Populater(int[] numbers)
        {
        Random rng = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 50);
            }

        }

      
        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
