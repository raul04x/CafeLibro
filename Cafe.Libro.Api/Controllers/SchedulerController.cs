using Cafe.Libro.Entities;
using Cafe.Libro.Entities.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Cafe.Libro.Api.Controllers
{
    [RoutePrefix("Scheduler")]
    public class SchedulerController : ApiController
    {

        [HttpGet]
        [Route("GetAllEaters")]
        public async Task<BaseRequest<Lunch>> GetAllEaters()
        {
            BaseRequest<Lunch> result = await Task.Run(() =>
            {
                BaseRequest<Lunch> temp = null;
                return temp;
            });
            return result;
        }

        [HttpPost]
        [Route("SaveTheMeet")]
        public async Task<BaseRequest<Lunch>> SaveTheMeet(BaseRequest<Lunch> lunch)
        {
            BaseRequest<Lunch> result = await Task.Run(() =>
            {
                BaseRequest<Lunch> temp = null;
                return temp;
            });
            return result;
        }

        [HttpPost]
        [Route("DeleteTheMeet")]
        public async Task<BaseRequest<Lunch>> DeleteTheMeet(BaseRequest<Lunch> lunch)
        {
            BaseRequest<Lunch> result = await Task.Run(() =>
            {
                BaseRequest<Lunch> temp = null;
                return temp;
            });
            return result;
        }

        [HttpPost]
        [Route("SignIn")]
        public async Task<BaseRequest<Lunch>> SignIn(BaseRequest<Lunch> lunch)
        {
            BaseRequest<Lunch> result = await Task.Run(() =>
            {
                BaseRequest<Lunch> temp = null;
                return temp;
            });
            return result;
        }
    }
}
