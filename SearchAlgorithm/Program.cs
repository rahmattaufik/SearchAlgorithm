using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
    class Program
    {
        //Array to be searched
        int[] arr = new int[20];
        //NUmber of elements in the array
        int n;
        //Get the number of elements to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the Array:  ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 elements.\n");
            }

            //Accept array elements
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine(" Enter array elements");
            Console.WriteLine("---------------------");

            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                //Accept the number to be searched
                Console.Write("\nEter the element you want to search:  ");
                int item = Convert.ToInt32(Console.ReadLine());

                //Apply binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //Obtain the index of the middlemost element
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //Loop to search for the element in the array'
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;
                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }

                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() +
                        " found at position " + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() +
                        " not found in the array\n");

                Console.Write("\nNumber of comparisons: " + ctr);

                Console.Write("\nContinue search (y/n) :");
                ch = Char.Parse(Console.ReadLine().ToUpper());
            } while ((ch == 'y'));
        }
        public void LinearSearch()
        {
            char ch;
            //Search for number of comparison
            int ctr;
            do
            {
                //Accept the number to be searched
                Console.Write("\nEter the element you want to search:  ");
                int item = Convert.ToInt32(Console.ReadLine());

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + " Found at position" + (i + 1).ToString());
                        break;
                    }
                    if (i == n)
                        Console.WriteLine("\n" + item.ToString() +
                        " not found in the array\n");

                    Console.Write("\nNumber of comparisons: " + ctr);



                }
                Console.Write("\nContinue search (y/n) :");
                ch = char.Parse(Console.ReadLine().ToUpper());
            } while ((ch == 'y'));

        }

        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmu;
            char ch;
            do
            {
                Console.WriteLine("Menu Option");
                Console.WriteLine("===========");
                Console.WriteLine("1.Linear Search");
                Console.WriteLine("2.Binary Search");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter your choice (1,2,3) : ");
                pilihanmu = Convert.ToInt32(Console.ReadLine());
                switch (pilihanmu)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine(".............");
                        Console.WriteLine("Linear Search");
                        Console.WriteLine(".............");
                        myList.input();
                        myList.LinearSearch();
                        break;

                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine(".............");
                        Console.WriteLine("Binary Search");
                        Console.WriteLine(".............");
                        myList.input();
                        myList.BinarySearch();
                        break;
                    case 3:
                        Console.WriteLine("exit.");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;

                }
            } while (pilihanmu != 3);
        }
    


        

    }
}