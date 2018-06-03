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
        public static string TextColor { get; private set; } = "Black";
        public static double Opacity{ get; private set; } = 0.2;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // オプション数をチェック
            if (e.Args.Length != 2) return;

            // テキストの色
            TextColor = e.Args[0];

            // テキストの透明度
            double ope;
            if(Double.TryParse(e.Args[1], out ope)) Opacity = ope;
        }
    }
}
