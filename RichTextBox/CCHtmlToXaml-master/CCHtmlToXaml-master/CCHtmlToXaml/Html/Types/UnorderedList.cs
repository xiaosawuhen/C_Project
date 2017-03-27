using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using HtmlAgilityPack;

namespace CCHtmlToXaml.Html.Types {
	public sealed class UnorderedList : IType {
		public IReadOnlyList<string> Tags {
			get {
				return new List<string> { "ul" };
			}
		}
		public void Convert(HtmlNode node, Paragraph paragraph, Settings settings) {
			var stackPanel = new StackPanel {
				Margin = new Thickness(25, 0, 0, 0)
			};

			foreach (var childNode in node.ChildNodes.Where(n => n.Name.Equals("li", StringComparison.InvariantCultureIgnoreCase))) {
				stackPanel.Children.Add(new TextBlock {
					Text = "• " + childNode.InnerText.CleanedFromTagsAndTrimmed(),
					TextWrapping = TextWrapping.Wrap
				});
			}

			paragraph.Inlines.Add(new InlineUIContainer {
				Child = stackPanel
			});
		}
	}
}
