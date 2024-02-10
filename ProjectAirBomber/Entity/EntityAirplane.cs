namespace ProjectAirBomber.Entity
{
    /// <summary>
    /// Класс сущность Самолет
    /// </summary>
    public class EntityAirplane
    {
        /// <summary>
        /// Скорость
        /// </summary>
        public int Speed { get; protected set; }
        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; protected set; }
        /// <summary>
        /// Основной цвет
        /// </summary>
        public Color BodyColor { get; protected set; }
        /// <summary>
        /// Шаг перемещения бомбардировщика
        /// </summary>
        public double Step => Speed * 100 / Weight;

        /// <summary>
        /// Конструктор объекта класса самолета
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="weight"></param>
        /// <param name="bodyColor"></param>
        public EntityAirplane(int speed, double weight, Color bodyColor)
        {
            Speed = speed;
            Weight = weight;
            BodyColor = bodyColor;
        }
        /// <summary>
        /// Изменение основного цвета
        /// </summary>
        /// <param name="color"></param>
        public void ChangeColor (Color color)
        {
            BodyColor = color;
        }

        /// <summary>
        /// Получение строк со значениями свойств объекта класса-сущности
        /// </summary>
        /// <returns></returns>
        public virtual string[] GetStringRepresentation()
        {
            return new[] { nameof(EntityAirplane), Speed.ToString(), Weight.ToString(), BodyColor.Name };
        }
        /// <summary>
        /// Создание объекта из массива строк
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static EntityAirplane? CreateEntityAirplane(string[] strs)
        {
            if (strs.Length != 4 || strs[0] != nameof(EntityAirplane))
            {
                return null;
            }
            return new EntityAirplane(Convert.ToInt32(strs[1]), Convert.ToDouble(strs[2]), Color.FromName(strs[3]));
        }
    }
}
