using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSProject.Models
{
    public interface IHomeModel
    {
        [SitecoreId]
        Guid Id { get; set; }

        [SitecoreField("Title")]
        string Title { get; set; }

        [SitecoreField("Image")]
        Image Image { get; set; }
    }
}