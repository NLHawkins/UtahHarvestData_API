using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using UtahHarvestData_API.Models;

namespace UtahHarvestData_API.Controllers
{
    public class GoatHuntController : ApiController
    {
       
            private ApplicationContext db = new ApplicationContext();

            public IQueryable<GoatHunt> Get()
            {
                return db.GoatHunts;
            }


            [ResponseType(typeof(GoatHunt))]
            public IHttpActionResult Get(int? id)
            {
                if (id == null)
                {
                    return BadRequest();
                }
                var instance = db.GoatHunts.Find(id);
                if (instance == null)
                {
                    return NotFound();
                }
                return Ok(instance);
            }
        }
    }
