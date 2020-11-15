using ForexAppApi.Model;
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
    }
}
