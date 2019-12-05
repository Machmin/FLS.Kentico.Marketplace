using System.Collections.Generic;

namespace FLS.Kentico.MvcWidget.Carousel
{
    public class CarouselWidgetViewModel
    {
        public IList<string> Links { get; set; }
        public bool ShowControls { get; set; }
        public int SlideInterval { get; set; }
        public bool PauseOnHower { get; set; }
    }
}
