using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    //public static class Human<T> List<T>(item)
    public static class GenericExtension
    {
        public static T FindAndReturnIfEqual <T>(this List<T> list, T item)
        
        {
            if(list.Contains(item))
            {
                return item;
            }

            return default;
        }
    }
}
