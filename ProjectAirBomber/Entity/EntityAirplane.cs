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
    }
}
