using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        Tech.MultiTasking.Entities.Pipe pipe = new Tech.MultiTasking.Entities.Pipe();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = Int32.Parse(textBox1.Text);

             pipe.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            textBox2.Text = random.Next(1, 1999).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pipe.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pipe.RunAndDelete();
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            //string f = await T3();
            string str = await GetCityData("London");
        }

        public async Task<string> GetCityData(string cityname)
        {
            System.Threading.Thread.Sleep(5000);
            string str = "";
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://api.weatherapi.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                HttpResponseMessage response = await client.GetAsync(@"/v1/current.json?key=b480e7a490374b44be472511222103&q=" + cityname + "&aqi=no%22");
                if (response.IsSuccessStatusCode)
                {
                    str = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }

            }

            return str;
        }
        public async Task<string> T3()
        {
            
            System.Threading.Thread.Sleep(5000);

            return "123333";
        }


        public Task T2()
        {
            return Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(5000);
            });
        }

        public void T1()
        {
            //
            System.Threading.Thread.Sleep(5000);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tech.MultiTasking.Entities.TaskNewGen taskNewGen = new Tech.MultiTasking.Entities.TaskNewGen();
            taskNewGen.Run();
        }
    }
}
