using System;
using System.IO;

namespace myFileIO{
    class Program{
        static void Main(string[] args){
            string writeTxt = "Hello World!";
            File.WriteAllText("files.txt",writeTxt);
            string readTxt = File.ReadAllText("files.txt");
            Console.WriteLine(readTxt);

            try{
                int[] myNum = {1,2,3};
                Console.WriteLine(myNum[10]);
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }finally{
                Console.WriteLine("You catched error...")
            }
        }
    }
}
