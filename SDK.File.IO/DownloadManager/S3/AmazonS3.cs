/*
     Framework              : using Framework 3.5
     System Libary          : System.Security.Cryptography,System,Linq
     Design Pattern Libary  : Singleton
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon;
using Amazon.Runtime.CredentialManagement;
using Amazon.S3;
using Amazon.S3.Model;
namespace DownloadManager.S3
{
    public class AmazonS3
    {
        private static AmazonS3 instance;
        private static object syncRoot = new object();
        private AmazonS3() { }
        public static AmazonS3 Instance
        {
            get
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new AmazonS3();
                    }
                }
                return instance;
            }
        }
        /// <summary>
        /// Get Link download from KeyName and Bucket Name
        /// </summary>
        /// <param name="AccessKey"></param>
        /// <param name="SerectKey"></param>
        /// <param name="bucketName"></param>
        /// <param name="keyName"></param>
        /// <param name="endPoint"></param>
        /// <returns></returns>
        public string GetLink(string AccessKey, string SerectKey,string bucketName,string keyName, RegionEndpoint endPoint)
        {
            using (IAmazonS3 client = new AmazonS3Client(AccessKey, SerectKey, endPoint))
            {
                GetPreSignedUrlRequest request = new GetPreSignedUrlRequest
                {
                    BucketName = bucketName,
                    Key = keyName,
                    Expires = DateTime.Now.AddHours(1),
                    Protocol = Protocol.HTTP
                };
                return client.GetPreSignedURL(request);
            }
        }
    }
}
