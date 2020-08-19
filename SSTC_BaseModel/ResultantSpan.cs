using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSTC_BaseModel
{
    // pure container train...
    [Serializable]
    public class ResultantSpan
    {
        /// <summary>
        /// Conductor total load with (eventually defined) additional wind and/or ice load.
        /// </summary>
        public double ConductorTotalLoad { get; private set; }                                          // mC2g [N/m]
        /// <summary>
        /// Tower to tower horizontal difference.
        /// </summary>
        public double ConductorSpanHorizontalLength { get; private set; }                               // aC [m]
        /// <summary>
        /// Tower to tower vertical difference.
        /// </summary>
        public double ConductorSpanVerticalDifference { get; private set; }                             // hC [m]
        /// <summary>
        /// Final horizontal tension.
        /// </summary>
        public double FinalHorizontalStress { get; private set; }                                       // s2 [N]
        /// <summary>
        /// Final conductor catenary length.
        /// </summary>
        public double ConductorSpanCatenaryLength { get; private set; }                                 // L2 [m]
        /// <summary>
        /// Final conductor vertex.
        /// </summary>
        public double ConductorSpanVertex { get; private set; }                                         // xV2 [m]
        /// <summary>
        /// Final conductor relative position with respect to span horizontal length.
        /// </summary>
        public double ConductorRelativeSpanVertexPosition { get; private set; }                         // xV2R [m]
        /// <summary>
        /// Left tower's total vertical force.
        /// </summary>
        public double LeftInsulatorTotalVerticalForce { get; private set; }                             // GKL2 [N]
        /// <summary>
        /// Left attachment set's horizontal offset.
        /// </summary>
        public double LeftInsulatorHorizontalOffset { get; private set; }                               // LdINS2 [m]
        /// <summary>
        /// Left attachment set's vertical offset.
        /// </summary>
        public double LeftInsulatorVerticalOffset { get; private set; }                                 // LeINS2 [m]
        /// <summary>
        /// Right tower's total vertical force.
        /// </summary>
        public double RightInsulatorTotalVerticalForce { get; private set; }                            // GKR2 [N]
        /// <summary>
        /// Right attachment set's horizontal offset.
        /// </summary>
        public double RightInsulatorHorizontalOffset { get; private set; }                              // RdINS2 [m]
        /// <summary>
        /// Right attachment set's vertical offset.
        /// </summary>
        public double RightInsulatorVerticalOffset { get; private set; }                                // ReINS2 [m]
        /// <summary>
        /// Left tower's total force.
        /// </summary>
        public double TowerLeftTensileForce { get; private set; }                                       // SFL [N]
        /// <summary>
        /// Right tower's total force.
        /// </summary>
        public double TowerRightTensileForce { get; private set; }                                      // SFR [N]
        /// <summary>
        /// Attachment point to attachment point span sag in span middle point (highest sag).
        /// </summary>
        public double ConductorMaxSag { get; private set; }                                             // f [m]
        /// <summary>
        /// Tower to tower span replacement sag calculated as attachment point to attachment point span sag with separately calculated correction.
        /// </summary>
        public double ConductorSagInSagVertexPoint_WithInsulatorSetOmitCorrection { get; private set; } // cf [m]


        public ResultantSpan(double mC2g, double aC, double hC, double s2, double L2, double xV2, double xV2R, double GKL2, double GKR2, double LdINS2, double LeINS2, double RdINS2, double ReINS2, double SFL, double SFR, double f, double cf) 
        {
            ConductorTotalLoad = mC2g;
            ConductorSpanHorizontalLength = aC;
            ConductorSpanVerticalDifference = hC;
            FinalHorizontalStress = s2;
            ConductorSpanCatenaryLength = L2;
            ConductorSpanVertex = xV2;
            ConductorRelativeSpanVertexPosition = xV2R;
            LeftInsulatorTotalVerticalForce = GKL2;
            LeftInsulatorHorizontalOffset = LdINS2;
            LeftInsulatorVerticalOffset = LeINS2;
            RightInsulatorTotalVerticalForce = GKR2;
            RightInsulatorHorizontalOffset = RdINS2;
            RightInsulatorVerticalOffset = ReINS2;
            TowerLeftTensileForce = SFL;
            TowerRightTensileForce = SFR;
            ConductorMaxSag = f;
            ConductorSagInSagVertexPoint_WithInsulatorSetOmitCorrection = cf;                
        }
        public ResultantSpan(double[] resultArray)
        {
            ConductorTotalLoad = resultArray[0];
            ConductorSpanHorizontalLength = resultArray[1];
            ConductorSpanVerticalDifference = resultArray[2];
            FinalHorizontalStress = resultArray[3];
            ConductorSpanCatenaryLength = resultArray[4];
            ConductorSpanVertex = resultArray[5];
            ConductorRelativeSpanVertexPosition = resultArray[6];
            
            LeftInsulatorTotalVerticalForce = resultArray[7];
            LeftInsulatorHorizontalOffset = resultArray[9];
            LeftInsulatorVerticalOffset = resultArray[10];
            
            RightInsulatorTotalVerticalForce = resultArray[8];
            RightInsulatorHorizontalOffset = resultArray[11];
            RightInsulatorVerticalOffset = resultArray[12];
            
            TowerLeftTensileForce = resultArray[13];
            TowerRightTensileForce = resultArray[14];
            
            ConductorMaxSag = resultArray[15];
            ConductorSagInSagVertexPoint_WithInsulatorSetOmitCorrection = resultArray[16];
        }
    }
}
