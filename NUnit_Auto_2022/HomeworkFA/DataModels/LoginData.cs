using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NUnit_Auto_2022.HomeworkFA.DataModels
{
	[XmlRoot(ElementName = "login")]

	public class LoginData
	{

		[XmlElement(ElementName = "username")]
		public string User { get; set; }

		[XmlElement(ElementName = "password")]
		public string Pass { get; set; }

	}	
}
