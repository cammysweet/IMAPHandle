
using System;
using System.Configuration;

namespace IMAPHandle
{
    public class Servidor
    {
        public Servidor(ServidorEnum server)
        {
            #region preenche propriedades outlook
            if (server == ServidorEnum.Outlook)
            {
                _servername = "Outlook";
                _hostname = ConfigurationManager.AppSettings["hostnameOutlook"].ToString();
                _hostsaida = ConfigurationManager.AppSettings["hostsaidaOutlook"].ToString();
                _port = Convert.ToInt32(ConfigurationManager.AppSettings["portOutlook"]);
                _portsaida = Convert.ToInt32(ConfigurationManager.AppSettings["portsaidaOutlook"]);
                _useSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["useSslOutlook"]);
                _username = ConfigurationManager.AppSettings["usernameOutlook"].ToString();
                _password = ConfigurationManager.AppSettings["passwordOutlook"].ToString();
                _email = ConfigurationManager.AppSettings["emailOutlook"].ToString();
                _serverIMAP = ConfigurationManager.AppSettings["serverIMAPOutlook"].ToString();
                _portIMAP = Convert.ToInt32(ConfigurationManager.AppSettings["portIMAPOutlook"]);
                _useSSLIMAP = Convert.ToBoolean(ConfigurationManager.AppSettings["SSLIMAPOutlook"]);
            }
            #endregion
            #region preenche propriedades gmail
            if (server == ServidorEnum.Gmail)
            {
                _servername = "Gmail";
                _hostname = ConfigurationManager.AppSettings["hostnameGmail"].ToString();
                _hostsaida = ConfigurationManager.AppSettings["hostsaidaGmail"].ToString();
                _port = Convert.ToInt32(ConfigurationManager.AppSettings["portGmail"]);
                _portsaida = Convert.ToInt32(ConfigurationManager.AppSettings["portsaidaGmail"]);
                _useSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["useSslGmail"]);
                _username = ConfigurationManager.AppSettings["usernameGmail"].ToString();
                _password = ConfigurationManager.AppSettings["passwordGmail"].ToString();
                _email = ConfigurationManager.AppSettings["emailGmail"].ToString();
                _serverIMAP = ConfigurationManager.AppSettings["serverIMAPGmail"].ToString();
                _portIMAP = Convert.ToInt32(ConfigurationManager.AppSettings["portIMAPGmail"]);
                _useSSLIMAP = Convert.ToBoolean(ConfigurationManager.AppSettings["SSLIMAPGmail"]);
                _usernameIMAPGmail = ConfigurationManager.AppSettings["usernameIMAPGmail"].ToString();
            }
            #endregion
            #region preenche propriedades bol
            if (server == ServidorEnum.Bol)
            {
                _servername = "Bol";
                _hostname = ConfigurationManager.AppSettings["hostnameBol"].ToString();
                _hostsaida = ConfigurationManager.AppSettings["hostsaidaBol"].ToString();
                _port = Convert.ToInt32(ConfigurationManager.AppSettings["portBol"]);
                _portsaida = Convert.ToInt32(ConfigurationManager.AppSettings["portsaidaBol"]);
                _useSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["useSslBol"]);
                _username = ConfigurationManager.AppSettings["usernameBol"].ToString();
                _password = ConfigurationManager.AppSettings["passwordBol"].ToString();
                _email = ConfigurationManager.AppSettings["emailBol"].ToString();
                _serverIMAP = ConfigurationManager.AppSettings["serverIMAPBol"].ToString();
                _portIMAP = Convert.ToInt32(ConfigurationManager.AppSettings["portIMAPBol"]);
                _useSSLIMAP = Convert.ToBoolean(ConfigurationManager.AppSettings["SSLIMAPBol"]);
            }
            #endregion
            #region preenche propriedades Yahoo
            if (server == ServidorEnum.Yahoo)
            {
                _servername = "Yahoo";
                _hostname = ConfigurationManager.AppSettings["hostnameYahoo"].ToString();
                _hostsaida = ConfigurationManager.AppSettings["hostsaidaYahoo"].ToString();
                _port = Convert.ToInt32(ConfigurationManager.AppSettings["portYahoo"]);
                _portsaida = Convert.ToInt32(ConfigurationManager.AppSettings["portsaidaYahoo"]);
                _useSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["useSslYahoo"]);
                _username = ConfigurationManager.AppSettings["usernameYahoo"].ToString();
                _password = ConfigurationManager.AppSettings["passwordYahoo"].ToString();
                _email = ConfigurationManager.AppSettings["emailYahoo"].ToString();
                _serverIMAP = ConfigurationManager.AppSettings["serverIMAPYahoo"].ToString();
                _portIMAP = Convert.ToInt32(ConfigurationManager.AppSettings["portIMAPYahoo"]);
                _useSSLIMAP = Convert.ToBoolean(ConfigurationManager.AppSettings["SSLIMAPYahoo"]);
            }
            #endregion
            #region preenche propriedades para envio de email
            //_emailConfirmaPara = ConfigurationManager.AppSettings["emailConfirmaPara"].ToString();
            //_emailConfirmaCopia1 = ConfigurationManager.AppSettings["emailConfirmaCopia1"].ToString();
            //_emailConfirmaCopia2 = ConfigurationManager.AppSettings["emailConfirmaCopia2"].ToString();
            //_emailConfirmaAssunto = ConfigurationManager.AppSettings["emailConfirmaAssunto"].ToString();
            //_emailConfirmaHostSaida = ConfigurationManager.AppSettings["emailConfirmaHost"].ToString();
            //_emailConfirmaPortSaida = Convert.ToInt32(ConfigurationManager.AppSettings["emailConfirmaPort"].ToString());
            //_emailConfirmaSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["emailConfirmaSsl"]);
            //_emailConfirmaDe = ConfigurationManager.AppSettings["emailConfirmaDe"].ToString();
            //_emailConfirmaSenha = ConfigurationManager.AppSettings["emailConfirmaSenha"].ToString();
            //_remetentejornal = ConfigurationManager.AppSettings["RemetenteJornal"].ToString();
            //_assuntocontains = ConfigurationManager.AppSettings["AssuntoContains"].ToString();
            #endregion
        }

        #region propriedades email a ser monitorado
        public string _servername { get; set; }
        public string _usernameIMAPGmail { get; set; }
        public string _hostname { get; set; }
        public string _hostsaida { get; set; }
        public int _port { get; set; }
        public int _portsaida { get; set; }
        public bool _useSsl { get; set; }
        public string _username { get; set; }
        public string _password { get; set; }
        public string _email { get; set; }
        #endregion

        #region propriedades email a ser enviado caso não encontre o jornal
        public string _emailConfirmaDe { get; set; }
        public string _emailConfirmaPara { get; set; }
        public string _emailConfirmaCopia1 { get; set; }
        public string _emailConfirmaCopia2 { get; set; }
        public string _emailConfirmaAssunto { get; set; }
        public int _emailConfirmaPort { get; set; }
        public int _emailConfirmaPortSaida { get; set; }
        public bool _emailConfirmaSsl { get; set; }
        public string _emailConfirmaHostSaida { get; set; }
        public string _emailConfirmaSenha { get; set; }
        #endregion

        #region propriedades do jornal
        public string _remetentejornal { get; set; }
        public string _assuntocontains { get; set; }
        #endregion

        #region propriedades IMAP
        public string _serverIMAP { get; set; }
        public int _portIMAP { get; set; }
        public bool _useSSLIMAP { get; set; }
        #endregion
    }

    public enum ServidorEnum
    {
        Outlook = 1,
        Gmail = 2,
        Bol = 3,
        Yahoo = 4
    }
}
