using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebApp
{
    public partial class Form1 : Form
    {
        const string APPID = "3a753578788b65f919a88e601b1b8138";
        const string APPKEY = "35265f9f5fc04e99bb6be7fac880ba79";


        public Form1()
        {
            InitializeComponent();
            getWeather("Paris");
            getNews("Paris");
            
        }

        void getWeather(string city)
        {
            using(WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&cnt=1", city, APPID);

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                WeatherInfo.root outPut = result;

                label1.Text = string.Format("{0}", outPut.name);
                label2.Text = string.Format("{0}", outPut.sys.country);
                label3.Text = string.Format("{0} \u00B0"+"c", outPut.main.temp);

            }
           

        }
        void getNews(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://newsapi.org/v2/everything?q={0}&language=en&apiKey={1}", city, APPKEY);

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<NewsInfo.articles>(json);

                NewsInfo.articles outPut = result;

                label7.Text = string.Format("{0}", outPut.author);
                label5.Text = string.Format("{0}", outPut.title);
                label6.Text = string.Format("{0}", outPut.description);
                label8.Text = string.Format("{0}", outPut.content);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {



        }

        private void btnConsultar_City(object sender, EventArgs e)
        {
            


        }
    }
}
