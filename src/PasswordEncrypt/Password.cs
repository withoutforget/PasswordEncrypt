namespace PasswordEncrypt
{
    class Password
    {
        public Password(string service, string login, string password, string comment)
        {
            this.service = service;
            this.login = login;
            this.password = password;
            this.comment = comment;
        }

        public string service { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string comment { get; set; }
    }
}
