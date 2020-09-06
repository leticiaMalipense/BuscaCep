using System;
using buscaCep.Servico.Modelo;
using System.Net;
using Newtonsoft.Json;

namespace buscaCep.Servico
{
    public class ServicoViaCep
    {
        private static String url = "https://viacep.com.br/ws/{0}/json/";

        public ServicoViaCep()
        {
        }

        public static Endereco BuscarEndereco(String cep)
        {
            String novaUrl = String.Format(url, cep);

            WebClient wc = new WebClient();

            String conteudo = wc.DownloadString(novaUrl);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(conteudo);

            return end;
        }
    }
}
