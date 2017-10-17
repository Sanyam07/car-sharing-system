﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using car_sharing_system.Models;

namespace car_sharing_system.Controllers {
	public class CarController : System.Web.Http.ApiController {
		// GET api/car
		public IEnumerable<string> Get() {
			return new string[] { "value1", "value2" };
		}

		// GET api/car/{amount}
		// Use amount as to the amount of cars requested
		// Return available cars number plate
		[Route("api/car/{amount}")]
		public string Get(int amount) {
			List<String> numberplates = new List<String>(new String[] { "AA11", "BB22", "CC33", "DD44" });
			return new JavaScriptSerializer().Serialize(numberplates);
		}

		// POST api/car
		public void Post([FromBody]String value) {
		}

		// PUT api/car/{id}
		public void Put(int id, [FromBody]string value) {
		}

		// DELETE api/car/{id}
		public void Delete(int id) {
		}
	}
}