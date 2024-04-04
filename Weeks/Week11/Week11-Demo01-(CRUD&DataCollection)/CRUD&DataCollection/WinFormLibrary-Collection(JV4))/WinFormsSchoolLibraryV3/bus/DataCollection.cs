using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsSchoolLibraryV3.bus
{
    public class DataCollection
    {

        private static List<Item>  listOfItems = new List<Item>();


        // public static List<Item> ListOfItems { get => listOfItems ; set => listOfItems = value ; }

        public static List<Item> ListOfItems
        {
            get { return listOfItems; }

            set { listOfItems = value; }
        }

        public static void Add(Item newItem )
        { 
        ListOfItems.Add( newItem );
        }

        public static void Remove(Item newItem)
        {
            ListOfItems.Remove(newItem);
        }

        public static void RemoveAt(int currentIndex)
        {
            ListOfItems.RemoveAt(currentIndex);
        }

        public static void InsertAt(int currentIndex , Item currentItem)
        {
            listOfItems.Insert(currentIndex, currentItem);
        }

        public static void Clear() { }

        public static Item Search(int key)
        {
            Item foundItem = new Item();

            foreach (Item currentItem in ListOfItems)
            {
                if (currentItem.Number  == key)
                { 
                 foundItem =  currentItem;
                   
                }
            }
            return foundItem ;        
        }

        public static List<Item> GetItemList()
        {
            return ListOfItems ;
        }

        public static List<Book> GetBookList()
        {
            List<Book> listOfBook = new List<Book>();

            foreach (Item currentItem in ListOfItems) 
            {
                if ( currentItem is Book)
                {
                    Book currentBook = new Book();
                    currentBook = (Book) currentItem;
                    listOfBook.Add(currentBook);
                }
            }  
            return listOfBook;
        }


        public static List<CompactDisk> GetCompactDiskList()
        {
            List<CompactDisk> listOfCompactDisk = new List<CompactDisk>();

            foreach (Item currentItem in ListOfItems)
            {
                if (currentItem is Book)
                {
                    CompactDisk currentCompactDisk = new CompactDisk();
                    currentCompactDisk = (CompactDisk)currentItem;
                    listOfCompactDisk.Add(currentCompactDisk);
                }
            }
            return listOfCompactDisk;
        }



    }
}
