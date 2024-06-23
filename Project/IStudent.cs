using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IStudent
    {
        string Name { get; set; }
        int Class { get; set; }
        double AverageIncomePerMember();
    }
}
