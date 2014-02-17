using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using System.IO;
using RestauraDir;

namespace RestauraDir
{
    public partial class Restaurar : Form
    {
        List<Carpeta> Carpetas = new List<Carpeta>();
        string Ubicacion;
        
        public Restaurar()
        {
            InitializeComponent();
        }

        private void Restaurar_Load(object sender, EventArgs e)
        {
            //Properties.Settings.Default.SVisible = false;
            //Properties.Settings.Default.Save();
            //CargarCarpetas();

            //cargar un child en el form
            //Configuracion config = new Configuracion();
            //config.TopLevel = false;
            //config.Parent = this;
            //config.Show();
        }



        void CargarCarpetas()
        {
            DirectoryInfo carpetasinfo = new DirectoryInfo(Ubicacion);
            DirectoryInfo[] ArrayDeCarpetas = carpetasinfo.GetDirectories(); //Caracteres no validos en la ruta de acceso
            var MisCarpetas = from dir in ArrayDeCarpetas select dir;

            if (Carpetas.Count > 0) Carpetas.Clear();

            foreach (var item in MisCarpetas)
            {
                Carpetas.Add(new Carpeta(item,true,item.Attributes,item.FullName));
            }

            CarpetasDtg.DataSource = null;
            CarpetasDtg.Rows.Clear();

            if (Carpetas.Count > 0)
            {
                CarpetasDtg.DataSource = Carpetas;
                this.RestaurarBtn.Enabled = true;
                this.TodasChk.Enabled = true;
            }
            else
            {
                this.RestaurarBtn.Enabled = false;
                this.TodasChk.Enabled = false;
                MessageBox.Show("La ubicacion seleccionada no contiene ninguna carpeta", "Restaurar carpetas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }


        bool RestaurarCarpetas()
        {

            try
            {
                              
                //string RutaEjecucion;
                //RutaEjecucion = Application.StartupPath.ToString() + "\\restaurar.bat";
                ////StreamWriter sw = new StreamWriter(RutaEjecucion, false, Encoding.GetEncoding(1252));
                //StreamWriter sw = new StreamWriter(RutaEjecucion, false, Encoding.Default);
                ////StreamWriter sw = new StreamWriter(RutaEjecucion);
                //foreach(var carpeta in Carpetas)
                //{
                //    if(carpeta.Restaurar)
                //        sw.WriteLine("attrib -r -s -h -a " + "\"" + carpeta.Ruta + "\"");
                //        //sw.WriteLine("attrib -r -s -h -a " + "\"" + LimpiaNombre(carpeta.Ruta) + "\"");
                        
                //}
                //sw.Close();

                //System.Diagnostics.Process restauradirs = new System.Diagnostics.Process();
                //restauradirs.EnableRaisingEvents = false;
                //restauradirs.StartInfo.FileName = RutaEjecucion;
                //restauradirs.Start();
                
                //restauradirs.WaitForExit();
                
                //restauradirs.Dispose();
                //File.Delete(RutaEjecucion);

                foreach (var carpeta in Carpetas)
                {
                    if (carpeta.Restaurar)
                        carpeta.Nombre.Attributes = FileAttributes.Normal;
                }
                Carpetas.Clear();
                CargarCarpetas();

                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }

        string LimpiaNombre(string nombre)
        {            
            //Regex patron = new Regex("áéíóúü");
            //string patron = "[áéíóúüñ]";
            Regex patron = new Regex("[áéíóúüñ]");
            string reemplazapor = "*";
            nombre = patron.Replace(nombre.ToLower(),reemplazapor);
            
            return nombre;
        }

        private void RestaurarBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Confirmas restaurar las carpetas seleccionadas? \n No se puede revertir el proceso","Restaurar Carpetas",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
            if (RestaurarCarpetas())
                MessageBox.Show("Se ha(n) restaurado las carpetas seleccionadas...!","Restaurar Carpetas");
            else
                MessageBox.Show("Se genero un error al intentar restaurar la(s) carpeta(s) seleccionada(s)...!", "Restaurar Carpetas");
            }
        }

        private void UbicacionBtn_Click(object sender, EventArgs e)
        {            
            FoldersDlg.ShowDialog();
            
            Ubicacion = FoldersDlg.SelectedPath;
            if (Ubicacion != "")
            {
                Carpetas.Clear();
                CargarCarpetas();
            }
        }

        private void TodasChk_CheckedChanged(object sender, EventArgs e)
        {            
            foreach (var carpeta in Carpetas)
            {
                if (this.TodasChk.Checked)
                    carpeta.Restaurar = true;
                else
                    carpeta.Restaurar = false;
            }

            this.CarpetasDtg.Refresh();
        }

        private void CarpetasDtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //if (this.CarpetasDtg.SelectedRows.Count > 0)
            if (this.CarpetasDtg.Columns[this.CarpetasDtg.CurrentCell.ColumnIndex].HeaderText == "Restaurar")
            {
                //recuperar el objeto que lleno la fila
                Carpeta carpetaselected = (Carpeta)this.CarpetasDtg.SelectedRows[0].DataBoundItem;

                if (carpetaselected.Restaurar)
                    carpetaselected.Restaurar = false;
                else
                    carpetaselected.Restaurar = true;

                this.CarpetasDtg.Refresh();
            }
          
           
                
                //this.CarpetasDtg.CurrentRow.Selected = true;
                //this.CarpetasDtg.Rows[1].Selected = true;
                //MessageBox.Show(this.CarpetasDtg.CurrentRow.Selected.ToString());
                //SeleccionarFilas(this.CarpetasDtg.CurrentRow.Index);
                //this.CarpetasDtg.Refresh();            
        }

        List<int> filasseleccionadas = new List<int>();
        public void SeleccionarFilas(int actual)
        {
            //var fila =  from f in filasseleccionadas where f == actual select f;
            int fila= 0;
            fila = filasseleccionadas.Find(val => val == actual);
            if (fila != 0)
            {
                filasseleccionadas.Remove(fila);
                this.CarpetasDtg.Rows[fila].Selected = false;
            }
            else
                filasseleccionadas.Add(actual);
                
            foreach(int filaselec in filasseleccionadas)
                this.CarpetasDtg.Rows[filaselec].Selected=true;

        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Configuracionbtn_Click(object sender, EventArgs e)
        {
            Configuracion config = new Configuracion();
            config.ShowDialog();
        }

    }
}
