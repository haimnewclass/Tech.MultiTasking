using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.MultiTasking.Entities
{
    public class TaskNewGen
    {
        public string ret = "";
        public async void Run()
        {
            string str = await DoSomthingLong2();
            
        }

        public async Task<string> DoSomthingLong2()
        {
            System.Threading.Thread.Sleep(10000);
          
            return "12345";
        }
        public string DoSomthingLong1()
        {
            System.Threading.Thread.Sleep(10000);
            ret = "123456";
            return "12345";
        }
        public void DoSomthingLong()
        {
            System.Threading.Thread.Sleep(10000);

        }
    }
}
