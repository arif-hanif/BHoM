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

using System.Collections.Generic;
using BH.oM.Physical.Materials;
using BH.oM.Base;
using BH.oM.Quantities.Attributes;
using System.ComponentModel;
using System.Dynamic;

namespace BH.oM.LifeCycleAssessment.MaterialFragments
{
    public interface IEnvironmentalProductDeclarationData : IFragment, IMaterialProperties
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/
        [Density]
        [Description("The material density in kg/m^3.")]
        double Density { get; set; }

        [Description("Note that any EPD that does not contain this parameter will not be evaluated." +
            "This metric is based on the declared unit of the reference EPD, i.e. a declared unit of kg refers to QuantityType of mass, a declared unit of m3 refers to a QuantityType of volume, etc. " +
            "All data should be normalized to metric declared units before integration in the BHoM. " +
            "The quantity type is a key metric for evaluation methods to function. " +
            "This property determines how the material is to be evaluated, based on Mass, Volume, Area, Item, or Length. ")]
        QuantityType QuantityType { get; set; }

        [Description("The number of units in reference to quantity type. Example, 1000 kg per unit quantityType of Mass.")]
        double QuantityTypeValue { get; set; }

        /***************************************************/
    }
}
