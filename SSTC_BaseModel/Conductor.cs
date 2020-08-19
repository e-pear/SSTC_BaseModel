using System;

namespace SSTC_BaseModel
{
    // Conductor 2.0
    // Base class holding all wire/conductor type data.
    [Serializable]
    public class Conductor :  IDataManageable, IEquatable<Conductor>
    {
        //MAIN PROPERTIES: - used in calculation/project module
        public double CrossSection { get; private set; }
        public double Diameter { get; private set; }
        public double RTS { get; private set; }
        public double WeightPerLength { get; private set; }
        public double ThermalExpansionCoefficient { get; private set; }
        public double ModulusOfElasticity { get; private set; }
        public double Resistance20oCPerLength { get; private set; }

        //DESCRIPTION PROPERTIES: - used in data managing module
        public string Category { get; set; }
        public string CodeName { get; set; }
        public string Description { get; set; }
        //DESCRIPTION PROPERTY - used in calculation module
        public string DetailedName
        {
            get { return CodeName + $" (\u25cf{CrossSection} / \u2300{Diameter} / {RTS}kN )"; }
        }

        //CONSTRUCTORS:
        public Conductor (string cat, string code, double A, double d, double RTS, double mC, double aT, double E, double R20, string desc)
        {
            this.CrossSection = A;
            this.Diameter = d;
            this.RTS = RTS;
            this.WeightPerLength = mC;
            this.ThermalExpansionCoefficient = aT;
            this.ModulusOfElasticity = E;
            this.Resistance20oCPerLength = R20;

            this.Category = cat;
            this.CodeName = code;
            this.Description = desc;
        }
        public Conductor (Conductor conductor)
        {
            this.CrossSection = conductor.CrossSection;
            this.Diameter = conductor.Diameter;
            this.RTS = conductor.RTS;
            this.WeightPerLength = conductor.WeightPerLength;
            this.ThermalExpansionCoefficient = conductor.ThermalExpansionCoefficient;
            this.ModulusOfElasticity = conductor.ModulusOfElasticity;
            this.Resistance20oCPerLength = conductor.Resistance20oCPerLength;

            this.Category = conductor.Category;
            this.CodeName = conductor.CodeName;
            this.Description = conductor.Description;
        }

        //INTERFACE METHODS:
        public string ToCSVLine()
        {
            double A = this.CrossSection;
            double d = this.Diameter;
            double RTS = this.RTS;
            double mC = this.WeightPerLength;

            double aT = this.ThermalExpansionCoefficient;
            double E = this.ModulusOfElasticity;
            double R20 = this.Resistance20oCPerLength;

            string cat = this.Category;
            string code = this.CodeName;
            string desc = this.Description;

            return $"{cat};{code};{A};{d};{mC};{RTS};{aT};{E};{R20};{desc}";
        }
        public bool Equals(Conductor other)
        {  
            if (other == null) return false;

            if (
                   Math.Abs(this.CrossSection - other.CrossSection) < 1e-7
                && Math.Abs(this.Diameter - other.Diameter) < 1e-7
                && Math.Abs(this.RTS - other.RTS) < 1e-4
                && Math.Abs(this.WeightPerLength - other.WeightPerLength) < 1e-9
                && Math.Abs(this.ThermalExpansionCoefficient - other.ThermalExpansionCoefficient) < 1e-11
                && Math.Abs(this.ModulusOfElasticity - other.ModulusOfElasticity) < 1e-4
                && Math.Abs(this.Resistance20oCPerLength - other.Resistance20oCPerLength) < 1e-9
                ) return true;
            else return false;
        }
    }
}
