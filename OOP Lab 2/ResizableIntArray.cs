using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab_2
{
    class ResizableIntArray
    {
        int[] mStorage = new int[10];
        int mCurrentIndex = 0;

        public void Add(int pNumber)
        {
            mStorage[mCurrentIndex] = pNumber;
            mCurrentIndex++;
            if (IsFull())
            {
                ExpandStorage(10);
            }
        }

        public void ExpandStorage(int pSizeIncrease)
        {
            int[] increasedStorage = new int[mCurrentIndex + pSizeIncrease];
            for (int i = 0; i< mCurrentIndex; i++)
            {
                increasedStorage[i] = mStorage[i];
            }
            mStorage = increasedStorage;
        }

        public bool IsFull()
        {
            if (mCurrentIndex < mStorage.Length)
            {
                return false;
            }
            return true;
        }

        public void WriteContentsToConsole()
        { 
            for (int i = 0; i < mCurrentIndex; i++)
            {
                Console.WriteLine(mStorage[i]);
            }
        }
    }
}
