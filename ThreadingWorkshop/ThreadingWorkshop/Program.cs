using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Download();

            Console.ReadLine();

        }

        static void Download()
        { 
            // ensure git commit is done!
            Task.Run( () => {
	        Thread.Sleep(3000);
            Console.WriteLine("Complete");
});
        }
    }
}
