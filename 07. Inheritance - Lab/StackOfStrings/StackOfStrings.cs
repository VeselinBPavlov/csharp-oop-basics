namespace CustomStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StackOfStrings : List<string>
    {
        // Fields.
        private List<string> data = new List<string>();

        // Methods.
        public void Push(string element)
        {
            this.Add(element);
        }

        public string Pop()
        {
            string element = GetLastElement();
            this.RemoveAt(Count - 1);
            return element;
        } 

        public string Peek()
        {
            return GetLastElement();
        }

        public bool IsEmpty()
        {
            return this.Count < 1;
        }

        private string GetLastElement()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The Stack is empty");
            }

            return this.Last();
        }
    }
}
