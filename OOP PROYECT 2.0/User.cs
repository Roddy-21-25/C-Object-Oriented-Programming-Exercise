using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROYECT_2._0
{
    public class User : ProductInventary
    {
        private string _name;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _email;
		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		private int _password;
		public int Password
		{
			get { return _password; }
			set { _password = value; }
		}

		private bool _access;
		public bool Access
		{
			get { return _access; }
			set { _access = value; }
		}

		public User()
		{
            Access = false;
			name = string.Empty;
			Email = string.Empty;
			Password = 0;
		}
	}
}
