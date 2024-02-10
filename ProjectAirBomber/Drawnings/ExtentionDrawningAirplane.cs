using ProjectAirBomber.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAirBomber.Drawnings
{
    /// <summary>
    /// Расширение для класса EntityAirplane
    /// </summary>
    public static class ExtentionDrawningAirplane
    {
        /// <summary>
        /// Разделитель для записи информации по объекту в файл
        /// </summary>
        private static readonly string _separatorForObject = ":";
        /// <summary>
        /// Создание объекта из строки
        /// </summary>
        /// <param name="info">Строка с данными для создания объекта</param>
        /// <returns>Объект</returns>
        public static DrawningAirplane? CreateDrawningAirplane(this string info)
        {
            string[] strs = info.Split(_separatorForObject);
            EntityAirplane? airplane = EntityAirBomber.CreateEntityAirBomber(strs);
            if (airplane != null)
            {
                return new DrawningAirBomber((EntityAirBomber?)airplane);
            }
            airplane = EntityAirplane.CreateEntityAirplane(strs);
            if (airplane != null)
            {
                return new DrawningAirplane(airplane);
            }
            return null;
        }

        /// <summary>
        /// Получение данных для сохранения в файл
        /// </summary>
        /// <param name="drawningAirplane">Сохраняемый объект</param>
        /// <returns>Строка с данными по объекту</returns>
        public static string GetDataForSave(this DrawningAirplane drawningAirplane)
        {
            string[]? array = drawningAirplane?.EntityAirplane?.GetStringRepresentation();
            if (array == null)
            {
                return string.Empty;
            }
            return string.Join(_separatorForObject, array);
        }

    }
}
