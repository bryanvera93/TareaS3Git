using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TareaS3Git
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_ventana_dos_Clicked(System.Object sender, System.EventArgs e)
        {

            string user = txtuser.Text;
            string pass = txtpass.Text;

            if (txtuser.Text == "estudiante2020" && txtpass.Text == "uisrael2020") {
                await DisplayAlert("Bienvenido", "Datos correctos", "Aceptar");
            }


            else {
                await DisplayAlert("ERROR", "Datos incorrectos", "Aceptar");
                return;
            }

          



            await Navigation.PushAsync(new Venatana_dos(user, pass));
        }
    }
}
