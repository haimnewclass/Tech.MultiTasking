using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.MultiTasking.Entities
{
    public class FileWriting
    {
        public bool ContinuToRun = true;

        
        public void Run(int p)
        {
            ContinuToRun = true;

            for (int i = 0; i < p && ContinuToRun; i++)
            {
                string fname = @"C:\Users\haim\source\repos\Tech.MultiTasking\UI\bin\Debug\Files\" + Guid.NewGuid().ToString() + ".txt";
                System.IO.File.WriteAllText(fname, "1000000");
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
