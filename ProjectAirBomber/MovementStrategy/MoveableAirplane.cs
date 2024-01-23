using ProjectAirBomber.Drawnings;

namespace ProjectAirBomber.MovementStrategy
{
    /// <summary>
    /// Класс-реализация IMoveableObject с использованием DrawningAirplane
    /// </summary>
    internal class MoveableAirplane : IMoveableObject
    {
        /// <summary>
        /// Поле-объект класса DrawningAirplane или его наследника
        /// </summary>
        private readonly DrawningAirplane? _drawningAirplane = null;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="drawningAirplane">Объект класса DrawningAirplane</param>
        public MoveableAirplane(DrawningAirplane drawningAirplane)
        {
            _drawningAirplane = drawningAirplane;
        }

        public ObjectParametrs? GetObjectPosition
        {
            get
            {
                if(_drawningAirplane == null || _drawningAirplane.EntityAirplane == null || !_drawningAirplane.GetPosX.HasValue || !_drawningAirplane.GetPosY.HasValue)
                {
                    return null;
                }
                return new ObjectParametrs(_drawningAirplane.GetPosX.Value, _drawningAirplane.GetPosY.Value, _drawningAirplane.GetWidth, _drawningAirplane.GetHeight);
            }
        }

        public int GetStep => (int)(_drawningAirplane?.EntityAirplane?.Step ?? 0);

        public bool TryMoveObject(MovementDirection direction)
        {
            if(_drawningAirplane == null || _drawningAirplane.EntityAirplane == null)
            {
                return false;
            }
            return _drawningAirplane.Move(GetDirectionType(direction));
        }
        /// <summary>
        /// Конвертация из MovementDirection в DirectionType
        /// </summary>
        /// <param name="direction">MovementDirection</param>
        /// <returns>DirectionType</returns>
        private DirectionType GetDirectionType(MovementDirection direction)
        {
            return direction switch
            {
                MovementDirection.Up => DirectionType.Up,
                MovementDirection.Down => DirectionType.Down,
                MovementDirection.Right => DirectionType.Right,
                MovementDirection.Left => DirectionType.Left,
                _ => DirectionType.Unknow,
            };
        }
    }
}
