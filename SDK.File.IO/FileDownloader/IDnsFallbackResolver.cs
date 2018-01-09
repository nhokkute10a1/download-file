/*
     Framework              : using Framework 3.5
     System Libary          : System
     Design Pattern Libary  : None
 */

using System;

namespace FileDownloader
{
    /// <summary>
    /// DNS Fallback Resolver interface
    /// </summary>
    public interface IDnsFallbackResolver
    {
        /// <summary>
        /// Resolves the host name inside of URI into IP address
        /// For example https://example.com/en/ could be resolved to https://8.8.8.8/en/
        /// </summary>
        /// <param name="uri">URI to resolve</param>
        /// <returns>Resolved URI</returns>
        Uri Resolve(Uri uri);
    }
}