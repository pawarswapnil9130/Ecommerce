using Ekart.Models;

namespace Ekart.Services
{
    public class CartService
    {
        private readonly EkartDbContext _ekartDb;
        public CartService(EkartDbContext ekartDbContext)
        {
            _ekartDb = ekartDbContext;
        }


        public IQueryable<Products> getProductsfromCart(int cartID)
        {
            return null;
        }

        public Products removeFromcart(int cartId, int productId)
        {
            return null;
        }

        public Products AddItemToCart(int cartId, Products product)
        {
            return null;
        }
    }
}
