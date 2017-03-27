using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using HtmlAgilityPack;

namespace CCHtmlToXaml.Html.Types {
	internal sealed class Header : IType {
		public IReadOnlyList<string> Tags {
			get {
				return new List<string> { "h1", "h2", "h3", "h4", "h5", "h6" };
			}
		}
		public void Convert(HtmlNode node, Paragraph paragraph, Settings settings) {
			paragraph.Inlines.Add(new Run {
				Text = node.InnerText.CleanedFromTagsAndTrimmed(),
				FontSize = CalculateSize(node, paragraph),
				FontWeight = FontWeights.Bold
			});
			paragraph.Inlines.Add(new LineBreak());
		}
		private static double CalculateSize(HtmlNode node, Paragraph paragraph) {
			var baseHeaderSize = paragraph.FontSize * 1.7;
			var paragraphNumber = int.Parse(node.Name.Substring(1, 1));

			return baseHeaderSize - (baseHeaderSize * paragraphNumber / 100);
		}
	}
}
