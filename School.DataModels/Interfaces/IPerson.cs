using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataModels.Interfaces
{
    public interface IPerson
    {
        string Name { get; set; }

        int Age { get; set; }

        string Location { get; set; }

        DateTime DOB { get; set; }
    }
}
