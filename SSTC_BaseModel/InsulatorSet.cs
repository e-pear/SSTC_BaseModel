using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSTC_BaseModel
{
    // InsulatorSet 2.0
    // Base class holding all insulator set/clamp type data.
    [Serializable]
    public class InsulatorSet : IDataManageable, IEquatable<InsulatorSet>
    {
        //MAIN PROPERTIES: - used in calculation/project module
        public double ArmLength { get; private set; }
        public double ArmWeight { get; private set; }
        public double OpeningAngle { get; private set; }

        //DESCRIPTION PROPERTIES: - used in data managing module
        public string Category { get; set; }
        public string CodeName { get; set; }
        public string Description { get; set; }

        //DESCRIPTION PROPERTY - used in calculation module
        public string DetailedName
        {
            get 
            {
                if (OpeningAngle != 0) return CodeName + $" ({ArmLength} m / {ArmWeight} kg / \u0398{OpeningAngle}\u00b0)";
                else return CodeName + $" ({ArmLength} m / {ArmWeight} kg)";
            }
        }
        //CONSTRUCTORS:
        public InsulatorSet(string category, string codeName, string shortDescription, double armLength, double armWeight, double openingAngle = 0)
        {
            this.Category = category;
            this.CodeName = codeName;
            this.Description = shortDescription;
            this.ArmLength = armLength;
            this.ArmWeight = armWeight;
            this.OpeningAngle = openingAngle;
        }
        public InsulatorSet(InsulatorSet insulator)
        {
            this.Category = insulator.Category;
            this.CodeName = insulator.CodeName;
            this.Description = insulator.Description;
            this.ArmLength = insulator.ArmLength;
            this.ArmWeight = insulator.ArmWeight;
            this.OpeningAngle = insulator.OpeningAngle;
        }
        //INTERFACE METHODS:
        public string ToCSVLine()
        {
            double Lins = this.ArmLength;
            double Mins = this.ArmWeight;
            double ains = this.OpeningAngle;
            
            string cat = this.Category;
            string code = this.CodeName;
            string desc = this.Description;

            return $"{cat};{code};{Lins};{Mins};{ains};{desc}";
        }

        public bool Equals(InsulatorSet other)
        {
            if (other == null) return false;

            if (
                   Math.Abs(this.ArmLength - other.ArmLength) < 1e-7
                && Math.Abs(this.ArmWeight - other.ArmWeight) < 1e-7
                && Math.Abs(this.OpeningAngle - other.OpeningAngle) < 1e-7
                ) return true;
            else return false;
        }
    }
}
