using Health.Adapters.Adapters;
using Health.Adapters.Interfaces;
using Health.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Health.Controllers
{
    public class apiDisplayController : ApiController
    {
        private IFoodAdapter _adapter;

        public apiDisplayController()
        {
            _adapter = new FoodAdapter();
        }

        public apiDisplayController(IFoodAdapter a)
        {
            _adapter = a;
        }

        public IHttpActionResult Get()
        {
            int dayID = _adapter.getDayId();
            return Ok(dayID);
        }

        [HttpPost]
        public IHttpActionResult Post(List<TotalsVM> YourFood)
        {
            List<TotalsVM> update = _adapter.PostDisplay(YourFood);
            return Ok(update);
        }

        public IHttpActionResult DeleteId(int id)
        {
            List<TotalsVM> delete = _adapter.DeleteId(id);
            return Ok(delete);
        }
    }
}