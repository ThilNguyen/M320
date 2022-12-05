namespace DependencyInjection
{
        public class User
        {
            private ICipher _cipherStrategy;
            public User(ICipher cipherStrategy, string username, string password)
            {
                _cipherStrategy = cipherStrategy;
                this.Username = username;
                this.password = password;
            }
            private string password;
            public string Username { get; set; }
            public string PasswordEncrypted
            {
                get
                {
                return _cipherStrategy.Encrypt(this.password);
                }
            }
        }

    
}
   
