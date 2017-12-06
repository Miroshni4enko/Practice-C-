using System;

/// <summary>
/// Summary description for Parallelepiped
/// </summary>
namespace pr9_interface
{
    public class Cone:ISqure
    {
        public double calcSqure(Int32[] array)
        {
            return array[0] * array[1] * Math.PI;
        }
    }
}
