﻿using System;
using System.Globalization;
using System.Xml;

namespace MagentoAccess.Misc
{
	public static class Extensions
	{
		public static string ToStringUtcIso8601( this DateTime dateTime )
		{
			var universalTime = dateTime.ToUniversalTime();
			var result = XmlConvert.ToString( universalTime, XmlDateTimeSerializationMode.RoundtripKind );
			return result;
		}

		public static decimal ToDecimalDotOrComaSeparated( this string srcString )
		{
			decimal parsedNumber;

			if( string.IsNullOrWhiteSpace( srcString ) )
				return default( decimal );

			try
			{
				parsedNumber = decimal.Parse( srcString, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture );
			}
			catch( Exception )
			{
				parsedNumber = decimal.Parse( srcString, new NumberFormatInfo { NumberDecimalSeparator = "," } );
			}

			return parsedNumber;
		}
	}
}