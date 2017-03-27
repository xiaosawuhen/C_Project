using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using HtmlAgilityPack;

namespace CCHtmlToXaml.Html.Types {
	internal sealed class DefinitionList : IType {
		public IReadOnlyList<string> Tags {
			get {
				return new List<string> { "dl" };
			}
		}
		public void Convert(HtmlNode node, Paragraph paragraph, Settings settings) {
			var stackPanel = new StackPanel();

			foreach (var childNode in node.ChildNodes) {
				var textBlock = new TextBlock {
					Text = childNode.InnerText.CleanedFromTagsAndTrimmed(),
					FontStyle = FontStyles.Italic
				};
				if (childNode.Name.Equals("dt", StringComparison.InvariantCultureIgnoreCase)) {
					textBlock.Margin = new Thickness(15, 0, 0, 0);
				}
				if (childNode.Name.Equals("dd", StringComparison.InvariantCultureIgnoreCase)) {
					textBlock.Margin = new Thickness(25, 0, 0, 0);
				}
				stackPanel.Children.Add(textBlock);
			}

			paragraph.Inlines.Add(new InlineUIContainer {
				Child = stackPanel
			});
		}
	}
}
