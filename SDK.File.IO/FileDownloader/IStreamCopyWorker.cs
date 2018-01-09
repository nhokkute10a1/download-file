/*
     Framework              : using Framework 3.5
     System Libary          : System,System.IO
     Design Pattern Libary  : None
*/

using System;
using System.IO;

namespace FileDownloader
{
    internal interface IStreamCopyWorker
    {
        event EventHandler<StreamCopyCompleteEventArgs> Completed;

        event EventHandler<StreamCopyProgressEventArgs> ProgressChanged;

        long Position { get; }

        void CopyAsync(Stream source, Stream destination, long sizeInBytes);

        void Cancel();
    }
}