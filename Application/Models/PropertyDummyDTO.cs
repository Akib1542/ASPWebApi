﻿namespace Application.Models
{
    public class PropertyDummyDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string ErfSize { get; set; }
        public string FloorSize { get; set; }
        public decimal price { get; set; }
        public decimal Levies { get; set; }
        public decimal Rates { get; set; }
        public string Address { get; set; }
        public bool PetsAllowed { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int Kitchens { get; set; }
        public int Lounge { get; set; }
        public int Dining { get; set; }
        public DateTime ListDate { get; set; }
    }
}
