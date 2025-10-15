using System.Text;
using System.Text.RegularExpressions;
using System.Net.Sockets;
using System.Net;

namespace HTTPPracticeWorkClient
{
    public partial class Form1 : Form
    {
        readonly string pattern = @"^(https?|ftp):\/\/[^\s/$.?#].[^\s]*$";
        readonly string domein = "http://localhost:8080/";
        HttpClient client;
        HttpListener httpListener;

        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            
            /*httpListener = new HttpListener();
            httpListener.Prefixes.Add("http://localhost:8080/");
            httpListener.Start();*/
        }

        private async void button1_Click(object sender, EventArgs e)
        {
                string input = EnterURITextBox.Text;
            try
            {
                if (Regex.IsMatch(input, pattern))
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(input);
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, input);
                    await client.SendAsync(request);
                    HttpResponseMessage response = await client.GetAsync(domein);
                    
                    //byte[] bytes = await client.GetAsync(domein);
                    
                    AnswerTextBox.Text = response.ToString();

                }
                else
                {
                    MessageBox.Show("Wrong URI, try again");


                }
            }
            catch (Exception ex) { }
        }
    }
}
