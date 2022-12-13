using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Delegates
    {
        public Delegates()
        {
            ProcessFilters processFilters = new ProcessFilters();
            processFilters.run();
        }
    }

    class Photo
    {
        public void Load (string path)
        {
            Console.WriteLine($"photo is loaded from the path {path}");
        }

        public void Save()
        {
            Console.WriteLine("Photo is saved");
        }
    }

    class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo picture);
        public void processFilter (string path, PhotoFilterHandler filterHandler)
        {
            Photo photo = new Photo();
            photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }

        public void processDotNetFilter (string path, Action<Photo> PhotoFilterUsingDotNet)
        {
            Photo photo = new Photo();
            photo.Load(path);

            PhotoFilterUsingDotNet(photo);

            photo.Save();
        }

    }

    class ProcessFilters
    {       
        
        public void run ()
        {
            string myPhotoPath = "\\";

            PhotoProcessor photoFilter = new PhotoProcessor();

            PhotoProcessor.PhotoFilterHandler filterHandler = ApplyBrightness; // extention made possible
            filterHandler += ApplyRedFilter;
            filterHandler += CustomFilter;

            photoFilter.processFilter(myPhotoPath, filterHandler);
        }

        public void ApplyBrightness (Photo picture)
        {
            Console.WriteLine("Applied brightness filter");
        }

        public void ApplyRedFilter (Photo photo)
        {
            Console.WriteLine("Applied red filter");
        }

        public void CustomFilter (Photo photo)
        {
            Console.WriteLine("Applied custom filter");
        }
    }
}
