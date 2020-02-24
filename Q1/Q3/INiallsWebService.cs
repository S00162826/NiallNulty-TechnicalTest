using Q3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Q3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INiallsWebService" in both code and config file together.
    [ServiceContract]
    public interface INiallsWebService
    {
        [OperationContract]
        StatusModel DisplayResults();
    }
}
