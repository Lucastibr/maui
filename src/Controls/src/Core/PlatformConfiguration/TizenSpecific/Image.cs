namespace Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific
{
	using Microsoft.Maui.Graphics;
	using FormsElement = Maui.Controls.Image;

	/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific/Image.xml" path="Type[@FullName='Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific.Image']/Docs/*" />
	public static class Image
	{
		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific/Image.xml" path="//Member[@MemberName='BlendColorProperty']/Docs/*" />
		public static readonly BindableProperty BlendColorProperty = BindableProperty.Create("BlendColor", typeof(Color), typeof(FormsElement), null);

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific/Image.xml" path="//Member[@MemberName='FileProperty']/Docs/*" />
		public static readonly BindableProperty FileProperty = BindableProperty.Create("File", typeof(string), typeof(FormsElement), default(string));

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific/Image.xml" path="//Member[@MemberName='GetBlendColor'][1]/Docs/*" />
		public static Color GetBlendColor(BindableObject element)
		{
			return (Color)element.GetValue(BlendColorProperty);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific/Image.xml" path="//Member[@MemberName='SetBlendColor'][1]/Docs/*" />
		public static void SetBlendColor(BindableObject element, Color color)
		{
			element.SetValue(BlendColorProperty, color);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific/Image.xml" path="//Member[@MemberName='GetBlendColor'][2]/Docs/*" />
		public static Color GetBlendColor(this IPlatformElementConfiguration<Tizen, FormsElement> config)
		{
			return GetBlendColor(config.Element);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific/Image.xml" path="//Member[@MemberName='SetBlendColor'][2]/Docs/*" />
		public static IPlatformElementConfiguration<Tizen, FormsElement> SetBlendColor(this IPlatformElementConfiguration<Tizen, FormsElement> config, Color color)
		{
			SetBlendColor(config.Element, color);
			return config;
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific/Image.xml" path="//Member[@MemberName='GetFile'][1]/Docs/*" />
		public static string GetFile(BindableObject element)
		{
			return (string)element.GetValue(FileProperty);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific/Image.xml" path="//Member[@MemberName='SetFile'][1]/Docs/*" />
		public static void SetFile(BindableObject element, string file)
		{
			element.SetValue(FileProperty, file);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific/Image.xml" path="//Member[@MemberName='GetFile'][2]/Docs/*" />
		public static string GetFile(this IPlatformElementConfiguration<Tizen, FormsElement> config)
		{
			return GetFile(config.Element);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific/Image.xml" path="//Member[@MemberName='SetFile'][2]/Docs/*" />
		public static IPlatformElementConfiguration<Tizen, FormsElement> SetFile(this IPlatformElementConfiguration<Tizen, FormsElement> config, string file)
		{
			SetFile(config.Element, file);
			return config;
		}
	}
}
