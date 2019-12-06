using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Forms.Web.Mvc;
using Kentico.Components.Web.Mvc.FormComponents;

namespace FLS.Kentico.MvcWidget.Carousel
{
    /// <summary>
    /// Properties for carousel widget.
    /// </summary>
    public class CarouselWidgetProperties : IWidgetProperties
    {
        /// <summary>
        /// Selected images property.
        /// </summary>
        //[EditingComponentProperty(nameof(MediaFilesSelectorProperties.LibraryName), "Graphics")] // Configures the media library from which you can select files in the selector
        //[EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".gif;.png;.jpg;.jpeg")] // Configures the allowed file extensions for the selected files
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 0)] // Limits the maximum number of files that can be selected at once
        [EditingComponent(MediaFilesSelector.IDENTIFIER, Order = 0, Label = "Images")] // Returns a list of media files selector items (objects that contain the GUIDs of selected media files)        
        public IList<MediaFilesSelectorItem> Images { get; set; }

        /// <summary>
        /// Show control property.
        /// </summary>
        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 1, Label = "Show carousel controls")]
        public bool ShowControls { get; set; } = true;
        /// <summary>
        /// Interval between slides property.
        /// </summary>
        [EditingComponent(IntInputComponent.IDENTIFIER, Order = 2, Label = "Interval between slides")]
        public int SlideIntervalSeconds { get; set; } = 5;
        /// <summary>
        /// Pause on hover property.
        /// </summary>
        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 3, Label = "Pause on hower")]
        public bool PauseOnHower { get; set; } = true;
    }
}
