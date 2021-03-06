﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace Neo.Gui.Base.Certificates
{
    public class CertificateQueryResult : IDisposable
    {
        public CertificateQueryResultType Type { get; set; }

        public X509Certificate2 Certificate { get; set; }

        public void Dispose()
        {
            this.Certificate?.Dispose();
        }
    }
}
