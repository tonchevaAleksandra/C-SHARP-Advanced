﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public interface INumberEnumerator :IEnumerator<int>
    {
        List<int> Data { set; }
    }
}
