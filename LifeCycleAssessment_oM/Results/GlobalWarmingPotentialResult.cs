/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2020, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using BH.oM.Analytical.Results;
using BH.oM.LifeCycleAssessment.MaterialFragments;
using BH.oM.Geometry;
using System.ComponentModel;
using BH.oM.Base;
using System;

namespace BH.oM.LifeCycleAssessment.Results
{
    [Description("Gives the total GlobalWarmingPotential of an object based on its EnvironmentalProductDeclaration.")]
    public class GlobalWarmingPotentialResult : LifeCycleAssessmentElementResult, IImmutable
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Description("The total embodied carbon of the object in kgCO2e.")]
        public virtual double GlobalWarmingPotential{ get; }


        /***************************************************/
        /**** Constructors                              ****/
        /***************************************************/

        public GlobalWarmingPotentialResult(   IComparable objectId,
                                IComparable resultCase,
                                double timeStep,
                                ObjectScope scope,
                                ObjectCategory category,
                                IEnvironmentalProductDeclarationData environmentalProductDeclaration,
                                double globalWarmingPotential): base(objectId, resultCase, timeStep, scope, category, environmentalProductDeclaration)
        {
            GlobalWarmingPotential = globalWarmingPotential;
        }

        /***************************************************/

    }
}

