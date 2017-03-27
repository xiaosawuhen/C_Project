using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;
using HtmlAgilityPack;

namespace CCHtmlToXaml.Html.Types {
	internal sealed class HorizontalRule : IType {
		public IReadOnlyList<string> Tags {
			get {
				return new List<string> { "hr" };
			}
		}
		public void Convert(HtmlNode node, Paragraph paragraph, Settings settings) {
			paragraph.Inlines.Add(new InlineUIContainer {
				Child = new Line {
					StrokeThickness = 2,
					Stroke = new SolidColorBrush(settings.BorderColor)
				}
			});
		}
	}
}
