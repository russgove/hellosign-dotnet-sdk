﻿using System.Collections.Generic;

namespace HelloSign
{
    public class Account
    {
        public enum RoleCode
        {
            ADMIN = 'A',
            MEMBER = 'M',
        }

        public string AccountId { get; set; }
        public string EmailAddress { get; set; }
        public bool IsPaidHs { get; set; }
        public bool IsPaidHf { get; set; }
        public string CallbackUrl { get; set; }
        public Dictionary<string, int> Quotas { get; set; }
    }
}