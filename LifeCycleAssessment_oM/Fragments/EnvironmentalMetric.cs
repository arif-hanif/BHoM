/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2021, the respective contributors. All rights reserved.
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

using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.LifeCycleAssessment.Fragments
{
    public class EnvironmentalMetric : BHoMObject, IFragment
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/
        [Description("This enum provides several evaluation fields that are commonly assessed within standard Environmental Product Declarations. You may provide single or multiple EPD Field selections for evaluation within the EvaluateEnvironmentalProductDeclaration compute method.")]
        public virtual EnvironmentalProductDeclarationField Field { get; set; } = EnvironmentalProductDeclarationField.GlobalWarmingPotential;

        [Description("The quantity of the specified field as a constanct used in the material's evaluation.")]
        public virtual double Quantity { get; set; } = double.NaN;

        [Description("Phase abbreviation for the scope of the EPD. For single phase entries, please input the relevant phase of evaluation i.e. A1 or A1-A3. More information on typical LCA phases can be found in the repository wiki.")]
        public virtual List<LifeCycleAssessmentPhases> Phase { get; set; } = new List<LifeCycleAssessmentPhases>();

        /***************************************************/
    }
}

