namespace Extrator_de_Geolocalização_de_Imagem
{
    partial class Main
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Long = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPSProcessingMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnKML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.File,
            this.DataFound,
            this.Lat,
            this.Long,
            this.GPSProcessingMethod,
            this.Time,
            this.Path});
            this.DataGridView.Location = new System.Drawing.Point(12, 12);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.ShowCellToolTips = false;
            this.DataGridView.Size = new System.Drawing.Size(774, 244);
            this.DataGridView.TabIndex = 0;
            // 
            // File
            // 
            this.File.HeaderText = "Arquivo";
            this.File.Name = "File";
            this.File.ReadOnly = true;
            // 
            // DataFound
            // 
            this.DataFound.HeaderText = "Dados encontrados?";
            this.DataFound.Name = "DataFound";
            this.DataFound.ReadOnly = true;
            // 
            // Lat
            // 
            this.Lat.HeaderText = "Latitude";
            this.Lat.Name = "Lat";
            this.Lat.ReadOnly = true;
            // 
            // Long
            // 
            this.Long.HeaderText = "Longitude";
            this.Long.Name = "Long";
            this.Long.ReadOnly = true;
            // 
            // GPSProcessingMethod
            // 
            this.GPSProcessingMethod.HeaderText = "Método de Localização";
            this.GPSProcessingMethod.Name = "GPSProcessingMethod";
            this.GPSProcessingMethod.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Data e Hora";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Path
            // 
            this.Path.HeaderText = "Caminho do Arquivo";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(12, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adicionar arquivos";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnKML
            // 
            this.btnKML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKML.Location = new System.Drawing.Point(701, 275);
            this.btnKML.Name = "btnKML";
            this.btnKML.Size = new System.Drawing.Size(85, 33);
            this.btnKML.TabIndex = 1;
            this.btnKML.Text = "Gerar KML";
            this.btnKML.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 320);
            this.Controls.Add(this.btnKML);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DataGridView);
            this.Name = "Main";
            this.Text = "Extrator de Geolocalização de Imagens";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn File;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Long;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPSProcessingMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnKML;
    }
}

