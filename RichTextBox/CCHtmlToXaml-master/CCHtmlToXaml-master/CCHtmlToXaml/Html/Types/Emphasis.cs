using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using HtmlAgilityPack;

namespace CCHtmlToXaml.Html.Types {
	internal sealed class Emphasis : IType {
		public IReadOnlyList<string> Tags {
			get {
				return new List<string> { "em", "i" };
			}
		}
		public void Convert(HtmlNode node, Paragraph paragraph, Settings settings) {
			paragraph.Inlines.Add(new Run {
				Text = node.InnerText.CleanedFromTags(),
				FontStyle = FontStyles.Italic
			});
		}
	}
}
