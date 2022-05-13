namespace GuiaMedidasMLB
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridEspecificacoes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridDomain = new System.Windows.Forms.DataGridView();
            this.domain_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domain_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescritivoItem = new System.Windows.Forms.TextBox();
            this.btn_buscar_dominio = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numQuantidadeResultado = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObterGuia = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspecificacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDomain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 606);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btnObterGuia);
            this.panel2.Controls.Add(this.dataGridEspecificacoes);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridDomain);
            this.panel2.Controls.Add(this.txtDescritivoItem);
            this.panel2.Controls.Add(this.btn_buscar_dominio);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numQuantidadeResultado);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 582);
            this.panel2.TabIndex = 0;
            // 
            // dataGridEspecificacoes
            // 
            this.dataGridEspecificacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEspecificacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridEspecificacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEspecificacoes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridEspecificacoes.Enabled = false;
            this.dataGridEspecificacoes.Location = new System.Drawing.Point(595, 14);
            this.dataGridEspecificacoes.Name = "dataGridEspecificacoes";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEspecificacoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridEspecificacoes.RowHeadersVisible = false;
            this.dataGridEspecificacoes.Size = new System.Drawing.Size(574, 505);
            this.dataGridEspecificacoes.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Encontrar Dominio";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(570, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 555);
            this.panel3.TabIndex = 8;
            // 
            // dataGridDomain
            // 
            this.dataGridDomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDomain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridDomain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDomain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.domain_id,
            this.domain_name,
            this.category_id,
            this.category_name,
            this.attributes});
            this.dataGridDomain.Location = new System.Drawing.Point(16, 118);
            this.dataGridDomain.Name = "dataGridDomain";
            this.dataGridDomain.RowHeadersVisible = false;
            this.dataGridDomain.Size = new System.Drawing.Size(539, 451);
            this.dataGridDomain.TabIndex = 7;
            this.dataGridDomain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDomain_CellDoubleClick);
            // 
            // domain_id
            // 
            this.domain_id.DataPropertyName = "domain_id";
            this.domain_id.HeaderText = "Dominio";
            this.domain_id.Name = "domain_id";
            this.domain_id.ReadOnly = true;
            // 
            // domain_name
            // 
            this.domain_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.domain_name.DataPropertyName = "domain_name";
            this.domain_name.HeaderText = "Nome de Dominio";
            this.domain_name.Name = "domain_name";
            this.domain_name.ReadOnly = true;
            // 
            // category_id
            // 
            this.category_id.DataPropertyName = "category_id";
            this.category_id.HeaderText = "Id Categoria";
            this.category_id.Name = "category_id";
            this.category_id.ReadOnly = true;
            // 
            // category_name
            // 
            this.category_name.DataPropertyName = "category_name";
            this.category_name.HeaderText = "Nome Categoria";
            this.category_name.Name = "category_name";
            this.category_name.ReadOnly = true;
            // 
            // attributes
            // 
            this.attributes.DataPropertyName = "attributes";
            this.attributes.HeaderText = "attributes";
            this.attributes.Name = "attributes";
            this.attributes.ReadOnly = true;
            this.attributes.Visible = false;
            // 
            // txtDescritivoItem
            // 
            this.txtDescritivoItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescritivoItem.Location = new System.Drawing.Point(16, 68);
            this.txtDescritivoItem.Name = "txtDescritivoItem";
            this.txtDescritivoItem.Size = new System.Drawing.Size(302, 27);
            this.txtDescritivoItem.TabIndex = 2;
            // 
            // btn_buscar_dominio
            // 
            this.btn_buscar_dominio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_dominio.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_buscar_dominio.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_buscar_dominio.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_buscar_dominio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_buscar_dominio.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_buscar_dominio.Location = new System.Drawing.Point(438, 49);
            this.btn_buscar_dominio.Name = "btn_buscar_dominio";
            this.btn_buscar_dominio.Size = new System.Drawing.Size(116, 63);
            this.btn_buscar_dominio.TabIndex = 6;
            this.btn_buscar_dominio.Text = "Buscar";
            this.btn_buscar_dominio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar_dominio.UseVisualStyleBackColor = true;
            this.btn_buscar_dominio.Click += new System.EventHandler(this.btn_buscar_dominio_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Qtde. Resultados.";
            // 
            // numQuantidadeResultado
            // 
            this.numQuantidadeResultado.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantidadeResultado.Location = new System.Drawing.Point(324, 69);
            this.numQuantidadeResultado.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantidadeResultado.Name = "numQuantidadeResultado";
            this.numQuantidadeResultado.Size = new System.Drawing.Size(108, 27);
            this.numQuantidadeResultado.TabIndex = 4;
            this.numQuantidadeResultado.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descritivo do Item:";
            // 
            // btnObterGuia
            // 
            this.btnObterGuia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnObterGuia.Enabled = false;
            this.btnObterGuia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnObterGuia.FlatAppearance.BorderSize = 0;
            this.btnObterGuia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObterGuia.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObterGuia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnObterGuia.Location = new System.Drawing.Point(595, 529);
            this.btnObterGuia.Name = "btnObterGuia";
            this.btnObterGuia.Size = new System.Drawing.Size(574, 40);
            this.btnObterGuia.TabIndex = 11;
            this.btnObterGuia.Text = "Obter Guia de Medida";
            this.btnObterGuia.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 606);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guia de Medidas - Mercado Livre Brasil";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspecificacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDomain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numQuantidadeResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescritivoItem;
        private FontAwesome.Sharp.IconButton btn_buscar_dominio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridDomain;
        private System.Windows.Forms.DataGridViewTextBoxColumn domain_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn domain_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridEspecificacoes;
        private System.Windows.Forms.Button btnObterGuia;
    }
}

