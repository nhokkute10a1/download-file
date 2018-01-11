using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Amazon;
using Amazon.Runtime.CredentialManagement;
using Amazon.S3;
using Amazon.S3.Model;

namespace DownloadFileS3
{
    class Program
    {
        static string bucketName = "elasticbeanstalk-us-west-1-833434519629";
        static string keyName = "20172905Bw-server-real-time-app-zplus.zip";
        static string AccessKey = "AKIAIHSNDT557FHGP3YA";
        static string SerectKey = "qQZBMAROOU50S5Mx2t+5Els5nQATvdPdFDaKybiP";
        static IAmazonS3 client;
        
        static void Main(string[] args)
        {
            DownloadFileS3();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private static void DownloadFileS3()
        {
            using (client = new AmazonS3Client(AccessKey, SerectKey, RegionEndpoint.USWest1))
            {
                ListObjectsRequest listRequest = new ListObjectsRequest
                {
                    BucketName = bucketName,
                };
                ListObjectsResponse listResponse;
                do
                {
                    // Get a list of objects
                    listResponse = client.ListObjects(listRequest);
                    foreach (S3Object obj in listResponse.S3Objects)
                    {
                        Console.WriteLine("Object - " + obj.Key);
                        Console.WriteLine(" Size - " + obj.Size);
                        Console.WriteLine(" LastModified - " + obj.LastModified);
                        Console.WriteLine(" Storage class - " + obj.StorageClass);
                    }

                    // Set the marker property
                    listRequest.Marker = listResponse.NextMarker;
                } while (listResponse.IsTruncated);
            }
        }
    }
}
