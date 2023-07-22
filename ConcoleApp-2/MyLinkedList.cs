using System.Collections;

namespace ConsoleApp2
{
    public class MyLinkedList<T> : IEnumerable<T>
    {
        public int Count { get; private set; }
        public class LinkedListNode
        {
            public LinkedListNode(T value)
            {
                Value = value;
            }

            public T Value { get; internal set; }
            public LinkedListNode next { get; internal set; }
        }


        private LinkedListNode head;
        private LinkedListNode tail;

        public void Add(T value)
        {
            LinkedListNode node = new LinkedListNode(value);

            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }

            Count++;
        }

        public void Push(T value)
        {
            LinkedListNode node = new LinkedListNode(value);

            if (head == null)
            {
                head = node;
                tail = node;
            }
            node.next = head;
            head = node;

            Count++;
        }

        public void Remove(T item)
        {
            LinkedListNode previous = null;
            LinkedListNode target = head;

            while (target != null)
            {
                if (target.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.next = target.next;

                        if (target.next == null)
                        {
                            tail = previous;
                        }
                    }
                    else
                    {
                        head = head.next;

                        if (head == null)
                        {
                            tail = null;
                        }
                    }

                    Count--;
                }

                previous = target;
                target = target.next;
            }
        }


        public void Pop() 
        {
            if (head != null)
            {
                LinkedListNode target = head;
                head = target.next;
                Count--;
            }
            else Console.WriteLine("List head missing");

        }

        public T Peek()
        {
            if (this.head == null) throw new InvalidOperationException("List head missing!"); // ?? DW

            return head.Value;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public IEnumerator<T> GetEnumerator() 
        {
            LinkedListNode target = head;
            while (target != null)
            {
                yield return target.Value;
                target = target.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}

