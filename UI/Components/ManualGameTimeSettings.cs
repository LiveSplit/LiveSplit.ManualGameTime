using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Globalization;
using LiveSplit.TimeFormatters;
using LiveSplit.Model;
using LiveSplit.Model.Comparisons;

namespace LiveSplit.UI.Components
{
    public partial class ManualGameTimeSettings : UserControl
    {
        public bool UseSegmentTimes { get; set; }

        public ManualGameTimeSettings()
        {
            InitializeComponent();

            UseSegmentTimes = true;

            rdoSegmentTimes.DataBindings.Add("Checked", this, "UseSegmentTimes", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;
            UseSegmentTimes = SettingsHelper.ParseBool(element["UseSegmentTimes"]);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            parent.AppendChild(SettingsHelper.ToElement(document, "Version", "1.4"));
            parent.AppendChild(SettingsHelper.ToElement(document, "UseSegmentTimes", UseSegmentTimes));
            return parent;
        }
    }
}
