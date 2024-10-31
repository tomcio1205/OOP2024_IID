using OOP.Constructions.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Constructions
{
    internal class Construction
    {
        public Construction()
        {
            Height = 23;
            Width = 43;
            Entrances = 3;
            HumanCapacity = 2;
            BuildMaterial = "Material";
        }

        public Construction(CreateConstructionDTO construction)
        {
            Height = construction.Height;
            Width = construction.Width;
            Entrances = construction.Entrances;
            HumanCapacity = 2;
            BuildMaterial = construction.BuildMaterial;
        }

        public Construction(float height, float width, int entrances, int humanCapacity, string buildMaterial)
        {
            Height = height; 
            Width = width; 
            Entrances = entrances; 
            HumanCapacity = humanCapacity; 
            BuildMaterial = buildMaterial; 
        }

        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        private string _buildMaterial { get; set; }


        public string BuildMaterial { 
            get 
            { 
                return _buildMaterial;
            } 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Value can not be null");
                }
                _buildMaterial = value;
            } 
        }

    }
}