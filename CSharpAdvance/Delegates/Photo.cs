﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Delegates
{
    public class Photo
    {
        public static Photo Load(string path) 
        {
            return new Photo();
        }
        public void Save()
        {

        }
    }
}
