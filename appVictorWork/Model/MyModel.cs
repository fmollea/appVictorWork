using System;
using Xamarin.Forms;

namespace appVictorWork.Model
{
    public class MyModel
    {
        public int iD { get; set; }
        public string firstLine { get; set; }
        public string secondaryText { get; set; }
        public int secondaryTextID { get; set; }
        public string secondaryText2 { get; set; }
        public string secondaryText2Description { get; set; }
        public string image1 { get; set; }
        public string image2 { get; set; }
        public bool flagCert { get; set; }

        
        public MyModel()
        {
            iD = -1;
            firstLine = string.Empty;
            secondaryText = string.Empty;
            secondaryTextID = -1;
            secondaryText2 = string.Empty;
            secondaryText2Description = string.Empty;
            image1 = string.Empty;
            image2 = string.Empty;
            flagCert = false;
        }
    }
}
