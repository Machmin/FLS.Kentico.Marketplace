using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Forms.Web.Mvc;
using Kentico.Components.Web.Mvc.FormComponents;

namespace FLS.Kentico.MvcWidget.Carousel
{
    public class Carousel2WidgetProperties : IWidgetProperties
    {
        // Assigns a selector component to the 'Images' property
        [EditingComponent(MediaFilesSelector.IDENTIFIER, Order = 0, Label = "Images")]
        // Configures the media library from which you can select files in the selector
        //[EditingComponentProperty(nameof(MediaFilesSelectorProperties.LibraryName), "Graphics")]
        // Limits the maximum number of files that can be selected at once
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 10)]
        // Configures the allowed file extensions for the selected files
        //[EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".gif;.png;.jpg;.jpeg")]
        // Returns a list of media files selector items (objects that contain the GUIDs of selected media files)
        public IList<MediaFilesSelectorItem> Images { get; set; }

        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 1, Label = "Show carousel controls")]
        public bool ShowControls { get; set; } = true;
        [EditingComponent(IntInputComponent.IDENTIFIER, Order = 2, Label = "Interval between slides")]
        public int SlideIntervalSeconds { get; set; } = 5;
        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 3, Label = "Pause on hower")]
        public bool PauseOnHower { get; set; } = true;
    }
}
