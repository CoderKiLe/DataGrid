using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid.Model
{
    // class to create a data source, and perform a CRUD operation like so
    // task manager lets presume
    public class DataSourceModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsCompleted { get; set; }
        public Priority Priority { get; set; }
    }
}
