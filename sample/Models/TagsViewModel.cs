using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sample.Core.Data;

namespace sample.Models
{
    public class TagViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public TagViewModel(Tag tag)
        {
            Id = tag.Id;
            Name = tag.Name;
        }
        public static List<TagViewModel> GetTagViewModelList(IEnumerable<Tag> tags)
        {
            return tags.Select(x => new TagViewModel(x)).ToList();
        }
    }

   
}