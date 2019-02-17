using System.Collections;
using System.Collections.Generic;


namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    internal class LinkedList : IEnumerable<int>
    {
        internal class ListElm
        {
            public int Value { get; set; }
            public ListElm Next { get; set; }


            public ListElm(int value)
            {
                Value = value;
                Next = null;
            }


            public ListElm(int value, ListElm next)
                : this(value)
            {
                Next = next;
            }


            public static bool operator <(ListElm lhs, ListElm rhs)
            {
                return lhs.Value < rhs.Value;
            }


            public static bool operator >(ListElm lhs, ListElm rhs)
            {
                return rhs < lhs;
            }


            public static bool operator <=(ListElm lhs, ListElm rhs)
            {
                return lhs.Value <= rhs.Value;
            }


            public static bool operator >=(ListElm lhs, ListElm rhs)
            {
                return rhs <= lhs;
            }
        }


        private ListElm _headPtr;
        private ListElm _tailPtr;
        public int Length
        {
            get
            {
                var tempPtr = _headPtr;
                int i;
                for (i = 0; tempPtr != null; i++, tempPtr = tempPtr.Next) ;
                return i;
            }
        }


        public void Add(int value, int insertAfterThis)
        {
            var newElm = new ListElm(value, null);
            if (_headPtr == null)
                _headPtr = _tailPtr = newElm;
            else
            {
                ListElm tempPtr;
                for (tempPtr = _headPtr; tempPtr.Next != null && tempPtr.Next < _headPtr; tempPtr = tempPtr.Next) ;
                newElm.Next = tempPtr.Next;
                tempPtr.Next = newElm;
                if (newElm.Next == null)
                    _tailPtr = newElm;
            }
        }


        public void Add(int value)
        {
            var newElm = new ListElm(value, null);
            if (_headPtr == null)
                _headPtr = _tailPtr = newElm;
            else
            {
                _tailPtr.Next = newElm;
                _tailPtr = newElm;
            }
        }


        public bool RemoveLast()
        {
            if (_headPtr == null) return false;
            var remove = _headPtr;
            while (remove.Next != _tailPtr)
                remove = remove.Next;
            remove.Next = null;
            _tailPtr = remove;
            return true;
        }


        public bool RemoveEven()
        {
            if (Length < 2) return false;
            for (var tempPtr = _headPtr; tempPtr.Next != null; tempPtr = tempPtr.Next)
                tempPtr.Next = tempPtr.Next.Next;
            return true;
        }


        public string RecursiveOddPrint()
        {
            string result = "";
            if (_headPtr == null) return result;
            result = PrivateRecursiveOddPrint(_headPtr);
            return result;
        }


        private string PrivateRecursiveOddPrint(ListElm ptr)
        {
            if (ptr == null) return "";
            string result = ptr.Value + "\r\n";
            return ptr.Next == null ? result : result + PrivateRecursiveOddPrint(ptr.Next.Next);
        }

        private void Swap(ListElm a, ListElm b)
        {
            int c = a.Value;
            a.Value = b.Value;
            b.Value = c;
        }

        public void Sort()
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (var tempPtr = _headPtr; tempPtr.Next != null; tempPtr = tempPtr.Next)
                {
                    if (tempPtr < tempPtr.Next) continue;
                    Swap(tempPtr, tempPtr.Next);
                    flag = true;
                }
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (var tempPtr = _headPtr; tempPtr != null; tempPtr = tempPtr.Next)
                yield return tempPtr.Value;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}