using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAirBomber.Drawnings
{
    /// <summary>
    /// Сравнение по типу, скорости, весу
    /// </summary>
    public class DrawningAirplaneCompareByType : IComparer<DrawningAirplane?>
    {
        public int Compare(DrawningAirplane? x, DrawningAirplane? y)
        {
            if (x == null || x.EntityAirplane == null)
            {
                return -1;
            }
            if (y == null || y.EntityAirplane == null)
            {
                return 1;
            }
            if (x.GetType().Name != y.GetType().Name)
            {
                return x.GetType().Name.CompareTo(y.GetType().Name);
            }
            var speedCompare = x.EntityAirplane.Speed.CompareTo(y.EntityAirplane.Speed);
            if (speedCompare != 0)
            {
                return speedCompare;
            }
            return x.EntityAirplane.Weight.CompareTo(y.EntityAirplane.Weight);
        }
    }
}
