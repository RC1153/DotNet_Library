using System;
using System.Linq;

namespace ExtensionMethod
{
    public static class ExtensionMethod
    {
        /// <summary>
        /// replace below code by using this extension method
        /// if(reallyLongIntegerVariableName == 1 || reallyLongIntegerVariableName == 6 || 
        /// reallyLongIntegerVariableName == 9 || reallyLongIntegerVariableName == 11){
        /// do something....}
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool In<T>(this T source, params T[] list)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            return list.Contains(source);
        }

        
    }
}
