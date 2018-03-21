using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectTestBlog.TestFiles
{
    public class NumberRepository : INumberRepository
    {
        public IList<int> GetNumbers()
        {
            return new List<int> { 1, 2, 3, 4, 5 };
        }
    }
}