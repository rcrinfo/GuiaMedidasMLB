using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaMedidasMLB.DTO
{
    public class dtoConfigXML
    {
        public string db_ip { get; set; }
        public string db_nome { get; set; }
        public long db_autenticacao { get; set; }
        public string tk_redirectUri { get; set; }
        public long tk_clientId { get; set; }
        public string tk_clientSecret { get; set; }
        public string tk_refreshToken { get; set; }
        public string tk_accessToken { get; set; }
        public string ml_listing_type_id { get; set; }
        public int app_tempo_execucao_carga { get; set; }
        public int app_tempo_execucao_pedido { get; set; }
        public decimal ml_estoque_maximo { get; set; }

        public string vendedor_id { get; set; }
        public string vendedor_nickname { get; set; }
        public string vendedor_registration_date { get; set; }
        public string vendedor_first_name { get; set; }
        public string vendedor_last_name { get; set; }
        public string vendedor_country_id { get; set; }
        public string vendedor_email { get; set; }

        public string codigo_doc { get; set; }
        public int controle_pr_venda { get; set; }
        public int versao_categorias { get; set; }
        public int controle_sku { get; set; }
    }
}
