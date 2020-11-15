using ForexAppApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForexAppApi.Services
{
    public interface IForexDataService
    {
        void Add(ForexDetail forexDetail);
        IQueryable<ForexDetail> FindAll();
        ForexDetail GetLatestForexDetail();

    }
}
