/*
     Framework              : using Framework 3.5
     System Libary          : System
     Design Pattern Libary  : None
 */

using System;

namespace FileDownloader
{
    internal static class EventHandlerExtensions
    {
        public static void SafeInvoke<T>(this EventHandler<T> evt, object sender, T e) where T : EventArgs
        {
            if (evt != null)
            {
                evt(sender, e);
            }
        }

        public static void SafeInvoke(this EventHandler evt, object sender, EventArgs e)
        {
            if (evt != null)
            {
                evt(sender, e);
            }
        }
    }
}