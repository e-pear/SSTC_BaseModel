using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSTC_BaseModel
{
    [Serializable]
    public class RawSectionSpan : ISpanModel
    {
        public string TowerDescription { get; }

        public double TowerAbscissa { get; }

        public double TowerOrdinate { get; }

        public double AttachmentPointHeight { get; }

        public string InsulatorSetCode { get; }

        public double InsulatorArmLength { get; }

        public double InsulatorArmWeight { get; }

        public double InsulatorOpeningAngle { get; }

        public double InsulatorIceLoad { get; }

        public double SpanIceLoad { get; }

        public double SpanWindLoad { get; }

        public RawSectionSpan(ISpanModel spanModel)
        {
            TowerDescription = spanModel.TowerDescription;
            TowerAbscissa = spanModel.TowerAbscissa;
            TowerOrdinate = spanModel.TowerOrdinate;
            AttachmentPointHeight = spanModel.AttachmentPointHeight;
            InsulatorSetCode = spanModel.InsulatorSetCode;
            InsulatorArmLength = spanModel.InsulatorArmLength;
            InsulatorArmWeight = spanModel.InsulatorArmWeight;
            InsulatorOpeningAngle = spanModel.InsulatorOpeningAngle;
            InsulatorIceLoad = spanModel.InsulatorIceLoad;
            SpanIceLoad = spanModel.SpanIceLoad;
            SpanWindLoad = spanModel.SpanWindLoad;
        }
    }
}
