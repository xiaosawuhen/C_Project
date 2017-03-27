using System.Collections.Generic;
using System.Windows.Documents;
using HtmlAgilityPack;

namespace CCHtmlToXaml.Html.Types {
	internal interface IType  {
		IReadOnlyList<string> Tags { get; }
		void Convert(HtmlNode node, Paragraph paragraph, Settings settings);
	}
}
