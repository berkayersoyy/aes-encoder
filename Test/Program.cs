using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Helpers;

namespace Test
{
    class Program
    {


        static void Main(string[] args)
        {
            var key = "wEgDCNvhccofPTkFt9zUdDgZDIVdGC9L";
            var iv = "crGTopEfBGXE1k1x";

            var encryptedString = "40YLp07vJIuR0TfMaNByWwXdtsp5YFy56MU37H8=";

            var decryptedString = AESEncoder.DecryptString(key,AESEncoder.PlainIvToByteArray(iv), encryptedString);
            Console.WriteLine($"Çözülmüş = {decryptedString}");

            Console.ReadKey();

        }
       
    }
}
