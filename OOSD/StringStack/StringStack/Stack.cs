using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringStack
{
    public class Stack
    {
        
        StringNode top = null;

        public Stack()
        {
            
        }

        public void Push(string newString)
        {
            StringNode newNode = new StringNode(newString);

            if (top == null)
            {                
                top = newNode;
            }
            else
            {                
                newNode.Next = top;
                top = newNode;
            }
        }

        public String Pop()
        {
            try
            {
                //get the string from the last added node on stack
                String returnString = top.nodeString;

                //remove the top node from the stack
                top = top.Next;                

                return returnString;
            }
                //if nothing on the stack
            catch (NullReferenceException)
            {
                throw new NullReferenceException("no items in stack");
            }
                
        }

        public String Peek()
        {
            try
            {
                return top.nodeString;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("no items in stack");
            }            
            
        }

        public int Count()
        {
            int count = 0;

            StringNode nodeWalker = top;

            while (nodeWalker != null)
            {
                count++;
                nodeWalker = nodeWalker.Next;
            }

            return count;
        }

        public bool IsEmpty()
        {
            if (top == null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
