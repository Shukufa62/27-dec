using System;
namespace menutaskproject_pt._2
{
	public class User
	{
        private string _userName;
        private string _password;
        public User(string name, string password)
        {
            _userName = Username;
            _password = Password;
        }
        public string Username
        {
            get
            {
                return _userName;
            }
            set
            {
                if (IsUsername(value))
                {
                    _userName = value;
                }
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (_password.Length >= 8 && _password.Length <= 25)
                {
                    if (HasDigit(Password) && HasLower(Password) && HasUpper(Password))

                        _password = Password;
                }

            }
        }

        public bool HasDigit(string Strs)

        {


            for (int i = 0; i < Strs.Length; i++)
            {
                if (char.IsDigit(Strs[i]))
                {
                    return true;
                }

            }
            return false;


        }
        public bool HasUpper(string Strs)
        {
            for (int i = 0; i < Strs.Length; i++)
            {
                if (char.IsUpper(Strs[i]))
                {
                    return true;
                }

            }
            return false;


        }
        public bool HasLower(string Strs)
        {
            for (int i = 0; i < Strs.Length; i++)
            {
                if (char.IsLower(Strs[i]))
                {
                    return true;
                }

            }
            return false;

        }
        public bool IsUsername(string str)
        {
            if (_userName.Length >= 6 && _userName.Length <= 25)
                return true;
            else
            {
                return false;
            }

        }

        public string ShowInfo()
        {
            return $"FullName: {Username}- Password {Password}";
        }

    }
}

