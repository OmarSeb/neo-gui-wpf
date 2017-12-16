﻿using System;
using System.Linq;
using System.Windows.Input;

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

using Neo.Wallets;

using Neo.Gui.Base.Dialogs.Interfaces;
using Neo.Gui.Base.Dialogs.LoadParameters.Accounts;
using Neo.Gui.Base.Dialogs.Results.Wallets;
using Neo.Gui.Base.MVVM;

namespace Neo.Gui.ViewModels.Accounts
{
    public class ViewPrivateKeyViewModel : ViewModelBase, IDialogViewModel<ViewPrivateKeyDialogResult>, ILoadable
    {
        #region Public Properties
        public string Address { get; private set; }

        public string PublicKeyHex { get; private set; }

        public string PrivateKeyHex { get; private set; }

        public string PrivateKeyWif { get; private set; }
        #endregion Public Properties

        public ICommand CloseCommand => new RelayCommand(() => this.Close(this, EventArgs.Empty));
        
        #region IDialogViewModel implementation 
        public event EventHandler Close;

        public event EventHandler<ViewPrivateKeyDialogResult> SetDialogResultAndClose;

        public ViewPrivateKeyDialogResult DialogResult { get; private set; }
        #endregion

        #region ILoadable Methods 
        public void OnLoad(params object[] parameters)
        {
            if (!parameters.Any()) return;

            var viewPrivateKeyLoadParameters = (parameters[0] as LoadParameters<ViewPrivateKeyLoadParameters>)?.Parameters;

            if (viewPrivateKeyLoadParameters?.Account == null) return;

            this.SetAccountInfo(viewPrivateKeyLoadParameters.Account);
        }
        #endregion

        #region Private Methods 

        private void SetAccountInfo(WalletAccount account)
        {
            if (account == null) return;

            var key = account.GetKey();

            this.Address = account.Address;
            this.PublicKeyHex = key.PublicKey.EncodePoint(true).ToHexString();
            using (key.Decrypt())
            {
                this.PrivateKeyHex = key.PrivateKey.ToHexString();
            }
            this.PrivateKeyWif = key.Export();

            // Update properties
            RaisePropertyChanged(nameof(this.Address));
            RaisePropertyChanged(nameof(this.PublicKeyHex));
            RaisePropertyChanged(nameof(this.PrivateKeyHex));
            RaisePropertyChanged(nameof(this.PrivateKeyWif));
        }
        
        #endregion
    }
}
