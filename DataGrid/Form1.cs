using DataGrid.DataSource;
using Microsoft.Data.Sqlite;

namespace DataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupDb();
        }

        static void SetupDb()
        {
            DbContext.CreateTaskRepository();
        }
    }
}
