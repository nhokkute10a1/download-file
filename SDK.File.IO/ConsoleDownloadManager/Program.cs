using FileDownloader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleDownloadManager
{
    class Program
    {
        private IFileDownloader fileDownloader = new FileDownloader.FileDownloader(new DownloadCacheImplementation());
        static void Main(string[] args)
        {

        }
    }
}
