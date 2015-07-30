using Health.Adapters.Adapters;
using Health.Adapters.Interfaces;
using Health.data.model;
using Health.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Health.Controllers
{
    public class apiFoodController : ApiController
    {
        private IFoodAdapter _adapter;

        public apiFoodController()
        {
            _adapter = new FoodAdapter();
        }

        public apiFoodController(IFoodAdapter a)
        {
            _adapter = a;
        }

        [HttpPost]
        public IHttpActionResult Post(List<TotalsVM> toEat)
        {
            List<TotalsVM> update = _adapter.Getvitamins(toEat);
            return Ok(update);
        }

        public IHttpActionResult Get(int id)
        {
            List<TotalsVM> vitamins = _adapter.GetVitamins(id);
            return Ok(vitamins);
        }
    }
}