using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using HtmlAgilityPack;

namespace CCHtmlToXaml.Html.Types {
	internal sealed class Image : IType {
		public IReadOnlyList<string> Tags {
			get {
				return new List<string> { "img" };
			}
		}
		public void Convert(HtmlNode node, Paragraph paragraph, Settings settings) {
			var srcAttribute = node.Attributes["src"];
			if (srcAttribute == null) return;

			var image = new System.Windows.Controls.Image {
				Source = new BitmapImage(new Uri(settings.ImageUriPrefix + srcAttribute.Value, UriKind.RelativeOrAbsolute)),
				Stretch = Stretch.Uniform
			};

			var altAttribute = node.Attributes["alt"];
			if (altAttribute != null
				&& !string.IsNullOrEmpty(altAttribute.Value.CleanedFromTagsAndTrimmed())) 
				ToolTipService.SetToolTip(image, altAttribute);

			paragraph.Inlines.Add(new InlineUIContainer {
				Child = image
			});
		}
	}
}
