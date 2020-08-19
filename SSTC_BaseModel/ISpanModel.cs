using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSTC_BaseModel
{
    public interface ISpanModel
    {
        string TowerDescription { get; }
        double TowerAbscissa { get; }
        double TowerOrdinate { get; }
        double AttachmentPointHeight { get; }
        string InsulatorSetCode { get; }
        double InsulatorArmLength { get; }
        double InsulatorArmWeight { get; }
        double InsulatorOpeningAngle { get; }
        double InsulatorIceLoad { get; }
        double SpanIceLoad { get; }
        double SpanWindLoad { get; }
    }
}
