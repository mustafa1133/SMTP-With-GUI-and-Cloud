﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EASendMail;
namespace GUI
{
    public class usercredentials
    {
        private string _name;
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        private string _email;
        public string email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }

        public static string[] addNameArray(string name)
        {

            string[] result = name.Split();
            return result;

        }

        public static string[] addEmailArray(string email)
        {

            string[] result = email.Split();
            return result;
        }

    }
    class SendToMultipleUsers
    {

        public static void SendEmail(string emailList , string subject ,string body)
        {
            string[] arRcpt = usercredentials.addEmailArray(emailList);

            int nRcpt = arRcpt.Length;
            SmtpMail[] arMail = new SmtpMail[nRcpt];
            SmtpClient[] arSmtp = new SmtpClient[nRcpt];
            SmtpClientAsyncResult[] arResult = new SmtpClientAsyncResult[nRcpt];
            for (int i = 0; i < nRcpt; i++)
            {
                arMail[i] = new SmtpMail("TryIt");
                arSmtp[i] = new SmtpClient();
            }

            for (int i = 0; i < nRcpt; i++)
            {
                SmtpMail oMail = arMail[i];
                // Set sender email address
                oMail.From = "mr.ebrahem3@gmail.com";

                // Set recipient email address
                oMail.To = arRcpt[i];

                // Set email subject
                oMail.Subject = subject;

                // Set email body
                oMail.TextBody = body;
                // Your smtp server address
                SmtpServer oServer = new SmtpServer("smtp.gmail.com");

                oServer.Port = 587;

                // User and password for ESMTP authentication, if your server doesn't require
                // User authentication, please remove the following codes.
                oServer.User = "mr.ebrahem3@gmail.com";
                oServer.Password = "rapper1133";

                // If your smtp server requires SSL connection, please add this line
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;
                SmtpClient oSmtp = arSmtp[i];

                // Submit email to BeginSendMail method and return
                // to process another email
                arResult[i] = oSmtp.BeginSendMail(oServer, oMail, null, null);
                Console.WriteLine(String.Format("Start to send email to {0} ...",
                    arRcpt[i]));
            }
            // All emails were sent by BeginSendMail Method
            // now get result by EndSendMail method
            int nSent = 0;
            while (nSent < nRcpt)
            {
                for (int i = 0; i < nRcpt; i++)
                {
                    // this email has been sent
                    if (arResult[i] == null)
                        continue;
                    // wait for specified email ...
                    if (!arResult[i].AsyncWaitHandle.WaitOne(10, false))
                    {
                        continue;
                    }
                    try
                    {
                        // this email is finished, using EndSendMail to get result
                        arSmtp[i].EndSendMail(arResult[i]);
                        Console.WriteLine(String.Format("Send email to {0} successfully",
                                                    arRcpt[i]));
                    }
                    catch (Exception ep)
                    {
                        Console.WriteLine(
                           String.Format("Failed to send email to {0} with error {1}: ",
                           arRcpt[i], ep.Message));
                    }
                    // Set this email result to null, then it won't be processed again
                    arResult[i] = null;
                    nSent++;
                }
            }
        }
    }
}
    

