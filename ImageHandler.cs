using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Fishy_Notes
{
    public class ImageHandler
    {
        private const String _imgNotFound = @"..\..\image-not-found.png";
        private Image _image;

        public ImageHandler() 
        {
        try
            {
                this._image = Bitmap.FromFile(Path.GetFullPath(_imgNotFound));
            }
            catch 
            {
            this._image = null;
            }
        }
        
        public Image LoadedImage { get => _image; }

        public ImageHandler(String imgPath)
        {
            try
            {
                this._image = Bitmap.FromFile(Path.GetFullPath(imgPath));
            }
            catch
            {
                throw new InvalidStringException("ImageHandler: Invalid path / filename");
            }
        }
    }
}
