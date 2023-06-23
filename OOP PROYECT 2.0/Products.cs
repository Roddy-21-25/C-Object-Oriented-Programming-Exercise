using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROYECT_2._0
{
    public class Products
    {
		private string _name;
		public string name
		{
			get { return _name; }
			set { _name = value; }
		}

		private int _id;
		public int id
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _description;
		public string description
		{
			get { return _description; }
			set { _description = value; }
		}

		private string _category;
		public string category
		{
			get { return _category; }
			set { _category = value; }
		}

		public Products()
		{
			name = string.Empty;
			id = 1;
			description = string.Empty;
			category = string.Empty;
		}

		
    }
}
