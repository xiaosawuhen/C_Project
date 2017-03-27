using System;
using System.Collections.Generic;
using System.Windows.Documents;
using HtmlAgilityPack;

namespace CCHtmlToXaml.Html.Types {
	internal sealed class Anchor : IType {
		public IReadOnlyList<string> Tags {
			get {
				return new List<string> { "a" };
			}
		}
		public void Convert(HtmlNode node, Paragraph paragraph, Settings settings) {
			if (string.IsNullOrWhiteSpace(node.InnerText)) return;

			var hrefAttribute = node.Attributes["href"];
			if (hrefAttribute == null) return;

			paragraph.Inlines.Add(new Hyperlink {
				NavigateUri = new Uri(hrefAttribute.Value, UriKind.RelativeOrAbsolute),
				Inlines = { new Run { Text = node.InnerText.CleanedFromTags() } },
				TargetName = "_blank"
			});
		}
	}
}
