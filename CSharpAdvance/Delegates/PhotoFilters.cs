using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo) 
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyContast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }

        public void ApplyResize(Photo photo)
        {
            Console.WriteLine("Apply resize");
        }
    }
}
