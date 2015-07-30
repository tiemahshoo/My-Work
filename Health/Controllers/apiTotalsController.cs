using Health.Adapters.Adapters;
using Health.Adapters.Interfaces;
using Health.data.model;
using Health.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Health.Controllers
{
    public class apiTotalsController : ApiController
    {
        private IFoodAdapter _adapter;

        public apiTotalsController()
        {
            _adapter = new FoodAdapter();
        }

        public apiTotalsController(IFoodAdapter a)
        {
            _adapter = a;
        }

        public IHttpActionResult Get()
        {
            int mealid = _adapter.getMealId();
            return Ok(mealid);
        }

        public IHttpActionResult Get(int id)
        {
            List<TotalsVM> totals = _adapter.GetTotals(id);
            return Ok(totals);
        }

        public IHttpActionResult Delete(int id)
        {
            _adapter.Delete(id);
            return Ok();
        }
    }
}