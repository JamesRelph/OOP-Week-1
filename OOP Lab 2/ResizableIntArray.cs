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
            for (int i = 0; i < mCurrentIndex; i++)
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


        public double Average()
        {
            double sum = 0;

            for (int i = 0; i < mCurrentIndex; i++)
            {
                sum = sum + mStorage[i];
            }

            double average = sum / mCurrentIndex;
            return average;
        }

        public int Max()
        {
            int maxIndex = mStorage[0];
            for (int i = 0; i < mCurrentIndex; i++)
                if (mStorage[i] > maxIndex)
                {
                    maxIndex = mStorage[i];
                }
            return maxIndex;
        }

        public int Min()
        {
            int minIndex = mStorage[0];
            for (int i = 0; i < mCurrentIndex; i++)
                if (mStorage[i] < minIndex)
                {
                    minIndex = mStorage[i];
                }
            return minIndex;
        }

        public void BubbleSortAscending()
        {
            if (mCurrentIndex > 1)
            {
                bool swapHappened = false;

                do
                {
                    swapHappened = false;
                    for (int i = 1; i < mCurrentIndex; i++)
                    {
                        int previousNumber = mStorage[i - 1];
                        int currentNumber = mStorage[i];

                        if (currentNumber < previousNumber)
                        {
                            mStorage[i] = previousNumber;
                            mStorage[i - 1] = currentNumber;
                            swapHappened = true;
                        }
                    }
                }
                while (swapHappened);
            }
        }
    }
}
