using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using HtmlAgilityPack;

namespace CCHtmlToXaml.Html.Types {
	internal sealed class OrderedList : IType {
		public IReadOnlyList<string> Tags {
			get {
				return new List<string> { "ol" };
			}
		}
		public void Convert(HtmlNode node, Paragraph paragraph, Settings settings) {
			var stackPanel = new StackPanel {
				Margin = new Thickness(25, 0, 0, 0)
			};

			var childNodes = node.ChildNodes.Where(n => n.Name.Equals("li", StringComparison.InvariantCultureIgnoreCase)).ToList();
			var childNodesQuantity = childNodes.Count();

			for (var i = 0; i < childNodesQuantity; i++) {
				stackPanel.Children.Add(new TextBlock {
					Text = i + ". " + childNodes[i].InnerText.CleanedFromTagsAndTrimmed(),
					TextWrapping = TextWrapping.Wrap
				});
			}

			paragraph.Inlines.Add(new InlineUIContainer {
				Child = stackPanel
			});
		}
	}
}
