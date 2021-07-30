using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    /// <summary>
    /// Possible EXIF orientation values describing clockwise
    /// rotation of the captured image due to camera orientation.
    /// </summary>
    /// <remarks>Reverse/undo these transformations to display an image correctly</remarks>
    public enum ImageOrientation
    {
        /// <summary>
        /// Image is correctly oriented
        /// </summary>
        Original = 1,
        /// <summary>
        /// Image has been mirrored horizontally
        /// </summary>
        MirrorOriginal = 2,
        /// <summary>
        /// Image has been rotated 180 degrees
        /// </summary>
        Half = 3,
        /// <summary>
        /// Image has been mirrored horizontally and rotated 180 degrees
        /// </summary>
        MirrorHalf = 4,
        /// <summary>
        /// Image has been mirrored horizontally and rotated 270 degrees clockwise
        /// </summary>
        MirrorThreeQuarter = 5,
        /// <summary>
        /// Image has been rotated 270 degrees clockwise
        /// </summary>
        ThreeQuarter = 6,
        /// <summary>
        /// Image has been mirrored horizontally and rotated 90 degrees clockwise.
        /// </summary>
        MirrorOneQuarter = 7,
        /// <summary>
        /// Image has been rotated 90 degrees clockwise.
        /// </summary>
        OneQuarter = 8
    }

    public static class Image_Orientation
    {
        public static ImageOrientation GetOrientation(this Image image)
        {
            PropertyItem pi = SafeGetPropertyItem(image, 0x112);

            if (pi == null || pi.Type != 3)
            {
                return ImageOrientation.Original;
            }

            return (ImageOrientation)BitConverter.ToInt16(pi.Value, 0);
        }

        // A file without the desired EXIF property record will throw ArgumentException.
        public static PropertyItem SafeGetPropertyItem(Image image, int propid)
        {
            try
            {
                return image.GetPropertyItem(propid);
            }
            catch (ArgumentException)
            {
                return null;
            }
        }
    }
}
