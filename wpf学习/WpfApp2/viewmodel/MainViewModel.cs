using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.view;

namespace WpfApp2.viewmodel
{

    public class MainViewModel:BindableBase
    {
        public DelegateCommand<string> OpenCommand { get; private set; }

        public MainViewModel()
        {
            OpenCommand = new DelegateCommand<string>(Open);
        }

        public Object body;

        public Object Body
        {
            get { return body; }

            set { body = value;RaisePropertyChanged(); }
        }

        public void Open (string obj)
        {
            switch (obj)
            {
                case "Page1":Body = new Page1(); break;
            }
        }
    }
}
