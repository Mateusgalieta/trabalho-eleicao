using System;
using System.Runtime.Serialization;

namespace Trabalho_Eleicao
{
    [Serializable]
    internal class MysqlError : Exception
    {
        public MysqlError()
        {
        }

        public MysqlError(string message) : base(message)
        {
        }

        public MysqlError(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MysqlError(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}