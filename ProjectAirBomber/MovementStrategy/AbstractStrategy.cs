namespace ProjectAirBomber.MovementStrategy
{
    /// <summary>
    /// Класс-стратегия перемещения объекта
    /// </summary>
    public abstract class AbstractStrategy
    {
        /// <summary>
        /// Перемещаемый объект
        /// </summary>
        private IMoveableObject? _moveableObject;
        /// <summary>
        /// Статус перемещения
        /// </summary>
        private StrategyStatus _state = StrategyStatus.NotInit;
        /// <summary>
        /// Ширина поля
        /// </summary>
        protected int FieldWidth {  get; private set; }
        /// <summary>
        /// Высота поля
        /// </summary>
        protected int FieldHeight {  get; private set; }
        /// <summary>
        /// Статус перемещения
        /// </summary>
        public StrategyStatus GetStatus() { return _state; }
        /// <summary>
        /// Установка данных
        /// </summary>
        /// <param name="moveableObject"></param>
        /// <param name="wedth"></param>
        /// <param name="height"></param>
        public void SetData(IMoveableObject moveableObject, int wedth, int height)
        {
            if (moveableObject == null)
            {
                _state = StrategyStatus.NotInit;
                return;
            }
            _state = StrategyStatus.InProgress;
            _moveableObject = moveableObject;
            FieldWidth = wedth;
            FieldHeight = height;
        }
        /// <summary>
        /// Шаг перемещения
        /// </summary>
        public void MakeStep()
        {
            if (_state != StrategyStatus.InProgress)
            {
                return;
            }
            if (IsTargetGetDestination())
            {
                _state = StrategyStatus.Finish;
                return;
            }
            MoveToTarget();
        }
        /// <summary>
        /// Перемещение влево
        /// </summary>
        /// <returns>Результат перемещения (true - удалось переместиться, false - неудача)</returns>
        protected bool MoveLeft() => MoveTo(MovementDirection.Left);
        /// <summary>
        /// Перемещение вправо
        /// </summary>
        /// <returns>Результат перемещения (true - удалось переместиться, false - неудача)</returns>
        protected bool MoveRight() => MoveTo(MovementDirection.Right);
        /// <summary>
        /// Перемещение вверх
        /// </summary>
        /// <returns>Результат перемещения (true - удалось переместиться, false - неудача)</returns>
        protected bool MoveUp() => MoveTo(MovementDirection.Up);
        /// <summary>
        /// Перемещение вниз
        /// </summary>
        /// <returns>Результат перемещения (true - удалось переместиться, false - неудача)</returns>
        protected bool MoveDown() => MoveTo(MovementDirection.Down);
        /// <summary>
        /// Параметры объекта
        /// </summary>
        protected ObjectParametrs? GetObjectParametrs => _moveableObject?.GetObjectPosition;
        /// <summary>
        /// Шаг объекта
        /// </summary>
        /// <returns></returns>
        protected int? GetStep()
        {
            if(_state != StrategyStatus.InProgress)
            {
                return null;
            }
            return _moveableObject?.GetStep;
        }
        /// <summary>
        /// Перемещение к цели
        /// </summary>
        protected abstract void MoveToTarget();
        /// <summary>
        /// Достигнута ли цель
        /// </summary>
        /// <returns></returns>
        protected abstract bool IsTargetGetDestination();
        /// <summary>
        /// Попытка перемещения в требуемом направлении
        /// </summary>
        /// <param name="movementDirection">Направление</param>
        /// <returns>Результат попытки (true - удалось переместиться, false - неудача)</returns>
        private bool MoveTo(MovementDirection movementDirection)
        {
            if (_state != StrategyStatus.InProgress)
            {
                return false;
            }
            return _moveableObject?.TryMoveObject(movementDirection) ?? false;
        }
    }
}
