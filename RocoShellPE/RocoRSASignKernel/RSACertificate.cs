using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace RocoRSASignKernel
{
    public class RSACertificate
    {
        private string _CommonName;
        private DateTime _IssueTime;
        private int _Years;
        private string _Issuer;
        private string _CertificateData;
        private string _IssuerCertificateData;
        public string CommonName { get { return _CommonName; } }
        public DateTime IssueTime { get { return _IssueTime; } }
        public int Years { get { return _Years; } }
        public string Issuer { get { return _Issuer; } }
        public string CertificateData { get { return CertificateData; } }
        public string IssuerCertificateData { get { return IssuerCertificateData; } }
        private RSACertificate()
        {
        }
        private RSACertificate CreateCertificate(RSACertificateRequest CertReq)
        {
            RSACertificate cert = new RSACertificate();
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
            string rsadata = rsa.ToXmlString(true);
            byte[] rsaData = Encoding.UTF8.GetBytes(rsadata);
            string base64rsa = Convert.ToBase64String(rsaData);
            cert._CertificateData = base64rsa;
            cert._CommonName = CertReq.CommonName;
            cert._Issuer = cert._CommonName;
            cert._IssueTime = DateTime.Now;
            cert._Years = CertReq.Years;
            cert._IssuerCertificateData = Convert.ToBase64String(Encoding.UTF8.GetBytes(rsa.ToXmlString(false)));
            return cert;
        }
        private RSACertificate InvokeCertificateFromCA(RSACertificateRequest CertReq)
        {
            RSACertificate cert = new RSACertificate();
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
            string rsadata = rsa.ToXmlString(true);
            byte[] rsaData = Encoding.UTF8.GetBytes(rsadata);
            string base64rsa = Convert.ToBase64String(rsaData);
            cert._CertificateData = base64rsa;
            cert._CommonName = CertReq.CommonName;
            cert._Issuer = this.CommonName;
            cert._IssueTime = DateTime.Now;
            cert._Years = CertReq.Years;
            cert._IssuerCertificateData = this._IssuerCertificateData;
            return cert;
        }
        public RSACertificate InvokeCertificate(RSACertificateRequest CertReq)
        {
            return CertReq.SelfSign ? CreateCertificate(CertReq) : InvokeCertificateFromCA(CertReq);
        }
        public RSACertificate LoadCertificate(string CertificatePath)
        {
            return null;
        }
        public void SaveCertificate(string CertificatePath)
        {

        }
    }
    public class RSACertificateRequest
    {
        private string _CommonName;
        private DateTime _RequestTime;
        private int _Years;
        private bool _SelfSign;
        public string CommonName { get { return _CommonName; } }
        public DateTime RequestTime { get { return _RequestTime; } }
        public int Years { get { return _Years; } }
        public bool SelfSign { get { return _SelfSign; } }
    }
}
