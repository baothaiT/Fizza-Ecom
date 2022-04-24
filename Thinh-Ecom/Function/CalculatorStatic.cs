using Microsoft.AspNetCore.Http;
using Thinh_Ecom.Data;


namespace Thinh_Ecom.Function
{
    public static class CalculatorStatic
    {
        public static int CalculatorPriceForSize(string CurrentSize, int DefaultPrice)
        {
            switch (CurrentSize)
            {
                case "S":
                    // code block
                    return DefaultPrice;
                case "M":
                    // code block
                    return DefaultPrice + 5;
                case "L":
                    // code block
                    return DefaultPrice + 7;
                default:
                    // code block
                    return DefaultPrice;
            }
        }


    }
}
