using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NUnit_Auto_2022.HomeworkFA.DataModels
{
	[XmlRoot(ElementName = "registration")]
	public class RegistrationDataModels
	{
		[XmlElement(ElementName = "username")]
		public string User { get; set; }

		[XmlElement(ElementName = "password")]
		public string Pass { get; set; }

		[XmlElement(ElementName = "confirmPass")]
		public string ConfirmPass { get; set; }

		[XmlElement(ElementName = "mr")]
		public bool Mr { get; set; }

		[XmlElement(ElementName = "mis")]
		public bool Mis { get; set; }

		[XmlElement(ElementName = "firstName")]
		public string FirstN { get; set; }

		[XmlElement(ElementName = "lastName")]
		public string LastN { get; set; }

		[XmlElement(ElementName = "email")]
		public string MyEmail { get; set; }

		[XmlElement(ElementName = "dateofbirth")]
		public string Date { get; set; }

		[XmlElement(ElementName = "nationality")]
		public string Nationality { get; set; }

		[XmlElement(ElementName = "terms")]
		public bool Terms { get; set; }

		[XmlElement(ElementName = "usernameError")]
		public string ExpectedUsernameErr { get; set; }

		[XmlElement(ElementName = "passwordError")]
		public string ExpectedPassErr { get; set; }

		[XmlElement(ElementName = "confirmPassError")]
		public string ExpectedConfirmPassErr { get; set; }

		[XmlElement(ElementName = "firstNameError")]
		public string ExpectedFirstNameErr { get; set; }

		[XmlElement(ElementName = "lastNameError")]
		public string ExpectedLastNameErr { get; set; }

		[XmlElement(ElementName = "emailError")]
		public string ExpectedEmailErr { get; set; }

		[XmlElement(ElementName = "termsError")]
		public string ExpectedTermsErr { get; set; }
	}
}

