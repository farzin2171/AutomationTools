using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCaptureAutomationTools
{

    public static class RequestHelper
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task MakeRequestAsync(string chunck, string chunk1, string chunk2, string chunk3, Dictionary<string, string> formData, string tenant , string url)
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

             await response.Content.ReadAsStringAsync();

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
