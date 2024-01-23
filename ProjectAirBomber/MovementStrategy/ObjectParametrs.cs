namespace ProjectAirBomber.MovementStrategy
{
    /// <summary>
    /// Параметры-координаты объекта
    /// </summary>
    public class ObjectParametrs
    {
        /// <summary>
        ///  координата X
        /// </summary>
        private readonly int _x;
        /// <summary>
        ///  координата Y
        /// </summary>
        private readonly int _y;
        /// <summary>
        ///  ширина объекта
        /// </summary>
        private readonly int _width;
        /// <summary>
        ///  высота объекта
        /// </summary>
        private readonly int _height;
        /// <summary>
        ///  левая граница
        /// </summary>
        public int LefrBorder => _x;
        /// <summary>
        ///  верхняя граница
        /// </summary>
        public int TopBorder => _y;
        /// <summary>
        ///  правая граница
        /// </summary>
        public int RigthBorder => _x + _width;
        /// <summary>
        ///  нижняя граница
        /// </summary>
        public int DownBorder => _y + _height;
        /// <summary>
        /// середина объекта
        /// </summary>
        public int ObjectMiddleHorizontal => _x + _width/2;
        /// <summary>
        /// середина объекта
        /// </summary>
        public int ObjectMiddleVertical => _y + _height/2;
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public ObjectParametrs (int x, int y, int width, int height) 
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
            
        }
    }
}
