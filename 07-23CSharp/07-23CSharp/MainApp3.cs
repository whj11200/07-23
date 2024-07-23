//using System;
//using System.Collections;
//using System.Collections.Generic;

//namespace _07_23CSharp
//{
//    class MyList<T> : IEnumerator<T>, IEnumerable<T>
//    {
//        private T[] array;
//        int position = -1; // 초기값이 -1로 설정

//        public MyList()
//        {
//            Console.WriteLine($"void 생성자 호출");
//            array = new T[5];
//            Console.WriteLine($"{array.Length}");
//        }

//        public T this[int idx]
//        {
//            get { return array[idx]; }
//            set
//            {
//                if (idx >= array.Length)
//                {
//                    Array.Resize(ref array, idx + 1);
//                    Console.WriteLine($"{array.Length}");
//                }
//                array[idx] = value;
//            }
//        }

//        public int Length // 'Legth'를 'Length'로 수정
//        {
//            get { return array.Length; }
//        }

//        public T Current // IEnumerator<T>의 Current 속성 구현
//        {
//            get { return array[position]; }
//        }

//        object IEnumerator.Current => Current; // non-generic Current

//        public void Dispose()
//        {
//            // 필요한 경우 자원 해제 로직
//        }

//        public IEnumerator<T> GetEnumerator() // IEnumerable<T>의 GetEnumerator
//        {
//            return this;
//        }

//        public bool MoveNext() // IEnemrator의 MoveNext 메소드
//        {
//            if (position >= array.Length - 1)
//            {
//                Reset();
//                return false;
//            }
//            position++;
//            return position < array.Length;
//        }

//        public void Reset()
//        {
//            position = -1;
//        }

//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            return GetEnumerator();
//        }
//    }

//    internal class MainApp3
//    {
//        static void Main(string[] args)
//        {
          
//            MyList<string> str_list = new MyList<string>();
//            str_list[0] = "adasda";
//            str_list[1] = "bdasd";
//            str_list[2] = "cdsa";

//            foreach (string i in str_list)
//            {
//                Console.WriteLine(i);
//            }

//            MyList<decimal> doubles = new MyList<decimal>();
//            doubles[0] = 1.132454694849884m;
//            doubles[1] = 1.0000001516646m;
//            doubles[2] = 12.48648646666m;

//            foreach (decimal d in doubles)
//            {
//                Console.WriteLine(d);
//            }
//        }
//    }
//}
