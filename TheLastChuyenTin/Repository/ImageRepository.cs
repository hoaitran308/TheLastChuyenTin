using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheLastChuyenTin.Repository
{
    public class ImageRepository
    {
        private List<string> _images;

        public ImageRepository()
        {
            _images = new();
        }

        public void Add(string image)
        {
            _images.Add(image);
        }

        public string GetImageAt(int id)
        {
            string image = _images[id];
            _images.RemoveAt(id);
            return image;
        }

        public int Total()
        {
            return _images.Count;
        }
    }
}
