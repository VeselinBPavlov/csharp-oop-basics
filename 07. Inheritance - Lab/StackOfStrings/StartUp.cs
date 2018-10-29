namespace CustomStack
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var stack = new StackOfStrings();
            stack.Push("Pesho");
            stack.Push("Gosho");
            stack.Push("Tosho");
            stack.Push("Sasho");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Peek());
        }
    }
}
