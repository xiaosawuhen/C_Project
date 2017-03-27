using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using HtmlAgilityPack;

namespace CCHtmlToXaml.Html.Types {
	internal sealed class BlockQuote : IType {
		public IReadOnlyList<string> Tags {
			get {
				return new List<string> { "blockquote" };
			}
		}
		public void Convert(HtmlNode node, Paragraph paragraph, Settings settings) {
			paragraph.Inlines.Add(new InlineUIContainer {
				Child = new Border {
					BorderBrush = new SolidColorBrush(settings.BorderColor),
					BorderThickness = new Thickness(4, 0, 0, 0),
					Margin = new Thickness(6, 0, 0, 0),
					HorizontalAlignment = HorizontalAlignment.Left,

					Child = new TextBlock {
						Margin = new Thickness(12, 0, 0, 0),
						TextWrapping = TextWrapping.Wrap,
						FontStyle = FontStyles.Italic,
						Text = node.InnerText.CleanedFromTagsAndTrimmed()
					}
				}
			});
		}
	}
}
