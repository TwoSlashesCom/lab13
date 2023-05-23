using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    public class DoublyLinkedList : IEnumerable
    {
        DoublyNode Head;
        DoublyNode Tail;
        int count;

        public void AddLast(int Data)
        {
            DoublyNode node = new DoublyNode(Data);

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }

            Tail = node;
            count++;
        }

        public void AddFirst(int Data)
        {
            DoublyNode node = new DoublyNode(Data);
            DoublyNode temp = Head;
            node.Next = temp;
            Head = node;

            if (Count == 0)
            {
                Tail = Head;
            }
            else
            {
                temp.Previous = node;
            }

            count++;
        }

        public int GetFirst()
        {
            return Head.Data;
        }
        public int GetLast()
        {
            return Tail.Data;
        }

        public bool Remove(int data)
        {
            DoublyNode current = Head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }

                current = current.Next;
            }
            if (current != null)
            {
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }

                else
                {
                    Tail = current.Previous;
                }

                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }

                else
                {
                    Head = current.Next;
                }
                count--;
                return true;
            }
            return false;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            Head = null;
            Tail = null;
            count = 0;
        }
        public bool Contains(int data)
        {
            DoublyNode current = Head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public string ToString(DoublyLinkedList a)
        {
            return Convert.ToString(a);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            DoublyNode current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }


        public IEnumerable<int> BackEnumerator()
        {
            DoublyNode current = Tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
    }

}
}
