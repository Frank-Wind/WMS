﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMS_Interface;

namespace WMS_Kernel
{
    public interface ITodoListView:IBaseView
    {
        void IniPlanTypeList(List<string> planTypeList);
    }
}
