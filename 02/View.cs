using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02
{
    public interface View
    {
        Presenter Presenter { get; set; }
    }
}