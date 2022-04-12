﻿using Newtonsoft.Json;

namespace WCS.Models
{
    public class EmailSettings
    {
        private Crypto _crypto;

        public string Host { get; set; }

        public int Port { get; set; }

        public bool EnableSSL { get; set; }

        public bool UseDefaultCredentials { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        [JsonIgnore]
        public string DecryptedPassword
        {
            get
            {
                return _crypto.Decrypt(Password);
            }
        }

        public string SenderName { get; set; }

        public void EncryptPassword()
        {
            Password = _crypto.Encrypt(Password);
        }

        public EmailSettings() => _crypto = new Crypto();
    }
}
