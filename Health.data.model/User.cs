using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.data.model
{
    public class User
    {
        public int id { get; set; }
        public int nutrient_id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string unit { get; set; }
        public double value { get; set; }
        public string food { get; set; }
        public string MealId { get; set; }

        public enum type
        {
            MaleBase = 0,
            FemaleBase = 1,
            meal = 2,
        }

        public int UserId { get; set; }
        public string gender { get; set; }
    }
}