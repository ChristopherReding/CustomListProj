using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFromScratch
{
    public class ScratchList<T>
    {
        //member variable
        int count;
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        private T[] items;        
        
        //constructor
        public ScratchList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }
        //member methods

        public void Add(T item)
        {

        }
    }
}
