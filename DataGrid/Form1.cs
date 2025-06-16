using C1.Win.C1FlexGrid;
using DataGrid.DataSource;
using DataGrid.Model;
using Microsoft.Data.Sqlite;
using System.Runtime.CompilerServices;

namespace DataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupDb();
            SetUpFlexChart();

        }

        public IEnumerable<DataSourceModel> SetupDb()
        {
            using var repository = DbContext.CreateTaskRepository();

            // initialize the repository
            repository.InitializeDatabase();

            // insert a task
            repository.InsertTask(new DataSourceModel
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Clean code review",
                Description = "Review database code",
                DateTime = DateTime.Now,
                Priority = Priority.High,
                IsCompleted = false
            });


            // Get all tasks
            var tasks = repository.GetAllTasks(); // consist the fetched values in the form fo teh IEnumerable
            var newTasks = repository.GetAllTasksAsDataTable();

            c1FlexGrid1.DataSource = newTasks; // should be in datatable format you know what and wh


            return tasks;

        }

        // method to setup the flexchar in the ui
        public void SetUpFlexChart()
        {
            flexChart1.Series.Clear();
            flexChart1.ChartType = C1.Chart.ChartType.Line;
            flexChart1.Header.Content = "DateWise Revenu";
            flexChart1.Series.Add(new C1.Win.Chart.Series
            {
                Name = "Sales",
                Binding = "Revenue",
            });

            flexChart1.BindingX = "Date";
            flexChart1.DataSource = GetProductRevenue();
        }

        // sample product list for the dateset for the flex chart
        public List<Product> GetProductRevenue()
        {
            List<Product> _list = new List<Product>();
            _list.Add(new Product() { Name = "Desktop", Date = new DateTime(2018, 04, 07), Orders = 265, Revenue = 6625 });
            _list.Add(new Product() { Name = "Desktop", Date = new DateTime(2018, 05, 08), Orders = 107, Revenue = 2675 });
            _list.Add(new Product() { Name = "Mouse", Date = new DateTime(2018, 06, 02), Orders = 56, Revenue = 560 });
            _list.Add(new Product() { Name = "Mouse", Date = new DateTime(2018, 07, 06), Orders = 572, Revenue = 5720 });
            _list.Add(new Product() { Name = "Mouse", Date = new DateTime(2018, 08, 05), Orders = 468, Revenue = 4680 });
            _list.Add(new Product() { Name = "Printer", Date = new DateTime(2018, 09, 02), Orders = 154, Revenue = 2310 });
            _list.Add(new Product() { Name = "Desktop", Date = new DateTime(2018, 10, 03), Orders = 89, Revenue = 2225 });
            _list.Add(new Product() { Name = "Desktop", Date = new DateTime(2018, 11, 05), Orders = 347, Revenue = 8675 });
            _list.Add(new Product() { Name = "Printer", Date = new DateTime(2018, 12, 07), Orders = 204, Revenue = 3060 });
            _list.Add(new Product() { Name = "Printer", Date = new DateTime(2019, 01, 03), Orders = 34, Revenue = 510 });
            _list.Add(new Product() { Name = "Mouse", Date = new DateTime(2019, 02, 06), Orders = 223, Revenue = 2230 });
            _list.Add(new Product() { Name = "Desktop", Date = new DateTime(2019, 03, 08), Orders = 119, Revenue = 2975 });
            _list.Add(new Product() { Name = "Desktop", Date = new DateTime(2019, 04, 08), Orders = 119, Revenue = 2975 });

            return _list;
        }

        private void flexChart1_Click(object sender, EventArgs e)
        {

        }
    }

}
