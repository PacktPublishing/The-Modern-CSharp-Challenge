using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace CompressImages
{
    public static class ImageExtensions
    {
        // Save an image in a file with format determined by its extension.
        public static void SaveImage(this Image image, string filename)
        {
            // Check the extension to see what kind of file this should be.
            string extension = Path.GetExtension(filename);
            switch (extension.ToLower())
            {
                case ".bmp":
                    image.Save(filename, ImageFormat.Bmp);
                    break;
                case ".exif":
                    image.Save(filename, ImageFormat.Exif);
                    break;
                case ".gif":
                    image.Save(filename, ImageFormat.Gif);
                    break;
                case ".jpg":
                case ".jpeg":
                    image.Save(filename, ImageFormat.Jpeg);
                    break;
                case ".png":
                    image.Save(filename, ImageFormat.Png);
                    break;
                case ".tif":
                case ".tiff":
                    image.Save(filename, ImageFormat.Tiff);
                    break;
                default:
                    throw new NotSupportedException(
                        "Unsupported file extension " + extension);
            }
        }

        // Find this mime type's ImageCodecInfo object.
        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            foreach (ImageCodecInfo encoder in ImageCodecInfo.GetImageEncoders())
                if (encoder.MimeType == mimeType) return encoder;
            return null;
        }

        // Save a JPG file with the indicated compression level.
        public static void SaveCompressed(this Image image, string filename, int compressionLevel)
        {
            // Make an object to hold one encoder parameter.
            EncoderParameters parameters = new EncoderParameters(1);

            // Place the compression level in that parameter.
            parameters.Param[0] = new EncoderParameter(
                System.Drawing.Imaging.Encoder.Quality, compressionLevel);

            // Get the JPG codec.
            ImageCodecInfo codecInfo = GetEncoderInfo("image/jpeg");

            // Create the file, deleting it if it already exists.
            if (File.Exists(filename)) File.Delete(filename);
            image.Save(filename, codecInfo, parameters);
        }
    }
}
