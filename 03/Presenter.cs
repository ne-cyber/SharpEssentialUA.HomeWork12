using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;


namespace _03
{
    internal class Presenter
    {
        MainWindow mainWindow;
        DispatcherTimer timer;
        TimeSpan currentTime;
        
        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.timer = new DispatcherTimer();
            this.timer.Tick += Timer_Tick;
            this.timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            this.currentTime = new TimeSpan();


            this.mainWindow.start += MainWindow_start;
            this.mainWindow.stop += MainWindow_stop;
            this.mainWindow.clear += MainWindow_clear;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.currentTime = this.currentTime.Add(new TimeSpan(0, 0, 0, 0, 10));

            this.mainWindow.textBlock.Text = $"{this.currentTime.Minutes:D2}:{this.currentTime.Seconds:D2}:{this.currentTime.Milliseconds/10:D2}";
        }

        private void MainWindow_clear(object sender, EventArgs e)
        {
            this.currentTime = new TimeSpan();
        }

        private void MainWindow_stop(object sender, EventArgs e)
        {
            this.timer.Stop();
        }

        private void MainWindow_start(object sender, EventArgs e)
        {
            this.timer.Start();
        }
    }
}
