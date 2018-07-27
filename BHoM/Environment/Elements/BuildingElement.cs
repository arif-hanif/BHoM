﻿using BH.oM.Base;
using BH.oM.Environment.Interface;
using BH.oM.Environment.Properties;
using BH.oM.Architecture.Elements;
using System.Collections.Generic;
using System;

namespace BH.oM.Environment.Elements
{
    public class BuildingElement : BHoMObject, IBuildingObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public Level Level { get; set; } = new Level();
        public BuildingElementProperties BuildingElementProperties { get; set; } = new BuildingElementProperties();
        public IBuildingElementGeometry BuildingElementGeometry { get; set; } = new BuildingElementPanel();
        public List<Guid> AdjacentSpaces { get; set; } = new List<Guid>();

        /***************************************************/
    }
}