using ProjectAirBomber.Entity;

namespace ProjectAirBomber.Drawnings
{
    /// <summary>
    ///   Прорисовка и перемещение бомбардировщика
    /// </summary>
    public class DrawningAirBomber : DrawningAirplane
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="weight"></param>
        /// <param name="bodyColor"></param>
        /// <param name="additionalColor"></param>
        /// <param name="airRefueling"></param>
        /// <param name="extraFuelTank"></param>
        /// <param name="aircraftBomb"></param>
        public DrawningAirBomber(int speed, double weight, Color bodyColor, Color additionalColor, bool airRefueling, bool extraFuelTank, bool aircraftBomb) : base(105, 96)
        {
            EntityAirplane = new EntityAirBomber(speed, weight, bodyColor, additionalColor, airRefueling, extraFuelTank, aircraftBomb);

        }

        /// <summary>
        /// Прорисовка объекта
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            if (EntityAirplane is not EntityAirBomber airBomber || !_startPosX.HasValue || !_startPosY.HasValue)
            {
                return;
            }

            base.Draw(g);

            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(airBomber.AdditionalColor);

            //бомбы
            if (airBomber.AircraftBomb)
            {
                int y = _startPosY.Value;
                Point[] bombPoints;
                for (int i = 0; i < 2; i++)
                {
                    bombPoints = new Point[]{
                        new Point(_startPosX.Value + 60, y + 15),
                        new Point(_startPosX.Value + 80, y + 20),
                        new Point(_startPosX.Value + 60, y + 25),
                    };
                    g.DrawPolygon(pen, bombPoints);
                    g.FillPolygon(brush, bombPoints);
                    y += 56;
                }
            }

            //топливные баки
            if (airBomber.AircraftBomb)
            {
                int y = _startPosY.Value;

                for (int i = 0; i < 2; i++)
                {
                    g.DrawRectangle(pen, _startPosX.Value + 20, y + 30, 20, 10);
                    g.FillRectangle(brush, _startPosX.Value + 20, y + 30, 20, 10);
                    y += 26;
                }
            }

            //дозаправка в воздухе
            if (airBomber.AirRefueling)
            {
                g.DrawLine(pen, new Point(_startPosX.Value + 100, _startPosY.Value + 48),
                    new Point(_startPosX.Value + 105, _startPosY.Value + 48));
            }
        }
    }
}
