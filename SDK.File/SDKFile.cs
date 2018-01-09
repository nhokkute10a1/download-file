using System;
using System.Linq;
using System.Security.Cryptography;
namespace SDK.File
{
    public static class SDKFile
    {
        /*==Tính toán MD5 của tệp tin đưa vào==*/
        public static string CheckSumMD5(string FileName)
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
        /*==Kiểm tra tệp gốc và tệp tải về==*/
        public static bool CheckSum(string SourceFile, string DestFile)
        {
            return CheckSumMD5(SourceFile).SequenceEqual(CheckSumMD5(DestFile)) ? true : false;
        }
    }
}