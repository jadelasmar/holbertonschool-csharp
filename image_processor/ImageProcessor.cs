using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// new class ImageProcessor
/// </summary>
class ImageProcessor
{
    /// <summary>
    /// method to invert colors
    /// </summary>
    /// <param name="filenames"></param>
    public static void Inverse(string[] filenames) {

        // Iterate through all .jpg files in images directory
        Parallel.ForEach(filenames, (imagePath) =>
        {
            {
                // For each image file create a new Bitmap object
                Bitmap image = new Bitmap(imagePath);

                // Lock the bitmaps bits
                BitmapData bmpData = image.LockBits(
                    new Rectangle(0, 0, image.Width, image.Height),
                    ImageLockMode.ReadWrite, image.PixelFormat);

                // Determine size of image in bytes
                int bytes = bmpData.Stride * bmpData.Height;

                // Allocate buffer size of image bytes
                byte[] rgbBuffer = new byte[bytes];

                // Safely copy bitmap data to buffer
                System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, rgbBuffer, 0, bytes);

                // Iterate through RGB buffer, inverting each color value
                for (var i = 0; i < bytes; i++)
                    rgbBuffer[i] = (byte)(255 - rgbBuffer[i]);

                // Copy values back from buffer
                System.Runtime.InteropServices.Marshal.Copy(rgbBuffer, 0, bmpData.Scan0, bytes);

                // Unlock bits
                image.UnlockBits(bmpData);

                // Extract filename from path and edit for new save
                string[] nameSplit = imagePath.Split(new Char[] {'/', '.'});
                String newFilename = nameSplit[nameSplit.Length - 2] + "_inverse." +
                                        nameSplit[nameSplit.Length - 1];

                // Save inverted image to new file
                image.Save(newFilename);
            }
        });
    }

    /// <summary>
    /// method to convert to grayscale
    /// </summary>
    /// <param name="filenames"></param>
    public static void Grayscale(string[] filenames)
    {
        Parallel.ForEach(filenames, (myFile) =>
        {
            var ext = Path.GetExtension(myFile);
            var fName = Path.GetFileNameWithoutExtension(myFile);
            fName += "_grayscale" + ext;

            Bitmap bmp = new Bitmap(myFile);

            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData =
                bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                bmp.PixelFormat);

            IntPtr ptr = bmpData.Scan0;

            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int i = 0; i < rgbValues.Length - 3; i += 3)
            {
                byte gray = (byte)((rgbValues[i] * 0.21 + rgbValues[i + 1] * 0.71 + rgbValues[i + 2] * 0.071));
                rgbValues[i] = rgbValues[i + 1] = rgbValues[i + 2] = gray;
            }

            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            bmp.UnlockBits(bmpData);

            bmp.Save($"{fName}");
        });
    }
    /// <summary>
    /// method to convert to black and white
    /// </summary>
    /// <param name="filenames"></param>

    public static void BlackWhite(string[] filenames, double threshold)
    {
        Parallel.ForEach(filenames, (myFile) =>
        {
            var ext = Path.GetExtension(myFile);
            var fName = Path.GetFileNameWithoutExtension(myFile);
            fName += "_bw" + ext;

            Bitmap bmp = new Bitmap(myFile);

            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData =
                bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                bmp.PixelFormat);

            IntPtr ptr = bmpData.Scan0;

            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int i = 0; i < rgbValues.Length - 3; i += 3)
            {
                byte gray = (byte)((rgbValues[i] * 0.21 + rgbValues[i + 1] * 0.71 + rgbValues[i + 2] * 0.071));

                if (gray >= threshold)
                    rgbValues[i] = rgbValues[i + 1] = rgbValues[i + 2] = 255;
                else rgbValues[i] = rgbValues[i + 1] = rgbValues[i + 2] = 0;
            }

            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            bmp.UnlockBits(bmpData);

            bmp.Save($"{fName}");
        });
    }

    public static void Thumbnail(string[] filenames, int height)
    {
        Parallel.ForEach(filenames, myFile =>
        {
            var ext = Path.GetExtension(myFile);
            var fName = Path.GetFileNameWithoutExtension(myFile);
            fName += "_bw" + ext;

            Bitmap bmp = new Bitmap(myFile);
            int width = height * bmp.Width / bmp.Height;
            Image img = bmp.GetThumbnailImage(width, height, null, IntPtr.Zero);
            bmp.Save($"{fName}");

        });
    }
}