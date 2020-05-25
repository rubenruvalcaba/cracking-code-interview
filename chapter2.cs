using System;
using System.Text;

public class chapter2
{

    public static void Run()
    {
        /*
        var linkedList = new linkedList();
        linkedList.Add(4);
        linkedList.Add(3);
        linkedList.Add(8);
        linkedList.Add(7);
        linkedList.Add(2);
        Console.WriteLine($"LinkedList: {linkedList}");

        var k = 4;
        var result = linkedList.GetKthFromLast(k);
        Console.WriteLine($" {k}th from last is: {result}");
        */
        var linkedList = new linkedList2();
        linkedList.Add("a");
        linkedList.Add("a");
        linkedList.Add("b");
        linkedList.Add("c");
        linkedList.Add("a");
        Console.WriteLine($"LinkedList: {linkedList}");
        Console.WriteLine($"LinkedList is Palindrome {linkedList.IsPalindrome()}");


    }

    public class linkedList
    {
        public class Node
        {

            public int Value { get; set; }
            public Node Next { get; set; }

            public override string ToString()
            {
                return Value.ToString();
            }
        }

        Node head;
        Node tail;
        int count;

        public void Add(int value)
        {
            Node newNode = new Node() { Value = value };
            if (head == null)
                head = newNode;
            else
                tail.Next = newNode;
            tail = newNode;
            count++;
        }

        public override string ToString()
        {
            if (head == null)
                return null;

            StringBuilder sb = new StringBuilder();
            ToString(head, sb);

            return sb.ToString();

        }

        public void ToString(Node node, StringBuilder sb)
        {
            if (node == null)
                return;
            sb.Append(node.Value);
            if (node.Next != null)
            {
                sb.Append("->");
                ToString(node.Next, sb);
            }
        }

        public Node GetKthFromLast(int k)
        {
            if (k < 0)
                throw new ArgumentException("K must be positive value");

            if (k > count - 1)
                throw new ArgumentException($"K cant be greather than {count - 1}");

            Node result = null;

            for (int i = 0; i < count - k; i++)
                if (result == null)
                    result = head;
                else
                    result = result.Next;

            return result;
        }

    }


    public class linkedList2
    {
        public class Node
        {
            public int Id { get; set; }
            public string Value { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }
            public override string ToString()
            {
                return Value.ToString();
            }
        }

        private Node head;
        private Node tail;
        private int count;


        public void Add(string value)
        {
            Node newNode = new Node() { Value = value, Id = count };
            if (head == null)
                head = newNode;
            else
                tail.Next = newNode;

            newNode.Previous = tail;
            tail = newNode;
            count++;

        }

        public bool IsPalindrome()
        {
            if (count <= 1)
                return true;

            Node h = head;
            Node t = tail;

            while (h.Id != t.Id && h != null && t != null)
            {
                if (h.Value != t.Value)
                    return false;
                h = h.Next;
                t = t.Previous;
            }

            return true;

        }

        public override string ToString()
        {
            if (head == null)
                return null;

            StringBuilder sb = new StringBuilder();
            ToString(head, sb);

            return sb.ToString();

        }

        public void ToString(Node node, StringBuilder sb)
        {
            if (node == null)
                return;
            sb.Append(node.Value);
            if (node.Next != null)
            {
                sb.Append("->");
                ToString(node.Next, sb);
            }
        }


    }

}