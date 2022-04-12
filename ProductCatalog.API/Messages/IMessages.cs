using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.API.Messages
{
    public interface IMessages
    {
        string Added { get; set; }
        string AddedError { get; set; }
        string Deleted { get; set; }
        string DeltedError { get; set; }
        string DuplicateData { get; set; }
        string Null { get; set; }
        string Updated { get; set; }
        string UpdatedError { get; set; }
        string ExceptionError { get; set; }
    }
}
