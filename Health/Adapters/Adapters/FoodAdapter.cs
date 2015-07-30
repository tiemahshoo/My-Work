using Health.Adapters.Interfaces;
using Health.data;
using Health.data.model;
using Health.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Health.Adapters.Adapters
{
    public class FoodAdapter : IFoodAdapter
    {
        //Recommended Vitamins
        public List<TotalsVM> GetVitamins(int id)
        {
            List<TotalsVM> model;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                model = db.Total.Where(x => x.MealId == id && x.FoodtypeId == Totals.foodType.MaleBase).Select(x => new TotalsVM()
                {
                    MealId = x.MealId,
                    nutrient_id = x.nutrient_id,
                    food = x.food,
                    name = x.name,
                    value = x.value,
                    unit = x.unit,
                    percent = x.percent,
                    totalvitamins = x.totalvitamins
                }).ToList();
            }

            return (model);
        }

        //add to meal

        public List<TotalsVM> Getvitamins(List<TotalsVM> toEat)
        {
            int MealId;
            int dayid;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                MealId = db.Total.Select(x => x.MealId).Max();
                dayid = db.Total.Select(y => y.dayid).Max();
            }
            dayid++;
            MealId++;
            foreach (var x in toEat)
            {
                switch (x.nutrient_id)
                {
                    case 301:
                        if (x.totalvitamins != 0)
                        {
                            Totals model = new Totals()
                            {
                                MealId = MealId,
                                food = x.food,
                                nutrient_id = 301,
                                totalvitamins = x.totalvitamins,
                                value = 1000,
                                unit = "mg",
                                name = "Calcium, Ca",
                                percent = (x.totalvitamins / 1000) * 100,
                                dayid = x.dayid
                            };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                        else
                        {
                            Totals model = new Totals()
                            {
                                MealId = MealId,
                                food = x.food,
                                nutrient_id = 301,
                                totalvitamins = x.value,
                                value = 1000,
                                unit = "mg",
                                name = "Calcium, Ca",
                                percent = (x.value / 1000) * 100,
                                dayid = dayid
                            };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }

                    case 312:
                        if (x.totalvitamins != 0)
                        {
                            Totals model = new Totals()
                              {
                                  MealId = MealId,
                                  food = x.food,
                                  nutrient_id = 312,
                                  totalvitamins = x.totalvitamins,
                                  value = 900,
                                  unit = "ug",
                                  name = "Copper, Cu",
                                  percent = (x.totalvitamins / 900) * 100,
                                  dayid = x.dayid
                              };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                        else
                        {
                            Totals model = new Totals()
                            {
                                MealId = MealId,
                                food = x.food,
                                nutrient_id = 312,
                                totalvitamins = x.value,
                                value = 900,
                                unit = "ug",
                                name = "Copper, Cu",
                                percent = (x.value / 900) * 100,
                                dayid = dayid
                            };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                    case 313:
                        if (x.totalvitamins != 0)
                        {
                            Totals model = new Totals()
                            {
                                MealId = MealId,
                                food = x.food,
                                nutrient_id = 313,
                                totalvitamins = x.totalvitamins,
                                value = 4,
                                unit = "mg",
                                name = "Fluoride, F",
                                percent = (x.totalvitamins / 4) * 100,
                                dayid = x.dayid
                            };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };

                            break;
                        }
                        else
                        {
                            Totals model = new Totals()
                              {
                                  MealId = MealId,
                                  food = x.food,
                                  nutrient_id = 313,
                                  totalvitamins = x.value,
                                  value = 4,
                                  unit = "mg",
                                  name = "Fluoride, F",
                                  percent = (x.value / 4) * 100,
                                  dayid = dayid
                              };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };

                            break;
                        }
                    case 431:
                        if (x.totalvitamins != 0)
                        {
                            Totals model = new Totals()
                            {
                                MealId = MealId,
                                food = x.food,
                                nutrient_id = 431,
                                totalvitamins = x.totalvitamins,
                                value = 400,
                                unit = "ug",
                                name = "Folic acid",
                                percent = (x.totalvitamins / 400) * 100,
                                dayid = x.dayid
                            };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };

                            break;
                        }
                        else
                        {
                            Totals model = new Totals()
                               {
                                   MealId = MealId,
                                   food = x.food,
                                   nutrient_id = 431,
                                   totalvitamins = x.value,
                                   value = 400,
                                   unit = "ug",
                                   name = "Folic acid",
                                   percent = (x.value / 400) * 100,
                                   dayid = dayid
                               };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };

                            break;
                        }
                    case 303:
                        if (x.totalvitamins != 0)
                        {
                            Totals model = new Totals()
                            {
                                MealId = MealId,
                                food = x.food,
                                nutrient_id = 303,
                                totalvitamins = x.totalvitamins,
                                value = 8,
                                unit = "mg",
                                name = "Iron, Fe",
                                percent = (x.totalvitamins / 8) * 100,
                                dayid = x.dayid
                            };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                        else
                        {
                            Totals model = new Totals()
                              {
                                  MealId = MealId,
                                  food = x.food,
                                  nutrient_id = 303,
                                  totalvitamins = x.value,
                                  value = 8,
                                  unit = "mg",
                                  name = "Iron, Fe",
                                  percent = (x.value / 8) * 100,
                                  dayid = dayid
                              };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                    case 304:
                        if (x.totalvitamins != 0)
                        {
                            Totals model = new Totals()
                          {
                              MealId = MealId,
                              food = x.food,
                              nutrient_id = 304,
                              totalvitamins = x.totalvitamins,
                              value = 400,
                              unit = "mg",
                              name = "Magnesium, Mg",
                              percent = (x.totalvitamins / 400) * 100,
                              dayid = x.dayid
                          };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                        else
                        {
                            Totals model = new Totals()
                              {
                                  MealId = MealId,
                                  food = x.food,
                                  nutrient_id = 304,
                                  totalvitamins = x.value,
                                  value = 400,
                                  unit = "mg",
                                  name = "Magnesium, Mg",
                                  percent = (x.value / 400) * 100,
                                  dayid = dayid
                              };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };

                            break;
                        }
                    case 315:
                        if (x.totalvitamins != 0)
                        {
                            Totals model = new Totals()
                            {
                                MealId = MealId,
                                food = x.food,
                                nutrient_id = 315,
                                totalvitamins = x.totalvitamins,
                                value = 2.3,
                                unit = "mg",
                                name = "Manganese, Mn",
                                percent = (x.totalvitamins / 2.3) * 100,
                                dayid = x.dayid
                            };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                        else
                        {
                            Totals model = new Totals()
                              {
                                  MealId = MealId,
                                  food = x.food,
                                  nutrient_id = 315,
                                  totalvitamins = x.value,
                                  value = 2.3,
                                  unit = "mg",
                                  name = "Manganese, Mn",
                                  percent = (x.value / 2.3) * 100,
                                  dayid = dayid
                              };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                    case 305:
                        if (x.totalvitamins != 0)
                        {
                            Totals model = new Totals()
                            {
                                MealId = MealId,
                                food = x.food,
                                nutrient_id = 305,
                                totalvitamins = x.totalvitamins,
                                value = 700,
                                unit = "mg",
                                name = "Phosphorus, P",
                                percent = (x.totalvitamins / 700) * 100,
                                dayid = x.dayid
                            };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                        else
                        {
                            Totals model = new Totals()
                               {
                                   MealId = MealId,
                                   food = x.food,
                                   nutrient_id = 305,
                                   totalvitamins = x.value,
                                   value = 700,
                                   unit = "mg",
                                   name = "Phosphorus, P",
                                   percent = (x.value / 700) * 100,
                                   dayid = dayid
                               };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                    case 317:
                        if (x.value == 55)
                        {
                            Totals model = new Totals()
                               {
                                   MealId = MealId,
                                   food = x.food,
                                   nutrient_id = 317,
                                   totalvitamins = x.totalvitamins,
                                   value = 55,
                                   unit = "ug",
                                   name = "Selenium, Se",
                                   percent = (x.totalvitamins / 55) * 100,
                                   dayid = x.dayid
                               };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                        else
                        {
                            Totals model = new Totals()
                               {
                                   MealId = MealId,
                                   food = x.food,
                                   nutrient_id = 317,
                                   totalvitamins = x.value,
                                   value = 55,
                                   unit = "ug",
                                   name = "Selenium, Se",
                                   percent = (x.value / 55) * 100,
                                   dayid = dayid
                               };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                    case 307:
                        if (x.totalvitamins != 0)
                        {
                            {
                                Totals model = new Totals()
                                {
                                    MealId = MealId,
                                    food = x.food,
                                    nutrient_id = 307,
                                    totalvitamins = x.totalvitamins,
                                    value = 1500,
                                    unit = "mg",
                                    name = "Sodium, Na",
                                    percent = (x.totalvitamins / 1500) * 100,
                                    dayid = x.dayid
                                };
                                using (ApplicationDbContext db = new ApplicationDbContext())
                                {
                                    db.Total.Add(model);
                                    db.SaveChanges();
                                };
                                break;
                            }
                        }
                        else
                        {
                            Totals model = new Totals()
                               {
                                   MealId = MealId,
                                   food = x.food,
                                   nutrient_id = 307,
                                   totalvitamins = x.value,
                                   value = 1500,
                                   unit = "mg",
                                   name = "Sodium, Na",
                                   percent = (x.value / 1500) * 100,
                                   dayid = dayid
                               };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                    case 318:
                        if (x.totalvitamins != 0)
                        {
                            Totals model = new Totals()
                            {
                                MealId = MealId,
                                food = x.food,
                                nutrient_id = 318,
                                totalvitamins = x.totalvitamins,
                                value = 3000,
                                unit = "iu",
                                name = "Vitamin A, IU",
                                percent = (x.totalvitamins / 3000) * 100,
                                dayid = x.dayid
                            };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };

                            break;
                        }
                        else
                        {
                            Totals model = new Totals()
                               {
                                   MealId = MealId,
                                   food = x.food,
                                   nutrient_id = 318,
                                   totalvitamins = x.value,
                                   value = 3000,
                                   unit = "iu",
                                   name = "Vitamin A, IU",
                                   percent = (x.value / 3000) * 100,
                                   dayid = dayid
                               };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };

                            break;
                        }
                    case 415:
                        if (x.totalvitamins != 0)
                        {
                            Totals model = new Totals()
                            {
                                MealId = MealId,
                                food = x.food,
                                nutrient_id = 415,
                                totalvitamins = x.totalvitamins,
                                value = 1.3,
                                unit = "mg",
                                name = "Vitamin B-6",
                                percent = (x.totalvitamins / 1.3) * 100,
                                dayid = x.dayid
                            };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                        else
                        {
                            Totals model = new Totals()
                               {
                                   MealId = MealId,
                                   food = x.food,
                                   nutrient_id = 415,
                                   totalvitamins = x.value,
                                   value = 1.3,
                                   unit = "mg",
                                   name = "Vitamin B-6",
                                   percent = (x.value / 1.3) * 100,
                                   dayid = dayid
                               };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                    case 325:
                        if (x.totalvitamins != 0)
                        {
                            Totals model = new Totals()
                            {
                                MealId = MealId,
                                food = x.food,
                                nutrient_id = 325,
                                totalvitamins = x.totalvitamins,
                                value = 90,
                                unit = "mg",
                                name = "Vitamin C, total ascorbic acid",
                                percent = (x.totalvitamins / 90) * 100,
                                dayid = x.dayid
                            };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };

                            break;
                        }
                        else
                        {
                            Totals model = new Totals()
                              {
                                  MealId = MealId,
                                  food = x.food,
                                  nutrient_id = 325,
                                  totalvitamins = x.value,
                                  value = 90,
                                  unit = "mg",
                                  name = "Vitamin C, total ascorbic acid",
                                  percent = (x.value / 90) * 100,
                                  dayid = dayid
                              };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };

                            break;
                        }
                    case 324:
                        if (x.totalvitamins != 0)
                        {
                            Totals model = new Totals()
                              {
                                  MealId = MealId,
                                  food = x.food,
                                  nutrient_id = 324,
                                  totalvitamins = x.totalvitamins,
                                  value = 15,
                                  unit = "ug",
                                  name = "Vitamin D",
                                  percent = (x.totalvitamins / 15) * 100,
                                  dayid = x.dayid
                              };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                        else
                        {
                            Totals model = new Totals()
                            {
                                MealId = MealId,
                                food = x.food,
                                nutrient_id = 324,
                                totalvitamins = x.value,
                                value = 15,
                                unit = "ug",
                                name = "Vitamin D",
                                percent = (x.value / 15) * 100,
                                dayid = dayid
                            };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                    case 323:
                        if (x.totalvitamins != 0)
                        {
                            Totals model = new Totals()
                              {
                                  MealId = MealId,
                                  food = x.food,
                                  nutrient_id = 323,
                                  totalvitamins = x.totalvitamins,
                                  value = 22.4,
                                  unit = "iu",
                                  name = "Vitamin E (alpha-tocopherol)",
                                  percent = (x.totalvitamins / 22.4) * 100,
                                  dayid = x.dayid
                              };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                        else
                        {
                            Totals model = new Totals()
                            {
                                MealId = MealId,
                                food = x.food,
                                nutrient_id = 323,
                                totalvitamins = x.value,
                                value = 22.4,
                                unit = "iu",
                                name = "Vitamin E (alpha-tocopherol)",
                                percent = (x.value / 22.4) * 100,
                                dayid = dayid
                            };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };
                            break;
                        }
                    case 309:
                        if (x.totalvitamins != 0)
                        {
                            Totals model = new Totals()
                            {
                                MealId = MealId,
                                food = x.food,
                                nutrient_id = 301,
                                totalvitamins = x.totalvitamins,
                                value = 11,
                                unit = "mg",
                                name = "Zinc, Zn",
                                percent = (x.totalvitamins / 11) * 100,
                                dayid = x.dayid
                            };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };

                            break;
                        }
                        else
                        {
                            Totals model = new Totals()
                              {
                                  MealId = MealId,
                                  food = x.food,
                                  nutrient_id = 301,
                                  totalvitamins = x.value,
                                  value = 11,
                                  unit = "mg",
                                  name = "Zinc, Zn",
                                  percent = (x.value / 11) * 100,
                                  dayid = dayid
                              };
                            using (ApplicationDbContext db = new ApplicationDbContext())
                            {
                                db.Total.Add(model);
                                db.SaveChanges();
                            };

                            break;
                        }
                }
            }

            return (toEat);
        }

        //food totals

        public List<TotalsVM> GetTotals(int id)
        {
            List<TotalsVM> model;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                model = db.Total.Where(x => x.MealId == id).Select(x => new TotalsVM()
                    {
                        MealId = x.MealId,
                        nutrient_id = x.nutrient_id,
                        food = x.food,
                        name = x.name,
                        value = x.value,
                        unit = x.unit,
                        percent = x.percent,
                        totalvitamins = x.totalvitamins,
                        dayid = x.dayid
                    }).ToList();
            };
            //want to add empty vitamins to list
            //empty = db.Total.Where(x => x.MealId == 1).Select(x => new TotalsVM()
            //{
            //    MealId = x.MealId,
            //    nutrient_id = x.nutrient_id,
            //    food = x.food,
            //    name = x.name,
            //    value = x.value,
            //    unit = x.unit,
            //    percent = x.percent,
            //    totalvitamins = x.totalvitamins
            //}).ToList();

            return (model);
        }

        //'your food' display

        public List<TotalsVM> YourFood(int id)
        {
            List<TotalsVM> model;
            List<TotalsVM> empty;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                model = db.Total.Where(x => x.MealId == id && x.FoodtypeId == Totals.foodType.totalsbase && x.food != null).Select(x => new TotalsVM()
                {
                    MealId = x.MealId,
                    nutrient_id = x.nutrient_id,
                    food = x.food,
                    name = x.name,
                    value = x.value,
                    unit = x.unit,
                    percent = x.percent,
                    totalvitamins = x.totalvitamins
                }).ToList();

                empty = db.Total.Where(x => x.MealId == id && x.FoodtypeId == Totals.foodType.totalsbase && x.food != null).Select(x => new TotalsVM()
                {
                    MealId = x.MealId,
                    nutrient_id = x.nutrient_id,
                    food = x.food,
                    name = x.name,
                    value = x.value,
                    unit = x.unit,
                    percent = x.percent,
                    totalvitamins = x.totalvitamins
                }).ToList();
            }

            return (model);
        }

        public List<TotalsVM> PostDisplay(List<TotalsVM> YourFood)
        {
            foreach (var x in YourFood)
            {
                Totals model = new Totals()
                {
                    food = x.food,
                    nutrient_id = x.nutrient_id,
                    name = x.name,
                    value = x.value,
                    MealId = x.MealId,
                    unit = x.unit,
                    FoodtypeId = Totals.foodType.meal
                };

                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    db.Total.Add(model);
                    db.SaveChanges();
                };
            }

            return (YourFood);
        }

        public int getMealId()
        {
            int MealId;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                MealId = db.Total.Select(x => x.MealId).Max();
            }
            return MealId;
        }

        public int getDayId()
        {
            int DayId;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                DayId = db.Total.Select(x => x.dayid).Max();
            }
            return DayId;
        }

        public void Delete(int id)
        {
            List<Totals> model;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                model = db.Total.Where(x => x.dayid == id).ToList();
                db.Total.RemoveRange(model);
                db.SaveChanges();
            }
        }

        public List<TotalsVM> DeleteId(int id)
        {
            List<TotalsVM> model;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                model = db.Total.Where(x => x.dayid == id).Select(x => new TotalsVM()
                {
                    MealId = x.MealId,
                    nutrient_id = x.nutrient_id,
                    food = x.food,
                    name = x.name,
                    value = x.value,
                    unit = x.unit,
                    percent = x.percent,
                    totalvitamins = x.totalvitamins,
                    dayid = x.dayid
                }).ToList();
            };
            return model;
        }
    }
}