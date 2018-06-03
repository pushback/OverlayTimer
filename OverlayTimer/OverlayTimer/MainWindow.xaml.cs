using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace OverlayTimer
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : OverlayWindow
    {
        // 実行開始時間
        private DateTime startTime;

        public MainWindow()
        {
            InitializeComponent();

            // 開始時刻を記憶しておく
            startTime = DateTime.Now;

            // 時刻更新のタイマーを開始
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += OnTimerFire;
            timer.Interval = new TimeSpan(0, 0, 1); // 1秒周期
            timer.Start();
        }

        private void OnTimerFire(object sender, EventArgs e)
        {
            // 現在時刻を表示
            this.nowTime.Content = DateTime.Now.ToString("HH:mm:ss");
            // 実行時間を表示
            TimeSpan ts = DateTime.Now - startTime;
            this.execTime.Content = ts.ToString("hh\\:mm\\:ss");
        }
    }
}
