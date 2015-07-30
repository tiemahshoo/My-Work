using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Health.Models
{
    public class TotalsVM
    {
        public int dayid { get; set; }
        public int id { get; set; }
        public int nutrient_id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string unit { get; set; }
        public double value { get; set; }
        public string food { get; set; }
        public int MealId { get; set; }
        public foodType FoodtypeId { get; set; }

        public enum foodType
        {
            [EnumMember]
            MaleBase,

            [EnumMember]
            FemaleBase,

            [EnumMember]
            meal,

            [EnumMember]
            notImportant
        };

        public int UserId { get; set; }
        public string gender { get; set; }
        public double totalvitamins { get; set; }
        public double percent { get; set; }
    }
}