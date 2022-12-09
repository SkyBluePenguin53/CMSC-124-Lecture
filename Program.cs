using System;
using System.Collections.Generic;

/*******************************************************************
                        EXPLORATION OF C#
                        
                Created by: Ron Gerlan F. Naragdao
                        December 9, 2022
*******************************************************************/


/*******************************************************************
When using Visual Code Studio, type dotnet run in console to run C#.
*******************************************************************/

namespace Csharp
{
    class Program
    {
        // enum is used if items are sure to be existing
        enum Subprograms
        {
            DataTypes,
            ActivitySearch,
            MinimumEditDistance,
            StackLinkedList,
            BinarySearch,
            SelectionSort,
            BubbleSort,
            DataTypes2
        }
        static void Main(string[] args)
        {
            // subprogram count
            int subcount;

            // usage count
            int count = 0;

            // hashtags used as border for task no. printing
            string hashtags = "######################################";

            // title art generated from https://patorjk.com/software/taag/#p=display&f=Big&t=WELCOME%20TO%20C%23!
            Console.WriteLine("__          ________ _      _____ ____  __  __ ______   _______ ____     _____    _  _   _ ");
            Console.WriteLine("\\ \\        / /  ____| |    / ____/ __ \\|  \\/  |  ____| |__   _ / __ \\   / ____| _| || |_| |");
            Console.WriteLine(" \\ \\  /\\  / /| |__  | |   | |   | |  | | \\  / | |__       | | | |  | | | |     |_  __  _| |");
            Console.WriteLine("  \\ \\/  \\/ / |  __| | |   | |   | |  | | |\\/| |  __|      | | | |  | | | |       | || |_| |");
            Console.WriteLine("   \\  /\\  /  | |____| |___| |___| |__| | |  | | |____     | | | |__| | | |____ |_  __  _|_|");
            Console.WriteLine("    \\/  \\/   |______|______\\_____\\____/|_|  |_|______|    |_|  \\____/   \\_____|  |_||_| (_)\n");

            Console.WriteLine("     Created by: Ron Gerlan F. Naragdao\n");
            
            // while loop to continue running program if user wants to
            while(true)
            {
                // iterate count to keep track task
                count++;
                // set subcount as 0 in this line
                subcount = 0;

                // print task no. for tracking
                Console.WriteLine(hashtags+"-TASK NO. "+count+"-"+hashtags+"\n");

                // prompt to print subprograms available using enum
                Console.WriteLine("These subprograms for C# are available for you to use:");

                // print subprograms using .GetNames
                foreach (string name in Enum.GetNames(typeof(Subprograms)))  
                {  
                    // increment subcount each time a subprogram
                    subcount++;
                    // print subprogram name
                    Console.WriteLine(subcount+" => "+name);
                }  

                // prompt for user to type wanted subprogram to run
                Console.Write("\nType the number of the desired subprogram. (Type 0 to exit program): ");
                
                // stores the user input
                string choice = Convert.ToString(Console.ReadLine());


                // if choice is the first subprogram in enums
                if(choice == "1")
                {
                    // prompt to execute a subprogram
                    Console.WriteLine("Executing Data Types. Please enjoy!\n");

                    // create class instance
                    DataTypes vars = new DataTypes();

                    // execute class instance method
                    vars.printDataTypes();
                }
                // if choice is the second subprogram in enums
                else if (choice == "2")
                {
                    // prompt to execute a subprogram
                    Console.WriteLine("Executing Activity Search. Please enjoy!\n");

                    // create class instance
                    ActivitySearch act = new ActivitySearch();

                    // execute class instance method
                    act.get_activities();
                }
                // if choice is the third subprogram in enums
                else if(choice == "3")
                {
                    // prompt to execute a subprogram
                    Console.WriteLine("Executing Minimum Edit Distance. Please enjoy!\n");

                    // prompt to ask first user input
                    Console.Write("Input the first string: ");
                    // stores the user input
                    var str = Console.ReadLine();
                    // prompt to ask first user input
                    Console.Write("Input the second string: ");
                    // stores the user input
                    var str2 = Console.ReadLine();

                    // create class instance
                    MinimumEditDistance med = new MinimumEditDistance();

                    // execute class instance method 
                    Console.WriteLine("The minimum edit distance of names "+str+" and "+str2+" is "+med.min_edit_dist(str, str2)+".");
                }
                // if choice is the fourth subprogram in enums
                else if(choice == "4")
                {
                    // prompt to execute a subprogram
                    Console.WriteLine("Executing Stack Linked List. Please enjoy!\n");

                    // create class instance
                    StackLinkedList sll = new StackLinkedList();
                    // execute class instance methods
                    sll.PrintSLL();
                    sll.Push(1);
                    sll.PrintSLL();
                    sll.Push(2);
                    sll.PrintSLL();
                    sll.Push(3);
                    sll.PrintSLL();
                    sll.Push(4);
                    sll.PrintSLL();
                    sll.Pop();
                    sll.PrintSLL();
                    sll.Pop();
                    sll.PrintSLL();
                    sll.Pop();
                    sll.PrintSLL();
                    sll.Pop();
                    sll.PrintSLL();
                }
                // if choice is the fifth subprogram in enums
                else if (choice == "5")
                {
                    // prompt to execute a subprogram
                    Console.WriteLine("Executing Binary Search. Please enjoy!\n");

                    // prompt to enter user input
                    Console.Write("Please enter the list size: ");

                    // stores input for variable
                    int size = Convert.ToInt32(Console.ReadLine());

                    // create new array using previous variable
                    int[] list = new int[size];

                    // prompt to input values from user
                    Console.WriteLine("Please enter the elements below: ");

                    // for loop to input values in the array
                    for(int index=0;index<size;index++)
                    {
                        // stores input from user
                        int input = Convert.ToInt32(Console.ReadLine());
                        // assigns input in array
                        list[index] = input;
                    }
                    
                    // method from C# library
                    Array.Sort(list);

                    // newline for readability
                    Console.WriteLine();

                    // prompt to print list after sorted
                    Console.Write("The list is sorted and it contains: ");
                    // foreach to print elements in list
                    foreach(int num in list)
                    {
                        // print element
                        Console.Write(num+" ");
                    }

                    // newline for readability
                    Console.WriteLine("\n");

                    // prompt to enter user input
                    Console.Write("Enter a number to find: ");

                    // stores input in variable
                    int query = Convert.ToInt32(Console.ReadLine());

                    // static call method to store result
                    int result = SearchNSort.BinarySearch(list,query);
                    // if result can be found
                    if(result!=-1)
                    {
                        // print the result
                        System.Console.WriteLine(query+" is found in position "+result+".");
                    }
                    else
                    {
                        // print prompt for fail
                        System.Console.WriteLine(query+" is not found in the list.");
                    }
                    
                }
                // if choice is the sixth subprogram in enums
                else if (choice == "6")
                {
                    // prompt to execute a subprogram
                    Console.WriteLine("Executing Selection Sort. Please enjoy!\n");

                    // create new array and initialize
                    int[] array = {4,1,3,13,5,6,8,10,347,67,324};

                    // prompt to print array before sorting 
                    Console.WriteLine("Before: ");
                    // print array elements
                    SearchNSort.PrintArray(array);
                    // newline for readability
                    Console.WriteLine("\n");

                    // sort array using selection
                    SearchNSort.SelectionSort(ref array);
                    // prompt to print sorted array
                    Console.WriteLine("After: ");
                    // print array elements
                    SearchNSort.PrintArray(array);
                    // newline for readability
                    Console.WriteLine();
                }
                // if choice is the seventh subprogram in enums
                else if (choice == "7")
                {
                    // prompt to execute a subprogram
                    Console.WriteLine("Executing Bubble Sort. Please enjoy!\n");

                    // create new array and initialize
                    int[] array = {32,46,43,6,346,57,547,53,25,235,2};

                    // prompt to print array before sorting
                    Console.WriteLine("Before: ");
                    // print array elements
                    SearchNSort.PrintArray(array);
                    // newline for readability
                    Console.WriteLine("\n");

                    // sort array using bubble
                    SearchNSort.BubbleSort(ref array);
                    // prompt to print sorted array
                    Console.WriteLine("After: ");
                    // print array elements
                    SearchNSort.PrintArray(array);
                    // newline for readability
                    Console.WriteLine();
                }
                // if choice is the eighth subprogram in enums
                else if (choice == "8")
                {
                    // prompt to execute a subprogram
                    Console.WriteLine("Executing Data Types 2. Please enjoy!\n");

                    // static call method to print data types
                    DataTypes2.printDS();
                    // static call method to print scoping of C#
                    DataTypes2.scoping();
                    // static call method to print abstract data types and their types inside
                    DataTypes2.typeSafe();
                }
                // if choice is to exit
                else if (choice == "0")
                {
                    // prompt to thank user
                    Console.WriteLine("Thank you for using the app!\n");
                    // break active program
                    break;
                }
                // if choice does not belong or typed by accident
                else
                {
                    // prompt to try again
                    Console.WriteLine("Your input is invalid. Please try again!\n");
                }
                // system prompt when user wants to use the program again
                System.Console.WriteLine("\nRedirecting to main...\n");
            }
        }
    } 
}