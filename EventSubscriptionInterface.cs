﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAllforTest
{
    public interface EventSubscriptionInterface
    {
        void Start_Subscription();

        delegate void execution_processing_reguest(object struct_transfer);

        #region События

        #endregion




    }
}
