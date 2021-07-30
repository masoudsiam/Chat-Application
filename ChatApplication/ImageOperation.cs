using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public static class ImageOperation
    {
        public static string SaveImage_ReturnPath(Image image, string folderName)
        {
            string FilePath = Path.GetFullPath(Path.Combine(Address.Pictures(), folderName));
            if (!Directory.Exists(FilePath))
                Directory.CreateDirectory(FilePath);
            int fileCount = Directory.GetFiles(FilePath, "*.*", SearchOption.AllDirectories).Length;
            FilePath = Path.GetFullPath(Path.Combine(FilePath, fileCount.ToString() + @".png"));
            image.Save(FilePath);
            return FilePath;
        }

        public static void SetPictureBoxImage(PictureBox pictureBox)
        {
            OpenFileDialog openImageDialog = new OpenFileDialog();
            openImageDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openImageDialog.FileName);
                ImageOrientation imageOrientation = Image_Orientation.GetOrientation(image);
                RotateFlipType rotateFlipType = RotateFlipType.RotateNoneFlipNone;
                switch (imageOrientation)
                {
                    case ImageOrientation.Original: rotateFlipType = RotateFlipType.RotateNoneFlipNone; break;
                    case ImageOrientation.MirrorOriginal: rotateFlipType = RotateFlipType.RotateNoneFlipX; break;
                    case ImageOrientation.Half: rotateFlipType = RotateFlipType.Rotate180FlipNone; break;
                    case ImageOrientation.MirrorHalf: rotateFlipType = RotateFlipType.Rotate180FlipX; break;
                    case ImageOrientation.MirrorThreeQuarter: rotateFlipType = RotateFlipType.Rotate90FlipX; break;
                    case ImageOrientation.ThreeQuarter: rotateFlipType = RotateFlipType.Rotate90FlipNone; break;
                    case ImageOrientation.MirrorOneQuarter: rotateFlipType = RotateFlipType.Rotate270FlipX; break;
                    case ImageOrientation.OneQuarter: rotateFlipType = RotateFlipType.Rotate270FlipNone; break;
                    default: rotateFlipType = RotateFlipType.RotateNoneFlipNone; break;
                }
                image.RotateFlip(rotateFlipType);
                pictureBox.Image = image;
            }
        }
    }
}
