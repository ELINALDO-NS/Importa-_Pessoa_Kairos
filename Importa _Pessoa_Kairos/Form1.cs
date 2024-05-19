using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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

        public async Task<List<Pessoa>> PreencheLista(string CaminhoTxt)
        {
            List<Pessoa> Pessoas = new List<Pessoa>();
            Pessoas.Clear();
            using (StreamReader reader = new StreamReader(LocalDoArquivo.Text))
            {

                for (int i = 0; i < 3000; i++)
                {

                    string linha = reader.ReadLine();
                    if (linha != null)
                    {

                        var Matricula = linha.Substring(9, 11);
                        string PIS = linha.Substring(21, 11);
                        string Nome = linha.Substring(45, 51);
                        Pessoas.Add(new Pessoa
                        {
                            Matricula = Matricula,
                            Cracha = Matricula,
                            CPF = Matricula,
                            PIS = PIS,
                            Nome = Nome

                        });
                    }

                }
                LBL_Progresso.Invoke(new MethodInvoker(delegate { LBL_Progresso.Text = $"0/{Pessoas.Count}"; }));
            }




            return Pessoas;
        }

        private async void btn_Importar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(LocalDoArquivo.Text) || string.IsNullOrEmpty(CPF.Text) || string.IsNullOrEmpty(Chave.Text))
                {
                    MessageBox.Show("Os Campos: Local do arquivo, CPF e CHAVE, não podem estar Vazios", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                btn_Importar.Invoke(new MethodInvoker(delegate { btn_Importar.Enabled = false; }));

                var pessoas = await PreencheLista(LocalDoArquivo.Text);
                int progresso = 0;
                using (null)
                {
                    Parallel.ForEach(pessoas, Pessoa =>
                    {
                        LBL_Progresso.Invoke(new MethodInvoker(delegate { LBL_Progresso.Text = $"{progresso}/{pessoas.Count}"; }));

                        #region Insere dados

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
                        #endregion
                        progresso++;

                    });
                    LBL_Progresso.Invoke(new MethodInvoker(delegate { LBL_Progresso.Text = $"{pessoas.Count}/{pessoas.Count}"; }));

                }

                btn_Importar.Invoke(new MethodInvoker(delegate { btn_Importar.Enabled = true; }));
                MessageBox.Show("Pessoas importadas com sucesso !");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


    }
}

