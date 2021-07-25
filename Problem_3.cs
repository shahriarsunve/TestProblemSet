using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{

        class MaxAreaChecker
        {
		public static int getMaxArea(int[] histogram,int number)
		{
			int maxArea = 0, stackTop,areaTopStack,i = 0,iValue;
			Stack<int> storeBar = new Stack<int>();
			while (i < number)
			{
				if (storeBar.Count == 0 || histogram[storeBar.Peek()] <= histogram[i])
				{
					storeBar.Push(i++);
				}
				else
				{
					stackTop = storeBar.Peek();
					storeBar.Pop();

                    if (storeBar.Count == 0) {
						iValue = i;
					}
                    else
                    {
						iValue = i - storeBar.Peek() - 1;
					}


					areaTopStack = histogram[stackTop] * iValue;
					if (maxArea < areaTopStack)
					{
						maxArea = areaTopStack;
					}
				}
			}
			while (storeBar.Count > 0)
			{
				stackTop = storeBar.Peek();
				storeBar.Pop();
				if (storeBar.Count == 0)
				{
					iValue = i;
				}
				else
				{
					iValue = i - storeBar.Peek() - 1;
				}
				areaTopStack = histogram[stackTop] * iValue;

				if (maxArea < areaTopStack)
				{
					maxArea = areaTopStack;
				}
			}

			return maxArea;

		}
            static void Main(string[] args)
            {
			Console.WriteLine("Input size of array: ");
			int arraySize = Int32.Parse(Console.ReadLine());
			int[] histogram = new int[arraySize];
			for (int i = 0; i < arraySize; i++) {
				histogram[i] = Int32.Parse(Console.ReadLine());
			}
                Console.WriteLine("Lagest area is " + getMaxArea(histogram, arraySize));
                Console.ReadKey();
            }
        }
}
