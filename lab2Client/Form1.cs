using SoapServiceReference;

namespace lab2Client
{
    public partial class Form1 : Form
    {
        private ISoapService _soapServiceChannel;

        public Form1()
        {
            _soapServiceChannel =
                new SoapServiceClient(SoapServiceClient.EndpointConfiguration.BasicHttpBinding_ISoapService_soap);


            InitializeComponent();
        }

        private async void reverseBtn_Click(object sender, EventArgs e)
        {
            string contextToReverse = inputField.Text;

            var stringResponse = await _soapServiceChannel.ReverseStringAsync(new ReverseStringRequest()
            {
                Body = new ReverseStringRequestBody()
                {
                    contextToReverse = contextToReverse
                }
            });

            outputLabelWords.Text = stringResponse.Body.ReverseStringResult;

            var charResponse = await _soapServiceChannel.ReverseCharsAsync(new ReverseCharsRequest()
            {
                Body = new ReverseCharsRequestBody()
                {
                    contextToReverse = contextToReverse
                }
            });

            outputLabelChars.Text = charResponse.Body.ReverseCharsResult;
        }
    }
}
