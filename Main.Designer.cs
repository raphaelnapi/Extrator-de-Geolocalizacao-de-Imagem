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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnKML = new System.Windows.Forms.Button();
            this.Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalFound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Long = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessingMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filepath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
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
            this.Filename,
            this.LocalFound,
            this.Lat,
            this.Long,
            this.Altitude,
            this.ProcessingMethod,
            this.DateTime,
            this.Make,
            this.Model,
            this.Filepath});
            this.DataGridView.Location = new System.Drawing.Point(12, 12);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.ShowCellToolTips = false;
            this.DataGridView.Size = new System.Drawing.Size(760, 485);
            this.DataGridView.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(12, 516);
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
            this.btnKML.Location = new System.Drawing.Point(687, 516);
            this.btnKML.Name = "btnKML";
            this.btnKML.Size = new System.Drawing.Size(85, 33);
            this.btnKML.TabIndex = 1;
            this.btnKML.Text = "Gerar KML";
            this.btnKML.UseVisualStyleBackColor = true;
            this.btnKML.Click += new System.EventHandler(this.btnKML_Click);
            // 
            // Filename
            // 
            this.Filename.HeaderText = "Arquivo";
            this.Filename.Name = "Filename";
            this.Filename.ReadOnly = true;
            this.Filename.Width = 150;
            // 
            // LocalFound
            // 
            this.LocalFound.HeaderText = "Localização encontrada?";
            this.LocalFound.Name = "LocalFound";
            this.LocalFound.ReadOnly = true;
            this.LocalFound.Width = 80;
            // 
            // Lat
            // 
            this.Lat.HeaderText = "Latitude";
            this.Lat.Name = "Lat";
            this.Lat.ReadOnly = true;
            this.Lat.Width = 80;
            // 
            // Long
            // 
            this.Long.HeaderText = "Longitude";
            this.Long.Name = "Long";
            this.Long.ReadOnly = true;
            this.Long.Width = 80;
            // 
            // Altitude
            // 
            this.Altitude.HeaderText = "Altitude";
            this.Altitude.Name = "Altitude";
            this.Altitude.ReadOnly = true;
            this.Altitude.Width = 80;
            // 
            // ProcessingMethod
            // 
            this.ProcessingMethod.HeaderText = "Método de Localização";
            this.ProcessingMethod.Name = "ProcessingMethod";
            this.ProcessingMethod.ReadOnly = true;
            // 
            // DateTime
            // 
            this.DateTime.HeaderText = "Data e Hora";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            this.DateTime.Width = 150;
            // 
            // Make
            // 
            this.Make.HeaderText = "Fabricante";
            this.Make.Name = "Make";
            this.Make.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.HeaderText = "Modelo";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 150;
            // 
            // Filepath
            // 
            this.Filepath.HeaderText = "Caminho do Arquivo";
            this.Filepath.Name = "Filepath";
            this.Filepath.ReadOnly = true;
            this.Filepath.Width = 400;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(186, 516);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 33);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Limpar Lista";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnKML);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DataGridView);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extrator de Geolocalização de Imagens";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnKML;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Long;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessingMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Make;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filepath;
        private System.Windows.Forms.Button btnClear;
    }
}

