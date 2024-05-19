
namespace SportsStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDBContext context;
        public EFStoreRepository(StoreDBContext ctx)
        {
            this.context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
