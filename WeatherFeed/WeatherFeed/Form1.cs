using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Xml;

namespace WeatherFeed
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, System.EventArgs e)  
        {

        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            // Create a new XmlDocument   
            XmlDocument doc = new XmlDocument();

            string zip = txtZip.Text;

            // Load data   
            doc.Load("http://xml.weather.yahoo.com/forecastrss?p="+zip);

            // Set up namespace manager for XPath   
            XmlNamespaceManager ns = new XmlNamespaceManager(doc.NameTable);
            ns.AddNamespace("yweather", "http://xml.weather.yahoo.com/ns/rss/1.0");

            // Get forecast with XPath   
            XmlNodeList nodes = doc.SelectNodes("//rss/channel/item/yweather:forecast", ns);

            // You can also get elements based on their tag name and namespace,   
            // though this isn't recommended   
            //XmlNodeList nodes = doc.GetElementsByTagName("forecast",    
            //                          "http://xml.weather.yahoo.com/ns/rss/1.0");   

            foreach (XmlNode node in nodes)
            {
                lblLow.Text = "Low: " + node.Attributes["low"].InnerText + " F";
                lblHigh.Text = "High: " + node.Attributes["high"].InnerText + " F";
                lblConditions.Text = "Conditions: " + node.Attributes["text"].InnerText.ToUpper();
            }   
        }

    }
}