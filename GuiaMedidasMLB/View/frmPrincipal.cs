using GuiaMedidasMLB.BLL;
using GuiaMedidasMLB.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GuiaMedidasMLB
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            if (!File.Exists(Application.StartupPath + @"\config.json"))
            {
                var dto = new dtoConfig();
                dto.path_file_config = null;

                var jsonConfig = JsonConvert.SerializeObject(dto, Newtonsoft.Json.Formatting.Indented);

                using (var tw = new StreamWriter(Application.StartupPath + @"\config.json", true))
                {
                    tw.WriteLine(jsonConfig);
                    tw.Close();
                }

                Environment.Exit(0);
            }
            else
            {
                var bll = new bllConfig();

                var json = File.ReadAllText(Application.StartupPath + @"\config.json");
                var dto = JsonConvert.DeserializeObject<dtoConfig>(json);

                if (dto.path_file_config == null)
                {
                    MessageBox.Show("Configure o arquivo [config.json] na pasta da aplicação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Environment.Exit(0);
                }

                VG.PathFileConfig = dto.path_file_config;

                var dto_config_xml = bll.Get(dto.path_file_config);
                VG.AccessToken = dto_config_xml.tk_accessToken;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {





            var body = new
            {
                seller_id = VG.IdClient,
                site_id = "MLB",
                domain_id = "SNEAKERS",
                attributes = new object[] {
                    new { id = "BRAND", values = new object[] { new { id = "150271" } } },
                    new { id = "GENDER", values = new object[] { new { name = "Mulher" } } }
                }
            };

            var clientt = new RestClient();
            var requesttt = new RestRequest($"https://api.mercadolibre.com/catalog/charts/search?access_token=" + VG.AccessToken, Method.Post)
                .AddHeader("Content-Type", "application/json")
                .AddJsonBody(body);

            var responserr = await clientt.ExecuteAsync(requesttt);


            ////Achar quais são as especificações de um dominio, e seus atributos
            //ps = new List<Parameter>();
            //response = VG.MercadoLivreAPI.Get($"domains/MLB-SNEAKERS/technical_specs", ps);


            ////Listar o catalogo
            //ps = new List<Parameter>();
            //ps.Add(new Parameter { Name = "access_token", Value = VG.AccessToken });


            //var responseVar = VG.MercadoLivreAPI.Post($"catalog/charts/search", ps, bodyy);

            //var json = JsonConvert.SerializeObject(responseVar.Content, Newtonsoft.Json.Formatting.Indented);
        }

        private async void btn_buscar_dominio_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDescritivoItem.Text))
            {
                MessageBox.Show("Informe o descritivo do item!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var request = new RestRequest($"https://api.mercadolibre.com/sites/MLB/domain_discovery/search?limit={numQuantidadeResultado.Value}&q={txtDescritivoItem.Text}");
            var client = new RestClient();
            var response = await client.GetAsync(request);
            var result = response.Content;

            var obj_result = JsonConvert.DeserializeObject<object>(result);

            // MessageBox.Show(result);

            dataGridDomain.DataSource = obj_result;
        }

        private async void dataGridDomain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dto = new dtoTechnical();
            List<dtoTechnical> obj = new List<dtoTechnical>();

            if (e.RowIndex == -1)
            {
                return;
            }

            var codigo_dominio = dataGridDomain.Rows[e.RowIndex].Cells[0].Value.ToString();

            var request = new RestRequest($"https://api.mercadolibre.com/domains/{codigo_dominio}/technical_specs");
            var client = new RestClient();
            var response = await client.GetAsync(request);
            var result = response.Content;

            var obj_result = JsonConvert.DeserializeObject<object>(result);
            dynamic objeto = JObject.Parse(result);

            foreach (dynamic spec in objeto.input.groups)
            {
                foreach (dynamic spec_components in spec.components)
                {
                    if (spec_components.component == "COMBO")
                    {
                        foreach (dynamic spec_attributes in spec_components.attributes)
                        {
                            if (spec_attributes.id == "BRAND")
                            {
                                dto = new dtoTechnical();
                                dto.id_technical = "0";
                                dto.description = "Marca";
                                obj.Add(dto);

                                foreach (dynamic spec_values in spec_attributes.values)
                                {
                                    var id = spec_values.id;
                                    var name = spec_values.name;

                                    dto = new dtoTechnical();
                                    dto.id_technical = id.ToString();
                                    dto.description = "   " + name.ToString();
                                    dto.type = "BRAND";
                                    obj.Add(dto);
                                }
                            }

                            if (spec_attributes.id == "GENDER")
                            {
                                dto = new dtoTechnical();
                                dto.id_technical = "1";
                                dto.description = "Gênero";
                                obj.Add(dto);

                                foreach (dynamic spec_values in spec_attributes.values)
                                {
                                    var id = spec_values.id;
                                    var name = spec_values.name;

                                    dto = new dtoTechnical();
                                    dto.id_technical = id.ToString();
                                    dto.description = "   " + name.ToString();
                                    dto.type = "GENDER";
                                    obj.Add(dto);
                                }
                            }

                            if (spec_attributes.id == "AGE_GROUP")
                            {
                                dto = new dtoTechnical();
                                dto.id_technical = "2";
                                dto.description = "Idade";
                                obj.Add(dto);

                                foreach (dynamic spec_values in spec_attributes.values)
                                {
                                    var id = spec_values.id;
                                    var name = spec_values.name;

                                    dto = new dtoTechnical();
                                    dto.id_technical = id.ToString();
                                    dto.description = "   " + name.ToString();
                                    dto.type = "AGE_GROUP";
                                    obj.Add(dto);
                                }
                            }


                            if (spec_attributes.id == "FABRIC_DESIGN")
                            {
                                dto = new dtoTechnical();
                                dto.id_technical = "3";
                                dto.description = "Desenho de Fabrica";
                                obj.Add(dto);

                                foreach (dynamic spec_values in spec_attributes.values)
                                {
                                    var id = spec_values.id;
                                    var name = spec_values.name;

                                    dto = new dtoTechnical();
                                    dto.id_technical = id.ToString();
                                    dto.description = "   " + name.ToString();
                                    dto.type = "FABRIC_DESIGN";
                                    obj.Add(dto);
                                }
                            }

                            if (spec_attributes.id == "SIZE")
                            {
                                dto = new dtoTechnical();
                                dto.id_technical = "4";
                                dto.description = "Tamanho";
                                obj.Add(dto);

                                foreach (dynamic spec_values in spec_attributes.values)
                                {
                                    var id = spec_values.id;
                                    var name = spec_values.name;

                                    dto = new dtoTechnical();
                                    dto.id_technical = id.ToString();
                                    dto.description = "   " + name.ToString();
                                    dto.type = "SIZE";
                                    obj.Add(dto);
                                }
                            }
                        }
                    }
                }
            }

            var col = new DataGridViewCheckBoxColumn();
            col.Name = "Coluna";
            col.HeaderText = "Selecionado";
            col.FalseValue = "1";
            col.TrueValue = "0";
            col.CellTemplate.Value = false;
            col.CellTemplate.Style.NullValue = true;

            dataGridEspecificacoes.Columns.Insert(0, col);
            dataGridEspecificacoes.DataSource = obj;
            dataGridEspecificacoes.Enabled = true;
            dataGridEspecificacoes.Columns[0].HeaderText = "Selecionado";
            dataGridEspecificacoes.Columns[1].HeaderText = "Código";
            dataGridEspecificacoes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridEspecificacoes.Columns[2].HeaderText = "Descrição";
            dataGridEspecificacoes.Columns[3].Visible = false;
            btnObterGuia.Enabled = true;

            foreach (DataGridViewRow dgvr in dataGridEspecificacoes.Rows)
            {
                if (int.Parse(dgvr.Cells[1].Value.ToString()) >= 0 && int.Parse(dgvr.Cells[1].Value.ToString()) <= 10)
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Blue;
                    dgvr.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
    }
}
