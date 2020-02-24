using Q3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;

namespace Q3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NiallsWebService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select NiallsWebService.svc or NiallsWebService.svc.cs at the Solution Explorer and start debugging.
    public class NiallsWebService : INiallsWebService
    {
        public StatusModel DisplayResults()
        {

            var status = new StatusModel()
            {
                //initial result is set to zero
                statusResultA = 0;
             };
        }
    }
}
