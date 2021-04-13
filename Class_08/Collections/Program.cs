using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = new int[4];
            string[] strArray = new string[] { "Hello", "World", "!" };
            //Array.Resize(ref, strArray, 10);     same as add list referenca
            //strArray[strArray.Length - 1] = ":::";
            //GoTroughCollection(strArray, "Array");


            ArrayList arrayList = new ArrayList() { "Hello", 2, true, 2.33 };
            arrayList.Add(9);
            arrayList.Add(strArray);   

            arrayList.Remove(true);
            Console.WriteLine(arrayList[3]);
            GoTroughCollection(arrayList, "ArrayList");
            Console.WriteLine("Lenght:" + arrayList.Count);

            List<int> listOfInts = new List<int>();
            listOfInts.Add(3);        // dodavanje elementi vo listata
            listOfInts.Add(5);
            listOfInts.Add(7);
            listOfInts.Add(4);
            listOfInts.Add(8);
            listOfInts.Add(15);
            //listOfInts.Add("Trajan") Vaka ne moze, mora da se ints
            GoTroughCollection(listOfInts, "List");  // kreiranje prazna lista

            List<string> strList = new List<string>() { "Hello", "World", "!" };
            strList.Add("Trajan");
            strList.AddRange(strArray); //dodavanje kolekcija druga od isti tip
            strList.Add("Stevkovski");
            strList.Remove("Trajan");
            strList.Remove(strArray[1]); // ke go izbise elementot so index 1 od strArray
            Console.WriteLine(strList[0]);
           
            GoTroughCollection(strList, "List");
            Console.WriteLine("Length:" + strList.Count);


            //dictionary collection
            // type     key     value
            Dictionary<string, string> dictionaryOne = new Dictionary<string, string>();
            dictionaryOne.Add("Song1", "Winds Of Change");
            dictionaryOne.Add("song2", "Enter Sandman");
            //dictionaryOne.Add("Song1", "asd"); // ke frli greska, klucevite mora da se unikatni // keys are unique, we cannot add 2 keys with same value
            GoTroughCollection(dictionaryOne, "Dictionary");
            string song = dictionaryOne["song2"];
            //Console.WriteLine(dictionaryOne[2]); // dictionarys dont have indexed
            Console.WriteLine(song);

            Dictionary<int, string> dictionaryTwo = new Dictionary<int, string>()
            {
                {1,"Hello" },
                {2, "World" },
                { 3, "!" },
                { 4,"!"  } // se dodeka klucot e razlicen nema da ima problem
            };
            string item1 = dictionaryTwo[2]; //the key is int, moze na ovoj nacin 
            Console.WriteLine(item1);
            dictionaryTwo.Remove(2); // koj kluc sakame da go izbriseme
            GoTroughCollection(dictionaryTwo, "Dictionary");

            int keyNumber = 3;
            Console.WriteLine(dictionaryTwo[keyNumber]);

            foreach(KeyValuePair<int,string> item in dictionaryTwo)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            Console.WriteLine("Length " + dictionaryTwo.Count);


            //ORDERED COLLECTION

            Queue<int> someQueue = new Queue<int>();        /// QUEUE - FIRST IN FIRST OUT
            someQueue.Enqueue(25); //adds item in queue
            someQueue.Enqueue(2);
            someQueue.Enqueue(3);
            someQueue.Enqueue(112);
            GoTroughCollection(someQueue, "Queue");
            int someNum = someQueue.Dequeue(); // removes first item always
            GoTroughCollection(someQueue, "Queue");
            //someQueue[2] -- cannot apply indexes to Queue
            Console.WriteLine(someQueue.Peek()); // peaks into the queue to see what item comes next//nema da go izvadi, samo zirka
            Console.WriteLine("Length:", someQueue.Count);



            //STACK           LAST IN FIRST OUT
            Stack<string> someStack = new Stack<string>();
            someStack.Push("Hey"); // adds item to the stack
            someStack.Push("Hello");
            someStack.Push("hi");
            someStack.Push("Zdravo");
            GoTroughCollection(someStack, "Stack");

            string someString = someStack.Pop(); // go vadime "Zdravo"
            Console.WriteLine(someString);
            GoTroughCollection(someStack, "Stack");
            Console.WriteLine(someStack.Peek());
            Console.WriteLine("Length", +someStack.Count);


            //FIRST EXERCISE PHONEBOOK
            Dictionary<string, int> phoneBookDictionary = new Dictionary<string, int>()
            {
                { "Sashka", 13332 },
                { "World", 567890 },
                { "Damjan", 7856789 },
                {"Trajan", 567890  }
            };
            Console.WriteLine("Please enter name");
            string input = Console.ReadLine();
            //getPhoneNumber(input, phoneBookDictionary)
            foreach(KeyValuePair <string,int> item in phoneBookDictionary)
            {
                if (item.Key == input)
                {
                    Console.WriteLine($"{item.Key}s phone number is {item.Value}");
                }
            }
                

            // EXERCISE 2 CLASS SONG
            Console.ReadLine();
        }


        static void GoTroughCollection(IEnumerable collection, string name)
        {
            Console.WriteLine($"Collection {name} items: ");
            foreach (var item in collection)
            {
                Console.WriteLine($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}

