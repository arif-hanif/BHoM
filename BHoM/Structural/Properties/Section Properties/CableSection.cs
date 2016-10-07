﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BHoM.Structural.Databases;


namespace BHoM.Structural.Properties
{
    public class CableSection : SectionProperty
    {

        private int m_numberOfCables;

        public CableSection()
        { }

        public CableSection(double diameter, double areaOfOneCable, int numberOfCables = 1) : this(diameter, areaOfOneCable, BHoM.Materials.Material.Default(Materials.MaterialType.Cable), numberOfCables)
        {   }

        public CableSection(double diameter, double areaOfOneCable, BHoM.Materials.Material mat, int numberOfCables = 1)
        {
            m_numberOfCables = numberOfCables;
            m_Area = areaOfOneCable;
            Material = mat;
            CreateEdgeCurves(diameter, numberOfCables);
            SectionData[(int)CableSectionData.D] = diameter;
            SectionData[(int)CableSectionData.A] = areaOfOneCable;
        }

        public override double GrossArea
        {
            get
            {
                if (m_Area == 0)
                    m_Area = SectionData[(int)CableSectionData.A];

                return m_Area * m_numberOfCables;
            }
        }

        public int NumberOfCables
        {
            get
            {
                return m_numberOfCables;
            }
            set
            {
                m_numberOfCables = value;
            }
        }

        private void CreateEdgeCurves(double diameter, int numberOfCables)
        {
            //TODO: Add something for creation of multiple cables
            Edges = CreateGeometry(ShapeType.Circle, diameter, diameter, 0, 0, 0, 0);
            
        }


        public override ShapeType Shape
        {
            get
            {
                return ShapeType.Cable;
            }

            set
            {
                base.Shape = ShapeType.Cable;
            }
        }

        protected override string GenerateStandardName()
        {
            return "Cable "+"Dia"+SectionData[(int)CableSectionData.D]+ "x" + m_numberOfCables;
        }

        /*************************************************************/
        /***** Property overrides Setting properties to 0 ************/
        /*************************************************************/

        public override double Asx
        {
            get
            {
                return 0;
            }
        }

        public override double Asy
        {
            get
            {
                return 0;
            }
        }

        public override double Ix
        {
            get
            {
                return 0;
            }
        }

        public override double Iy
        {
            get
            {
                return 0;
            }
        }

        public override double J
        {
            get
            {
                return 0;
            }
        }

        public override double Sx
        {
            get
            {
                return 0;
            }
        }
        public override double Sy
        {
            get
            {
                return 0;
            }
        }
        public override double Vpx
        {
            get
            {
                return 0;
            }
        }
        public override double Vpy
        {
            get
            {
                return 0;
            }
        }

        public override double Vx
        {
            get
            {
                return 0;
            }
        }

        public override double Vy
        {
            get
            {
                return 0;
            }
        }

        public override double Zx
        {
            get
            {
                return 0;
            }
        }

        public override double Zy
        {
            get
            {
                return 0;
            }
        }
    }
}