using AribilgiWebProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AribilgiWebProject.RESTFUL.ViewModels
{
    public class CategoryViewModel : BaseViewModel<Category>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Icon { get; set; }

        public int? ParentId { get; set; }

        public long? Tags { get; set; }

        public string CreTime => CreDate.ToString("HH:mm:ss");

        public CategoryViewModel(Category category) : base(category)
        {
            Name = category.Name;
            Description = category.Description;
            Icon = category.Icon;
            ParentId = category.ParentId;
            Tags = category.Tags;
        }
    }
}