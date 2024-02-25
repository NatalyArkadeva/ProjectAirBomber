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
        public string AdditionalColor { get; private set; }
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
        public EntityAirBomber(int speed, double weight, string bodyColor, string additionalColor, bool airRefueling, bool extraFuelTank, bool aircraftBomb) : base(speed, weight, bodyColor)
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
            AdditionalColor = color.Name;
        }

        public override string[] GetStringRepresentation()
        {
            return new[] { nameof(EntityAirBomber), Speed.ToString(), Weight.ToString(), BodyColor, AdditionalColor,
                AirRefueling.ToString(), ExtraFuelTank.ToString(), AircraftBomb.ToString() };

        }
        /// <summary>
        /// Создание объекта из массива строк
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static EntityAirBomber? CreateEntityAirBomber(string[] strs)
        {
            if (strs.Length != 8 || strs[0] != nameof(EntityAirBomber))
            {
                return null;
            }
            return new EntityAirBomber(Convert.ToInt32(strs[1]), Convert.ToDouble(strs[2]), Color.FromName(strs[3]).Name, Color.FromName(strs[4]).Name,
                Convert.ToBoolean(strs[5]), Convert.ToBoolean(strs[6]), Convert.ToBoolean(strs[7]));
        }
    }
}
