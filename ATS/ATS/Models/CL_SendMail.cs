using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using static System.Net.WebRequestMethods;


public class CL_SendMail
{
    #region Mail_Credential
    private string mail_host = "192.168.0.120";

    public string Mail_Host
    {
        get { return mail_host; }
        set { mail_host = value; }
    }

    private int mail_port = 25;

    public int Mail_Port
    {
        get { return mail_port; }
        set { mail_port = value; }
    }

    //private string mail_from = "Reports@1point1.in";
    private string mail_from = "escalation@1point1.in";


    public string Mail_From
    {
        get { return mail_from; }
        set { mail_from = value; }
    }

    private string mail_userid = "escalation";

    public string Mail_UserId
    {
        get { return mail_userid; }
        set { mail_userid = value; }
    }

    private string mail_password = "opo@123";

    public string Mail_Password
    {
        get { return mail_password; }
        set { mail_password = value; }
    }
    #endregion

  

    public string sendMail( string InterviewrNam, string Mobile, string OTP , string EmailIDrValue)
    {

        try
        {
            SmtpClient smtpClient = new SmtpClient();
            //smtpClient.Host = "mail.onepointone.in";
            smtpClient.Host = this.Mail_Host;
            smtpClient.Port = this.Mail_Port;

            //smtpClient.Credentials = new System.Net.NetworkCredential("jflreports@1point1.in", "Report@321");
            smtpClient.Credentials = new System.Net.NetworkCredential(this.Mail_UserId, this.Mail_Password);
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            {
                return true;
            };
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            MailMessage mailMessage = new MailMessage();
  
            mailMessage.From = new MailAddress(this.Mail_From);

            mailMessage.To.Add(new MailAddress(EmailIDrValue));
       
            mailMessage.Subject = "Interview Assigned " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    
            string firstname = InterviewrNam;

            mailMessage.IsBodyHtml = true;
            string email_body_msg = "<html><body>Dear " + firstname + ",<br />" +
           
               "Mobile : " + Mobile + "<br /><br />" +

               "OTP : " + OTP + "<br /><br />" +
               "Thank You for contact OPO,<br />" +
             
               "Regards,<br />" +
               "Recruitment Team";

            string email_Rejectionbody_msg = "<html><body>Dear " + firstname + ",<br />" +


                   "" + OTP + "<br /><br />" +

              "Thank You for contact OPO,<br />" +

              "Regards,<br />" +
              "Recruitment Team";
          

            mailMessage.Body = email_body_msg;
            string EmailSendAsseesnmentLinik = $@"<html>
                            <body>
                                Dear {firstname},<br /><br />


                                Assesment  Link: {OTP}<br /><br />

                                Thank you for contacting OPO,<br />

                                Regards,<br />
                                Recruitment Team
                            </body>
                        </html>";

            mailMessage.Body = email_body_msg;
            if (OTP.Contains("Link"))
            {
                mailMessage.Body = EmailSendAsseesnmentLinik;

            }
            if (OTP.Contains("rejected"))
            {
                mailMessage.Body = email_Rejectionbody_msg;

            }
            try
            {
                smtpClient.Send(mailMessage);
                return "Message Sent";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        catch(Exception ex)
        {
            return "Message Sent";
        }
        return "Message Sent";
    }


    public string sendMailToCandidateinterview(string CandidateName  , string CandidateEmailID,string  InterviewStage, DateTime? Date,string MeetingLink)
    {

        try
        {
            SmtpClient smtpClient = new SmtpClient();
            //smtpClient.Host = "mail.onepointone.in";
            smtpClient.Host = this.Mail_Host;
            smtpClient.Port = this.Mail_Port;

            //smtpClient.Credentials = new System.Net.NetworkCredential("jflreports@1point1.in", "Report@321");
            smtpClient.Credentials = new System.Net.NetworkCredential(this.Mail_UserId, this.Mail_Password);
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            {
                return true;
            };
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            MailMessage mailMessage = new MailMessage();

            mailMessage.From = new MailAddress(this.Mail_From);

            mailMessage.To.Add(new MailAddress(CandidateEmailID));

            mailMessage.Subject = "Interview Assigned " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string firstname = CandidateName;
            

            mailMessage.IsBodyHtml = true;
            string email_body_msg = $@"<html>
                            <body>
                                Dear {firstname},<br /><br />

                                Interview arranged for: {Date}<br /><br />

                                Meeting Link: {MeetingLink}<br /><br />

                                Thank you for contacting OPO,<br />

                                Regards,<br />
                                Recruitment Team
                            </body>
                        </html>";

           

            try
            {
                smtpClient.Send(mailMessage);
                return "Message Sent";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        catch (Exception ex)
        {
            return "Message Sent";
        }
        return "Message Sent";
    }
}