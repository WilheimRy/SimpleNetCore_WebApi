using ForexAppApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForexAppApi.Data
{
    public class DbInitializer
    {
        public static void Initialize(ForexDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any existing forex tables.
            if (context.ForexDetails.Any())
            {
                return;   // DB has been seeded
            }

            var forexDetails = new ForexDetail[]
            {
                new ForexDetail{CurrencyCode="EURUSD", OrderStatus = OrderStatus.ACTIVE, OrderAction = OrderAction.BUY, OrderResult = OrderResult.PENDING, OrderOpenPrice = 1.18111, OrderTakeProfitPrice = 1.19000, OrderStopLossPrice = 1.18000, OrderOpenTime = new DateTime(2020,11,14) },
                new ForexDetail{CurrencyCode="EURUSD", OrderStatus = OrderStatus.ACTIVE, OrderAction = OrderAction.BUY, OrderResult = OrderResult.PENDING, OrderOpenPrice = 1.18333, OrderTakeProfitPrice = 1.19000, OrderStopLossPrice = 1.18000, OrderOpenTime = new DateTime(2020,11,14) },
                new ForexDetail{CurrencyCode="AUDUSD", OrderStatus = OrderStatus.ACTIVE, OrderAction = OrderAction.SELL, OrderResult = OrderResult.PENDING, OrderOpenPrice = 0.72222, OrderTakeProfitPrice = 0.73000, OrderStopLossPrice = 0.71000, OrderOpenTime = new DateTime(2020,11,14) },
                new ForexDetail{CurrencyCode="AUDUSD", OrderStatus = OrderStatus.ACTIVE, OrderAction = OrderAction.SELL, OrderResult = OrderResult.PENDING, OrderOpenPrice = 0.73333, OrderTakeProfitPrice = 0.73000, OrderStopLossPrice = 0.71000, OrderOpenTime = new DateTime(2020,11,14) },
            };
            foreach (var fx in forexDetails)
            {
                context.ForexDetails.Add(fx);
            }
            context.SaveChanges();
        }
    }
}
