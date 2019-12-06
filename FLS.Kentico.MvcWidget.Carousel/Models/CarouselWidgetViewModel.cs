using System.Collections.Generic;

namespace FLS.Kentico.MvcWidget.Carousel
{
    /// <summary>
    /// View model for carousel widget.
    /// </summary>
    public class CarouselWidgetViewModel
    {
        /// <summary>
        /// Name of Images property
        /// </summary>
        public string ImagesPropertyName { get; set; }

        /// <summary>
        /// Urls of images
        /// </summary>
        public IList<string> Urls { get; set; }
        /// <summary>
        /// Show controls flag.
        /// </summary>
        public bool ShowControls { get; set; }
        /// <summary>
        /// Slide interval.
        /// </summary>
        public int SlideInterval { get; set; }
        /// <summary>
        /// Pause on hover flag.
        /// </summary>
        public bool PauseOnHower { get; set; }
    }
}
