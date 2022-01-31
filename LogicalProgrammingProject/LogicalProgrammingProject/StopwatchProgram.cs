using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LogicalProgrammingProject
{
    internal class StopwatchProgram
    {
        public void Elapsetime()
        {
            Stopwatch measuretime = new Stopwatch();
            measuretime.Start();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(6);
            }
            measuretime.Stop();
            Console.WriteLine(" Time elapsed: {0}", measuretime.Elapsed);
        }
    }
}
