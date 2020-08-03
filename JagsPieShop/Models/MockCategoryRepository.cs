using System.Collections.Generic;

namespace JagsPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category> { 
                new Category { CategoryId=1, CategoryName="Fruit Pie", Description="All fruity"},
                new Category { CategoryId = 2, CategoryName = "Cheese Pie", Description="All Cheese" },
                new Category { CategoryId = 3, CategoryName = "Seasonla Pie", Description="All Season"},
            };

    }
}
