using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAirBomber.Drawnings
{
    /// <summary>
    /// Сравнение по цвету, скорости, весу
    /// </summary>
    public class DrawningAirplaneCompareByColor : IComparer<DrawningAirplane?>
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
            if (x.EntityAirplane.BodyColor == y.EntityAirplane.BodyColor)
            {
                return x.EntityAirplane.BodyColor.CompareTo(y.EntityAirplane.BodyColor);
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
