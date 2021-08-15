using System;
using System.Windows.Forms;
using System.Net.Http;

namespace whois
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            output.Items.Clear();
        }
        private async void Search_btn_Click(object sender, EventArgs e)
        {
            string api_key = "at_FU1DNxrqrCiKtOOKTGrIJE6GbSeqL";
            string domainName = Domain_tb.Text;
            HttpClient request = new HttpClient();
            var content = await request.GetAsync("https://www.whoisxmlapi.com/whoisserver/WhoisService?apiKey=" + api_key + "&domainName=" + domainName + "&outputFormat=JSON");
            var content_string = await content.Content.ReadAsStringAsync();
            string[] content_array = content_string.Split('\n');
            foreach (string c in content_array)
            {
                output.Items.Add(c);
            }
        }
    }
}
