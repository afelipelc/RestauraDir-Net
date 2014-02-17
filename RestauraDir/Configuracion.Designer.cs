namespace RestauraDir
{
    partial class Configuracion
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
            this.label1 = new System.Windows.Forms.Label();
            this.ColorDlg = new System.Windows.Forms.ColorDialog();
            this.SelectColorBtn = new System.Windows.Forms.Button();
            this.ColorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color de fondo:";
            // 
            // ColorDlg
            // 
            this.ColorDlg.Color = System.Drawing.SystemColors.AppWorkspace;
            // 
            // SelectColorBtn
            // 
            this.SelectColorBtn.Location = new System.Drawing.Point(119, 4);
            this.SelectColorBtn.Name = "SelectColorBtn";
            this.SelectColorBtn.Size = new System.Drawing.Size(30, 23);
            this.SelectColorBtn.TabIndex = 1;
            this.SelectColorBtn.Text = "...";
            this.SelectColorBtn.UseVisualStyleBackColor = true;
            this.SelectColorBtn.Click += new System.EventHandler(this.SelectColorBtn_Click);
            // 
            // ColorLbl
            // 
            this.ColorLbl.BackColor = global::RestauraDir.Properties.Settings.Default.ColorFondo;
            this.ColorLbl.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::RestauraDir.Properties.Settings.Default, "ColorFondo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ColorLbl.Location = new System.Drawing.Point(84, 4);
            this.ColorLbl.Name = "ColorLbl";
            this.ColorLbl.Size = new System.Drawing.Size(29, 23);
            this.ColorLbl.TabIndex = 0;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 37);
            this.Controls.Add(this.SelectColorBtn);
            this.Controls.Add(this.ColorLbl);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuracion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog ColorDlg;
        private System.Windows.Forms.Button SelectColorBtn;
        private System.Windows.Forms.Label ColorLbl;
    }
}