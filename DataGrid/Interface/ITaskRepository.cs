using DataGrid.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid.Interface
{ 
    public interface ITaskRepository : IDisposable
    {
            void InitializeDatabase();
            void InsertTask(DataSourceModel task);

            DataTable GetAllTasksAsDataTable();

            IEnumerable<DataSourceModel> GetAllTasks();

    }
}
