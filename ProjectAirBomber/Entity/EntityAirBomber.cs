namespace ProjectAirBomber.Entity
{
    /// <summary>
    /// Класс-сущность "Бомбардировщик"
    /// </summary>
    public class EntityAirBomber : EntityAirplane
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color AdditionalColor { get; private set; }
        /// <summary>
        /// Наличие дозаправки в воздухе
        /// </summary>
        public bool AirRefueling { get; private set; }
        /// <summary>
        /// Наличие дополнительных товливных баков
        /// </summary>
        public bool ExtraFuelTank { get; private set; }
        /// <summary>
        /// Наличие авиабомбы
        /// </summary>
        public bool AircraftBomb { get; private set; }

        /// <summary>
        /// Конструктор объекта класса бомбардировщика
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="weight"></param>
        /// <param name="bodyColor"></param>
        /// <param name="additionalColor"></param>
        /// <param name="airRefueling"></param>
        /// <param name="extraFuelTank"></param>
        /// <param name="aircraftBomb"></param>
        public EntityAirBomber(int speed, double weight, Color bodyColor, Color additionalColor, bool airRefueling, bool extraFuelTank, bool aircraftBomb) : base(speed, weight, bodyColor)
        {
            AdditionalColor = additionalColor;
            AirRefueling = airRefueling;
            ExtraFuelTank = extraFuelTank;
            AircraftBomb = aircraftBomb;
        }
        /// <summary>
        /// Изменение дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void ChangeAdditionalColor(Color color)
        {
            AdditionalColor = color;
        }
    }
}
