using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAirBomber.Exceptions
{
    /// <summary>
    /// Класс, описывающий ошибку не уникального элемента коллекции
    /// </summary>
    [Serializable]
    internal class NotUniqueElementException : ApplicationException
    {
        public NotUniqueElementException() : base("Такой объект уже существует в коллекции") { }
        public NotUniqueElementException(string message) : base(message) { }
        public NotUniqueElementException(string message, Exception exception) : base(message, exception) { }
        protected NotUniqueElementException(SerializationInfo info, StreamingContext contex) : base(info, contex) { }
    }
}
