using DataGrid.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid.DataSource
{
    public static class DbContext
    {
        public static ITaskRepository CreateTaskRepository()
        {
            return new TaskRepository("Data Source=taskDatabase.db");
        }
    }
}
