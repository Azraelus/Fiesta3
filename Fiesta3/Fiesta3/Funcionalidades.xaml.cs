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
    public partial class Funcionalidades : ContentPage
    {
        int numcarnes = 0;
        int numverduras = 0;
        public Funcionalidades()
        {
            InitializeComponent();
        }
        void crear_Clicked(object sender, EventArgs e)
        {
            numcarnes = numcarnes + 1;
            numverduras = numverduras + 1;
            if (numcarnes <= 3)
            {
                //var pickercarnes = new Picker { Title = "Escoje la carne" };
                //pickercarnes.SetBinding(Picker.ItemsSourceProperty, "Carnes");
                //pickercarnes.SetBinding(Picker.SelectedItemProperty, "SelectedCarne");
                //pickercarnes.ItemDisplayBinding = new Binding("Nombre");
                //BindingContext = new CarnesPageViewModel();

                //var nameLabel = new Label { HorizontalOptions = LayoutOptions.Center };
                //nameLabel.SetBinding(Label.TextProperty, "SelectedCarne.Nombre");
                //nameLabel.SetDynamicResource(VisualElement.StyleProperty, "TitleStyle");

                var pickercarnes = new Picker { Title = "Escoje la carne" };
                var listacarnes = new List<string>();
                listacarnes.Add("Res - Filete");
                listacarnes.Add("Res - Palanca");
                listacarnes.Add("Res - Punta Picana");
                pickercarnes.ItemsSource = listacarnes;

                //var carnelabel1 = new Label();
                //carnelabel1.SetBinding(Label.TextProperty, new Binding("Text", source: pickercarnes));

                var botonmas = new Button { Text = "+ Info" };
                botonmas.Clicked += botonmas_Clicked;

                void botonmas_Clicked(object sender2, EventArgs e2)
                {
                   Navigation.PushModalAsync(new CatalogoCarnes(Convert.ToString(pickercarnes.SelectedItem)));
                }

                this.Content = layout;
                layout.Children.Add(pickercarnes);
                //layout.Children.Add(nameLabel);
                //layout.Children.Add(carnelabel1);
                layout.Children.Add(botonmas);
            }
            else
            {
                DisplayAlert("Lo sentimos!", "No puedes agregar más de 3 carnes!", "Ok");
            }
        }
    }
}