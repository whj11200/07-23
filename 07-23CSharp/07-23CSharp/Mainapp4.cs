//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _07_23CSharp
//{
//    // List <T> 클래스는 비일반화 클래스인 ArrayList와 같이 기능을 한다 
//    // 사용법 역시 동일하지만 차이점은 List<T> 클래스는 인스턴스를 만들 때 형식 매개 변수를 필요로 한다는 것과
//    // 한 컬렉션에 아무 형식의 객체 나 마구 집어 넣을 수 있었던 ArrayList 달리 매개변수에 입력한 형식외에는 다르다.
//    class StructArray<T> where T : struct // 형식 매개변수 T는 반드시 값 형식이여야한다.
//    {
//        public T[] Array { get; set; }
//        public StructArray(int size)
//        {
//            Array = new T[size];
//        }
       
        
//    }
//    class RefArray<T> where T : class       // 이 클래스는 참조 형식 데이터만 받겠다라는 의미
//    {
//        public T[] Array { get; set; }  // 자동 프로퍼티
//        public RefArray(int size)       // 매개변수가 있는 생성자
//        {
//            Array = new T[size];        // 배열을 생성
//        }
//    }

//    class Base { }                              // Base 클래스
//    class Derived : Base { }                    // Base 클래스를 상속받은 Derived 클래스
//    class BaseArray<U> where U : Base       // 이 클래스는 반드시 Base 클래스를 상속받은 타입만 받겠다라는 의미
//    {
//        public U[] Array { get; set; }  // 자동 프로퍼티
//        public BaseArray(int size)      // 매개변수가 있는 생성자
//        {
//            Array = new U[size];        // 배열을 생성
//        }
//        public void CopyArray<T>(T[] Source) where T : U    // U로 제약된 타입 T를 매개변수로 받는 CopyArray 메서드
//        {
//            Source.CopyTo(Array, 0);    // 배열 복사
//        }
//    }

//    internal class Mainapp4
//    {
//       public static T CrateInstance<T>() where T : new()
//       {
//            return new T();
//       }
//        static void Main(string[] args)
//        {
//            StructArray<int> a = new StructArray<int>(3);
//           for (int i = 0; i < a.Array.Length; i++)
//           {
//                a.Array[i] = i;
//           }
//           for (int i = 0; i < a.Array.Length; i++)
//           {
//                Console.WriteLine(i);
//           }
//            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
//            b.Array[0] = new StructArray<double>(5);
//            b.Array[1] = new StructArray<double>(10);
//            b.Array[2] = new StructArray<double>(1005);
//            for (int i = 0; i < b.Array.Length; i++)
//            {
//                Console.WriteLine(b.Array[i]);
//            }
//            BaseArray<Base> baseArray = new BaseArray<Base>(3);
//            baseArray.Array[0] = new Base();
//            baseArray.Array[1] = new Derived();
//            baseArray.Array[2] = CrateInstance<Base>();
//            for (int i = 0;i < baseArray.Array.Length; i++)
//            {
//                Console.WriteLine(baseArray.Array[i]);
//            }
//            BaseArray<Derived> baseArr_der = new BaseArray<Derived>(3);
//            baseArr_der.Array[0] = new Derived();
//            baseArr_der.Array[1] = CrateInstance<Derived>();
//            baseArr_der.Array[2] = CrateInstance<Derived>();
//            for (int i = 0; i <= baseArr_der.Array.Length; i++)
//            {
//                Console.WriteLine(baseArr_der.Array[i]);
//            }
//        }
//    }
//}
