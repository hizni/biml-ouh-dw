using System.Collections.Generic;
using System.Linq;
using System.Text;
using Varigence.Biml.Extensions;
using System.Web;
using System.Net;

public static class XmlHelper
{
	
	public static string Capitalise(string inputString) {
		return inputString.ToUpper();
	}
	
	private static string Replacer(string s, string find, string replace)
	{
		return s.Replace(find, replace);
	}
}