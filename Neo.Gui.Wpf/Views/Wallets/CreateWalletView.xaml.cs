﻿using System.Windows;
using System.Windows.Controls;
using Neo.Gui.Dialogs.Interfaces;
using Neo.Gui.Dialogs.LoadParameters.Wallets;
using Neo.Gui.ViewModels.Wallets;

namespace Neo.Gui.Wpf.Views.Wallets
{
    public partial class CreateWalletView : IDialog<CreateWalletLoadParameters>
    {
        private readonly CreateWalletViewModel viewModel;

        public CreateWalletView()
        {
            InitializeComponent();

            this.viewModel = this.DataContext as CreateWalletViewModel;
        }

        private void PasswordChanged(object sender, RoutedEventArgs e)
        {
            var passwordBox = sender as PasswordBox;

            if (passwordBox == null) return;

            this.viewModel?.UpdatePassword(passwordBox.Password);
        }

        private void ReEnteredPasswordChanged(object sender, RoutedEventArgs e)
        {
            var reEnteredPasswordBox = sender as PasswordBox;

            if (reEnteredPasswordBox == null) return;

            this.viewModel?.UpdateReEnteredPassword(reEnteredPasswordBox.Password);
        }
    }
}