using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFromScratch
{
    public class ScratchList<T> : IEnumerable
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
        public T this[int index] 
        {
            get
            {
                if (index < 0 || index >= items.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return items[index];
            }
            set
            {
                if (index < 0 || index >= items.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                items[index] = value;
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
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
                items[count] = item;
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
                items[count] = item;
                count++;

            }
        }

        public void Remove(T item)
        {
            T[] tempArray = new T[capacity];              
            int indexOfRemovedItem = count + 1;
            bool itemIsInList = false;
            for (int i = 0; i < count; i++)
            {
                if (item.Equals(items[i]))
                {
                    indexOfRemovedItem = i;
                    itemIsInList = true;
                    break;
                }
                tempArray[i] = items[i]; 
            }
            for (int i = indexOfRemovedItem + 1; i < count; i++)
            {
                tempArray[i-1] = items[i];
            }            
            if(itemIsInList == true)
            {                
                count--;
            }
            for (int i = 0; i < count; i++)
            {
                items[i] = tempArray[i];
            }
            


        }

        public override string ToString()
        {
            string listAsString = null;
            for (int i = 0; i < count; i++)
            {
                string tempString = Convert.ToString(items[i]);
                listAsString = listAsString + tempString;
            }

            return listAsString; 
        }

        public static ScratchList<T> operator+ (ScratchList<T> list1, ScratchList<T> list2)
        {            
            
            if(list1.GetType() != list2.GetType())
            {
                throw new IndexOutOfRangeException("Cannot add lists of different data type");
            }

            ScratchList<T> summedList = new ScratchList<T>();
            for (int i = 0; i < list1.count; i++)
            {
                summedList.Add(list1[i]);
            }
            for (int i = 0; i < list2.count; i++)
            {
                summedList.Add(list2[i]);
            }
            return summedList;

        }
    }
}
