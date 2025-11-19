using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintSalesApp
{
    public class Sale
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int PaintId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime SaleDate { get; set; }
    }
}