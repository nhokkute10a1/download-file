/*
     Framework              : using Framework 3.5
     System Libary          : System
     Design Pattern Libary  : None
*/

using System;

namespace FileDownloader
{
    internal class StreamCopyCompleteEventArgs : EventArgs
    {
        public CompletedState CompleteState { get; set; }
        public Exception Exception { get; set; }
    }
}