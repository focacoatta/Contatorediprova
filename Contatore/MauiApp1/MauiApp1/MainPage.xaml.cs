using System;
using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        private int contatore = 0;

        public MainPage()
        {
            InitializeComponent();


            AggiornaVisibilitaImmagini();
        }

        private void AggiornaVisibilitaImmagini()
        {
            for (int i = 0; i <= 9; i++)
            {
                NascondiImmagine(i);
            }

            MostraImmagine(contatore);
        }

        private void NascondiImmagine(int numero)
        {
            string nomeImmagine = $"{numero}4";
            Image immagine = this.FindByName<Image>(nomeImmagine);

            if (immagine != null)
            {
                immagine.IsVisible = false;
            }
        }

        private void MostraImmagine(int numero)
        {
            string nomeImmagine = $"{numero}4";
            Image immagine = this.FindByName<Image>(nomeImmagine);

            if (immagine != null)
            {
                immagine.IsVisible = true;
            }
        }

        private void OnContatorediProvaClicked(object sender, EventArgs e)
        {
            contatore = (contatore + 1) % 10;
            AggiornaVisibilitaImmagini();
        }
    }
}