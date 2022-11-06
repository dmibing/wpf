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
using System.Windows.Annotations;
using System.Windows.Media.Animation;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           DoubleAnimation  animation = new DoubleAnimation();
            animation.From = btn.Width;   //设置动画初始值
            animation.To = btn.Width -30; //设置动画结束值
            animation.Duration = TimeSpan.FromSeconds(2);  //动画持续事件


            //当前按钮执行动画 
            btn.BeginAnimation(Button.WidthProperty,animation);
        }
    }
}
