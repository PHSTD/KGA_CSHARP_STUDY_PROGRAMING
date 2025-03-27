using System.Collections.Specialized;
using System.ComponentModel.Design;

namespace Day250327_1;

class Program
{
    // <인덱서 정의>
    // this[]를 속성으로 정의하여 클래스의 인스턴스에 인덱스 방식으로 접근 허용
    public class Indexer
    {
        private int[] array = new int[10];

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
    }

    // <인덱서 자료형>
    // 인덱서는 다른 자료형 사용도 가능
    // 열거형을 통해 인덱서를 사용하는 경우도 빈번
    public enum Parts { Head, Body, Feet, Hand, SIZE }
    public class Equipment
    {
        string[] parts = new string[(int)Parts.SIZE];

        public string this[Parts type]
        {
            get
            {
                return parts[(int)type];
            }
            set
            {
                parts[(int)type] = value;
            }
        }
    }

  
        

        public static void Main()
        {
            Equipment equipment = new Equipment();

            equipment[Parts.Hand] = "투구";
            equipment[Parts.Body] = "갑옷";

            string curHead = equipment[Parts.Head];
            
        }
}

