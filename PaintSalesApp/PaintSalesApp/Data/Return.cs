using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintSalesApp
{
    public class Return
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public DateTime ReturnDate { get; set; }
        public int Quantity { get; set; }
        public string Reason { get; set; }
    }
}