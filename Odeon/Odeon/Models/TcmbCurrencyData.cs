using System;

namespace Odeon.Models
{
    public class TcmbCurrencyData
    {
        // Parent XML Attributes (Tarih_Date)

        public DateTime Tarih { get; set; } //ok

        public DateTime Date { get; set; } //ok

        // Bulten_No
        public string BultenNo { get; set; } //ok

        // Child XML Attributes (Currency)

        public int CrossOrder { get; set; } //ok

        public string Kod { get; set; } //ok

        public string CurrencyCode { get; set; } //ok

        // Child XML Elements (Currency)

        public string Unit { get; set; } //ok

        // Isim
        public string CurrencyNameTurkish { get; set; } //ok

        // CurrencyName
        public string CurrencyNameEnglish { get; set; } //ok

        public decimal? ForexBuying { get; set; } //ok

        public decimal? ForexSelling { get; set; } //ok

        public decimal? BanknoteBuying { get; set; } //ok

        public decimal? BanknoteSelling { get; set; } //ok

        public decimal? CrossRateUsd { get; set; } //ok

        public decimal? CrossRateOther { get; set; } //ok
    }
}