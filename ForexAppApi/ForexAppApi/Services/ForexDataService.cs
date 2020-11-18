using ForexAppApi.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForexAppApi.Services
{
    public class ForexDataService: IForexDataService
    {
        private readonly ForexDbContext _forexDbContext;

        public ForexDataService(ForexDbContext forexDbContext)
        {
            _forexDbContext = forexDbContext;
        }

        public void Add(ForexDetail forexDetail)
        {
            if (forexDetail == null)
            {
                throw new Exception("forex can not be null");
            }

            _forexDbContext.ForexDetails.Add(forexDetail);
            _forexDbContext.SaveChanges();
        }

        public IQueryable<ForexDetail> FindAll()
        {
            return _forexDbContext.ForexDetails;
        }

        //Todo: need to think how to trigger this 
        
        public ForexDetail GetLatestForexDetail()
        {
            return _forexDbContext.ForexDetails.Last();
        }

        public ForexDetail getForexDetaiObj(IFormCollection keyValuePairs)
        {
            var forexDetail = new ForexDetail();

            forexDetail.CurrencyCode = keyValuePairs["CurrencyCode"];
            forexDetail.OrderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), keyValuePairs["OrderStatus"]);
            //forexDetail.OrderResult = (OrderResult)Enum.Parse(typeof(OrderResult), keyValuePairs["OrderResult"]);
            forexDetail.OrderAction = (OrderAction)Enum.Parse(typeof(OrderAction), keyValuePairs["OrderAction"]);
            forexDetail.OrderOpenPrice = Convert.ToDouble(keyValuePairs["OrderOpenPrice"]);
            //forexDetail.OrderTakeProfitPrice = Convert.ToDouble(keyValuePairs["OrderTakeProfitPrice"]);
            //forexDetail.OrderStopLossPrice = Convert.ToDouble(keyValuePairs["OrderStopLossPrice"]);
            forexDetail.OrderOpenTime = DateTime.Parse(keyValuePairs["OrderOpenTime"]);
            //forexDetail.OrderCloseTime = DateTime.Parse(keyValuePairs["OrderCloseTime"]);



            // convert to forex detail

            return forexDetail;
        }
    }
}
