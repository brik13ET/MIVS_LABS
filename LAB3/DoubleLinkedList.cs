namespace LAB3
{
    class DoubleLinkedList<T>
    {
        private DoubleLinkedListNode<T> Head;
        public DoubleLinkedListNode<T> head
        {
            get
            {
                return Head;
            }
            set
            {
                Head = value;
            }
        }
        public DoubleLinkedList()
        {
            head = new DoubleLinkedListNode<T>();
            head.Next = head;
            head.Prev = head;
        }
        public void Insert(T v)
        {
            if (head != null)
            {
                var p = new DoubleLinkedListNode<T>(v);
                p.Next = head;
                p.Prev = head.Prev;
                head.Prev.Next = p;
                head.Prev = p;
                p.Val = v;
            }
        }

        public void Clear()
        {
            head = new DoubleLinkedListNode<T>();
            head.Next = head;
            head.Prev = head;
        }
    }

    class DoubleLinkedListNode<T>
    {
        T val ;
        public DoubleLinkedListNode<T> Next { get; set; }
        public DoubleLinkedListNode<T> Prev { get; set; }
        public T Val { get => val; set => val = value; }

        public DoubleLinkedListNode()
        {
            Next = null;
            Prev = null;
            val = default(T);
        }
        public DoubleLinkedListNode(T val_)
        {
            val = val_;
        }
        public DoubleLinkedListNode(T val_, DoubleLinkedListNode<T> next, DoubleLinkedListNode<T> prev)
        {
            val = val_;
            Next = next;
            Prev = prev;
        }

    }

}
