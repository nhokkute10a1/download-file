using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using FileDownloader.CheckSum;
namespace ConsoleAppDownloadFile
{
    class Program
    {
        private static List<string> list = new List<string>();
        //Tạo danh sách CheckSum
        private static List<string> listCheck = new List<string> { "eecebf71f41ae5c2f9db89c81e7962e4", "ece383eba489e2e198b309e5ef78ff05" };
        private static string Path = AppDomain.CurrentDomain.BaseDirectory + @"\File\";//Lấy thư mục hiện tại
        static void Main(string[] args)
        {
            ////var T = new Thread(new ThreadStart(CheckSumDemo));
            ////T.Start();
            //var File = @"C:\Users\asus\Desktop\DownloadFileCheckSum\SDK.File.IO\ConsoleAppDownloadFile\bin\Debug\File\20172905Bw-server-real-time-app-zplus.zip";
            //CheckSum.Instance.CreatedCheckSumMD5(File);
            ////var etag = HashOf(File, 7757625);
            //Console.WriteLine(CheckSum.Instance.CreatedCheckSumMD5(File));
            //Console.ReadLine();
            var FileName = "https://s3-us-west-1.amazonaws.com/elasticbeanstalk-us-west-1-833434519629/20172905Bw-server-real-time-app-zplus.zip";
            Console.WriteLine(CheckSum.Instance.CreatedCheckSumMD5Online(FileName));
            Console.ReadLine();
        }
        private static void CheckSumDemo()
        {
            FileInfo[] Files = new DirectoryInfo(Path).GetFiles();//Lấy danh sách tệp tin của máy trạm
            Console.WriteLine("=======List-Files-With-CheckSum=======");
            Console.WriteLine();
            foreach (var item in CheckSum.Instance.GetListFiles(Path, "*"))//Lấy danh sách tệp tin của máy chủ download
            {
                list.Add(item.FileMD5);
                Console.WriteLine("File Name [[{0}]] | File MD5 [[{1}]]",
                    item.FileName,
                    item.FileMD5
                );
            }
            Console.WriteLine();
            Console.WriteLine("=======Total-File-Exits=======");
            Console.WriteLine();
            var count = 0;
            foreach (var item in list)
            {
                foreach (var itemCheck in listCheck)
                {
                    if (item.Contains(itemCheck))
                    {
                        count++;
                        Console.WriteLine("CheckSum Exits [[{0}]]", itemCheck);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Total File Exits [[{0}]]", count);
            Console.ReadLine();
        }

        private static string HashOf(string filename, int chunkSizeInMb)
        {
            string returnMD5 = string.Empty;
            int chunkSize = chunkSizeInMb * 1024 * 1024;

            using (var crypto = new MD5CryptoServiceProvider())
            {
                int hashLength = crypto.HashSize / 8;

                using (var stream = File.OpenRead(filename))
                {
                    if (stream.Length > chunkSize)
                    {
                        int chunkCount = (int)Math.Ceiling((double)stream.Length / (double)chunkSize);

                        byte[] hash = new byte[chunkCount * hashLength];
                        Stream hashStream = new MemoryStream(hash);

                        long nByteLeftToRead = stream.Length;
                        while (nByteLeftToRead > 0)
                        {
                            int nByteCurrentRead = (int)Math.Min(nByteLeftToRead, chunkSize);
                            byte[] buffer = new byte[nByteCurrentRead];
                            nByteLeftToRead -= stream.Read(buffer, 0, nByteCurrentRead);

                            byte[] tmpHash = crypto.ComputeHash(buffer);

                            hashStream.Write(tmpHash, 0, hashLength);

                        }

                        returnMD5 = BitConverter.ToString(crypto.ComputeHash(hash)).Replace("-", string.Empty).ToLower() + "-" + chunkCount;
                    }
                    else
                    {
                        returnMD5 = BitConverter.ToString(crypto.ComputeHash(stream)).Replace("-", string.Empty).ToLower();

                    }
                    stream.Close();
                }
            }
            return returnMD5;
        }
    }
    /*==Hướng dẫn cơ bản về Checksum==*/
    /*
        Tại thời điểm A là 13:00 với tệp tin A có mã check sum là 76cdb2bad9582d23c1f6f4d868218d6c
        Sau khi tải lên máy chủ tệp tin A với mã check sum là 76cdb2bad9582d23c1f6f4d868218d6c
        Sau một thời gian người dùng cần tải tệp tin A về máy
        Thì bạn phải kiểm tra mã CheckSum của tệp tin A có khớp với tệp mã CheckSum lúc đầu
        hay không,nếu đúng thì tệp tin không bị hư hại trong quá trình tải lên máy chủ
        còn nếu cùng 1 tệp tin mà 2 mã khác nhau thì tệp tin đó đã bị chỉnh sửa lại hoặc bị
        hư hại trong quá trình tải lên
    */
    /*==Hướng dẫn cơ bản sử dụng thư viện CheckSum==*/
    /*
        Để sử dụng thư viện Check cần phải usingn FileDownloader trong project FileDownloader
        trong đây bao gồm 3 hàm cơ bản
        CreatedCheckSumMD5 : Tạo mã MD5 từ tệp tin,Dữ liệu trả về là 1 chuỗi
        CheckSumFile : Kiểm tra mã checksum từ tệp tin gốc và tệp tin được tải về máy bạn,dữ liệu trả về là true/false
        GetListFiles : Lấy danh sách tệp tin trong 1 thư mục với mọi định dạng,dữ liệu trả về là 1 danh sách(list) files
        Xem ví dụ phía trên
    */
}
