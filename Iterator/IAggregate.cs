﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
        void Push(T t);
        T Pop();

    }
}
