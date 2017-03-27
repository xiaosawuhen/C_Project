using System.Collections.Generic;
using System.Windows.Documents;
using HtmlAgilityPack;

namespace CCHtmlToXaml.Html.Types {
	internal sealed class Break : IType {
		public IReadOnlyList<string> Tags {
			get {
				return new List<string> { "br" };
			}
		}
		public void Convert(HtmlNode node, Paragraph paragraph, Settings settings) {
			paragraph.Inlines.Add(new LineBreak());
		}
	}
}
