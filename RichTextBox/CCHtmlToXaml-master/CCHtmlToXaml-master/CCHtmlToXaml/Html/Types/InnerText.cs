using System.Collections.Generic;
using System.Windows.Documents;
using HtmlAgilityPack;

namespace CCHtmlToXaml.Html.Types {
	internal sealed class InnerText : IType {
		public IReadOnlyList<string> Tags {
			get {
				return new List<string> { "#text" };
			}
		}
		public void Convert(HtmlNode node, Paragraph paragraph, Settings settings) {
			var text = node.InnerText.CleanedFromTags();
			if(string.IsNullOrWhiteSpace(text.Trim())) return;

			paragraph.Inlines.Add(new Run {
				Text = text
			});
		}
	}
}
