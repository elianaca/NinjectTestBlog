using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTestBlog.TestFiles
{
    public interface INumberRepository
    {
        IList<int> GetNumbers();
    }
}
