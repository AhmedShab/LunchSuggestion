using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace LunchApp.Infrastructure
{
	public class ZomatoApi
	{
		private IConfigurationRoot _config;

		public ZomatoApi(IConfigurationRoot config)
		{
			_config = config;
		}

		public string GetResturantNameByCity(string city)
		{
			return $"{_config["Keys:Zomato"]}";
		}
	}
}
