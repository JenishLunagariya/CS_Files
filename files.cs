using System;
using System.IO;

namespace myFileIO{
    class Program{
        static void Main(string[] args){
            string writeTxt = "Hello World!";
            File.WriteAllText("files.txt",writeTxt);
            string readTxt = File.ReadAllText("files.txt");
            Console.WriteLine(readTxt);

            writeTxt = "Password";
            File.WriteAllText("files.txt",writeTxt);
            readTxt = File.ReadAllText("files.txt");
            Console.WriteLine(readTxt);
        }
    }
}
