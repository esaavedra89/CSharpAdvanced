using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Delegates
{
    public class PhotoProcessor
    {
        // PhotoFilterHandler nombre del delegado.
        // Con esto podemos llamar a una funcion o a un grupo.
        // The client of this delegate, it is the need to handler methods to call.
        public delegate void PhotoFilterHandler(Photo photo);

        // We can create a delegate like this or use a Action or Func delegate. 
        //public void Process(string path, PhotoFilterHandler filterHandler) 
        public void Process(string path, Action<Photo> filterHandler) 
        {
            //System.Action<> This delegate can receive until 16 parameters and returns void.
            //System.Func<> This delegate can receive until 16 parameters and returns a value.

            var photo = Photo.Load(path);

            var filters = new PhotoFilters();

            //filters.ApplyBrightness(photo);
            //filters.ApplyContast(photo);
            //filters.ApplyResize(photo);

            // We apply the delegate.
            filterHandler(photo);

            photo.Save();
        }
    }
}
