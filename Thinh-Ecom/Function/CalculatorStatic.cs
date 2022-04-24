using Microsoft.AspNetCore.Http;
using Thinh_Ecom.Data;
using System.Linq;


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

        // Count product in Cart from database
        public static int CountProductInCart(ApplicationDbContext _context,bool isLogin, string idUser)
        {
            if(isLogin)
            {
                var queryCartId = _context.Cart.FirstOrDefault(a => a.cart_UserID == idUser);

                var queryProductInCart = _context.ProductInCart.Where(a => a.pic_CartId == queryCartId.cart_Id);

                return queryProductInCart.Count();
            }
            return 0;
        }
    }
}
