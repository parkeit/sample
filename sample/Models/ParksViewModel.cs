using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sample.Core;
using sample.Core.Data;

namespace sample.Models
{
    public class ParkViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public List<TagViewModel> Tags { get; set; }

        public ParkViewModel(Park park)
        {
            Id = park.Id;
            Name = park.Name;
            Image = park.ImageUrl;
            Description = park.Description;
            Tags = TagViewModel.GetTagViewModelList(park.Tags);
        }

        public static List<ParkViewModel> GetParkViewModelList(IEnumerable<Park> parks)
        {
            return parks.Select(x => new ParkViewModel(x)).ToList();
        }

    }

   
    
}