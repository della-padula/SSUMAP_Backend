using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SSUMAP.Models.Data;

namespace SSUMAP.Models.Response
{
    public class SpotResponseModel
    {
        public long Id { get; }
        public string FileName { get; }
        public string Name { get; set; }
        public int CategoryIndex { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }        

        public SpotResponseModel(Spot spot)
        {
            Id = spot.Id;
            FileName = spot.FileName;
            Name = spot.Name;
            CategoryIndex = spot.CategoryIndex;
            Latitude = spot.Latitude;
            Longitude = spot.Longitude;
            Address = spot.Address;
            Description = spot.Description;
            PhoneNumber = spot.PhoneNumber;
        }
    }
}