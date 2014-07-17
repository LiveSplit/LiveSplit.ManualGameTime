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

        private T ParseEnum<T>(XmlElement element)
        {
            return (T)Enum.Parse(typeof(T), element.InnerText);
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;
            Version version;
            if (element["Version"] != null)
                version = Version.Parse(element["Version"].InnerText);
            else
                version = new Version(1, 0, 0, 0);
            UseSegmentTimes = Boolean.Parse(element["UseSegmentTimes"].InnerText);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            parent.AppendChild(ToElement(document, "Version", "1.4"));
            parent.AppendChild(ToElement(document, "UseSegmentTimes", UseSegmentTimes));
            return parent;
        }

        private XmlElement ToElement<T>(XmlDocument document, String name, T value)
        {
            var element = document.CreateElement(name);
            element.InnerText = value.ToString();
            return element;
        }
    }
}
