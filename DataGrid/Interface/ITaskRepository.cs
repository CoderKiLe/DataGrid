using DataGrid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid.Interface
{ 
    public interface ITaskRepository : IDisposable
    {
            void InitializeDatabase();
            void InsertTask(DataSourceModel task);
            IEnumerable<DataSourceModel> GetAllTasks();
    }
}
