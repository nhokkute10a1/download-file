using System;
using System.Net;
using FileDownloader;

namespace ConsoleDownloadManager
{
    internal class DownloadCacheImplementation : IDownloadCache
    {
        public void Add(Uri uri, string path, WebHeaderCollection headers)
        {
            throw new NotImplementedException();
        }

        public string Get(Uri uri, WebHeaderCollection headers)
        {
            throw new NotImplementedException();
        }

        public void Invalidate(Uri uri)
        {
            throw new NotImplementedException();
        }
    }
}