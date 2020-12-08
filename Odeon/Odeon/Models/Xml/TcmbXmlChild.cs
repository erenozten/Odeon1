using System.Xml.Serialization;

namespace Odeon.Models.Xml
{
    // Bu class, veriyi kolay bir şekilde
    // download etmek için oluşturuldu.
    public class TcmbXmlChild
    {
        // Parent XML Attributes (Tarih_Date)

        [XmlAttribute]
        public string Tarih { get; set; } //ok

        [XmlAttribute]
        public string Date { get; set; } //ok

        [XmlElement("Bulten_No")]
        public string BultenNo { get; set; } //ok

        // Child XML Attributes (Currency)

        [XmlAttribute]
        public string CrossOrder { get; set; } //ok

        [XmlAttribute]
        public string Kod { get; set; } //ok

        [XmlAttribute]
        public string CurrencyCode { get; set; } //ok

        // Child XML Elements (Currency)

        public string Unit { get; set; } //ok

        [XmlElement("Isim")]
        public string CurrencyNameTurkish { get; set; } //ok

        [XmlElement("CurrencyName")]
        public string CurrencyNameEnglish { get; set; } //ok

        public string ForexBuying { get; set; } //ok

        public string ForexSelling { get; set; } //ok

        public string BanknoteBuying { get; set; } //ok

        public string BanknoteSelling { get; set; } //ok

        public string CrossRateUSD { get; set; } //ok

        public string CrossRateOther { get; set; } //ok
    }
}
