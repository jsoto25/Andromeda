using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Microcolsa.Suite.Services
{
    public class SuiteResponse
    {
        public object Result { get; set; }
        public string Error { get; set; }
        public string InnerException { get; set; }
        public string StackTrace { get; set; }

        public SuiteResponse()
        { 
        }

        public SuiteResponse(object result)
        {
            this.Result = result;
        }

        public SuiteResponse(string errormsg, Exception Ex)
        {
            Error = errormsg;
            if (Ex != null)
            {
                InnerException = Ex.Message;
                StackTrace = Ex.StackTrace;
            }
        }
    }
}