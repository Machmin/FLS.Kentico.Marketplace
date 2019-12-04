using CMS.MediaLibrary;
using FLS.Kentico.MvcWidget.Carousel;
using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

[assembly: RegisterWidget("FLS.Kentico.MvcWidget.Carousel2", typeof(Carousel2WidgetController), "Carousel2", IconClass = "icon-carousel")]
namespace FLS.Kentico.MvcWidget.Carousel
{
    public class Carousel2WidgetController : WidgetController<Carousel2WidgetProperties>
    {
        public ActionResult Index()
        {
            Carousel2WidgetProperties properties = GetProperties();

            var links = new List<string>();
            if (properties.Images != null)
            {
                foreach (var image in properties.Images)
                {
                    links.Add(GetImageUrlFromMediaLibrary(image.FileGuid));
                }
            }

            var model = new Carousel2WidgetViewModel()
            {
                Links = links,
                ShowControls = properties.ShowControls,
                SlideInterval = properties.SlideIntervalSeconds * 1000,
                PauseOnHower = properties.PauseOnHower,
            };
            return PartialView("Widgets/_Carousel2Widget", model);
        }

        string GetImageUrlFromMediaLibrary(Guid imageGuid)
        {
            //get filenale
            string fileName = null;
            var libs = MediaLibraryInfoProvider.GetMediaLibraries().ToList();
            foreach (var lib in libs)
            {
                var folder = lib.Children.FirstOrDefault();

                foreach (var image in folder)
                {
                    if (!string.IsNullOrEmpty(image.GetProperty("Guid").ToString()))
                    {
                        if (image.GetProperty("Guid").ToString() == imageGuid.ToString())
                        {
                            fileName = image.GetProperty("FileName").ToString();
                        }
                    }
                }
            }

            //get url
            string url = MediaFileURLProvider.GetMediaFileUrl(imageGuid, fileName);

            return url;
        }
    }
}
