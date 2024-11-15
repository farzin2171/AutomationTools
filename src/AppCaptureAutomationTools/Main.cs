using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace AppCaptureAutomationTools
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int numberOfRequests = 3; // Number of simultaneous requests
            var tasks = new Task[numberOfRequests];

            // Define form fields
            var formData = new Dictionary<string, string>
        {
            { "ProductCode", "b6af7ed0-b00e-4522-b48d-07340bb6c997" },
            { "State", "AL" },
            { "FormCode", "NSSLifeLongForm" },
            { "ApplicationNumber", $"{RandomGenerator.GenerateApplicationNumber(txtApplicationPrefix.Text)}" },

        };
            var formData2 = new Dictionary<string, string>
        {
            { "ProductCode", "30efc81f-22e4-436c-a192-471ab743906f" },
            { "State", "AZ" },
            { "FormCode", "NSSAnnuity" },
            { "ApplicationNumber", $"{RandomGenerator.GenerateApplicationNumber(txtApplicationPrefix.Text)}" },

        };

            var formData3 = new Dictionary<string, string>
        {
            { "ProductCode", "ff774ed4-1edd-45da-af99-a0e8cf1f3c24" },
            { "State", "CO" },
            { "FormCode", "NSSInvestmentGrowth" },
            { "ApplicationNumber", $"{RandomGenerator.GenerateApplicationNumber(txtApplicationPrefix.Text)}" },
            };
            tasks[0] = MakeRequestAsync(txtChunk.Text, txtChunck1.Text, txtChunk2.Text, txtChunck3.Text, formData, txtTenant.Text, txtAppCaptureAddress.Text);
            tasks[1] = MakeRequestAsync(txtChunk.Text, txtChunck1.Text, txtChunk2.Text, txtChunck3.Text, formData2, txtTenant.Text, txtAppCaptureAddress.Text);
            tasks[2] = MakeRequestAsync(txtChunk.Text, txtChunck1.Text, txtChunk2.Text, txtChunck3.Text, formData3, txtTenant.Text, txtAppCaptureAddress.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async Task MakeRequestAsync(string chunck, string chunk1, string chunk2, string chunk3, Dictionary<string, string> formData, string tenant, string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, $"{url}/AppCapture/New");
            var session = $"AppCapture.{tenant}";
            var session1 = $"AppCapture.{tenant}C1";
            var session2 = $"AppCapture.{tenant}C2";
            var session3 = $"AppCapture.{tenant}C3";

            var cookie = string.Empty;
            cookie += $"{session}={chunck};";
            cookie += $"{session1}={chunk1};";
            cookie += $"{session2}={chunk2};";
            if (!string.IsNullOrEmpty(chunk3))
            {
                cookie += $"{session3}={chunk3};";

            }

            // Format the cookie header with all session chunks
            request.Headers.Add("Cookie", cookie);
            request.Content = new FormUrlEncodedContent(formData);
            HttpResponseMessage response = await client.SendAsync(request);

            richTextBox1.Text += await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Request succeeded.");
            }
            else
            {
                Console.WriteLine($"Request failed with status code: {response.StatusCode}");
            }
        }

    }
}

