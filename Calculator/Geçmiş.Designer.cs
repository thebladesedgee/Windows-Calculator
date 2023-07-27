namespace Calculator
{
    partial class Geçmiş
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Geçmiş));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sonuçDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesaplamaGeçmişiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Calculator_ContextDataSet = new Calculator._Calculator_ContextDataSet();
            this.hesaplamaGeçmişiTableAdapter = new Calculator._Calculator_ContextDataSetTableAdapters.HesaplamaGeçmişiTableAdapter();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesaplamaGeçmişiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Calculator_ContextDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesaplama Geçmişi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sonuçDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hesaplamaGeçmişiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(144, 179);
            this.dataGridView1.TabIndex = 1;
            // 
            // sonuçDataGridViewTextBoxColumn
            // 
            this.sonuçDataGridViewTextBoxColumn.DataPropertyName = "sonuç";
            this.sonuçDataGridViewTextBoxColumn.HeaderText = "sonuç";
            this.sonuçDataGridViewTextBoxColumn.Name = "sonuçDataGridViewTextBoxColumn";
            // 
            // hesaplamaGeçmişiBindingSource
            // 
            this.hesaplamaGeçmişiBindingSource.DataMember = "HesaplamaGeçmişi";
            this.hesaplamaGeçmişiBindingSource.DataSource = this._Calculator_ContextDataSet;
            // 
            // _Calculator_ContextDataSet
            // 
            this._Calculator_ContextDataSet.DataSetName = "_Calculator_ContextDataSet";
            this._Calculator_ContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hesaplamaGeçmişiTableAdapter
            // 
            this.hesaplamaGeçmişiTableAdapter.ClearBeforeFill = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.IndianRed;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(34, 280);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(191, 45);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Geçmiş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(271, 357);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Geçmiş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesaplama Geçmişi";
            this.Load += new System.EventHandler(this.Geçmiş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesaplamaGeçmişiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Calculator_ContextDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _Calculator_ContextDataSet _Calculator_ContextDataSet;
        private System.Windows.Forms.BindingSource hesaplamaGeçmişiBindingSource;
        private _Calculator_ContextDataSetTableAdapters.HesaplamaGeçmişiTableAdapter hesaplamaGeçmişiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonuçDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnTemizle;
    }
}