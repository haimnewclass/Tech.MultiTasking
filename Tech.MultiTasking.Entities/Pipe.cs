using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.MultiTasking.Entities
{
    public class Pipe
    {
        public Task runRask;
        FileWriting fileWriting;

        public void RunAndDelete()
        {
            // Create Files
            Start();

            // Wait 10 seconds
            System.Threading.Thread.Sleep(5000);

            //Wait
            while(runRask.Status!=TaskStatus.RanToCompletion)
            {
                System.Threading.Thread.Sleep(10);
            }
            //Delegte all files
            string[] files = System.IO.Directory.GetFiles(@"C:\Users\haim\source\repos\Tech.MultiTasking\UI\bin\Debug\Files\");
            for (int i = 0; i < files.Length; i++)
            {
                System.IO.File.Delete(files[i]);
            }


        }
        public void Start()
        {
            Action func = WritBigFile;

            runRask = Task.Factory.StartNew(func);
            
        }
        public void WritBigFile()
        {

            fileWriting = new FileWriting();
            fileWriting.Run(1000);
        }

        public void Stop()
        {
            fileWriting.ContinuToRun = false;
        }
    }
}
