namespace TicketMaster
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewBoletos = new System.Windows.Forms.DataGridView();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxCostoEmbarque = new System.Windows.Forms.TextBox();
            this.comboBoxTipoBoleto = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoletos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBoletos
            // 
            this.dataGridViewBoletos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBoletos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBoletos.Name = "dataGridViewBoletos";
            this.dataGridViewBoletos.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewBoletos.TabIndex = 0;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(12, 200);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero.TabIndex = 1;
            this.textBoxNumero.Text = "Número Boleto";
            // 
            // textBoxCostoEmbarque
            // 
            this.textBoxCostoEmbarque.Location = new System.Drawing.Point(12, 240);
            this.textBoxCostoEmbarque.Name = "textBoxCostoEmbarque";
            this.textBoxCostoEmbarque.Size = new System.Drawing.Size(100, 20);
            this.textBoxCostoEmbarque.TabIndex = 2;
            this.textBoxCostoEmbarque.Text = "Costo Embarque";
            // 
            // comboBoxTipoBoleto
            // 
            this.comboBoxTipoBoleto.FormattingEnabled = true;
            this.comboBoxTipoBoleto.Items.AddRange(new object[] {
            "Todos",
            "Turista",
            "Ejecutivo"});
            this.comboBoxTipoBoleto.Location = new System.Drawing.Point(12, 280);
            this.comboBoxTipoBoleto.Name = "comboBoxTipoBoleto";
            this.comboBoxTipoBoleto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoBoleto.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(200, 200);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Añadir";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(200, 240);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Actualizar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(200, 280);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(300, 200);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(300, 240);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(75, 23);
            this.buttonList.TabIndex = 8;
            this.buttonList.Text = "Listar";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxTipoBoleto);
            this.Controls.Add(this.textBoxCostoEmbarque);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.dataGridViewBoletos);
            this.Name = "MainForm";
            this.Text = "Gestión de Boletos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoletos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBoletos;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxCostoEmbarque;
        private System.Windows.Forms.ComboBox comboBoxTipoBoleto;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonList;

    }
}

