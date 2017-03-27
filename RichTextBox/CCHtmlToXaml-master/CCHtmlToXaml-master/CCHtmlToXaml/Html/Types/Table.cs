using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Documents;
using HtmlAgilityPack;

namespace CCHtmlToXaml.Html.Types {
	internal sealed class Table : IType {
		public IReadOnlyList<string> Tags {
			get {
				return new List<string> { "table" };
			}
		}
		public void Convert(HtmlNode node, Paragraph paragraph, Settings settings) {
			var rows = node.ChildNodes.Where(r => r.Name.Equals("tr", StringComparison.InvariantCultureIgnoreCase)).ToList();
			if (!rows.Any()) return;

			var columnsQuantity = GetColumns(rows.First()).Count;
			if (columnsQuantity == 0) return;

			var grid = new Grid();
			
			for (var i = 0; i < rows.Count; i++) grid.RowDefinitions.Add(new RowDefinition());
			for (var i = 0; i < columnsQuantity; i++) grid.ColumnDefinitions.Add(new ColumnDefinition());

			for (var rowIndex = 0; rowIndex < rows.Count; rowIndex++) {
				var columns = GetColumns(rows[rowIndex]);
					
				for (var columnIndex = 0; columnIndex < columns.Count; columnIndex++) {
					var textBlock = new TextBlock {
						Text = columns[columnIndex].InnerText.CleanedFromTagsAndTrimmed()
					};
					textBlock.SetValue(Grid.RowProperty, rowIndex);
					textBlock.SetValue(Grid.ColumnProperty, columnIndex);

					grid.Children.Add(textBlock);
				}
			}

			paragraph.Inlines.Add(new InlineUIContainer {
				Child = grid
			});
		}
		private static List<HtmlNode> GetColumns(HtmlNode row) {
			return row.ChildNodes.Where(c => c.Name.Equals("td", StringComparison.InvariantCultureIgnoreCase)).ToList();
		}
	}
}
