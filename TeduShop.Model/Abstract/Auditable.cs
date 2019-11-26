using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public abstract class AudiTable : IAudiTable
    {
        public DateTime? CreatedDateTable { get; set; }

        [MaxLength(256)]
        public string CreatedByTable { get; set; }
        public DateTime? UpdatedDateTable { get; set; }

        [MaxLength(256)]
        public  string UpdatedByTable { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}
