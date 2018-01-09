/*
     Framework              : using Framework 3.5
     System Libary          : System
     Design Pattern Libary  : None
*/

using System;

namespace FileDownloader
{
    internal class StreamCopyProgressEventArgs : EventArgs
    {
        public long BytesReceived { get; set; }
    }
}