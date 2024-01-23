namespace ProjectAirBomber.MovementStrategy
{
    /// <summary>
    /// Интерфейс для работы с перермещением объекта
    /// </summary>
    public interface IMoveableObject
    {
        /// <summary>
        /// Получение координаты объекта
        /// </summary>
        ObjectParametrs? GetObjectPosition {  get; }
        /// <summary>
        /// Шаг объекта
        /// </summary>
        int GetStep {  get; }
        /// <summary>
        /// Попытка переместить объект в указанном направлении
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        bool TryMoveObject(MovementDirection direction);
    }
}
