using System;
using System.Threading;

namespace AsyncLocal.CorrelationId
{
    public static class Current
    {
        private static readonly AsyncLocal<Guid?> CorrelationId = new AsyncLocal<Guid?>();

        public static Guid? Value
        {
            get => CorrelationId.Value;
            set => CorrelationId.Value = value;
        }
    }
}
