using CMS.MediaLibrary;
using FLS.Kentico.MvcWidget.Carousel;
using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

[assembly: RegisterWidget("FLS.Kentico.MvcWidget.Carousel", typeof(CarouselWidgetController), "Carousel", IconClass = "icon-carousel")]
namespace FLS.Kentico.MvcWidget.Carousel
{
    /// <summary>
    /// Controller for carousel widget.
    /// </summary>
    public class CarouselWidgetController : WidgetController<CarouselWidgetProperties>
    {
        public ActionResult Index()
        {
            CarouselWidgetProperties properties = GetProperties();

            var links = new List<string>();
            if (properties.Images != null)
            {
                foreach (var image in properties.Images)
                {
                    links.Add(GetImageUrlFromMediaLibrary(image.FileGuid));
                }
            }

            var model = new CarouselWidgetViewModel()
            {
                ImagesPropertyName = nameof(properties.Images),

                Urls = links,
                ShowControls = properties.ShowControls,
                SlideInterval = properties.SlideIntervalSeconds * 1000,
                PauseOnHower = properties.PauseOnHower,
            };
            return PartialView("Widgets/_CarouselWidget", model);
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
