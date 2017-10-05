using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace DataStructGroup
{
    class Program
    {
        static void Main(string[] args)
        {

            int iEntryMain = 0;
            int iEntrySub = 0;
            int iCount = 0;
                   
            while (iEntryMain != 4)
            {
                Stack myStack = new Stack(); // declaring new stack at the beginning because it will loop through  
                Dictionary<string, int> dDictionary = new Dictionary<string, int>();
                Queue qQueue = new Queue();
                int iDictionaryCount = 1;
                //Displays main menu
                Console.WriteLine("1. Stack");
                Console.WriteLine("2. Queue");
                Console.WriteLine("3. Dictionary");
                Console.WriteLine("4. Exit");
                //Receives selection
                iEntryMain = Convert.ToInt32(Console.ReadLine());
                iEntrySub = 0;

                if (iEntryMain == 1)
                {
                    while (iEntrySub != 7)
                    {
                        //Displays option 1 sub-menu
                        Console.WriteLine("1. Add one item to Stack");
                        Console.WriteLine("2. Add huge list of items to Stack");
                        Console.WriteLine("3. Display Stack");
                        Console.WriteLine("4. Delete from Stack");
                        Console.WriteLine("5. Clear Stack");
                        Console.WriteLine("6. Search Stack ");
                        Console.WriteLine("7. Return to Main Menu");
                        iEntrySub = Convert.ToInt32(Console.ReadLine());
                        if (iEntrySub == 1)
                        {
                            Console.WriteLine("Enter item to add to stack:");
                            string sInput = Console.ReadLine();
                            myStack.Push(sInput);
                        }
                        else if (iEntrySub == 2)
                        {
                            myStack.Clear();
                            //Adds a huge list to stack
                            for (iCount = 1; iCount < 2001; iCount++)
                            {
                                string sCount = iCount.ToString();
                                string stackItem = "New Entry " + sCount;
                                myStack.Push(stackItem);
                            }
                        }
                        else if (iEntrySub == 3)
                        {
                            foreach (var stackItems in myStack)
                            {
                                Console.WriteLine(stackItems);
                            }
                        }
                        else if (iEntrySub == 4)
                        {
                            Stack TempStack = new Stack();
                            Console.WriteLine("Enter item to delete from stack:");
                            string sDelete = Console.ReadLine();
                            if (myStack.Contains(sDelete) == true)
                            {
                                //Loop while the top entry is not the item to be deleted, and
                                //move top item to temporary stack, if so.
                                while (Convert.ToString(myStack.Peek()) != sDelete)
                                {
                                    TempStack.Push(myStack.Pop());
                                }
                                //Deletes the top entry
                                myStack.Pop();
                                //Loop to return all the TempStack items to myStack

                                for (iCount = 0; iCount < TempStack.Count; iCount++)
                                {
                                    myStack.Push(TempStack.Pop());
                                }
                            }
                            else
                            {
                                Console.WriteLine("Item is not in the stack");
                            }
                        }
                        else if (iEntrySub == 5)
                        {
                            myStack.Clear();
                        }
                        else if (iEntrySub == 6)
                        {
                            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                            Console.WriteLine("What should I search for?");
                            string stackSearch = Console.ReadLine();
                            sw.Restart();
                            if (myStack.Contains(stackSearch) == true)
                            {
                                sw.Stop();
                                TimeSpan ts = sw.Elapsed;
                                Console.WriteLine("Item found in " + ts);
                            }
                            else
                            {
                                sw.Stop();
                                TimeSpan ts = sw.Elapsed;
                                Console.WriteLine("Item is not in stack, it took " + ts + " seconds to discover this");
                            }
                        }
                        else if (iEntrySub == 7)
                        {
                            iEntryMain = 0;
                        }
                    }
                }
                else if (iEntryMain == 2)
                {
                    while (iEntrySub != 7)
                    {
                       
                        Console.WriteLine("1. Add one item to Queue");
                        Console.WriteLine("2. Add huge list of items to Queue");
                        Console.WriteLine("3. Display Queue");
                        Console.WriteLine("4. Delete from Queue");
                        Console.WriteLine("5. Clear Queue");
                        Console.WriteLine("6. Search Queue");
                        Console.WriteLine("7. Return to Main Menu");
                        iEntrySub = Convert.ToInt32(Console.ReadLine());
                        if (iEntrySub == 1)
                        {
                            Console.Write("What would you like to add to the queue? Type it here: ");
                            string sAddQueue = Console.ReadLine();
                            qQueue.Enqueue(sAddQueue);
                        }
                        else if (iEntrySub == 2)
                        {
                            qQueue.Clear();
                            for (iCount = 1; iCount < 2001; iCount++)
                            {
                                string sCount = iCount.ToString();
                                string queueItem = "New Entry " + sCount;
                                qQueue.Enqueue(queueItem);
                            }
                        }
                        else if (iEntrySub == 3)
                        {
                            foreach(var queueItems in qQueue)
                            {
                                Console.WriteLine(queueItems);
                            }
                            
                        }
                        else if (iEntrySub == 4)
                        {
                            Queue TempQueue = new Queue();
                            Console.WriteLine("Enter item to delete from queue:");
                            string qDelete = Console.ReadLine();
                            if (qQueue.Contains(qDelete) == true)
                            {
                                //Loop while the top entry is not the item to be deleted, and
                                //move top item to temporary stack, if so.
                                while (Convert.ToString(qQueue.Peek()) != qDelete)
                                {
                                    TempQueue.Enqueue(qQueue.Dequeue());
                                }
                                //Deletes the top entry
                                qQueue.Dequeue();

                                //Loop to return all the TempQueue items to qQueue
                                while(qQueue.Count>0)
                                {
                                    TempQueue.Enqueue(qQueue.Dequeue());
                                }
                                qQueue = TempQueue;
                            }
                            else
                            {
                                Console.WriteLine("Item is not in the queue");
                            }
                        }
                        else if (iEntrySub == 5)
                        {
                            qQueue.Clear();
                        }
                        else if (iEntrySub == 6)
                        {
                            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                            Console.WriteLine("What should I search for?");
                            string queueSearch = Console.ReadLine();
                            sw.Restart();
                            if (qQueue.Contains(queueSearch) == true)
                            {
                                sw.Stop();
                                TimeSpan ts = sw.Elapsed;
                                Console.WriteLine("Item found in " + ts);
                            }
                            else
                            {
                                sw.Stop();
                                TimeSpan ts = sw.Elapsed;
                                Console.WriteLine("Item is not in queue, it took " + ts + " seconds to discover this");
                            }
                        }
                        else if(iEntrySub==7)
                        {
                            iEntryMain = 0;
                        }
                    }
                }
                else if (iEntryMain == 3)
                {
                    while (iEntrySub != 7)
                    {
                        Console.WriteLine("1. Add one item to Dictionary");
                        Console.WriteLine("2. Add huge list of items to Dictionary");
                        Console.WriteLine("3. Display Dictionary");
                        Console.WriteLine("4. Delete from Dictionary");
                        Console.WriteLine("5. Clear Dictionary");
                        Console.WriteLine("6. Search Dictionary");
                        Console.WriteLine("7. Return to Main Menu");
                        iEntrySub = Convert.ToInt32(Console.ReadLine());
                        
                        if (iEntrySub == 1)
                        {
                            Console.WriteLine("Enter a name:");
                            string dName = Console.ReadLine();
                            dDictionary.Add(dName, iDictionaryCount);
                            iDictionaryCount++;
                        }
                        else if (iEntrySub == 2)
                        {
                            dDictionary.Clear();
                            for (iDictionaryCount = 1; iDictionaryCount < 2001; iDictionaryCount++)
                            {
                                string sDictionaryCount = iDictionaryCount.ToString();
                                string dName = "New Entry " + sDictionaryCount;
                                dDictionary.Add(dName, iDictionaryCount);
                            }
                        }
                        else if (iEntrySub == 3)
                        {
                            //loops through the dictionary and displays each item's name and total burger count
                            foreach (KeyValuePair<string, int> entry in dDictionary)
                            {
                                Console.Write("Key: " + entry.Key);
                                Console.WriteLine(", Value: " + entry.Value);
                            }
                        }
                        else if (iEntrySub == 4)
                        {
                            Console.WriteLine("Enter the name you want to delete:");
                            var key = Console.ReadLine();
                            if (dDictionary.ContainsKey(key))
                            {
                                dDictionary.Remove(key);
                            }
                        }
                        else if (iEntrySub == 5)
                        {
                            dDictionary.Clear();
                            iDictionaryCount = 1;
                        }
                        else if(iEntrySub ==6)
                        {
                            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                            Console.WriteLine("What should I search for?");
                            string dictionarySearch = Console.ReadLine();
                            sw.Restart();
                            if (dDictionary.ContainsKey(dictionarySearch))
                            {
                                sw.Stop();
                                TimeSpan ts = sw.Elapsed;
                                Console.WriteLine("Item found in " + ts);
                            }
                            else
                            {
                                sw.Stop();
                                TimeSpan ts = sw.Elapsed;
                                Console.WriteLine("Item is not in stack, it took " + ts + " seconds to discover this");
                            }
                        }
                        else if(iEntrySub == 7)
                        {
                            iEntryMain = 0;
                        }
                    }
                }
            }
        }
    }
}