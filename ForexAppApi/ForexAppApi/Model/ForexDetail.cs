using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForexAppApi.Model
{
    public class ForexDetail
    {
        public int Id { get; set; }
        public string CurrencyCode { get; set; }
        public string OrderStatus { get; set; }
        public string OrderResult { get; set; }
        public string OrderAction { get; set; }
        public double OrderOpenPrice { get; set; }
        public double OrderTakeProfitPrice { get; set; }
        public double OrderStopLossPrice { get; set; }
        public DateTime OrderOpenTime { get; set; }
        public DateTime OrderCloseTime { get; set; }

    }
}
