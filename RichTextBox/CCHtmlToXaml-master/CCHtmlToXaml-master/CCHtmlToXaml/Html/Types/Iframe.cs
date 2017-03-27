using System;
using System.Collections.Generic;
using System.Windows.Documents;
using HtmlAgilityPack;

namespace CCHtmlToXaml.Html.Types {
	internal sealed class Iframe : IType {
		public IReadOnlyList<string> Tags {
			get {
				return new List<string> { "iframe" };
			}
		}
		public void Convert(HtmlNode node, Paragraph paragraph, Settings settings) {
			var hrefAttribute = node.Attributes["href"];
			if (hrefAttribute == null) return;

			paragraph.Inlines.Add(new Hyperlink {
				NavigateUri = new Uri(hrefAttribute.Value, UriKind.RelativeOrAbsolute),
				Inlines = { new Run { Text = GetText(node) } },
				TargetName = "_blank"
			});
		}
		private string GetText(HtmlNode node) {
			var titleAttribute = node.Attributes["title"];
			
			if (titleAttribute != null
				&& !string.IsNullOrWhiteSpace(titleAttribute.Value)) return titleAttribute.Value.CleanedFromTagsAndTrimmed();

			foreach (var childNode in node.ChildNodes) {
				var text = GetTextFromChildNode(childNode);
				if (!string.IsNullOrWhiteSpace(text)) return text.CleanedFromTagsAndTrimmed();
			}

			return "Встроенное содержимое";
		}
		private string GetTextFromChildNode(HtmlNode node) {
			foreach (var childNode in node.ChildNodes) {
				return GetTextFromChildNode(childNode);
			}
			return node.InnerText;
		}
	}
}
