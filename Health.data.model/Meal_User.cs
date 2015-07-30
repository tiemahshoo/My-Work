using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.data.model
{
    public class Meal_User
    {
        public int UserId { get; set; }
        public int MealId { get; set; }
        public int Id { get; set; }
        public virtual Meal Meal { get; set; }
        public virtual User User { get; set; }
    }
}