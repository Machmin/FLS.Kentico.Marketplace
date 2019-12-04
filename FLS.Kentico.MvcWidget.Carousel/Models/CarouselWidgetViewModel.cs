using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLS.Kentico.MvcWidget.Carousel
{
    public class Carousel2WidgetViewModel
    {
        public IList<string> Links { get; set; }
        public bool ShowControls { get; set; }
        public int SlideInterval { get; set; }
        public bool PauseOnHower { get; set; }
    }
}
