using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Primeira.Models
{
    public class CurrencyConvertApiResponse
    {
        
            public double Amount { get; set; }
            public string From { get; set; }
            public string To { get; set; }
            public double ConvertedAmount { get; set; }

        public CurrencyConvertApiResponse(double amount, string from, string to)
        {
            Amount = amount;
            From = from;
            To = to;
        }

    }
}
