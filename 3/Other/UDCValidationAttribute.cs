using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace _3.Other
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
	public class UDCValidationAttribute : ValidationAttribute
	{
		private const string UDCRegexPattern = @"^\d{3}\.\d{2}(\.\d{2})?$";

		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value != null)
			{
				string udc = value.ToString();

				if (!Regex.IsMatch(udc, UDCRegexPattern))
				{
					return new ValidationResult("Invalid UDC format. The format should be XXX.XX or XXX.XX.XX");
				}
			}

			return ValidationResult.Success;
		}
	}
}
