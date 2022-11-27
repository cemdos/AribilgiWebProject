using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AribilgiWebProject.Model
{
    public abstract class BaseModel
    {
        public int ID { get; set; }

        private bool? _deleted;

        [DefaultValue(false)]
        public bool Deleted
        {
            get { return _deleted ?? false; }
            set { _deleted = value; }
        }
        public int? DelUser { get; set; }
        public DateTime? DelDate { get; set; }
        public int? CreUser { get; set; }

        private DateTime? _creDate;

        public DateTime CreDate
        {
            get { return _creDate ?? DateTime.Now; }
            set { _creDate = value; }
        }
    }
}
