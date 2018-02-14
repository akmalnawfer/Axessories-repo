using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Messenger
{
    class MesgaeBuilder
    {
        private static MailMessage mailMessage;
        private static SmtpClient smtpClient;

        public string Subject { get; set; }

        public string Body { get; set; }

        public string From { get; set; }

        public string To { get; set; }
        public List<string> ToMany { get; set; }

        public bool IsNewCustomer { get; set; }
    }

}
