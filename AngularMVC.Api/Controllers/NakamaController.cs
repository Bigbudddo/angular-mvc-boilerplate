using AngularMVC.Models;
using AngularMVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace AngularMVC.Api.Controllers {

    public class NakamaController : ApiController {

        [HttpGet]
        [ResponseType(typeof (Nakama))]
        [Route("api/nakama")]
        [Route("api/nakama/{nakamaId}")]
        public IHttpActionResult GetNakama(int nakamaId) {
            var repo = new NakamaRepository();
            return Ok(repo.GetNakama(nakamaId));
        }

        [HttpGet]
        [ResponseType(typeof (List<Nakama>))]
        [Route("api/nakama/all")]
        public IHttpActionResult GetAllNakama() {
            var repo = new NakamaRepository();
            return Ok(repo.GetNakamas());
        }
    }
}
