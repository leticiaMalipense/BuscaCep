using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using buscaCep.Servico;
using buscaCep.Servico.Modelo;

namespace buscaCep
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BuscarCep(object sender, EventArgs args)
        {
            String auxiliar = CEP.Text.Trim();

            Endereco end = ServicoViaCep.BuscarEndereco(auxiliar); 

            Resultado.Text = String.Format("Endereço: {0}, de {1}, {2} - {3}",
                                    end.logradouro, end.bairro, end.localidade, end.uf); 

            CEP.Text = "";
        }
    }
}
