﻿using System;

namespace SingleResponsibilityPrinciple.Example3
{
    public class SmtpMailService : IEmailService
    {
        public void SendEmail(string receiverEmail)
        {
            throw new NotImplementedException();
        }
    }
}
