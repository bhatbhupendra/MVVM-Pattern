using MVVMPattern.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPattern.MVVM.ViewModels
{
	public class ConvertersViewModel
	{
		public Data Data { get; set; }
		public ConvertersViewModel()
		{
			Data = new Data
			{
				Married = "YES"
			};
		}
	}
}
