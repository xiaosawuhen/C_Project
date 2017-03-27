namespace CCHtmlToXaml.Html {
	internal static class Extensions {
		public static string CleanedFromTagsAndTrimmed(this string value) {
			return value
				.CleanedFromTags()
				.Trim();
		}
		public static string CleanedFromTags(this string value) {
			return value
				.Replace("&", "&amp;")
				.Replace("\"", "&quot;")
				.Replace("'", "`")
				.Replace("\n", "")
				.Replace("\r", "")
				.Replace("  ", "");
		}
	}
}
