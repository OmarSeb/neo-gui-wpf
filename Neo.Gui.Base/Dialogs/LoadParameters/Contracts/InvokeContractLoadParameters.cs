﻿using Neo.Core;

namespace Neo.Gui.Wpf.Views.Contracts
{
    public class InvokeContractLoadParameters
    {
        public InvocationTransaction Transaction { get; }

        public InvokeContractLoadParameters(InvocationTransaction transaction)
        {
            this.Transaction = transaction;
        }
    }
}