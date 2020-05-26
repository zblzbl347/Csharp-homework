using System;

namespace list
{

    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head
        {
            get;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void Foreach(Action<T> action)
        {
            for (Node<T> p = head; p != null; p = p.Next)
            {
                action(p.Data);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            GenericList<int> list = new GenericList<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i + random.Next(0, 10));
            }
            list.Foreach(data => Console.Write(data + "  "));
            Console.WriteLine();
            list.Foreach(data => max = data > max ? data : max);
            list.Foreach(data => min = data < min ? data : min);
            list.Foreach(data => sum += data);
            Console.WriteLine($"最大值为：{max}，最小值为：{min}，和为：{sum}");
        }

    }

}
