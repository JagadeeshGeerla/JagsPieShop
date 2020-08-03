using System.Collections.Generic;

namespace JagsPieShop.Models
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> AllCategories { get; }
    }
}
