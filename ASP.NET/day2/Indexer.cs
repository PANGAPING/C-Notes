using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyIndexer
    {

        static void Main(string[] args) {

            var names = new IndexedNames();
            names[1] = "dengweihao";

        }

    }


    class IndexedNames {
        private string[] nameList = new string[10];

        public IndexedNames()
        {
            for (int i = 0; i < nameList.Length; i++) {
                nameList[i] = "N/A";
            }
        }

        public string this[int index]
        {

            get
            {
                string tmp;
                if (index >= 0 && index <= nameList.Length - 1)
                {
                    tmp = nameList[index];
                }
                else {
                    tmp = "";
                }

                return tmp;
            }

            set
            {

                if (index >= 0 && index < nameList.Length - 1) {
                    nameList[index] = value;
                }
            }
        }

        public int this[string name] {
            get {
                int index = 0;
                while (index < nameList.Length) {
                    if (nameList[index] == name) {
                        return index;
                    }

                    index++;
                }
                return -1;
            }
        }
    }


    public interface ISomeInterface {
        int this[int index] {
            get;
            set;
        }
    }

    public class IndexerClass1 : ISomeInterface {
        private int[] arr = new int[100];

        public int this[int index] {
            get {
                return arr[index];
            }
            set {

            }
        }
    }
}
