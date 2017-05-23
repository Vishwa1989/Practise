using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{

    class Program
    {
        public static void reversestring()
        {
            string Str, reversestring = "";
            int Length;
            Console.Write("Enter A String : ");
            Str = Console.ReadLine();
            Length = Str.Length - 1;
            while (Length >= 0)
            {
                reversestring += Str[Length];
                Length--;
            }
            Console.WriteLine("Reverse  String  Is  {0}", reversestring);
            Console.ReadLine();
        }

        public static void Palindrome()
        {
            Console.Write("Enter A String : ");
            bool ispalindrome = true;
            string input = Console.ReadLine();
            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    ispalindrome = false;
                    Console.WriteLine("It is not palindrome");
                    break;
                }
            }
            if (ispalindrome)
                Console.WriteLine("it is palindrome");
        }

        static void Main(string[] args)
        {


            LinkedList lnklist = new LinkedList();
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.AddatLast(1);
            lnklist.AddatLast(2);
            lnklist.AddatLast(3);
            lnklist.AddatLast(4);
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.AddatFirst(0);
            lnklist.PrintAllNodes();
            Console.WriteLine();
            lnklist.InsertatParticularPosition(3, 2.5);
            lnklist.PrintAllNodes();
            lnklist.RemovefromStart();
            lnklist.PrintAllNodes();

            Console.ReadKey();
            Console.ReadLine();
        }
    }

    public class Node
    {
        public Node Next;
        public object Value;
    }
    public class LinkedList
    {
        private Node head;
        private Node current;
        public int Count;

        public LinkedList()
        {
            head = new Node();
            current = head;
        }

        public void InsertatParticularPosition(int position, object data)
        {
            Node dummy = new Node();

            if (Count >= position)
            {
                dummy = head;
                for (int i = 0; i < position; i++)
                {
                    dummy = dummy.Next;
                }
                Node node = new Node();
                node.Value = data;
                node.Next = dummy.Next;
                dummy.Next = node;
            }
            else
            {
                Console.WriteLine("No element at the position!");
            }
            

        }

        public void AddatLast(object data)
        {
            Node node = new Node();
            node.Value = data;
            current.Next = node;
            current = node;
            Count++;
        }

        public void AddatFirst(object data)
        {
            Node node = new Node();
            node.Value = data;
            node.Next = head.Next;
            head.Next = node;
            Count++;
        }

        public void RemovefromStart()
        {
            if (Count > 0)
            {
                head.Next = head.Next.Next;
                Count--;
            }
            else
            {
                Console.WriteLine("No element in Linked List!");
            }
        }
        public void PrintAllNodes()
        {
            Console.WriteLine("Head ->");
            Node curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write("->");
            }
            Console.Write("Null");
        }
    }
}
