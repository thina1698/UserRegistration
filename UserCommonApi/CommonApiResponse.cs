using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UserCommonApi
{
    public class CommonApiResponse
    {
        public HttpStatusCode httpStatusCode { get; set; }
        public dynamic? Data {  get; set; }
        public string Message {  get; set; }
    }
}
