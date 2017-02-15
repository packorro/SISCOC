using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Infragistics.Win.UltraWinGrid;
using SISCOC_BL;

namespace SISCOC_FEL
{
    public partial class FrmProveedor : Form
    {
        #region Listas_Variables
            List<ClsProveedor> ListProveedor;
            List<ClsListas> ListFiltroBusq;
            List<ClsListas> ListTipoPersona;

            int IdProveedor;
            int TipoFiltro = 0;
            int Permiso;

            private Boolean Nuevo = false;
            private Boolean ValAdd = false;
            private Boolean Guarda = true;
        #endregion
        

        public FrmProveedor(int _Permiso)
        {
            try
            {

                InitializeComponent();

                Permiso = _Permiso;
            

                //Cargo la lista de Proveedores
                ListProveedor = ClsProveedor.ListProveedor();
                clsProveedorBindingSource.DataSource = ListProveedor;
                if (ListProveedor.Count == 0)
                {
                    ClsProveedor cont = new ClsProveedor();
                    cont.Status = 1;
                    cont.TipoPersona = 2;
                    ListProveedor.Add(cont);
                   
                    clsProveedorBindingSource.DataSource = ListProveedor;
                    clsProveedorBindingSource.ResetBindings(false);
                    AccionesNavigator(1);                    
                }
                else
                {
                    AccionesNavigator(0);
                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message + " -- " + Ex.InnerException); }



        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
           KeyPreview = true;

           chckBxMuestraInf.Checked = false;
           chckBxMuestraInf_CheckedChanged(sender,e);
        }

