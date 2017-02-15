using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinDataSource;
using Infragistics.Win.UltraWinGrid;
using System.Diagnostics;
using SISCOC_BL;
using System.Reflection;

namespace SISCOC_FEL
{
    public partial class FrmBuscaObra : Form
    {
        #region Litas&Variables
            List<ClsObra> ListBuscaObra;
            public ClsObra BuscaObra;       

        #endregion
        
        public FrmBuscaObra()
        {
            InitializeComponent();
            this.rdBtnDescripcion.Checked = true;
            this.txtfrase.Focus(); 
        }

        private void FrmBuscaObra_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void w_Click(object sender, EventArgs e)
        {
            buscaObra();
        }

        private void buscaObra()
        {
            try
            {
                //busqueda.......
                ListBuscaObra = ClsObra.ListObrasLike(txtfrase.Text.Trim());                
                if (ListBuscaObra.Count != 0)
                {
                    clsObrasBuscarBindingSource.DataSource = ListBuscaObra;                    
                    uGrdObra.Focus();
                }
                else
                {
                    MessageBox.Show("No se Encontro Ninguna Coincidencia con el Parametro de busqueda", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtfrase.Text = "";
                    ListBuscaObra.Clear();                    
                    txtfrase.Focus();
                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }

        private void txtfrase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { buscaObra(); }

            if (e.KeyCode == Keys.Escape)
            { this.Close(); }
        }

        private void btnNuevaBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                txtfrase.Text = ""; //Descripcion = null;
                rdBtnDescripcion.Checked = true; txtfrase.Focus();
                ListBuscaObra.Clear();                
                clsObrasBuscarBindingSource.ResetBindings(false);                
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }

        private void uGrdObra_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            try
            {
                BuscaObra = (ClsObra)clsObrasBuscarBindingSource.Current;                
                FrmBuscaObra.ActiveForm.Hide();                
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }  
        }

        private void uGrdObra_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BuscaObra = (ClsObra)clsObrasBuscarBindingSource.Current;                    
                    FrmBuscaObra.ActiveForm.Hide();                    
                }
                if (e.KeyCode == Keys.Escape)
                { this.Close(); }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }




    }
}