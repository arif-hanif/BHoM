﻿using BHoM.Base.Results;
using BHoM.Structural.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHoM.Structural.Interface
{
    public interface IResultAdapter
    {
        bool StoreResults(string filename, List<ResultType> resultTypes, List<string> loadcases, bool append = false);

        bool GetBarForces(List<string> bars, List<string> cases, int divisions, ResultOrder orderBy, out Dictionary<string, ResultSet<BarForce>> results);
        bool GetBarStresses();

        bool GetNodeReactions(List<string> nodes, List<string> cases, ResultOrder orderBy, out Dictionary<string, ResultSet<NodeReaction>> results);
        bool GetNodeDisplacements(List<string> nodes, List<string> cases, ResultOrder orderBy, out Dictionary<string, ResultSet<NodeDisplacement>> results);
        bool GetNodeVelocities(List<string> nodes, List<string> cases, ResultOrder orderBy, out Dictionary<string, ResultSet<NodeVelocity>> results);
        bool GetNodeAccelerations(List<string> nodes, List<string> cases, ResultOrder orderBy, out Dictionary<string, ResultSet<NodeAcceleration>> results);

        bool GetModalResults();

        bool GetPanelForces(List<string> panels, List<string> cases, ResultOrder orderBy, out Dictionary<string, ResultSet<PanelForce>> results);
        bool GetPanelStress(List<string> panels, List<string> cases, ResultOrder orderBy, out Dictionary<string, ResultSet<PanelStress>> results);
    }
}
