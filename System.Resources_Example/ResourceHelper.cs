using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;

namespace System.Resources_Example
{
    public class ResourceHelper
    {
        public static string getResource(string key)
        {
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager(typeof(System.Resources_Example.Main));
            return rm.GetString(key);
        }
    }
}
