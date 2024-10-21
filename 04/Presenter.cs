using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Presenter
    {
        MainWindow mainWindow;
        Model model;
        public Presenter(MainWindow mainWindow)
        {
            model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.addEvent += MainWindow_addEvent;
            this.mainWindow.subEvent += MainWindow_subEvent;
            this.mainWindow.mulEvent += MainWindow_mulEvent;
            this.mainWindow.divEvent += MainWindow_divEvent;

            this.mainWindow.divisionByZeroEvent += MainWindow_divisionByZeroEvent;
        }

        private void MainWindow_divisionByZeroEvent(object sender, EventArgs e)
        {
            mainWindow.Result.Text = "Спроба поділу на нуль!";
        }

        private void MainWindow_divEvent(object sender, EventArgs e)
        {
            double a = double.Parse(mainWindow.a.Text);
            double b = double.Parse(mainWindow.b.Text);

            mainWindow.Result.Text = model.Div(a,b).ToString();
        }

        private void MainWindow_mulEvent(object sender, EventArgs e)
        {
            double a = double.Parse(mainWindow.a.Text);
            double b = double.Parse(mainWindow.b.Text);

            mainWindow.Result.Text = model.Mul(a, b).ToString();
        }

        private void MainWindow_subEvent(object sender, EventArgs e)
        {
            double a = double.Parse(mainWindow.a.Text);
            double b = double.Parse(mainWindow.b.Text);

            mainWindow.Result.Text = model.Sub(a, b).ToString();
        }

        private void MainWindow_addEvent(object sender, EventArgs e)
        {
            double a = double.Parse(mainWindow.a.Text);
            double b = double.Parse(mainWindow.b.Text);

            mainWindow.Result.Text = model.Add(a, b).ToString();
        }
    }
}
