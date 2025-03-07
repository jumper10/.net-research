﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace UwpApp
{
    public class ResourceUtil
    {
        public static object GetResource(string key)
        {
            if (Application.Current.Resources.ContainsKey(key))
                return Application.Current.Resources[key];
            else
                return null;
        }

        public static T GetResource<T>(string key)
        {
            var resourceValue = GetResource(key);
            return resourceValue == null ? default(T) : (T)resourceValue;
        }
    }
}
