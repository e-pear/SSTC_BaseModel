using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SSTC_BaseModel
{
    //Base interface for every database manageable object.
    public interface IDataManageable
    {
        string Category { get; set; }
        string CodeName { get; set; }
        string DetailedName { get; }
        string ToCSVLine();
    }
}
