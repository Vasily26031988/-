using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;
using System.Globalization;
using System.Windows.Markup;

namespace Органайзер
{
	/// <summary>
	/// Логика взаимодействия для App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			var cultureinfo = new CultureInfo("ru-RU");
			Thread.CurrentThread.CurrentCulture = cultureinfo;
			Thread.CurrentThread.CurrentUICulture = cultureinfo;
			CultureInfo.DefaultThreadCurrentCulture = cultureinfo;
			CultureInfo.DefaultThreadCurrentUICulture = cultureinfo;
			FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));
			base.OnStartup(e);
		}
	}
}
