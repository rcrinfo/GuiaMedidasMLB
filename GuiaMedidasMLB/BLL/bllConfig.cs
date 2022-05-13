using GuiaMedidasMLB.CORE;
using GuiaMedidasMLB.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaMedidasMLB.BLL
{
    public class bllConfig
    {
        public dtoConfigXML Get(string path_file)
        {
            var dto = new dtoConfigXML();
            var path = path_file;

            if (!File.Exists(path))
            {
                return dto;
            }

            var coreXml = new coreXML();

            dto.db_ip = coreXml.Ler(path, "/Config/BancoDados/ip");
            dto.db_nome = coreXml.Ler(path, "/Config/BancoDados/nomebanco");
            dto.db_autenticacao = Convert.ToInt64(coreXml.Ler(path, "/Config/BancoDados/autenticacao"));
            dto.tk_clientId = Convert.ToInt64(coreXml.Ler(path, "/Config/TokenML/clientId"));
            dto.tk_clientSecret = coreXml.Ler(path, "/Config/TokenML/clienteSecret");
            dto.tk_redirectUri = coreXml.Ler(path, "/Config/TokenML/redirectUri");
            dto.tk_refreshToken = coreXml.Ler(path, "/Config/TokenML/refreshToken");
            dto.tk_accessToken = coreXml.Ler(path, "/Config/TokenML/accessToken");
            dto.ml_listing_type_id = coreXml.Ler(path, "/Config/MercadoLivre/listing_type_id");
            dto.ml_estoque_maximo = Convert.ToDecimal(coreXml.Ler(path, "/Config/MercadoLivre/estoque_maximo"));
            dto.app_tempo_execucao_carga = Convert.ToInt32(coreXml.Ler(path, "/Config/Aplicativo/tempo_execucao_carga"));
            dto.app_tempo_execucao_pedido = Convert.ToInt32(coreXml.Ler(path, "/Config/Aplicativo/tempo_execucao_pedido"));

            dto.vendedor_id = coreXml.Ler(path, "/Config/ML_Vendedor/id");
            dto.vendedor_nickname = coreXml.Ler(path, "/Config/ML_Vendedor/nickname");
            dto.vendedor_registration_date = coreXml.Ler(path, "/Config/ML_Vendedor/registration_date");
            dto.vendedor_first_name = coreXml.Ler(path, "/Config/ML_Vendedor/first_name");
            dto.vendedor_last_name = coreXml.Ler(path, "/Config/ML_Vendedor/last_name");
            dto.vendedor_country_id = coreXml.Ler(path, "/Config/ML_Vendedor/country_id");
            dto.vendedor_email = coreXml.Ler(path, "/Config/ML_Vendedor/email");

            dto.codigo_doc = coreXml.Ler(path, "/Config/BancoDados/codigo_doc");
            dto.controle_pr_venda = Convert.ToInt32(coreXml.Ler(path, "/Config/BancoDados/controle_pr_venda") == "" ? "0" : coreXml.Ler(path, "/Config/BancoDados/controle_pr_venda"));

            dto.versao_categorias = Convert.ToInt32(coreXml.Ler(path, "/Config/Controle/versao_categorias") == "" ? "0" : coreXml.Ler(path, "/Config/Controle/versao_categorias"));

            dto.controle_sku = Convert.ToInt32(coreXml.Ler(path, "/Config/BancoDados/controle_sku") == "" ? "0" : coreXml.Ler(path, "/Config/BancoDados/controle_sku"));

            coreXml = null;

            return dto;
        }
    }
}
