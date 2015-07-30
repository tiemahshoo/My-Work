using Health.data.model;
using Health.Models;
using System.Collections.Generic;

namespace Health.Adapters.Interfaces
{
    public interface IFoodAdapter
    {
        List<TotalsVM> GetVitamins(int id);

        List<TotalsVM> Getvitamins(List<TotalsVM> toEat);

        List<TotalsVM> GetTotals(int id);

        List<TotalsVM> PostDisplay(List<TotalsVM> YourFood);

        int getMealId();

        void Delete(int id);

        int getDayId();

        List<TotalsVM> DeleteId(int id);
    }
}