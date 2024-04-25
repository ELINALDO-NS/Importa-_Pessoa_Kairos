using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Importa__Pessoa_Kairos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                using (OpenFileDialog OpenFileDialog1 = new OpenFileDialog())
                {
                    OpenFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        LocalDoArquivo.Text = OpenFileDialog1.FileName;
                        return;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um Erro ao abrir o arquivo \r\n " + ex.Message);
            }
        }

        string SalvaPessoa_URL = "https://www.dimepkairos.com.br/RestServiceApi/People/SavePerson";

        public List<Pessoa> PreencheLista(string CaminhoTxt)
        {
            List<Pessoa> Pessoas = new List<Pessoa>();



            return Pessoas;
        }

        private void btn_Importar_Click(object sender, EventArgs e)
        {


            Parallel.ForEach(PreencheLista(LocalDoArquivo.Text), Pessoa =>
            {

                using (null)
                {


                    var client = new RestClient(SalvaPessoa_URL);
                    var request = new RestRequest("", Method.Post);
                    request.AddHeader("Content-Type", "application/json");
                    request.AddHeader("key", Chave.Text);
                    request.AddHeader("identifier", CNPJ.Text);
                    var JPessoa = JsonConvert.SerializeObject(Pessoa);
                    request.AddJsonBody(JPessoa);
                    request.AddParameter("application/json; charset=utf-8", JPessoa, ParameterType.RequestBody);

                    var response = client.Execute(request);
                    if (response.ContentType.Equals("application/json"))
                    {
                        var Resposta = JsonConvert.DeserializeObject<Resposta>(response.Content);
                        if (!Resposta.Sucesso)
                        {

                            Log.GravaLog("Salva Pessoa - " + Resposta.Mensagem + " - Matricula : " + Pessoa.Matricula + " - " + Pessoa.Nome);
                        }


                    }
                    else
                    {
                        Log.GravaLog("Salva Pessoa - " + response.Content + " - Matricula : " + Pessoa.Matricula + " - " + Pessoa.Nome);

                    }
                }
            });

        }
    }
}

