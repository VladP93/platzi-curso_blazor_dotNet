using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_Category
    {
        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new InventoryContext())
            {
                return db.Categories.ToList();
            }
        }

        public static void CreateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventoryContext())
            {
                db.Categories.Add(oCategory);
                db.SaveChanges();
            }
        }

        public void UpdateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventoryContext())
            {
                db.Categories.Update(oCategory);
                db.SaveChanges();
            }
        }

        public void DeleteCategory(CategoryEntity oCategory)
        {
            using (var db = new InventoryContext())
            {
                db.Remove(oCategory);
                db.SaveChanges();
            }
        }
    }
}
