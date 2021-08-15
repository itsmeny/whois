using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
namespace whois
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length <= 1) 
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainFrm());
            }
            else
            {
                Task<string> task = getContent(args[1]);
                Console.WriteLine(task.Result.ToString());
            }

        }
        static async Task<String> getContent(string domainName)
        {
            string api_key = "at_FU1DNxrqrCiKtOOKTGrIJE6GbSeqL"; // เปลี่ยน API KEY ตรงนี้
            HttpClient request = new HttpClient();
            var content = await request.GetAsync("https://www.whoisxmlapi.com/whoisserver/WhoisService?apiKey=" + api_key + "&domainName=" + domainName + "&outputFormat=JSON");
            var content_string = await content.Content.ReadAsStringAsync();
            return content_string;
        }
    }

}
