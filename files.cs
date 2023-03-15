using System;
using System.IO;
using System.Security.Cryptography;

namespace myFileIO{
    class Program{
        static void Main(string[] args){
            byte[] key = {0x02, 0x03, 0x01, 0x03, 0x03, 0x07, 0x07, 0x08, 0x09, 0x09, 0x11, 0x11, 0x16, 0x17, 0x19, 0x16};
            try{
                using FileStream myStream = new FileStream(@"C:\Users\10710516\OneDrive - LTI\Desktop\JBL\CS_Files\files.txt",FileMode.OpenOrCreate);

                using Aes aes = Aes.Create();
                aes.Key = key;

            }catch{
                Console.WriteLine("Error");
                throw;
            }
            
            Console.WriteLine("Running...");

        }
    }
}