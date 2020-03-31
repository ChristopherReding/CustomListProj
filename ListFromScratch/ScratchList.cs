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
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
            
        }
        
        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if(Capacity >= count)
                {                    
                    T[] tempArray = new T[capacity];
                    for (int i = 0; i < count; i++)
                    {
                        tempArray[i] = items[i];
                    }                    
                    capacity = value;
                    items = new T[capacity];
                    for (int i = 0; i < count; i++)
                    {
                        items[i] = tempArray[i];
                    }
                }
               
                
            }
        }
        private T[] items;   
                
        public T this[int index] //indexer
        {
            get
            {
                return items[index];
            }
            set
            {
                if(index < 0 || index >= items.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                items[index] = value;
            }
        }
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
            if(count < capacity)//there is room in array
            {
                item = items[count];
                count++;
            }
            else if(count == capacity)//if there isnt room in the array
            {
                T[] tempArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = items[i];
                }
                capacity = capacity * 2;
                items = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    items[i] = tempArray[i];
                }
                item = items[count];
                count++;

            }
        }
        public void Remove(T item)
        {

        }
    }
}
