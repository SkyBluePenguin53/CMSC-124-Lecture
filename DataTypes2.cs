using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

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
    public class DataTypes2
    {
        // records
        public record Car(string name, string maker);

        // struct
        public struct Computer
        {
            // constructor
            public Computer(string brand, string kind)
            {
                Brand = brand;
                Kind = kind;
            }
            // get function for Brand variable
            public string Brand { get; }
            // get function for Kind variable
            public string Kind { get; }

            // print structure
            public override string ToString() => $"Computer brand: {Brand}, computer kind: {Kind}";
        }

        //Enumeration types
        enum SolarSystemPlanets
        {
            // Data from https://solarsystem.nasa.gov/planets/overview/
            Mercury,
            Venus,
            Earth,
            Mars,
            Jupiter,
            Saturn,
            Uranus,
            Neptune,
        }

        // prints all data types
        public static void printDS()
        {
            // string array
            String[] stringArray = {"Hi", "How", "is", "it", "going", "?"};
            
            // print string type array
            Console.Write("String array: ");
            print(stringArray);
            // print type of string array
            printType(stringArray);

            // object array
            Object[] intArray = {1,8,2,0,3,6};

            // print object type array
            Console.Write("Object array: ");
            print(intArray);
            // print type of object array
            printType(intArray);

            Console.WriteLine("Record instances:");
            // new record instance
            Car car1 = new("Expedition", "Ford");
            // print record instance
            Console.WriteLine(car1);
            // print record type instance
            printType(car1);
            // new record instance
            Car car2 = new("Landcruiser", "Toyota");
            // print record instance
            Console.WriteLine(car2);
            // print record type instance
            printType(car2);
            
            Console.WriteLine("Enumeration instances:");
            // new enums instance
            SolarSystemPlanets ourPlanet = SolarSystemPlanets.Earth;
            // print enums instance
            Console.WriteLine(ourPlanet);
            // print enums instance type
            Console.WriteLine("The type of the item above is "+ourPlanet.GetType());

            // new enums instance
            SolarSystemPlanets targetPlanet = SolarSystemPlanets.Mars;
            // print enums instance
            Console.WriteLine(targetPlanet);
            // print enums instance type
            Console.WriteLine("The type of the item above is "+targetPlanet.GetType());

            // new enums instance
            SolarSystemPlanets furthestPlanets = SolarSystemPlanets.Neptune;
            // print enums instance
            Console.WriteLine(furthestPlanets);
            // print enums instance type
            Console.WriteLine("The type of the item above is "+furthestPlanets.GetType()+"\n");

            Console.WriteLine("Structure instances:");
            // new structure instance
            Computer comp1 = new Computer("Razor", "Desktop");
            // print structure instance
            Console.WriteLine(comp1);

            // new structure instance
            Computer comp2 = new Computer("Pirates", "Laptop");
            // print structure instance
            Console.WriteLine(comp2+"\n");
        }

        // checks the scoping of C#
        public static void scoping()
        {
            Console.WriteLine("Scoping:");
            // From https://msujaws.wordpress.com/2011/05/03/static-vs-dynamic-scoping/
            int x = 8;
            // assigns 4 to x
            // returns 9 if x is referenced from active subprogram one()
            // returns 13 if x is referenced from static parent scoping()
            int one()
            {
                int x = 4;
                // calls two() function
                return two();
            }
            // returns 13 as x is referenced from static parent scoping()
            int two()
            {
                int z = x+5;
                return z;
            }
            
            // run and print the result of one() function
            System.Console.WriteLine("In scoping, one() function returns "+one());
            // run and print the result of two() function
            System.Console.WriteLine("In scoping, two() function returns "+two());

            // if both functions one() and two() have equal results
            if(one()==two())
            {
                // print statement
                System.Console.WriteLine("C# is statically scoped.\n");
            }
            // if both functions one() and two() does not have equal results
            else
            {
                // print statement
                System.Console.WriteLine("C# is dynamically scoped.\n");
            }
        }

        public static void typeSafe()
        {
            Console.WriteLine("Type Safe checking:\n");

            Console.WriteLine("ArrayList instance:");
            // new ArrayList instance
            var integers = new ArrayList();
            // add in ArrayList values 1, 2, and "3"
            integers.Add(1);
            integers.Add(2);
            integers.Add("3");

            // print ArrayList elements
            foreach(var item in integers) 
            {
                Console.WriteLine(item+" in ArrayList has type "+item.GetType());
            }
            Console.WriteLine();

            Console.WriteLine("Generic list instance:");
            // new generic List instance
            List<int> integers2 = new List<int>();
            // add generic List values 1, 2, and 3
            integers2.Add(1);
            integers2.Add(2);
            // NOTE: integers.Add("3"); returns an error at runtime 
            integers2.Add(3);

            // print generic List elements
            foreach(var item in integers) 
            {
                Console.WriteLine(item+" in List<T> has type "+item.GetType());
            }
            Console.WriteLine();

            Console.WriteLine("SortedList instance:");
            // new SortedList instance
            SortedList sortedList = new SortedList();
            // add in SortedList values 1-5 and "one", "two" to "five"
            // Invalid code for sortedList.Add(1, "one") while the next lines are sortedList.Add("two", 2)
            sortedList.Add(1, "one");
            sortedList.Add(3, "three");
            sortedList.Add(2, "two");
            sortedList.Add(5, "five");
            sortedList.Add(4, "four");

            // print all SortedList elements as Dictionary Entry
            foreach (DictionaryEntry listItem in sortedList)
            {
                Console.WriteLine("Key: "+listItem.Key+", Value: "+listItem.Value);
            }
            Console.WriteLine();

            Console.WriteLine("Hashtable instance:");
            // new Hashtable instance
            Hashtable hashTable = new Hashtable();
            // add Hashtable variables
            hashTable.Add(1, "one");
            hashTable.Add("three", 3);
            hashTable.Add(2, "two");

            // print all Hashtable elements as Dictionary Entry
            foreach (DictionaryEntry hashItem in hashTable)
            {
                Console.WriteLine("Key: "+hashItem.Key+", Value: "+hashItem.Value);
            }
            Console.WriteLine();
            // C# Collection site https://www.tutorialsteacher.com/csharp/

        }


        //Method to print arrays
        public static void print(string[] array)
        {
            foreach(var item in array)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
        
        // @Method override to print arrays
        public static void print(object[] array)
        {
            foreach(var item in array)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }

        // Method to print type of object passed in parameter
        public static void printType(string[] item)
        {
            Console.WriteLine("The type of the item above is "+item.GetType());
            Console.WriteLine();
        }
        // @Method override to print type of object passed in parameter
        public static void printType(object[] item)
        {
            Console.WriteLine("The type of the item above is "+item.GetType());
            Console.WriteLine();
        }
        // @Method override to print type of object passed in parameter
        public static void printType(Car item)
        {
            Console.WriteLine("The type of the item above is "+item.GetType());
            Console.WriteLine();
        }
    }
}