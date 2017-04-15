using System;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace LTTCommunity_WindowsForms_Example_App.Examples.BrowserControls
{
    public partial class Browser : UserControl
    {
        ChromiumWebBrowser chromium;
        ChromiumWebBrowser content;

        public Browser()
        {
            InitializeComponent();
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
         //   urlBox.Text = "https://google.com";
        //    chromium = new ChromiumWebBrowser(urlBox.Text);
            componentView.Controls.Add(chromium);

            content = new ChromiumWebBrowser("");
            codeView.Controls.Add(content);
        }

        private void urlBox_TextChanged(object sender, EventArgs e)
        {
      //      chromium = new ChromiumWebBrowser(urlBox.Text);
            componentView.Controls.Clear();
            componentView.Controls.Add(chromium);
        }

        private void applyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
