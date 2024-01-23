namespace ProjectAirBomber.MovementStrategy
{
    /// <summary>
    /// Статус выполнения операции перемещения
    /// </summary>
    public enum StrategyStatus
    {
        /// <summary>
        /// Все готово к началу
        /// </summary>
        NotInit,
        /// <summary>
        /// Выполняется
        /// </summary>
        InProgress,
        /// <summary>
        /// Завершено
        /// </summary>
        Finish
    }
}
