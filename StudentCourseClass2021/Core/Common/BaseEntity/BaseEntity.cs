using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Common.BaseEntity
{
    public class BaseEntity<T>
    {
        public T ID { get; set; }
    }
}
