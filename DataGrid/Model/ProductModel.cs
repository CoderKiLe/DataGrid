using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid.Model
{
    public class Product
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Orders { get; set; }
        public decimal Revenue { get; set; }

        // Calculated property
        public decimal AverageOrderValue => Orders > 0 ? Revenue / Orders : 0;

        // Formatting methods
        public string GetFormattedDate() => Date.ToString("yyyy-MM-dd");
        public string GetFormattedRevenue() => Revenue.ToString("C");

        // Constructor
        public Product() { }

        public Product(string name, DateTime date, int orders, decimal revenue)
        {
            Name = name;
            Date = date;
            Orders = orders;
            Revenue = revenue;
        }

        public override string ToString()
        {
            return $"{Name.PadRight(10)} | {GetFormattedDate()} | {Orders.ToString().PadLeft(5)} orders | {GetFormattedRevenue().PadLeft(10)}";
        }
    }
}
