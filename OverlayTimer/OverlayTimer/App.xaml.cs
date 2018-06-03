using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace OverlayTimer
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        public static string[] Args { get; private set; }
        public static string TextColor { get; private set; } = "#33000000";

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // オプション数をチェック
            if (e.Args.Length != 1) return;

            // テキストの色と不透明度(#AARRGGBB形式)
            TextColor = e.Args[0];
        }
    }
}
