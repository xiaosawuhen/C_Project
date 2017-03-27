using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using CCHtmlToXaml.Html;
using CCHtmlToXaml.Html.Types;
using HtmlAgilityPack;

namespace CCHtmlToXaml {
	public sealed class HtmlToXaml {
		private readonly List<IType> _htmlTypes = new List<IType>();
		private readonly List<string> _blockTagsWithNestedContent = new List<string> {
			"p", "div"
		};
		private readonly List<string> _inlineTagsWithNestedContent = new List<string> {
			"span", "nobr"
		};
		public HtmlToXaml() {
			var htmlType = typeof(IType);
			var htmlTypes = AppDomain.CurrentDomain.GetAssemblies()
				.SelectMany(a => a.GetTypes())
				.Where(c => htmlType.IsAssignableFrom(c) && !c.IsInterface);

			foreach (var type in htmlTypes) {
				_htmlTypes.Add(Activator.CreateInstance(type) as IType);
			}
		}

		// ReSharper disable once UnusedMember.Global
		public Paragraph GetParagraph(string htmlContent, Settings settings = null) {
			if (string.IsNullOrWhiteSpace(htmlContent)) return new Paragraph();

			if (settings == null) settings = DefaultSettings.Settings;

			var htmlDocument = new HtmlDocument();
			htmlDocument.LoadHtml(htmlContent);

			var paragraph = new Paragraph();
			foreach (var childNode in htmlDocument.DocumentNode.ChildNodes) {
				Convert(childNode, paragraph, settings);
			}
			return paragraph;
		}
		private void Convert(HtmlNode node, Paragraph paragraph, Settings settings) {
			var wasConverted = ConvertNested(_blockTagsWithNestedContent, node, paragraph, settings);
			if (wasConverted) paragraph.Inlines.Add(new LineBreak());

			ConvertNested(_inlineTagsWithNestedContent, node, paragraph, settings);

			foreach (var htmlType in _htmlTypes) {
				if (!htmlType.Tags.Contains(node.Name.ToLowerInvariant())) continue;
				htmlType.Convert(node, paragraph, settings);
			}
		}
		private bool ConvertNested(IEnumerable<string> tags, HtmlNode node, Paragraph paragraph, Settings settings) {
			if (!tags.Contains(node.Name.ToLowerInvariant())) return false;
			if (string.IsNullOrWhiteSpace(node.InnerHtml)) return false;

			foreach (var childNode in node.ChildNodes) {
				Convert(childNode, paragraph, settings);
			}
			return true;
		}
	}
}
