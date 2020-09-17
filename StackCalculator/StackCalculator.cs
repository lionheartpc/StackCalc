using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    public class StackCalculator<DataType>
    {

        private Stack<DataType> memoryStack = new Stack<DataType>();
        private static int stackSize = 5;
        private short maxRangeOfNumber = 1024;
        public int getStackSize()
        {
            return memoryStack.Count;
        }

        public string GetStackString()
        {
            string result = "";
            result = string.Join(", ", memoryStack.ToArray());
            return "(stack is "+result+")";
                
        }

        public string Push(DataType pushValue)
        {
            if (!isStackFull())
            {
                memoryStack.Push(pushValue);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Stack is full");
            }

            return GetStackString();
        }


        public string Pop()
        {
            if (memoryStack.Count > 0)
            {
                memoryStack.Pop();
            }
            return GetStackString();
        }

        private bool isStackFull()
        {
            return memoryStack.Count >= stackSize;
        }

        public string Add()
        {

            dynamic firstStackValue = memoryStack.Pop();
            dynamic secondStackValue = memoryStack.Pop();
            dynamic result = firstStackValue + secondStackValue;

            memoryStack.Push(getNumberAfterOverflow(result));

            return GetStackString();
        }

        public string Sub()
        {

            dynamic firstStackValue = memoryStack.Pop();
            dynamic secondStackValue = memoryStack.Pop();
            dynamic result = firstStackValue - secondStackValue;

            memoryStack.Push(getNumberAfterOverflow(result));

            return GetStackString();
        }

        private dynamic getNumberAfterOverflow(dynamic intVal) 
        {
            dynamic result= intVal;

            if(intVal < 0)
            {
                result = maxRangeOfNumber + intVal;
            };
            if (intVal > maxRangeOfNumber)
            {
                result = intVal - maxRangeOfNumber;
            };

            return result;
        }

    }
}
