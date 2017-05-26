using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherWebservicex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowWeather_Click(object sender, EventArgs e)
        {
            WeartherService.GlobalWeatherSoapClient client = new WeartherService.GlobalWeatherSoapClient();
            //WeatherService.GlobalWeatherSoapClient client = new WeatherService.GlobalWeatherSoapClient();
            lblResult.Text = client.GetWeather(txtBxCity.Text,txtBxCounty.Text);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
