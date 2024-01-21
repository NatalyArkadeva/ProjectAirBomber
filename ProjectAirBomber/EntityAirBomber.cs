namespace ProjectAirBomber
{
    /// <summary>
    /// Класс-сущность "Бомбардировщик"
    /// </summary>
    public class EntityAirBomber
    {
        /// <summary>
        /// Скорость
        /// </summary>
        public int Speed { get; private set; }
        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; private set; }
        /// <summary>
        /// Основной цвет
        /// </summary>
        public Color BodyColor { get; private set; }
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
        /// Шаг перемещения бомбардировщика
        /// </summary>
        public double Step => Speed * 100 / Weight;

        /// <summary>
        /// Инициализация полей объекта класса бомбардировщика
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
            Speed = speed;
            Weight = weight;
            BodyColor = bodyColor;
            AdditionalColor = additionalColor;
            AirRefueling = airRefueling;
            ExtraFuelTank = extraFuelTank;
            AircraftBomb = aircraftBomb;
        }
    }
}
