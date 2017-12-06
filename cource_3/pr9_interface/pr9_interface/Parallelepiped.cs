using System;

/// <summary>
/// Summary description for Parallelepiped
/// </summary>
namespace pr9_interface
{
    public class Parallelepiped:ISqure
    {
        public double calcSqure(int[] array)
        {
            return array[0] * array[1] * array[2];
        }
    }
}
