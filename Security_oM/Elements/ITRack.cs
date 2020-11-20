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

using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Base;
using BH.oM.Security.Enums;
using BH.oM.Geometry;
using BH.oM.Dimensional;
using BH.oM.Quantities.Attributes;

namespace BH.oM.ICT.Elements
{
    [Description("An IT Rack object is a cabinet that hosts network infrastructure equipment (such as patch panels).")]
    public class ITRack : BHoMObject, IElement0D, IElementM
    {
        /***************************************************/
        /****                Properties                 ****/
        /***************************************************/

        [Description("The center point that the IT Rack is located at")]
        public virtual Point Position { get; set; } = new Point();

        [Description("The maximum number of standard units that the IT Rack is capable of containing.")]
        public virtual int UCapacity { get; set; } = 42;

        [Length]
        [Description("The total physical length of the IT Rack, also understood as its depth.")]
        public virtual double Length { get; set; } = 0;

        [Length]
        [Description("The total physical width of the IT Rack, also understood as its front size.")]
        public virtual double Width { get; set; } = 0;

        [Description("The IT Rack mounting type that describes how it's installed.")]
        public virtual MountingType Mounting { get; set; } = MountingType.Undefined;

        //changes

        /***************************************************/
    }
}
