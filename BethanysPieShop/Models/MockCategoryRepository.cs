using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category {CategoryId=1,CategoryName="Fruit pies",Description="All-fruity pies"},
                new Category {CategoryId=2,CategoryName="Cheese cake",Description="Cheesy aññ the way"},
                new Category {CategoryId=1,CategoryName="Seasonal pies",Description="Get in to the mood for a seasonal pie"}
            };
    }
}
