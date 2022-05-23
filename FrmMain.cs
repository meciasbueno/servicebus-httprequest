using System;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Servicebus.http
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/rest/api/servicebus/send-message-to-queue
    /// https://docs.microsoft.com/en-us/rest/api/eventhub/generate-sas-token (PHP example)
    /// </summary>
    public partial class FrmMain : Form
    {
        private const string ResourceUrlServicebus = "https://{0}.servicebus.windows.net/{1}/messages";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateRequired()) return;
                var sasToken = GenerateSasToken(GetResourceUrl(), txtAccessKeyName.Text, txtAccessKey.Text);
                Send(sasToken);
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error", $"{ex.Message}{Environment.NewLine}{Environment.NewLine}{ex}");
            }
        }

        private void ShowErrorMessage(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string GetResourceUrl()
        {
            return string.Format(CultureInfo.InvariantCulture, ResourceUrlServicebus, txtServicebusNamespace.Text, txtQueueNameOrTopicName.Text);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/rest/api/eventhub/generate-sas-token
        /// </summary>
        /// <returns></returns>
        private string GenerateSasToken(string resourceUri, string accessKeyName, string accessKey)
        {
            TimeSpan sinceEpoch = DateTime.UtcNow - new DateTime(1970, 1, 1);
            var week = 60 * 60 * 24 * 7;
            var expiry = Convert.ToString((int)sinceEpoch.TotalSeconds + week);
            string stringToSign = WebUtility.UrlEncode(resourceUri) + "\n" + expiry;
            HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(accessKey));
            var signature = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(stringToSign)));
            var sasToken = string.Format(CultureInfo.InvariantCulture, "SharedAccessSignature sr={0}&sig={1}&se={2}&skn={3}", 
                                WebUtility.UrlEncode(resourceUri), WebUtility.UrlEncode(signature), expiry, accessKeyName);
            return sasToken;
        }

        private void Send(string sasToken)
        {
            using (var client = new HttpClient())
            {
                var content = string.IsNullOrEmpty(mmMessage.Text) ? null : new StringContent(mmMessage.Text, Encoding.UTF8, "application/json");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", sasToken);
                var result = client.PostAsync(GetResourceUrl(), content).Result;
                if (result.IsSuccessStatusCode)
                    MessageBox.Show("Success \\o/", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    ShowErrorMessage("Error", $"StatusCode: {(int)result.StatusCode}-{result.StatusCode}{Environment.NewLine}{Environment.NewLine}"+
                                              $"{result.ReasonPhrase}{Environment.NewLine}{Environment.NewLine} " +
                                              $"{result.RequestMessage}");
                }
            }
        }

        private bool ValidateRequired()
        {
            if (string.IsNullOrWhiteSpace(txtAccessKeyName.Text))
            {
                ShowErrorMessage("Required Fields", "Access Key Name is Required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAccessKey.Text))
            {
                ShowErrorMessage("Required Fields", "Access Key is Required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtServicebusNamespace.Text))
            {
                ShowErrorMessage("Required Fields", "Servicebus Namespace is Required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtQueueNameOrTopicName.Text))
            {
                ShowErrorMessage("Required Fields", "Queue name or Topic name is Required.");
                return false;
            }
            return true;
        }

        private void txtLinkGit_Click(object sender, EventArgs e)
        {
            var sInfo = new ProcessStartInfo("https://github.com/meciasbueno/servicebus-httprequest");
            Process.Start(sInfo);
        }
    }
}
