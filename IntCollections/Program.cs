using System;
using System.Collections.Generic;
using System.Text;

namespace IntCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<int> list = new List<int>() {1, 10, -30, 10, -5};
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(10);
            stack.Push(-30);
            stack.Push(10);
            stack.Push(-5);
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(10);
            queue.Enqueue(-30);
            queue.Enqueue(10);
            queue.Enqueue(-5);
            HashSet<int> hashSet = new HashSet<int>() {1, 10, -30, 10, -5};

            PrintCollection(list);
            PrintCollection(stack);
            PrintCollection(queue);
            PrintCollection(hashSet);
        }
        
        private static void PrintCollection<T>(IEnumerable<T> collection)
        {
            string fullName = collection.GetType().Name;
            int backtickIndex = fullName.IndexOf('`');
            if (backtickIndex > 0) fullName = fullName.Substring(0, backtickIndex);
            StringBuilder stringBuilder = new StringBuilder($"{fullName}: ");
            foreach (var item in collection)
            {
                stringBuilder.Append(item + ", ");
            }
            Console.WriteLine(stringBuilder.ToString().Substring(0, stringBuilder.Length - 2));
        }
    }
}