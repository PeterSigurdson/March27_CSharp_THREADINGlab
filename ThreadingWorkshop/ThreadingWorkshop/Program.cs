using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;

namespace ThreadingWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading File...");
            Download();
            Console.ReadLine();
        }

        static async void Download()
        {
            HttpClient client = new HttpClient();
            string data = await client.GetStringAsync("http://rousacademy.com");
            Console.WriteLine("Download complete " + data);
        }
    }

    class Network
    {
        static public Task Download()
        {
            return Task.Run(() => Thread.Sleep(3000));
        }
    }
}
