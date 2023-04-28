namespace mystackgeneric
{
    class MyStack<A>
    {
        A[] stackArray;
        int top;
        public MyStack()
        {
            stackArray = new A[10];
            top = -1;
        }
        public void Push(A item)
        {
            if (top == stackArray.Length - 1)
            {
                Console.WriteLine(" Stack is OverFlow");
            }
            else
            {
                top = top + 1;
                stackArray[top] = item;
            }
        }
        public A Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is UnderFlow");
            }
            A item = stackArray[top];
            top--;
            return item;
        }
        public A Top
        {
            get
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is empty");
                }
                return stackArray[top];
            }
        }
        public int Count
        {
            get { return top + 1; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine("Count of the stack is: " + stack.Count);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Push(6);
            Console.WriteLine("Top of the stack is: " + stack.Top);
            Console.WriteLine("Count of the stack is: " + stack.Count);
        }
    }
}