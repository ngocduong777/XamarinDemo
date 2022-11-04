using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;

namespace webapinew.Controllers
{
    public class XuLyController : ApiController
    {
        [Route("api/XuLy/Chao")]
        [HttpGet]
        public IHttpActionResult Chao()
        {
            try
            {
                string cauchao = "Chao cac ban hihi";
                return Ok(cauchao);
            }
            catch
            {
                return NotFound();
            }
        }

        [Route("api/LoaiHoa/LayDSLoaiHoa")]
        [HttpGet]
        public IHttpActionResult LayDSLoaiHoa()
        {
            try
            {
                DataTable tb = Database.LayDSLoaiHoa();
                return Ok(tb);
            }
            catch
            {
                return NotFound();
            }
        }

    }
}
