using System.Xml.Serialization;

namespace Odeon.Models.Xml
{
    [XmlRoot("Tarih_Date")]
    public class TcmbXmlParent
    {
        [XmlAttribute("Tarih")]
        public string Tarih { get; set; }

        [XmlAttribute("Date")]
        public string Date { get; set; }

        [XmlAttribute("Bulten_No")]
        public string BultenNo { get; set; }

        [XmlElement("Currency")]
        public TcmbXmlChild[] Currencies { get; set; }
    }
}