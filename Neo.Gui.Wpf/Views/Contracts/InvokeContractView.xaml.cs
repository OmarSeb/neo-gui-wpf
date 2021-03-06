﻿using System;
using Neo.Gui.Base.Dialogs.Interfaces;
using Neo.Gui.Base.Dialogs.Results.Contracts;

namespace Neo.Gui.Wpf.Views.Contracts
{
    /// <summary>
    /// Interaction logic for InvokeContractView.xaml
    /// </summary>
    public partial class InvokeContractView : IDialog<InvokeContractDialogResult>
    {
        public InvokeContractView()
        {
            InitializeComponent();

            this.SetSelectedTab(1);
        }

        private void SetSelectedTab(int tabIndex)
        {
            if (tabIndex < 0 || tabIndex >= this.TabControl.Items.Count) throw new IndexOutOfRangeException();

            this.TabControl.SelectedIndex = tabIndex;
        }
    }
}