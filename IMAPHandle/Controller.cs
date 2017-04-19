using Koolwired.Imap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMAPHandle
{
    class Controller
    {
        public string[] CarregaCaixaEntrada(ServidorEnum server)
        {
            Servidor serverEmail = new Servidor(server);
            string[] retorno = null;

            try
            {
                #region Grava Log no arquivo
                //using (StreamWriter sw = File.AppendText(serverEmail._logExecucao))
                //{
                //    sw.WriteLine("Metodo Carregar Email " + serverEmail._servername + " Iniciado " + DateTime.Now.ToString());
                //}
                #endregion

                ImapAuthenticate imapAutentic;

                ImapConnect connection = new ImapConnect(serverEmail._serverIMAP, serverEmail._portIMAP, serverEmail._useSSLIMAP);
                ImapCommand command = new ImapCommand(connection);
                if (server == ServidorEnum.Gmail)
                    imapAutentic = new ImapAuthenticate(connection, serverEmail._usernameIMAPGmail, serverEmail._password);
                else imapAutentic = new ImapAuthenticate(connection, serverEmail._username, serverEmail._password);

                connection.Open();
                imapAutentic.Login();

                //Para teste (listar pastas)
                var koolPasta = command.List();

                ImapMailbox inbox;

                //if (idServer == 4) 
                inbox = command.Select("Inbox"); //Yahoo
                //else inbox = command.Select("Junk");
                inbox = command.Fetch(inbox);
                int mailCount = inbox.Messages.Count;

                for (int i = 0; i < mailCount; i++)
                {
                    retorno = new string[mailCount];

                    string emailRemetente = "";

                    ImapMailboxMessage msg = inbox.Messages[i];
                    if (server != ServidorEnum.Bol)
                        msg = command.FetchBodyStructure(msg);

                    string assunto = msg.Subject;
                    DateTime recebida = msg.Received;
                    emailRemetente = msg.From.Address;
                    retorno[i] = "\nEmail " + i.ToString() + "\nRemetente: " + emailRemetente + "\nRecebida em: " + recebida.ToString("dd/MM/yyyy")
                        + "\nAssunto: " + assunto;

                    #region Grava Log no arquivo
                    //using (StreamWriter sw = File.AppendText(serverEmail._logExecucao))
                    //{
                    //    sw.WriteLine("Email encontrado: "+retorno[i]);
                    //}
                    #endregion
                }

                imapAutentic.Logout();
                connection.Close();

                #region Grava Log no arquivo
                //using (StreamWriter sw = File.AppendText(serverEmail._logExecucao))
                //{
                //    sw.WriteLine("Fim do Processo Monitora " + serverEmail._servername + "!!! " + DateTime.Now.ToString());
                //}
                #endregion

                return retorno;

            }
            catch (Exception e)
            {
                #region Grava Log no arquivo
                //using (StreamWriter sw = File.AppendText(serverEmail._logExecucao))
                //{
                //    sw.WriteLine("Erro do Processo Monitora " + serverEmail._servername + " " + e.Message + DateTime.Now.ToString());
                //}
                #endregion
                return retorno;
            }

        }
    }
}
