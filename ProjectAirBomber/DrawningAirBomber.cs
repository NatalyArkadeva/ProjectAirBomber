namespace ProjectAirBomber
{
    /// <summary>
    ///   Прорисовка и перемещение бомбардировщика
    /// </summary>
    public class DrawningAirBomber
    {
        /// <summary>
        /// Класс - сущность
        /// </summary>
        public EntityAirBomber? EntityAirBomber { get; private set; }
        /// <summary>
        /// Ширина окна
        /// </summary>
        private int? _pictureWidth;
        /// <summary>
        /// Высота окна
        /// </summary>
        private int? _pictureHeight;
        /// <summary>
        /// Левая коотдината прорисовки бомбардировщика
        /// </summary>
        private int? _startPosX;
        /// <summary>
        /// Верхняя координата прорисовки бомбардировщика
        /// </summary>
        private int? _startPosY;
        /// <summary>
        /// Ширина прорисовки бомбардировщика
        /// </summary>
        private readonly int _drawningAirWidth = 105;
        /// <summary>
        /// Высота прорисовки бомбардировщика
        /// </summary>
        private readonly int _drawingAirHeight = 96;

        /// <summary>
        /// Инициализация полей
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="weight"></param>
        /// <param name="bodyColor"></param>
        /// <param name="additionalColor"></param>
        /// <param name="airRefueling"></param>
        /// <param name="extraFuelTank"></param>
        /// <param name="aircraftBomb"></param>
        public void Init(int speed, double weight, Color bodyColor, Color additionalColor, bool airRefueling, bool extraFuelTank, bool aircraftBomb)
        {
            EntityAirBomber = new EntityAirBomber();
            EntityAirBomber.Init(speed, weight, bodyColor, additionalColor, airRefueling, extraFuelTank, aircraftBomb);
            _pictureWidth = null;
            _pictureHeight = null;
            _startPosX = null;
            _startPosY = null;
        }

        /// <summary>
        /// Установка границ поля
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public bool SetPictureSize(int width, int height)
        {
            if (width > _drawningAirWidth && height > _drawingAirHeight)
            {
                _pictureWidth = width;
                _pictureHeight = height;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Установка позиции
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void SetPosition(int x, int y)
        {
            if (!_pictureHeight.HasValue || !_pictureWidth.HasValue)
            {
                return;
            }

            if (x > 0 && x < (_pictureWidth.Value - _drawningAirWidth) && y > 0 && y < (_pictureHeight.Value - _drawingAirHeight))
            {
                _startPosX = x;
                _startPosY = y;
            }
        }

        /// <summary>
        /// Перемещение объекта
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public bool Move(DirectionType direction)
        {
            if (EntityAirBomber == null || !_startPosX.HasValue || !_startPosY.HasValue)
            {
                return false;
            }
            switch (direction)
            {
                case DirectionType.Left:
                    if (_startPosX.Value - EntityAirBomber.Step > 0)
                    {
                        _startPosX -= (int)EntityAirBomber.Step;
                    }
                    return true;
                case DirectionType.Right:
                    if (_startPosX.Value + _drawningAirWidth + EntityAirBomber.Step < _pictureWidth.Value)
                    {
                        _startPosX += (int)EntityAirBomber.Step;
                    }
                    return true;
                case DirectionType.Up:
                    if (_startPosY.Value - EntityAirBomber.Step > 0)
                    {
                        _startPosY -= (int)EntityAirBomber.Step;
                    }
                    return true;
                case DirectionType.Down:
                    if (_startPosY.Value + _drawingAirHeight + EntityAirBomber.Step < _pictureHeight.Value)
                    {
                        _startPosY += (int)EntityAirBomber.Step;
                    }
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Прорисовка объекта
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            if (EntityAirBomber == null || !_startPosX.HasValue || !_startPosY.HasValue)
            {
                return;
            }

            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Aquamarine);

            // фюзеляж
            Point[] bodyPoints = new Point[]{
                new Point(_startPosX.Value + 80, _startPosY.Value + 40),
                new Point(_startPosX.Value + 100, _startPosY.Value + 48),
                new Point(_startPosX.Value + 80, _startPosY.Value + 56),
            };
            g.DrawPolygon(pen, bodyPoints);
            g.FillPolygon(brush, bodyPoints);

            brush = new SolidBrush(EntityAirBomber.BodyColor);
            g.DrawRectangle(pen, _startPosX.Value, _startPosY.Value + 40, 80, 16);
            g.FillRectangle(brush, _startPosX.Value, _startPosY.Value + 40, 80, 16);

            //крыло
            Point[] wingPoints = new Point[]{
                new Point(_startPosX.Value + 45, _startPosY.Value + 40),
                new Point(_startPosX.Value + 50, _startPosY.Value),
                new Point(_startPosX.Value + 60, _startPosY.Value),
                new Point(_startPosX.Value + 60, _startPosY.Value + 96),
                new Point(_startPosX.Value + 50, _startPosY.Value + 96),
                new Point(_startPosX.Value + 45, _startPosY.Value + 56),
            };
            g.DrawPolygon(pen, wingPoints);
            g.FillPolygon(brush, wingPoints);

            //хвост
            Point[] tailPoints = new Point[]{
                new Point(_startPosX.Value + 15, _startPosY.Value + 40),
                new Point(_startPosX.Value + 10, _startPosY.Value + 20),
                new Point(_startPosX.Value, _startPosY.Value + 20),
                new Point(_startPosX.Value, _startPosY.Value + 76),
                new Point(_startPosX.Value + 10, _startPosY.Value + 76),
                new Point(_startPosX.Value + 15, _startPosY.Value + 56),
            };
            g.DrawPolygon(pen, tailPoints);
            g.FillPolygon(brush, tailPoints);

            brush = new SolidBrush(EntityAirBomber.AdditionalColor);

            //бомбы
            if (EntityAirBomber.AircraftBomb)
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
            if (EntityAirBomber.AircraftBomb)
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
            if (EntityAirBomber.AirRefueling)
            {
                g.DrawLine(pen, new Point(_startPosX.Value + 100, _startPosY.Value + 48),
                    new Point(_startPosX.Value + 105, _startPosY.Value + 48));
            }
        }
    }
}
