using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        IWebDriver driver;
        public Form1()
        {
            InitializeComponent();
            var options = new ChromeOptions();
            options.AddExcludedArgument("enable-logging");
            driver = new ChromeDriver(@"D:\Education\5 Semestr\Software Development Technology\Drivers", options);
            driver.Url = "https://www.ebay.com/";

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            String product = searchTextField.Text;// what exact product we are looking for e.g "lenovo"
            driver.FindElement(By.Id("gh-ac")).SendKeys(product);//search field
            driver.FindElement(By.Id("gh-btn")).Click();//search field
            String Url = driver.Url;
            linkField.Text = Url;
            richTextBox1.Text = Url;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            driver.Quit();
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            driver.Navigate().Back();
            driver.FindElement(By.Id("gh-ac")).Clear(); 
            searchTextField.Text = String.Empty;
            linkField.Text = String.Empty;
        }
    }
}
