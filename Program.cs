using Amazon.S3;
using System;
using System.Threading.Tasks;

namespace aws_sdk_1118_repro
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var s3Client = new AmazonS3Client();
            await s3Client.ListBucketsAsync();
            Console.WriteLine("Success");
        }
    }
}
