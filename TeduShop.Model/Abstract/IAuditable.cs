using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public interface IAudiTable
    {
        DateTime? CreatedDateTable { get; set; }
        string CreatedByTable { get; set; }
        DateTime? UpdatedDateTable { get; set; }
        string UpdatedByTable { get; set; }
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
        bool Status { get; set; }
    }
}
