using System.Collections.Generic;
using System.Linq;
using Odeon.Models;

namespace Odeon
{
    public class Sorter : ISorter
    {
        public List<TcmbCurrencyData> SortByName(List<TcmbCurrencyData> list)
        {
            return list.OrderBy(t => t.CurrencyNameEnglish).ToList();
        }

        public List<TcmbCurrencyData> SortByNameDescending(List<TcmbCurrencyData> list)
        {
            return list.OrderByDescending(t => t.CurrencyNameEnglish).ToList();
        }

        public List<TcmbCurrencyData> SortByForexBuying(List<TcmbCurrencyData> list)
        {
            return list.OrderBy(t => t.ForexBuying).ToList();
        }

        public List<TcmbCurrencyData> SortByForexBuyingDescending(List<TcmbCurrencyData> list)
        {
            return list.OrderByDescending(t => t.ForexBuying).ToList();
        }

        public List<TcmbCurrencyData> SortByForexSelling(List<TcmbCurrencyData> list)
        {
            return list.OrderBy(t => t.ForexSelling).ToList();
        }

        public List<TcmbCurrencyData> SortByForexSellingDescending(List<TcmbCurrencyData> list)
        {
            return list.OrderByDescending(t => t.ForexSelling).ToList();
        }

        public List<TcmbCurrencyData> SortByBanknoteBuying(List<TcmbCurrencyData> list)
        {
            return list.OrderBy(t => t.BanknoteBuying).ToList();
        }

        public List<TcmbCurrencyData> SortByBanknoteBuyingDescending(List<TcmbCurrencyData> list)
        {
            return list.OrderByDescending(t => t.BanknoteBuying).ToList();
        }

        public List<TcmbCurrencyData> SortByBanknoteSelling(List<TcmbCurrencyData> list)
        {
            return list.OrderBy(t => t.BanknoteSelling).ToList();
        }

        public List<TcmbCurrencyData> SortByBanknoteSellingDescending(List<TcmbCurrencyData> list)
        {
            return list.OrderByDescending(t => t.BanknoteSelling).ToList();
        }
    }

    public interface ISorter
    {
        List<TcmbCurrencyData> SortByName(List<TcmbCurrencyData> list);
        List<TcmbCurrencyData> SortByNameDescending(List<TcmbCurrencyData> list);

        List<TcmbCurrencyData> SortByForexBuying(List<TcmbCurrencyData> list);
        List<TcmbCurrencyData> SortByForexBuyingDescending(List<TcmbCurrencyData> list);

        List<TcmbCurrencyData> SortByForexSelling(List<TcmbCurrencyData> list);
        List<TcmbCurrencyData> SortByForexSellingDescending(List<TcmbCurrencyData> list);

        List<TcmbCurrencyData> SortByBanknoteBuying(List<TcmbCurrencyData> list);
        List<TcmbCurrencyData> SortByBanknoteBuyingDescending(List<TcmbCurrencyData> list);

        List<TcmbCurrencyData> SortByBanknoteSelling(List<TcmbCurrencyData> list);
        List<TcmbCurrencyData> SortByBanknoteSellingDescending(List<TcmbCurrencyData> list);
    }
}