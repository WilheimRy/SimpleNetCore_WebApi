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
                throw new Exception("student can not be null");
            }

            _forexDbContext.ForexDetails.Add(forexDetail);
            _forexDbContext.SaveChanges();
        }

        public IEnumerable<ForexDetail> FindAll()
        {
            return _forexDbContext.ForexDetails.ToList();
        }

        //Todo: need to think how to trigger this 

        public IEnumerable<ForexDetail> FindLatestForexDetail()
        {
            return _forexDbContext.ForexDetails.ToList();
        }
    }
}
