////using System;
////using System.Collections;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;
////using static System.Console;

////namespace _07_23CSharp
////{

////    // 인덱서 프로퍼티
////    // 일반화 프로그래밍
////    // 일반화 메서드

////    #region 인덱서 프로터피
////    //class MyList :IEnumerable,IEnumerator
////    //{
////    //private int[] array;
////    //int position = -1; //  초기값이 0이기때문에 -1로 등급
////    //public MyList()
////    //{
////    //    Console.WriteLine($"void 생성자 호출");
////    //    array = new int[5];
////    //    WriteLine($"{array.Length}");

////    //}
////    //public int this[int idx]
////    //{
////    //    get { return array[idx]; }
////    //    set { if (idx >= array.Length)
////    //        {
////    //            Array.Resize<int>(ref array, idx + 1);
////    //            Console.WriteLine($"{array.Length}");
////    //        }
////    //        array[idx] = value;
////    //    }
////    //}
////    //public int Legth
////    //{
////    //    get { return array.Length; }
////    //}

////    //public object Current // IEnumerator 의 멤버
////    //{
////    //    // IEnumerator 로 상속 받은 Current 프로퍼티는 현재 위치 요소 반환
////    //    get { return array[position]; }
////    //}

////    //public IEnumerator GetEnumerator() // IEnumerator 의 멤버
////    //                                   // IEnumerator() 메소드는 IEnumerator 형식 객체
////    //{
////    //    return this;
////    //}

////    //public bool MoveNext() //  IEnemrator 의 멤버 MoveNext 메소드
////    //                          // 다음 위치로 이동
////    //{
////    //    if (position == array.Length -1)
////    //    {
////    //        Reset();
////    //        return false;
////    //    }
////    //    position++;
////    //    return (position < array.Length);
////    //}

////    //public void Reset()
////    //{
////    //    position = -1;
////    //}
////    //class MyEnumerator
////    //{
////    //    int[] numbers = { 1, 2, 3, 4,5 };
////    //    public IEnumerator GetEnumerator()
////    //    {
////    //        yield return numbers[0];
////    //        yield return numbers[1];
////    //        yield return numbers[2];

////    //        yield break;
////    //        yield return numbers[3];

////    //    }

////    //}
////    #endregion
////    //}
////    internal class Mainapp
////    {

////        static void Main(string[] args)
////        {
////            #region 인덱서 프로터피
////            ////MyList list = new MyList();
////            ////for (int i = 1; i< 8; i++)
////            ////{
////            ////    list[i] = i;
////            ////}
////            ////foreach (int i in list)
////            ////{
////            ////    Console.WriteLine($"{list[i]}");
////            ////}
////            ////WriteLine();
////            ////var obj = new MyEnumerator();
////            ////foreach (int i in obj)
////            ////{
////            ////    Console.WriteLine(i);
////            ////}
////            #endregion
////            CopyMethod copyMethod = new CopyMethod();
////            int[] source = { 1, 2, 3, 4, 5 };
////            int[] target = new int[source.Length];
////            copyMethod.CapyArray<int>(source, target);
////            foreach (int i in target)
////            {
////                Console.WriteLine(i);
////            }
            
////            double[] source1 = { 1.1, 2.2, 3.3, 4.4, 5.5 };
////            double[] target2 = new double[source1.Length];
////            copyMethod.CapyArray<double>(source1, target2);
////            foreach (double de in target2)
////            {
////                Console.WriteLine(de);
////            }
////            string[] source3 = { "엥?" };
////            string[] target3 = new string[source3.Length];
////            copyMethod.CapyArray(source3, target3);
////            foreach (string nn in target3)
////            {
////                Console.WriteLine(nn);
////            }

////        }

////    }
   
////}
