using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TareaS3Git
{
    public partial class Venatana_dos : ContentPage
    {
        public Venatana_dos(string user, string pass)
        {
            InitializeComponent();

           lbluser.Text = user;
        }

        void btnSumar_Clicked(System.Object sender, System.EventArgs e)
        {

            //try catch
            try
            {
                double seguimiento1 = Convert.ToDouble(txtSeg1.Text);
                double examen1 = Convert.ToDouble(txtExa1.Text);

                //Resultado

                double parcial1 = (seguimiento1 * 0.3) + (examen1 * 0.2);
                txtParcial1.Text = parcial1.ToString();


            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta", "ERROR" + ex.Message, "Ok");

            }
        }

        void btnSumar2_Clicked(System.Object sender, System.EventArgs e)
        {

            //try catch
            try
            {
                double seguimiento2 = Convert.ToDouble(txtSeg2.Text);
                double examen2 = Convert.ToDouble(txtExa2.Text);

                //Resultado

                double parcial2 = (seguimiento2 * 0.3) + (examen2 * 0.2);
                txtParcial2.Text = parcial2.ToString();



            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta", "ERROR" + ex.Message, "Ok");

            }
        }

        void btnNotafin_Clicked(System.Object sender, System.EventArgs e)
        {

            //try catch
            try
            {


                //Resultado

                double parcial1 = Convert.ToDouble(txtParcial1.Text);
                double parcial2 = Convert.ToDouble(txtParcial2.Text);


                double notaFinal = parcial1 + parcial2;
                txtNotafin.Text = notaFinal.ToString();



            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta", "ERROR" + ex.Message, "Ok");

            }
        }
    }
}