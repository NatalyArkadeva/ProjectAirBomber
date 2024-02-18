using ProjectAirBomber.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAirBomber.Drawnings
{
    /// <summary>
    /// Реализация сравнения двух объектов класса-прорисовки
    /// </summary>
    internal class DrawningAirplaneEqutables : IEqualityComparer<DrawningAirplane?>
    {
        public bool Equals(DrawningAirplane? x, DrawningAirplane? y)
        {
            if (x == null || x.EntityAirplane == null)
            {
                return false;
            }
            if (y == null || y.EntityAirplane == null)
            {
                return false;
            }
            if (x.GetType().Name != y.GetType().Name)
            {
                return false;
            }
            if (x.EntityAirplane.Speed != y.EntityAirplane.Speed)
            {
                return false;
            }
            if (x.EntityAirplane.Weight != y.EntityAirplane.Weight)
            {
                return false;
            }
            if (x.EntityAirplane.BodyColor != y.EntityAirplane.BodyColor)
            {
                return false;
            }
            if (x is DrawningAirBomber && y is DrawningAirBomber)
            {
                EntityAirBomber entityAirBomberX = (EntityAirBomber)x.EntityAirplane;
                EntityAirBomber entityAirBomberY = (EntityAirBomber)y.EntityAirplane;
                if (entityAirBomberX.AdditionalColor != entityAirBomberY.AdditionalColor)
                {
                    return false;
                }
                if (entityAirBomberX.AircraftBomb != entityAirBomberY.AircraftBomb)
                {
                    return false;
                }
                if (entityAirBomberX.AirRefueling != entityAirBomberY.AirRefueling)
                {
                    return false;
                }
                if (entityAirBomberX.ExtraFuelTank != entityAirBomberY.ExtraFuelTank)
                {
                    return false;
                }
            }
            return true;
        }

        public int GetHashCode([DisallowNull] DrawningAirplane? obj)
        {
            return obj.GetHashCode();
        }
    }
}
