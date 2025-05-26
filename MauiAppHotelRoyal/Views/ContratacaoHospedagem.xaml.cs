using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotelRoyal.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        public ContratacaoHospedagem()
        {
            InitializeComponent();
        }

        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime novaData = e.NewDate;
            Console.WriteLine($"Data de check-in selecionada: {novaData:dd/MM/yyyy}");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new HospedagemContratada());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void OnSobreClicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Sobre"
        }
    }
}
