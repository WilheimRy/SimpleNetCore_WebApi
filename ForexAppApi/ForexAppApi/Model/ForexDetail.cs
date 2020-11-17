using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForexAppApi.Model
{
    public class ForexDetail
    {
        public int Id { get; set; }
        public string? CurrencyCode { get; set; }
        public OrderStatus? OrderStatus { get; set; }
        public OrderResult? OrderResult { get; set; }
        public OrderAction? OrderAction { get; set; }
        public double? OrderOpenPrice { get; set; }
        public double? OrderTakeProfitPrice { get; set; }
        public double? OrderStopLossPrice { get; set; }
        public DateTime? OrderOpenTime { get; set; }
        public DateTime? OrderCloseTime { get; set; }

    }

    public enum OrderStatus 
    {
        ACTIVE = 0,
        CLOSE = 1
    }

    public enum OrderAction
    { 
        BUY = 0,
        SELL = 1
    }

    public enum OrderResult
    { 
        PENDING = 0,
        PROFIT = 1,
        LOSS = 2
        
    }

}
