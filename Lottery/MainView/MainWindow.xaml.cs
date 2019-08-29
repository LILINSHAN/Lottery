using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MainView
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        int choose = 0;
        bool start = true;
        Brush ColorOrange = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Orange"));
        Brush ColorLightGray = new SolidColorBrush((Color)ColorConverter.ConvertFromString("LightGray"));
        public MainWindow()
        {
            InitializeComponent();
            AllReset();

            Thread t1 = new Thread(new ThreadStart(GetLottery));
            t1.Start();
        }

        private void Button_Main_Click(object sender, RoutedEventArgs e)
        {
            Button_Main.IsEnabled = false;
            start = false;
        }

        private void GetLottery()
        {
            while (start)
            {
                Thread.Sleep(1);
            }
            new Thread(() =>
            {
                this.Dispatcher.Invoke(new Action(() =>
                {
                    Button_Main.Content = "选择中";
                }));
            }).Start();
            for (int i = 300; i > 0; i = i - 50)
            {
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T1(true);
                    }));
                }).Start();
                Thread.Sleep(i);
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T1(false);
                        T2(true);
                    }));
                }).Start();
                Thread.Sleep(i);
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T2(false);
                        T3(true);
                    }));
                }).Start();
                Thread.Sleep(i);
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T3(false);
                        T4(true);
                    }));
                }).Start();
                Thread.Sleep(i);
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T4(false);
                        T5(true);
                    }));
                }).Start();
                Thread.Sleep(i);
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T5(false);
                        T6(true);
                    }));
                }).Start();
                Thread.Sleep(i);
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T6(false);
                        T7(true);
                    }));
                }).Start();
                Thread.Sleep(i);
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T7(false);
                        T8(true);
                    }));
                }).Start();
                Thread.Sleep(i);
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T8(false);
                    }));
                }).Start();
            }
            for (int i = 50; i < 150; i = i + 25)
            {
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T1(true);
                    }));
                }).Start();
                Thread.Sleep(i);
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T1(false);
                        T2(true);
                    }));
                }).Start();
                Thread.Sleep(i);
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T2(false);
                        T3(true);
                    }));
                }).Start();
                Thread.Sleep(i);
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T3(false);
                        T4(true);
                    }));
                }).Start();
                Thread.Sleep(i);
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T4(false);
                        T5(true);
                    }));
                }).Start();
                Thread.Sleep(i);
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T5(false);
                        T6(true);
                    }));
                }).Start();
                Thread.Sleep(i);
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T6(false);
                        T7(true);
                    }));
                }).Start();
                Thread.Sleep(i);
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T7(false);
                        T8(true);
                    }));
                }).Start();
                Thread.Sleep(i);
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T8(false);
                    }));
                }).Start();
            }
            for (int i = 0; i < 16; i++)
            {
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T2(true);
                        T4(true);
                        T6(true);
                        T8(true);
                    }));
                }).Start();
                Thread.Sleep(100);
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        AllReset();
                    }));
                }).Start();
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        T1(true);
                        T3(true);
                        T5(true);
                        T7(true);
                    }));
                }).Start();
                Thread.Sleep(100);
                new Thread(() =>
                {
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        AllReset();
                    }));
                }).Start();
            }
            if (choose == 0)
            {
                Random rd = new Random();
                choose = rd.Next(1, 8);
            }
            switch (choose)
            {
                case 1:
                    new Thread(() =>
                    {
                        this.Dispatcher.Invoke(new Action(() =>
                        {
                            T1(true);
                        }));
                    }).Start();
                    break;
                case 2:
                    new Thread(() =>
                    {
                        this.Dispatcher.Invoke(new Action(() =>
                        {
                            T2(true);
                        }));
                    }).Start();
                    break;
                case 3:
                    new Thread(() =>
                    {
                        this.Dispatcher.Invoke(new Action(() =>
                        {
                            T3(true);
                        }));
                    }).Start();
                    break;
                case 4:
                    new Thread(() =>
                    {
                        this.Dispatcher.Invoke(new Action(() =>
                        {
                            T4(true);
                        }));
                    }).Start();
                    break;
                case 5:
                    new Thread(() =>
                    {
                        this.Dispatcher.Invoke(new Action(() =>
                        {
                            T5(true);
                        }));
                    }).Start();
                    break;
                case 6:
                    new Thread(() =>
                    {
                        this.Dispatcher.Invoke(new Action(() =>
                        {
                            T6(true);
                        }));
                    }).Start();
                    break;
                case 7:
                    new Thread(() =>
                    {
                        this.Dispatcher.Invoke(new Action(() =>
                        {
                            T7(true);
                        }));
                    }).Start();
                    break;
                case 8:
                    new Thread(() =>
                    {
                        this.Dispatcher.Invoke(new Action(() =>
                        {
                            T8(true);
                        }));
                    }).Start();
                    break;

            }
            new Thread(() =>
            {
                this.Dispatcher.Invoke(new Action(() =>
                {
                    Button_Main.Content = "选择完毕";
                }));
            }).Start();
        }

        private void AllReset()
        {
            TextBox_1.Background = ColorLightGray;
            TextBox_2.Background = ColorLightGray;
            TextBox_3.Background = ColorLightGray;
            TextBox_4.Background = ColorLightGray;
            TextBox_5.Background = ColorLightGray;
            TextBox_6.Background = ColorLightGray;
            TextBox_7.Background = ColorLightGray;
            TextBox_8.Background = ColorLightGray;
        }

        private void T1(bool b)
        {
            if (b)
            {
                TextBox_1.Background = ColorOrange;
            }
            else
            {
                TextBox_1.Background = ColorLightGray;
            }
        }

        private void T2(bool b)
        {
            if (b)
            {
                TextBox_2.Background = ColorOrange;
            }
            else
            {
                TextBox_2.Background = ColorLightGray;
            }
        }
        private void T3(bool b)
        {
            if (b)
            {
                TextBox_3.Background = ColorOrange;
            }
            else
            {
                TextBox_3.Background = ColorLightGray;
            }
        }
        private void T4(bool b)
        {
            if (b)
            {
                TextBox_4.Background = ColorOrange;
            }
            else
            {
                TextBox_4.Background = ColorLightGray;
            }
        }
        private void T5(bool b)
        {
            if (b)
            {
                TextBox_5.Background = ColorOrange;
            }
            else
            {
                TextBox_5.Background = ColorLightGray;
            }
        }
        private void T6(bool b)
        {
            if (b)
            {
                TextBox_6.Background = ColorOrange;
            }
            else
            {
                TextBox_6.Background = ColorLightGray;
            }
        }
        private void T7(bool b)
        {
            if (b)
            {
                TextBox_7.Background = ColorOrange;
            }
            else
            {
                TextBox_7.Background = ColorLightGray;
            }
        }
        private void T8(bool b)
        {
            if (b)
            {
                TextBox_8.Background = ColorOrange;
            }
            else
            {
                TextBox_8.Background = ColorLightGray;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Title = ConfigurationManager.AppSettings["Title"].ToString();
            TextBox_1.Text = ConfigurationManager.AppSettings["T1"].ToString();
            TextBox_2.Text = ConfigurationManager.AppSettings["T2"].ToString();
            TextBox_3.Text = ConfigurationManager.AppSettings["T3"].ToString();
            TextBox_4.Text = ConfigurationManager.AppSettings["T4"].ToString();
            TextBox_5.Text = ConfigurationManager.AppSettings["T5"].ToString();
            TextBox_6.Text = ConfigurationManager.AppSettings["T6"].ToString();
            TextBox_7.Text = ConfigurationManager.AppSettings["T7"].ToString();
            TextBox_8.Text = ConfigurationManager.AppSettings["T8"].ToString();
            choose = int.Parse(ConfigurationManager.AppSettings["Choose"].ToString());
        }
    }
}
