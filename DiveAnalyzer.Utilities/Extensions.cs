﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DiveAnalyzer.Utilities
{
    //public static class Extensions
    //{
    //    public static object ToType<T>(this object obj, T type)
    //    {

    //        //create instance of T type object:
    //        var tmp = Activator.CreateInstance(Type.GetType(type.ToString()));

    //        //loop through the properties of the object you want to covert:          
    //        foreach (PropertyInfo pi in obj.GetType().GetProperties())
    //        {
    //            try
    //            {

    //                //get the value of property and try 
    //                //to assign it to the property of T type object:
    //                tmp.GetType().GetProperty(pi.Name).SetValue(tmp, pi.GetValue(obj, null), null);
    //            }
    //            catch { }
    //        }

    //        //return the T type object:         
    //        return tmp;
    //    }
    //    public static object ToType<T>(this object obj, T type)
    //    {

    //        //create instance of T type object:
    //        var tmp = Activator.CreateInstance(Type.GetType(type.ToString()));

    //        //loop through the properties of the object you want to covert:          
    //        foreach (PropertyInfo pi in obj.GetType().GetProperties())
    //        {
    //            try
    //            {

    //                //get the value of property and try 
    //                //to assign it to the property of T type object:
    //                tmp.GetType().GetProperty(pi.Name).SetValue(tmp, pi.GetValue(obj, null), null);
    //            }
    //            catch { }
    //        }

    //        //return the T type object:         
    //        return tmp;
    //    }
    //}
}
