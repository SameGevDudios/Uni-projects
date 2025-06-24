using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace KR
{
    internal class ImageConverter
    {
        private static Image _loadedImage;
        public static void ConvertImage(Image sourceImage, int targetFormatIndex, long quality, out string filePath, out bool ok)
        {
            filePath = null;
            _loadedImage = sourceImage;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string extension = ".png";
            switch (targetFormatIndex)
            {
                case 0:
                    saveFileDialog.Filter = "PNG Image|*.png";
                    break;
                case 1:
                    saveFileDialog.Filter = "JPEG Image|*.jpg;*.jpeg";
                    extension = ".jpeg";
                    break;
                case 2:
                    saveFileDialog.Filter = "BMP Image|*.bmp";
                    extension = ".bmp";
                    break;
            }
            saveFileDialog.Title = "Save Converted Image";
            ok = saveFileDialog.ShowDialog() == DialogResult.OK;
            if (ok)
            {
                string outputPath = saveFileDialog.FileName;

                filePath = outputPath;
                // Convert the image based on the selected extension
                switch (extension)
                {
                    case ".png":
                        SaveAsPng(outputPath);
                        break;

                    case ".jpg":
                    case ".jpeg":
                        SaveAsJpeg(outputPath, quality);
                        break;

                    case ".bmp":
                        SaveAsBmp(outputPath);
                        break;

                    default:
                        MessageBox.Show("Unsupported file format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }
        private static void SaveAsPng(string outputPath)
        {
            _loadedImage.Save(outputPath, ImageFormat.Png);
        }

        // Save the image as JPEG with quality settings
        private static void SaveAsJpeg(string outputPath, long quality)
        {
            ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");
            if (jpegCodec != null)
            {
                EncoderParameter qualityParam = new EncoderParameter(Encoder.Quality, quality);
                EncoderParameters encoderParams = new EncoderParameters(1);
                encoderParams.Param[0] = qualityParam;
                _loadedImage.Save(outputPath, jpegCodec, encoderParams);
            }
            else
            {
                MessageBox.Show("JPEG codec not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Save the image as BMP
        private static void SaveAsBmp(string outputPath)
        {
            _loadedImage.Save(outputPath, ImageFormat.Bmp);
        }

        // Get the encoder info for the given mime type
        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.MimeType == mimeType)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}
