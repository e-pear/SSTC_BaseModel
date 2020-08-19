using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSTC_BaseModel
{
    [Serializable]
    public class ResultantSection
    {
        // Handy data pack for passing crucial data to other tabs and for further content serialization of calculator tab.

        public string ProjectName { get; set; }
        public IEnumerable<ISpanModel> SpatialModel { get; private set; }

        public Conductor SectionConductor { get; private set; }

        public double SectionInitialTension { get; private set; }

        public double SectionInitialTemperature { get; private set; }

        public double SectionTargetTemperature { get; private set; }

        public IEnumerable<ResultantSpan> Results { get; private set; }
        public double[] Solutions { get; private set; }

        public ResultantSection(string projectName, IEnumerable<ISpanModel> spatialModel, Conductor conductor, double initialTension, double initialTemperature, double targetTemperature, double[] solutions, IEnumerable<ResultantSpan> results)
        {
            this.ProjectName = projectName;
            this.SpatialModel = spatialModel;
            this.SectionConductor = conductor;
            this.SectionInitialTension = initialTension;
            this.SectionInitialTemperature = initialTemperature;
            this.SectionTargetTemperature = targetTemperature;
            this.Solutions = solutions;
            this.Results = results;
        }
    }
}
