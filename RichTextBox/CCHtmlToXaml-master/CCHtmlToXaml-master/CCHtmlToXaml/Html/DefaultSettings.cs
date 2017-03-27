using System.Windows.Media;

namespace CCHtmlToXaml.Html {
	public static class DefaultSettings {
		public static Settings Settings {
			get {
				return new Settings {
					BorderColor = new Color { A = 255, R = 128, B = 128, G = 128 },
					ImageUriPrefix = string.Empty
				};
			}
		}
	}
}
