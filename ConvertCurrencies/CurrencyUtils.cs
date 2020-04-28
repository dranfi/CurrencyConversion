using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertCurrencies
{
    public class CurrencyUtils
    {
        public List<string> availableCurrencies = new List<string>();
        // Dictionary listing all conversion rates. The key being input+output currency codes like GBPEUR
        public Dictionary<string, double> currencyConversionRates = new Dictionary<string, double>();
        public CurrencyUtils()
        {
            // initialise data from JSON file
            var js = File.ReadAllText("currencies.json");
            var currencyList = JsonConvert.DeserializeObject<List<CurrencyPair>>(js);
            foreach(var currencyPair in currencyList)
            {
                var firstCurrency = currencyPair.Pair.Substring(0, 3);
                var secondCurrency = currencyPair.Pair.Substring(3);
                if (!availableCurrencies.Contains(firstCurrency)) availableCurrencies.Add(firstCurrency);
                if (!availableCurrencies.Contains(secondCurrency)) availableCurrencies.Add(secondCurrency);
                currencyConversionRates[currencyPair.Pair] = currencyPair.Rate;
                // get the reverse pair
                currencyConversionRates[secondCurrency + firstCurrency] = 1 / currencyPair.Rate;
            }
            foreach(var firstCurrency in availableCurrencies)
            {
                var secondCurrencies = availableCurrencies.Where(t => t != firstCurrency);
                foreach(var secondCurrency in secondCurrencies)
                {
                    if(!currencyConversionRates.ContainsKey(firstCurrency+secondCurrency))
                    {
                        // Found a pair that doesn't have a rate yet.
                        // Below the code finds an intermediate currency to calculate the missing rate.
                        // That code cannot handle more than 1 intermediate currency. To deal with an infitiy of intermediates currency we could use recursivity
                        var intermediateCurrencyList = availableCurrencies.Where(t => t != firstCurrency && t != secondCurrency);
                        foreach(var intermediateCurrency in intermediateCurrencyList)
                        {
                            if(currencyConversionRates.ContainsKey(firstCurrency+intermediateCurrency) && currencyConversionRates.ContainsKey(intermediateCurrency+secondCurrency))
                            {
                                currencyConversionRates[firstCurrency + secondCurrency] = currencyConversionRates[firstCurrency + intermediateCurrency] * currencyConversionRates[intermediateCurrency + secondCurrency];
                                break;
                            }
                        }
                    }
                }

            }

        }
    }
}
