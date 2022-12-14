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
            //animation.From = btn.Width;   //设置动画初始值
            //animation.To = btn.Width -30; //设置动画结束值
            animation.By  = btn.Width - 30;  //原来基础上减30
            animation.Duration = TimeSpan.FromSeconds(2);  //动画持续事件
            animation.RepeatBehavior = new RepeatBehavior(5); //执行五次结束
            animation.Completed += complete;


            //当前按钮执行动画 
            btn.BeginAnimation(Button.WidthProperty,animation);
        }

        private void complete(object sender,EventArgs e)
        {
            btn.Content = "动画已完成";
        }
    }
}
