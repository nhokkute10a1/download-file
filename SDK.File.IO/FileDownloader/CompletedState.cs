/*
     Framework              : using Framework 3.5
     System Libary          : None
     Design Pattern Libary  : None
 */

namespace FileDownloader
{
    /// <summary>
    /// Downloaded completed states
    /// </summary>
    public enum CompletedState
    {
        /// <summary>
        /// Download successful
        /// </summary>
        Succeeded,

        /// <summary>
        /// Download canceled
        /// </summary>
        Canceled,

        /// <summary>
        /// Download failed
        /// </summary>
        Failed
    }
}