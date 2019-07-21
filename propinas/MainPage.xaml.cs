using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace propinas
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


    private void BtnCalcular_OnClicked(object sender, EventArgs e)
        {
            var total = (decimal.Parse(txtTotal.Text));
            var propina = (int.Parse(txtPropina.Text));
            var noPersonas = (int.Parse(txtNoPersonas.Text));

            var totalPropina = ((total * propina) / 100);

            lblPropina.Detail = totalPropina.ToString("C");
            lblTotal.Detail = (totalPropina + total).ToString("C");
            lblPropinaPorPersona.Detail = (totalPropina / noPersonas).ToString("C");
            lblTotalPorPersona.Detail = ((total + totalPropina) / noPersonas).ToString("C");
        }

    }
}
