using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListFinal
{
    public class CustomList<T>: IEnumerable<T>
    {
        //member varibles
        int capacity;
        int count;
        public int length;
        private T[] originalArray;
        // public int[] listOne = { 1, 3, 5 };
        //public int[] listTwo = { 2, 4, 6 };
        //public T[]
        //T[] innerArray;

        public T this[int i]
        {
            get
            {
                OutOfRange(i);
                return originalArray[i];
            }
            set
            {
                OutOfRange(i);
                originalArray[i] = value;
            }
        }


        public int Count
        {
            get
            {
                return count;
            }
        }

        public CustomList()
        {
            count = 0;
        }

        //public int Count
        //{
        //    get
        //    {
        //        return count;
        //    }
        //    set
        //    {
        //        count = value;
        //        count = 100;
        //    }
        //}

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



        public void Add(T itemToAdd)
        {
            //if the count of items to be added is greater than the current capacity, do this...
            if (count >= capacity)
            {
                ExpandArray();
                AddItemToArray(itemToAdd);
            }
            //if there is still enough capacity to hold new items, do this...
            else
            {
                AddItemToArray(itemToAdd);
            }
        }

        public void ExpandArray()
        {
            T[] newArray = new T[capacity += 4];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = originalArray[i];
            }
            originalArray = newArray;
        }

        public void AddItemToArray(T itemToAdd)
        {
            originalArray[count] = itemToAdd;
            count++;
        }

        public void OutOfRange(int indexReq)
        {
            if (indexReq < 0 || indexReq > count)
            {
                throw new IndexOutOfRangeException("There is no information at that index");
            }
        }

        //Identify object to remove
        public void Remove(T itemToRemove)
        {
            T[] newArray = new T[count];
            for (int i = 0, j = 0; i < count; i++, j++)
            {

                //when item at originalArray[i] IS item to be deleted.
                if (originalArray[i].Equals(itemToRemove))
                {
                    j--;
                    count--;
                    continue;
                }
                else
                {
                    //item at [i] is NOT what we want to delete.  Copy over to new array.
                    newArray[j] = originalArray[i];
                }
            }
            originalArray = newArray;
            //count--;
        }

        public override string ToString()
        {
            string result = "";

            foreach (T value in originalArray)
            {
                result += originalArray[count].ToString() + ", ";
            }
            // return base.ToString();
            return result;
        }

        public IEnumerator<T> GetEnumerator()

        {
            for (int i = 0; i < count; i++)
            {
                yield return originalArray[i];
            }
        }

        // TODO: understand this!
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> listResult = new CustomList<T>();

            {
                // for (int i = 0, i < count, i++)
                //   listResult.Add(listOne(i))
                //
                foreach (T data in listOne)
                {
                    listResult.Add(data);
                }
                foreach (T data in listTwo)
                {
                    listResult.Add(data);
                }
                return listResult;
            }
        }

        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {

            foreach (T data in listTwo)
            {
                listOne.Remove(data);
            }
            return listOne;
        }

        ///ZIP omg 2 For loops
    }
}
