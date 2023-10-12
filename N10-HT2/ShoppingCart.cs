
namespace N10_HT2
{
    internal class ShoppingCart
    {
        private Dictionary<int, int> Items = new Dictionary<int, int>();

        public void Add(Product product, int soni)
        {
            if (!Items.ContainsKey(product.Id))
            {
                Items.Add(product.Id, soni);
            }
        }

        public bool Remove(int productID)
        {
            if (Items.TryGetValue(productID, out int soni))
            {
                if (soni > 0)
                {
                    Items[productID] = soni - 1;
                    return true;
                }
            }
            return false;
        }
    }
}
