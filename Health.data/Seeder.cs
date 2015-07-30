using Health.data.model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.data
{
    public static class Seeder
    {
        public static void Seed
            (ApplicationDbContext db,
            bool values = true,
            bool totals = true)
        {
            if (values) seeddata(db);
        }

        private static void seeddata
            (ApplicationDbContext db)
        {
            db.Total.AddOrUpdate(
               x => x.id,
               new Totals { id = 1, name = "Calcium, Ca", unit = "mg", value = 1000, FoodtypeId = Totals.foodType.totalsbase, nutrient_id = 301, MealId = 1, dayid = 1 },
               new Totals { id = 3, name = "Copper, Cu", value = 900, unit = "ug", FoodtypeId = Totals.foodType.totalsbase, nutrient_id = 312, MealId = 1, dayid = 1 },
               new Totals { id = 4, name = "Fluoride, F", value = 4, unit = "mg", FoodtypeId = Totals.foodType.totalsbase, nutrient_id = 313, MealId = 1, dayid = 1 },
               new Totals { id = 5, name = "Folic acid", value = 400, unit = "ug", FoodtypeId = Totals.foodType.totalsbase, nutrient_id = 431, MealId = 1, dayid = 1 },
               new Totals { id = 6, name = "Iron, Fe", value = 8, unit = "mg", FoodtypeId = Totals.foodType.totalsbase, nutrient_id = 303, MealId = 1, dayid = 1 },
               new Totals { id = 7, name = "Magnesium, Mg", value = 400, unit = "mg", FoodtypeId = Totals.foodType.totalsbase, nutrient_id = 304, MealId = 1, dayid = 1 },
               new Totals { id = 8, name = "Manganese, Mn", value = 2.3, unit = " mg", FoodtypeId = Totals.foodType.totalsbase, nutrient_id = 315, MealId = 1, dayid = 1 },
               new Totals { id = 9, name = "Phosphorus, P", value = 700, unit = "mg", FoodtypeId = Totals.foodType.totalsbase, nutrient_id = 305, MealId = 1, dayid = 1 },
               new Totals { id = 10, name = "Selenium, Se", value = 55, unit = "ug", FoodtypeId = Totals.foodType.totalsbase, nutrient_id = 317, MealId = 1, dayid = 1 },
               new Totals { id = 11, name = "Sodium, Na", value = 1500, unit = "mg", FoodtypeId = Totals.foodType.totalsbase, nutrient_id = 307, MealId = 1, dayid = 1 },
               new Totals { id = 12, name = "Vitamin A, IU", value = 3000, unit = "iu", FoodtypeId = Totals.foodType.totalsbase, nutrient_id = 318, MealId = 1, dayid = 1 },
               new Totals { id = 14, name = "Vitamin B-6", value = 1.3, unit = "mg", FoodtypeId = Totals.foodType.totalsbase, nutrient_id = 415, MealId = 1, dayid = 1 },
               new Totals { id = 15, name = "Vitamin C, total ascorbic acid", value = 90, unit = "mg", FoodtypeId = Totals.foodType.totalsbase, nutrient_id = 401, MealId = 1, dayid = 1 },
               new Totals { id = 16, name = "Vitamin D", value = 15, unit = "ug", FoodtypeId = Totals.foodType.totalsbase, nutrient_id = 324, MealId = 1, dayid = 1 },
               new Totals { id = 17, name = "Vitamin E (alpha-tocopherol)", value = 22.4, unit = "iu", FoodtypeId = Totals.foodType.totalsbase, nutrient_id = 323, MealId = 1, dayid = 1 },
               new Totals { id = 18, name = "Zinc, Zn", value = 11, unit = "mg", FoodtypeId = Totals.foodType.totalsbase, nutrient_id = 309, MealId = 1, dayid = 1 });
        }
    }
}