        private void chckBxMuestraInf_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBxMuestraInf.Checked == true)
            {
                grpBxInfExtra.Visible = true;
            }
            else
            {
                grpBxInfExtra.Visible = false;
            }
        }
        
        #region Metodos
            //Para Cancelar la operacion Actual Reestablece 
            private void AccionCancelar()
            {
                ValAdd = false;

                clsProveedorBindingSource.Position = clsProveedorBindingSource.Count;
                clsProveedorBindingSource.RemoveCurrent();
                clsProveedorBindingSource.ResetBindings(false);
                if (ListProveedor.Count == 0)
                {
                    ClsProveedor cont = new ClsProveedor();
                    cont.Status = 1;
                    cont.TipoPersona = 2;
                    ListProveedor.Add(cont);                    

                    clsProveedorBindingSource.DataSource = ListProveedor;
                    clsProveedorBindingSource.ResetBindings(false);
                    AccionesNavigator(1);
                }
                else
                { AccionesNavigator(0); }
            }

            //ACCIONES DEL NAVEGADOR
            public void AccionesNavigator(int inAction) //**
            {
                // 0-Browse   1-Adding     2-Editing
                if (this.clsProveedorBindingSource.DataSource != null && this.BindingNavigator.BindingSource != null)
                {
                    switch (inAction)
                    {
                        case 0:
                            {
                                setNavigatorDirections(true);
                                if (clsProveedorBindingSource.AllowNew == false)
                                    clsProveedorBindingSource.AllowNew = true;
                                cancelToolStripButton.Enabled = false;                                
                                bindingNavigatorAddNewItem.Enabled = true;
                                BindingNavigatorDeleteItem.Enabled = clsProveedorBindingSource.Count > 0;
                                ContactoProvtoolStripButton.Enabled = clsProveedorBindingSource.Count > 0;
                                BindingNavigatorSaveItem.Enabled = clsProveedorBindingSource.Count > 0;
                                toolStripTextBoxSearch.Visible = true;
                                uGridProveedor.Enabled = true;
                                break;
                            }

                        case 1:
                            {
                                setNavigatorDirections(false);
                                if (clsProveedorBindingSource.AllowNew == true)
                                    clsProveedorBindingSource.AllowNew = false;
                                cancelToolStripButton.Enabled = true;                                
                                BindingNavigatorDeleteItem.Enabled = false;
                                ContactoProvtoolStripButton.Enabled = false;
                                BindingNavigatorSaveItem.Enabled = true;
                                toolStripTextBoxSearch.Visible = false;
                                uGridProveedor.Enabled = false;
                                break;
                            }

                        case 2:
                            {
                                setNavigatorDirections(false);

                                if (clsProveedorBindingSource.AllowNew == true)
                                    clsProveedorBindingSource.AllowNew = false;
                                cancelToolStripButton.Enabled = false;                                
                                BindingNavigatorDeleteItem.Enabled = false;
                                ContactoProvtoolStripButton.Enabled = false;
                                BindingNavigatorSaveItem.Enabled = true;
                                toolStripTextBoxSearch.Visible = false;
                                uGridProveedor.Enabled = false;
                                break;
                            }
                    }
                }

            }

            //OPCION NAVEGAR
            private void setNavigatorDirections(bool inVisible) //**
            {
                if (BindingNavigator.BindingSource != null)
                {
                    bindingNavigatorMoveFirstItem.Visible = inVisible;
                    bindingNavigatorMovePreviousItem.Visible = inVisible;
                    bindingNavigatorPositionItem.Visible = inVisible;
                    bindingNavigatorCountItem.Visible = inVisible;
                    bindingNavigatorMoveNextItem.Visible = inVisible;
                    bindingNavigatorMoveLastItem.Visible = inVisible;
                    bindingNavigatorSeparator.Visible = inVisible;
                    bindingNavigatorSeparator1.Visible = inVisible;
                    bindingNavigatorCountItem.Visible = inVisible;
                }
            }

            //VALIDA PROVEEDOR
            private bool ValidaProveedor(string Nombre) //**
            {
                int cont = 0;

                for (int i = 0; i <= clsProveedorBindingSource.Count - 1; i++)
                {
                    clsProveedorBindingSource.Position = i;
                    ClsProveedor CA = (ClsProveedor)clsProveedorBindingSource.Current;

                    //if (Convert.ToInt16(this.clsListasTipoPersonaComboBox.SelectedValue) == 1) //Fisica 1
                    //{
                    //    if (CA.RFC.Trim() == RFC.Trim() && CA.Apell_Pat.Trim() == Apell_Pat.Trim() && CA.Apell_Mat.Trim() == Apell_Mat.Trim() && CA.Nombre.Trim() == Nombre.Trim())
                    //    { cont = cont + 1; }
                    //}
                    //else //Moral 2
                    //{
                        if (CA.Nombre.Trim() == Nombre.Trim())
                        { cont = cont + 1; }
                    //}
                }
                if (cont >= 2)
                { return true; }
                else
                { return false; }
            }


            private void AtajosKeys(object sender, KeyEventArgs e)//atajos de teclado 
            {
                //#region Ayuda_F1
                //if (e.KeyCode == Keys.F1) { }
                //#endregion

                #region Nueva_F2
                    if (e.KeyCode == Keys.F2)
                    {
                        if (ValAdd == false)
                        {
                            ClsProveedor cont = new ClsProveedor();
                            cont.Status = 1;
                            cont.TipoPersona = 2;
                            ListProveedor.Add(cont);

                            clsProveedorBindingSource.Position = ListProveedor.Count;
                            bindingNavigatorAddNewItem_Click(sender, e);
                        }
                    }
                #endregion

                #region Busca_F3
                    if (e.KeyCode == Keys.F3 == true)
                    {
                        this.toolStripTextBoxSearch.Focus();
                    }
                #endregion

                #region Guarda_F4
                    if (e.KeyCode == Keys.F4)
                    {
                        BindingNavigatorSaveItem_Click(sender, e);
                    }
                #endregion

                #region Cancelaraccion_F6
                    if (e.KeyCode == Keys.F6)
                    {
                        cancelToolStripButton_Click(sender, e);
                    }
                #endregion

                #region Contacto_F7
                    if (e.KeyCode == Keys.F7)
                    {
                        ContactoProvtoolStripButton_Click(sender, e);
                    }
                #endregion

                #region Eliminar_Spr
                    if (e.KeyCode == Keys.Delete)
                    {
                        BindingNavigatorDeleteItem_Click(sender, e);
                    }
                #endregion

                #region Salir
                    if (e.KeyCode == Keys.Escape)
                    {
                        if (e.KeyCode == Keys.Escape)
                        {
                            if (MessageBox.Show("Esta Seguro que Desea Salir ?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                            { Close(); }
                        }
                    }
                #endregion
            }

        #endregion

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (ValAdd == false)
            {
                ValAdd = true;
                //***************
                if (Permiso != 3)
                {
                    AccionesNavigator(1);
                    ClsProveedor cont = (ClsProveedor)clsProveedorBindingSource.Current;
                    cont.Status = 1;
                    cont.TipoPersona = 1;
                    //clsListasTipoPersonaComboBox.SelectedValue = 1;
                    clsProveedorBindingSource.ResetBindings(false);
                    //clsListasTipoPersonaComboBox.Focus();
                }
                else
                {
                    MessageBox.Show("No Tiene los privilegios que le \n Permitan Agregar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    AccionCancelar();
                }
                //*****************
            }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Permiso != 1)
                {
                    MessageBox.Show("No Tiene los privilegios que le \n Permitan Eliminar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult Result = MessageBox.Show("Seguro que desea eliminar el registro", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    ClsProveedor CA = (ClsProveedor)clsProveedorBindingSource.Current;
                    CA.Status = 0;
                    clsProveedorBindingSource.ResetBindings(false);
                    ClsProveedor.UpdateProveedor(CA);

                    MessageBox.Show("El Proveedor se ha sido Eliminado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                ValAdd = false;
                ListProveedor = ClsProveedor.ListProveedor();
                clsProveedorBindingSource.DataSource = ListProveedor;
                AccionesNavigator(0);
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.nombreTextBox.Text == "") { MessageBox.Show("Proporcione un Nombre de Proveedor ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.nombreTextBox.Focus(); return; }
                
                BindingNavigator.Focus();
                nombreTextBox.Focus();
                ClsProveedor CA = (ClsProveedor)clsProveedorBindingSource.Current;
                CA.Apell_Mat = "";
                CA.Apell_Pat = "";

                if (CA.Ciudad==null) {CA.Ciudad = ""; }
                if (CA.Colonia == null) {CA.Colonia = "";}
                if (CA.Domicilio == null) {CA.Domicilio = "";}
                if (CA.Email == null) {CA.Email = "";}
                if (CA.RFC == null) { CA.RFC = "";}
                if (CA.Telefono == null) { CA.Telefono = ""; }
                
                CA.Status = 1;
                CA.TipoPersona = 2;           

                if (CA.IdProveedor == 0) //nuevo
                {
                    if (Permiso == 3)//Valido Permiso
                    {
                        MessageBox.Show("No Tiene los privilegios que le \n Permitan Agregar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        ListProveedor = ClsProveedor.ListProveedor();
                        clsProveedorBindingSource.DataSource = ListProveedor;
                        AccionesNavigator(0);
                        return;
                    }

                    if (ValidaProveedor(CA.Nombre) == false)
                    {
                        DialogResult Result = MessageBox.Show("Seguro que Desea Agregar el Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Result == DialogResult.Yes)
                        {
                            ClsProveedor.AddProveedor(CA);
                            MessageBox.Show("Registro agregado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error el Proveedor ya Existe...", "A v i s o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clsProveedorBindingSource.Position = clsProveedorBindingSource.Count;
                        this.nombreTextBox.Text = ""; this.nombreTextBox.Focus(); return;
                    }
                }
                else //modifica
                {

                    if (Permiso != 1)//Valido Permiso
                    {
                        MessageBox.Show("No Tiene los privilegios que le \n Permitan Modificar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        ListProveedor = ClsProveedor.ListProveedor();
                        clsProveedorBindingSource.DataSource = ListProveedor;
                        AccionesNavigator(0);
                        return;
                    }

                    if (ValidaProveedor(CA.Nombre) == false)
                    {
                        DialogResult Result = MessageBox.Show("Seguro que Desea Modificar el Registro", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Result == DialogResult.Yes)
                        {
                            BindingNavigator.Focus();
                            this.nombreTextBox.Focus();
                            ClsProveedor.UpdateProveedor(CA);
                            MessageBox.Show("Registro modificado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error el Proveedor ya Existe...", "A v i s o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListProveedor = ClsProveedor.ListProveedor();
                        clsProveedorBindingSource.DataSource = ListProveedor;
                        clsProveedorBindingSource.ResetBindings(false);
                        this.nombreTextBox.Focus(); return;
                    }
                }
                ValAdd = false;
                ListProveedor = ClsProveedor.ListProveedor();
                clsProveedorBindingSource.DataSource = ListProveedor;
                AccionesNavigator(0);
            }
            catch (Exception Ex)
            { MessageBox.Show(Ex.Message); }
        }

        private void cancelToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (cancelToolStripButton.Enabled != false)
                {
                    AccionCancelar();
                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message + " -- " + Ex.InnerException); }
        }

        private void ContactoProvtoolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClsProveedor Proveedor = (ClsProveedor)clsProveedorBindingSource.Current;
                IdProveedor = Proveedor.IdProveedor;
                FrmContactoProveedor ContactoProveedor = new FrmContactoProveedor(IdProveedor, Permiso);

                ContactoProveedor.ShowDialog();
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message + " -- " + Ex.InnerException); } 
        }

        private void FrmProveedor_KeyUp(object sender, KeyEventArgs e)
        {
            #region Next Control
                if (e.KeyCode == Keys.Enter)
                { SendKeys.Send("{TAB}"); }
            #endregion
        }

        private void toolStripTextBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            int posicion = 0;
            ProveedorFilter Filtro = new ProveedorFilter(this.toolStripTextBoxSearch.Text.Trim(), 3);
            Predicate<ClsProveedor> Filtrado = new Predicate<ClsProveedor>(Filtro.BuscaAll);

            posicion = ListProveedor.FindIndex(Filtrado);
            if (posicion == 0)
            { this.clsProveedorBindingSource.Position = 0; }
            else
            { this.clsProveedorBindingSource.Position = posicion; }  
        }

        private void telefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == 8))//Validate numbers and Tab keys
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;        
            }
        }

        private void grpBxInfExtra_Enter(object sender, EventArgs e)
        {

        }




    }
}