using ProjectAirBomber.Entity;

namespace ProjectAirBomber.Drawnings
{
    /// <summary>
    /// Прорисовка и перемещение самолета
    /// </summary>
    public class DrawningAirplane
    {
        /// <summary>
        /// Класс - сущность
        /// </summary>
        public EntityAirplane? EntityAirplane { get; protected set; }
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
        protected int? _startPosX;
        /// <summary>
        /// Верхняя координата прорисовки бомбардировщика
        /// </summary>
        protected int? _startPosY;
        /// <summary>
        /// Ширина прорисовки бомбардировщика
        /// </summary>
        private readonly int _drawningAirWidth = 100;
        /// <summary>
        /// Высота прорисовки бомбардировщика
        /// </summary>
        private readonly int _drawingAirHeight = 96;
        /// <summary>
        /// Координата X объекта
        /// </summary>
        public int? GetPosX => _startPosX;
        /// <summary>
        /// Координата Y объекта
        /// </summary>
        public int? GetPosY => _startPosY;
        /// <summary>
        /// Ширина объекта
        /// </summary>
        public int GetWidth => _drawningAirWidth;
        /// <summary>
        /// Высота объекта
        /// </summary>
        public int GetHeight => _drawingAirHeight;

        /// <summary>
        /// Пустой конструктор
        /// </summary>
        private DrawningAirplane()
        {
            _pictureWidth = null;
            _pictureHeight = null;
            _startPosX = null;
            _startPosY = null;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="weight"></param>
        /// <param name="bodyColor"></param>
        public DrawningAirplane(int speed, double weight, Color bodyColor) : this()
        {
            EntityAirplane = new EntityAirplane(speed, weight, bodyColor);
        }

        /// <summary>
        /// Конструктор для наследников
        /// </summary>
        /// <param name="drawningAirWidth"></param>
        /// <param name="drawingAirHeight"></param>
        protected DrawningAirplane(int drawningAirWidth, int drawingAirHeight) : this()
        {
            _drawningAirWidth = drawningAirWidth;
            _drawingAirHeight = drawingAirHeight;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="entityAirplane"></param>
        public DrawningAirplane(EntityAirplane? entityAirplane)
        {
            EntityAirplane = entityAirplane;
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

            if (x < 0 || y < 0)
            {
                x = 0;
                y = 0;  
            }
            if (x > _pictureWidth.Value - _drawningAirWidth || y > _pictureHeight.Value - _drawingAirHeight)
            {
                x = _pictureWidth.Value - _drawningAirWidth;
                y = _pictureHeight.Value - _drawingAirHeight;
            }

            _startPosX = x;
            _startPosY = y;
        }

        /// <summary>
        /// Перемещение объекта
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public bool Move(DirectionType direction)
        {
            if (EntityAirplane == null || !_startPosX.HasValue || !_startPosY.HasValue)
            {
                return false;
            }
            switch (direction)
            {
                case DirectionType.Left:
                    if (_startPosX.Value - EntityAirplane.Step > 0)
                    {
                        _startPosX -= (int)EntityAirplane.Step;
                    }
                    return true;
                case DirectionType.Right:
                    if (_startPosX.Value + _drawningAirWidth + EntityAirplane.Step < _pictureWidth.Value)
                    {
                        _startPosX += (int)EntityAirplane.Step;
                    }
                    return true;
                case DirectionType.Up:
                    if (_startPosY.Value - EntityAirplane.Step > 0)
                    {
                        _startPosY -= (int)EntityAirplane.Step;
                    }
                    return true;
                case DirectionType.Down:
                    if (_startPosY.Value + _drawingAirHeight + EntityAirplane.Step < _pictureHeight.Value)
                    {
                        _startPosY += (int)EntityAirplane.Step;
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
        public virtual void Draw(Graphics g)
        {
            if (EntityAirplane == null || !_startPosX.HasValue || !_startPosY.HasValue)
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

            Brush brushBody = new SolidBrush(EntityAirplane.BodyColor);
            g.DrawRectangle(pen, _startPosX.Value, _startPosY.Value + 40, 80, 16);
            g.FillRectangle(brushBody, _startPosX.Value, _startPosY.Value + 40, 80, 16);

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
            g.FillPolygon(brushBody, wingPoints);

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
            g.FillPolygon(brushBody, tailPoints);
        }
    }
}
