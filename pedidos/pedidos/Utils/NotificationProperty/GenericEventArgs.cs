using System;

namespace pedidos.Utils.NotificationProperty
{
    public class GenericEventArgs<T> : EventArgs
    {
        public T Result { private get; set; }
        public GenericEventArgs(T _result) => this.Result = _result;
    }
}
