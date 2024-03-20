using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MVVM.Model
{
	public class PageModel
	{
		public List<ProductModel> Products { get; set; }
		public ProductModel AddedProduct { get; set; }
	}
}
