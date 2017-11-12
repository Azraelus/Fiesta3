using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fiesta3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new NuevoCarrete());
        }

        private void consultarcarrete_Clicked(object sender, EventArgs e)
        {

        }

        async public void catalogocarnes_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new CatalogoCarnes());
        }

        async private void funcionalidades_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Funcionalidades());
        }
    }
}