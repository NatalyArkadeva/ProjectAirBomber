﻿using ProjectAirBomber.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAirBomber.CollectionGenericObjects
{
    /// <summary>
    /// Класс, хранящиий информацию по коллекции
    /// </summary>
    public class CollectionInfo : IEquatable<CollectionInfo>
    {
        /// <summary>
        /// Название
        /// </summary>
        [Key]
        public string? Name { get; private set; }
        /// <summary>
        /// Тип
        /// </summary>
        public CollectionType CollectionType { get; private set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; private set; }

        [ForeignKey("CollectionInfoName")]
        public virtual List<EntityAirplane> Airplanes { get; set; } = new();
        /// <summary>
        /// Разделитель для записи информации по объекту в файл
        /// </summary>
        [NotMapped]
        private static readonly string _separator = "-";
        public CollectionInfo() { }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="collectionType">Тип</param>
        /// <param name="description">Описание</param>
        public CollectionInfo(string name, CollectionType collectionType, string description)
        {
            Name = name;
            CollectionType = collectionType;
            Description = description;
        }
        /// <summary>
        /// Создание объекта из строки
        /// </summary>
        /// <param name="data">Строка</param>
        /// <returns>Объект или null</returns>
        public static CollectionInfo? GetCollectionInfo(string data)
        {
            string[] strs = data.Split(_separator, StringSplitOptions.RemoveEmptyEntries);
            if (strs.Length < 1 || strs.Length > 3)
            {
                return null;
            }
            return new CollectionInfo(strs[0], (CollectionType)Enum.Parse(typeof(CollectionType), strs[1]), strs.Length > 2 ? strs[2] : string.Empty);
        }
        public override string ToString()
        {
            return Name + _separator + CollectionType + _separator + Description;
        }
        public bool Equals(CollectionInfo? other)
        {
            return Name == other?.Name;
        }
        public override bool Equals(object? obj)
        {
            return Equals(obj as CollectionInfo);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
