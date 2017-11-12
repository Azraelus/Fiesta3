using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Fiesta3
{
    public class CatalogoCarnes : ContentPage
    {
        public CatalogoCarnes(string tipocarne)
        {
            //var picker = new Picker { Title = "Escoja una carne" };
            //var listacarnes = new List<string>();
            //listacarnes.Add("Res - Filete");
            //listacarnes.Add("Res - Palanca");
            //listacarnes.Add("Res - Punta Picana");
            //picker.ItemsSource = listacarnes;
            //tipocarne = Convert.ToString(picker.SelectedItem);

            var labelcarne = new Label { HorizontalOptions = LayoutOptions.Center, Text = tipocarne, FontSize = 24 };
            var labelusocarne = new Label { FontAttributes = FontAttributes.Italic, HorizontalOptions = LayoutOptions.Center };
            var imagencarne = new Image { HeightRequest = 200, WidthRequest = 200, HorizontalOptions = LayoutOptions.CenterAndExpand };
            var labeldescripcioncarne = new Label();
            var botonvolver = new Button { Text = "Volver" };
            botonvolver.Clicked += Botonvolver_Clicked;

            switch (tipocarne)
            {
                case "Res - Palanca":
                    labelusocarne.Text = "Parrila";
                    imagencarne.Source = "https://static.wixstatic.com/media/4b5e13_5a9e475d3fbc45ebbe78275b4f9d09aa.jpg/v1/fill/w_279,h_323,al_c,q_80,usm_0.66_1.00_0.01/4b5e13_5a9e475d3fbc45ebbe78275b4f9d09aa.webp";
                    labeldescripcioncarne.Text = "Esta es mi carne favorita, tiene la wuea la cosa y todo el resto y blablablabalbalblabalb laksbdlakbsd laks dlaksd alks dalskd alksd alskd alskd alskd alsk daslkd ";
                    break;
                case "Res - Filete":
                    labelusocarne.Text = "Parrila";
                    imagencarne.Source = "http://goplek.com/cms-data/files/a51e4855156cc9.jpg";
                    labeldescripcioncarne.Text = "El filete es uno de los mejores cortes que hay y viene del solomillo y bla bla bla";
                    break;
                case "Res - Punta Picana":
                    labelusocarne.Text = "Parrila";
                    imagencarne.Source = "https://static.wixstatic.com/media/4b5e13_8a54be316ca140238ce583873059540d.jpg/v1/fill/w_338,h_200,al_c,q_80,usm_0.66_1.00_0.01/4b5e13_8a54be316ca140238ce583873059540d.webp";
                    labeldescripcioncarne.Text = "Esta es una carne muy rica que aprendí a cocinar hace poco";
                    break;
                default:
                    DisplayAlert("Ninguna!", tipocarne, "Ok1");
                    break;
            }

            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Children = {
                        new Label { Text = "Carnes", FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center },
                        //picker,
                        labelcarne,
                        labelusocarne,
                        imagencarne,
                        labeldescripcioncarne,
                        botonvolver
                    }
                }
            };
        }
        private void Botonvolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

    }
}