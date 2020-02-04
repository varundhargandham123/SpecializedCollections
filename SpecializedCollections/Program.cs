using System;
using System.Collections;
using System.Collections.Specialized;

namespace CollectionClasses
{    
    class SpecializedCollections
    {
        /// <summary>
        /// A collection of strings.
        /// </summary>
        public void stringCollection()
        {
            StringCollection stringCollection = new StringCollection();
            stringCollection.Add("varun");
            stringCollection.Add("vnr");
            stringCollection.Add("vikas");
            stringCollection.Add("nitin");
            foreach (var i in stringCollection)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        ///A Collection of StringDictionary
        /// </summary>
        public void stringDictionary()
        {
            StringDictionary stringDictionary = new StringDictionary();
            stringDictionary.Add("one", "varun");
            stringDictionary.Add("two", "vnr");
            stringDictionary.Add("three", "vikas");
            stringDictionary.Add("four", "nitin");
            foreach (DictionaryEntry i in stringDictionary)
            {
                Console.WriteLine(i.Key + "  " + i.Value);
            }
        }

        /// <summary>
        /// A orderedDictionary 
        /// </summary>
        public void orderedDictionary()
        {
            OrderedDictionary orderedDictionary = new OrderedDictionary();
            orderedDictionary.Add("one", "varun");
            orderedDictionary.Add("two", "vnr");
            orderedDictionary.Add("three", "vikas");
            orderedDictionary.Add("four", "nitin");
            foreach (DictionaryEntry i in orderedDictionary)
            {
                Console.WriteLine(i.Key + "  " + i.Value);
            }
        }

        /// <summary>
        /// Collection of  ListDictionary 
        /// </summary>
        public void listDictionary()
        {
            ListDictionary listDictionary = new ListDictionary();
            listDictionary.Add("one", "varun");
            listDictionary.Add("two", "vnr");
            listDictionary.Add("three", "vikas");
            listDictionary.Add("four", "nitin");
            listDictionary.Add("five", "ram");
            foreach (DictionaryEntry i in listDictionary)
            {
                Console.WriteLine(i.Key + "   " + i.Value);
            }
        }

        /// <summary>
        /// HybridDictionary switches based on number of elements.
        /// </summary>
        public void hybridDictionary()
        {
            HybridDictionary hybridDictionary = new HybridDictionary();
            hybridDictionary.Add("one", "varun");
            hybridDictionary.Add("two", "vnr");
            hybridDictionary.Add("three", "vikas");
            hybridDictionary.Add("four", "nitin");
            foreach (DictionaryEntry i in hybridDictionary)
            {
                Console.WriteLine(i.Key + "  " + i.Value);
            }
        }

        /// <summary>
        /// A collection with String keys and String values. 
        /// </summary>
        public void nameValueCollection()
        {
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection.Add("one", "varun");
            nameValueCollection.Add("two", "vnr");
            nameValueCollection.Add("three", "vikas");
            nameValueCollection.Add("four", "nitin");
            foreach (var i in nameValueCollection.AllKeys)
            {
                Console.WriteLine(i + "  " + nameValueCollection[i]);
            }
        }
    }
    class Specialized
    {
        public static void Main(string[] args)
        {
            
            SpecializedCollections specialized = new SpecializedCollections();
            Console.WriteLine("StringCollection");
            specialized.stringCollection();
            Console.WriteLine("StringDictionary");
            specialized.stringDictionary();
            Console.WriteLine("OrderedDictionary");
            specialized.orderedDictionary();
            Console.WriteLine("ListDictionary");
            specialized.listDictionary();
            Console.WriteLine("HybridDictionary");
            specialized.hybridDictionary();
            Console.WriteLine("NameValueCollection");
            specialized.nameValueCollection();

        }
    }
}