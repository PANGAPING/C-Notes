using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "";

            string folderName = "";


            //1


            if (!File.Exists(fileName)) {
                File.Create(fileName);
            }

            File.ReadAllLines(fileName);


            Directory.Exists(folderName);

            DirectoryInfo dir = new DirectoryInfo(folderName);

            foreach (FileInfo f in dir.GetFiles("*.exe")) {
                string name = f.Name;
                long size = f.Length;
                DateTime createTime = f.CreationTime;
            }


            //2

            FileStream fs = new FileStream(fileName, FileMode.Create);
            BinaryWriter w = new BinaryWriter(fs);

            for (int i = 0; i < 11; i++) {
                w.Write("a");
            }


            w.Close();

            fs.Close();


            //3

            using (StreamWriter sw = File.AppendText(fileName)) {

                Log("hehe", sw);
 
            }


            //4 read


            //FileStream fs1 = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            //BinaryReader r = new BinaryReader(fs);
            //for (int l = 0; l < 11; l++) {
            //    Console.WriteLine(r.ReadString());
            //}

            //r.Close();
            //fs.Close();


            using (StreamReader sr = File.OpenText(fileName)) {
                string input;
                while ((input = sr.ReadLine()) != null) {
                    Console.Write(input);
                }
            }


        }



        public static void Log(string logMessage, TextWriter w) {

            w.Write("\r\n Log Entry: ");

            w.WriteLine(":{0}", logMessage);

            w.Flush();
                    
        }





    }
}
