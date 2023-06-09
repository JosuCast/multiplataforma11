using Semana11A2023.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana11A2023.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operacions : ContentPage
    {
        public Operacions()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelOperaciones();
        }
    }
}