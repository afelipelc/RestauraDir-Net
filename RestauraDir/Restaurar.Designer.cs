namespace RestauraDir
{
    partial class Restaurar
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restaurar));
            this.CarpetasDtg = new System.Windows.Forms.DataGridView();
            this.RestaurarBtn = new System.Windows.Forms.Button();
            this.UbicacionBtn = new System.Windows.Forms.Button();
            this.FoldersDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.TodasChk = new System.Windows.Forms.CheckBox();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.Configuracionbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarpetasDtg)).BeginInit();
            this.SuspendLayout();
            // 
            // CarpetasDtg
            // 
            this.CarpetasDtg.AllowUserToAddRows = false;
            this.CarpetasDtg.AllowUserToDeleteRows = false;
            this.CarpetasDtg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CarpetasDtg.BackgroundColor = System.Drawing.SystemColors.Window;
            this.CarpetasDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarpetasDtg.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CarpetasDtg.Location = new System.Drawing.Point(5, 1);
            this.CarpetasDtg.MultiSelect = false;
            this.CarpetasDtg.Name = "CarpetasDtg";
            this.CarpetasDtg.ReadOnly = true;
            this.CarpetasDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarpetasDtg.Size = new System.Drawing.Size(461, 178);
            this.CarpetasDtg.TabIndex = 2;
            this.CarpetasDtg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarpetasDtg_CellClick);
            // 
            // RestaurarBtn
            // 
            this.RestaurarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RestaurarBtn.Enabled = false;
            this.RestaurarBtn.Location = new System.Drawing.Point(329, 185);
            this.RestaurarBtn.Name = "RestaurarBtn";
            this.RestaurarBtn.Size = new System.Drawing.Size(75, 24);
            this.RestaurarBtn.TabIndex = 3;
            this.RestaurarBtn.Text = "Restaurar";
            this.RestaurarBtn.UseVisualStyleBackColor = true;
            this.RestaurarBtn.Click += new System.EventHandler(this.RestaurarBtn_Click);
            // 
            // UbicacionBtn
            // 
            this.UbicacionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UbicacionBtn.Location = new System.Drawing.Point(248, 185);
            this.UbicacionBtn.Name = "UbicacionBtn";
            this.UbicacionBtn.Size = new System.Drawing.Size(75, 24);
            this.UbicacionBtn.TabIndex = 0;
            this.UbicacionBtn.Text = "Ubicacion";
            this.UbicacionBtn.UseVisualStyleBackColor = true;
            this.UbicacionBtn.Click += new System.EventHandler(this.UbicacionBtn_Click);
            // 
            // TodasChk
            // 
            this.TodasChk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TodasChk.AutoSize = true;
            this.TodasChk.Checked = true;
            this.TodasChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TodasChk.Enabled = false;
            this.TodasChk.Location = new System.Drawing.Point(12, 190);
            this.TodasChk.Name = "TodasChk";
            this.TodasChk.Size = new System.Drawing.Size(116, 17);
            this.TodasChk.TabIndex = 1;
            this.TodasChk.Text = "Todas las carpetas";
            this.TodasChk.UseVisualStyleBackColor = true;
            this.TodasChk.CheckedChanged += new System.EventHandler(this.TodasChk_CheckedChanged);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CerrarBtn.Location = new System.Drawing.Point(405, 185);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(55, 24);
            this.CerrarBtn.TabIndex = 4;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // Configuracionbtn
            // 
            this.Configuracionbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Configuracionbtn.Location = new System.Drawing.Point(190, 185);
            this.Configuracionbtn.Name = "Configuracionbtn";
            this.Configuracionbtn.Size = new System.Drawing.Size(52, 24);
            this.Configuracionbtn.TabIndex = 0;
            this.Configuracionbtn.Text = "&Config";
            this.Configuracionbtn.UseVisualStyleBackColor = true;
            this.Configuracionbtn.Click += new System.EventHandler(this.Configuracionbtn_Click);
            // 
            // Restaurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::RestauraDir.Properties.Settings.Default.ColorFondo;
            this.CancelButton = this.CerrarBtn;
            this.ClientSize = new System.Drawing.Size(472, 213);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.TodasChk);
            this.Controls.Add(this.Configuracionbtn);
            this.Controls.Add(this.UbicacionBtn);
            this.Controls.Add(this.RestaurarBtn);
            this.Controls.Add(this.CarpetasDtg);
            this.DataBindings.Add(new System.Windows.Forms.Binding("TopMost", global::RestauraDir.Properties.Settings.Default, "SVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::RestauraDir.Properties.Settings.Default, "ColorFondo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 247);
            this.Name = "Restaurar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurar carpetas... afelipelc@gmail.com";
            this.TopMost = global::RestauraDir.Properties.Settings.Default.SVisible;
            this.Load += new System.EventHandler(this.Restaurar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarpetasDtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CarpetasDtg;
        private System.Windows.Forms.Button RestaurarBtn;
        private System.Windows.Forms.Button UbicacionBtn;
        private System.Windows.Forms.FolderBrowserDialog FoldersDlg;
        private System.Windows.Forms.CheckBox TodasChk;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.Button Configuracionbtn;
    }
}

