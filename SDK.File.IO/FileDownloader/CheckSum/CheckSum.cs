/*
     Framework              : using Framework 3.5
     System Libary          : System.Security.Cryptography,System,Linq
     Design Pattern Libary  : Singleton
*/

using System;
using System.Linq;
using System.Security.Cryptography;

namespace FileDownloader.CheckSum
{
    public class CheckSum
    {
        private static CheckSum instance;
        private static object syncRoot = new object();
        private CheckSum() { }
        public static CheckSum Instance
        {
            get
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new CheckSum();
                    }
                }
                return instance;
            }
        }
        /// <summary>
        /// CreatedCheckSumMD5
        /// Caculator MD5 Of File
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns>String</returns>
        public string CreatedCheckSumMD5(string FileName)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = System.IO.File.OpenRead(FileName))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
        /// <summary>
        /// Compare File Origin File with Destination File
        /// CheckSumFile
        /// </summary>
        /// <param name="SourceFile"></param>
        /// <param name="DestFile"></param>
        /// <returns>bool</returns>
        public bool CheckSumFile(string SourceFile, string DestFile)
        {
            return CreatedCheckSumMD5(SourceFile).SequenceEqual(CreatedCheckSumMD5(DestFile)) ? true : false;
        }
    }
}
