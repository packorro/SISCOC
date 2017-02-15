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
    public partial class FrmProveedor1 : Form
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


        public FrmProveedor1(int _Permiso)
        {
          try
          {
                
                InitializeComponent();

                Permiso = _Permiso;

                //Tipo de persona 1-Fisica, 2-Moral
                ListTipoPersona = ClsListas.ListTipoPersona();
                clsListasTipoPersonaBindingSource.DataSource = ListTipoPersona;

                //Filtro de Busqueda
                ListFiltroBusq = ClsListas.ListBusqueda();
                clsListasFiltrobindingSource.DataSource = ListFiltroBusq;

                //Cargo la lista de Proveedores
                ListProveedor = ClsProveedor.ListProveedor();
                clsProveedorBindingSource.DataSource = ListProveedor;
                if (ListProveedor.Count == 0)
                {
                    ClsProveedor cont = new ClsProveedor();                
                    cont.Status = 1;
                    cont.TipoPersona = 1;
                    ListProveedor.Add(cont);
                    clsListasTipoPersonaComboBox.SelectedValue = 1;                               

                    clsProveedorBindingSource.DataSource = ListProveedor;
                    clsProveedorBindingSource.ResetBindings(false);
                    AccionesNavigator(1);
                    clsListasTipoPersonaComboBox.Focus();
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
            clsListasFiltrocomboBox_SelectedIndexChanged(sender, e);
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
                    cont.TipoPersona = 1;
                    ListProveedor.Add(cont);
                    clsListasTipoPersonaComboBox.SelectedValue = 1;

                    clsProveedorBindingSource.DataSource = ListProveedor;
                    clsProveedorBindingSource.ResetBindings(false);
                    AccionesNavigator(1);
                    clsListasTipoPersonaComboBox.Focus();

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
                                grpBxFiltro.Enabled = true;
                                bindingNavigatorAddNewItem.Enabled = true;
                                BindingNavigatorDeleteItem.Enabled = clsProveedorBindingSource.Count > 0;
                                ContactoProvtoolStripButton.Enabled = clsProveedorBindingSource.Count > 0;
                                BindingNavigatorSaveItem.Enabled = clsProveedorBindingSource.Count > 0;
                                uGridProveedor.Enabled = true;
                                break;
                            }

                        case 1:
                            {
                                setNavigatorDirections(false);
                                if (clsProveedorBindingSource.AllowNew == true)
                                    clsProveedorBindingSource.AllowNew = false;
                                cancelToolStripButton.Enabled = true;
                                grpBxFiltro.Enabled = false;
                                BindingNavigatorDeleteItem.Enabled = false;
                                ContactoProvtoolStripButton.Enabled = false;
                                BindingNavigatorSaveItem.Enabled = true;
                                uGridProveedor.Enabled = false;
                                break;
                            }

                        case 2:
                            {
                                setNavigatorDirections(false);

                                if (clsProveedorBindingSource.AllowNew == true)
                                    clsProveedorBindingSource.AllowNew = false;
                                cancelToolStripButton.Enabled = false;
                                grpBxFiltro.Enabled = false;
                                BindingNavigatorDeleteItem.Enabled = false;
                                ContactoProvtoolStripButton.Enabled = false;
                                BindingNavigatorSaveItem.Enabled = true;
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
            private bool ValidaProveedor(string Apell_Pat, string Apell_Mat, string Nombre, string RFC) //**
            {
                int cont = 0;

                for (int i = 0; i <= clsProveedorBindingSource.Count - 1; i++)
                {
                    clsProveedorBindingSource.Position = i;
                    ClsProveedor CA = (ClsProveedor)clsProveedorBindingSource.Current;
                    
                    if (Convert.ToInt16(this.clsListasTipoPersonaComboBox.SelectedValue) == 1) //Fisica 1
                    {
                        if (CA.RFC.Trim() == RFC.Trim() && CA.Apell_Pat.Trim() == Apell_Pat.Trim() && CA.Apell_Mat.Trim() == Apell_Mat.Trim() && CA.Nombre.Trim() == Nombre.Trim())
                        { cont = cont + 1; }
                    }
                    else //Moral 2
                    {
                        if (CA.RFC.Trim() == RFC.Trim() && CA.Nombre.Trim() == Nombre.Trim())
                        { cont = cont + 1; }
                    }
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
                            cont.TipoPersona = 1;
                            ListProveedor.Add(cont);

                            clsProveedorBindingSource.Position = ListProveedor.Count;                        
                            bindingNavigatorAddNewItem_Click(sender, e);
                        }
                    }
                #endregion

                #region Busca_F3
                    if (e.KeyCode == Keys.F3 == true)
                    {                        
                        this.clsListasFiltrocomboBox.Focus();
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


        private void clsListasFiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoFiltro = Convert.ToInt16(clsListasFiltrocomboBox.SelectedValue);
        }

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
                    clsListasTipoPersonaComboBox.SelectedValue = 1;
                    clsProveedorBindingSource.ResetBindings(false);
                    clsListasTipoPersonaComboBox.Focus();
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

                    MessageBox.Show("El Cliente se ha sido Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                //if (this.clsListasTipoPersonaComboBox.SelectedValue == null) { MessageBox.Show("Proporcione un Tipo de Persona ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.clsListasTipoPersonaComboBox.Focus(); return; }
                

                BindingNavigator.Focus();

                nombreTextBox.Focus();
                ClsProveedor CA = (ClsProveedor)clsProveedorBindingSource.Current;
                          
                CA.Status = 1;
                CA.TipoPersona = 1;
                //if (Convert.ToInt16(this.clsListasTipoPersonaComboBox.SelectedValue) == 1) //Fisica 1
                //{
                //    if (this.apell_PatTextBox.Text == "") { MessageBox.Show("Proporcione un Apellido Paterno de Proveedor ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.apell_PatTextBox.Focus(); return; }
                //    if (this.apell_MatTextBox.Text == "") { MessageBox.Show("Proporcione un Apellido Materno de Proveedor ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.apell_MatTextBox.Focus(); return; }
                //    if ((CA.RFC.Trim().Length < 13) || (this.rFCTextBox.Text == ""))
                //    { MessageBox.Show("Proporcione un RFC Valido del Cliente ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.rFCTextBox.Focus(); return; }
                //}
                //else //Moral 2
                //{
                //    CA.Apell_Pat = ""; CA.Apell_Mat = "";
                //    if ((CA.RFC.Trim().Length < 12) || (this.rFCTextBox.Text == ""))
                //    { MessageBox.Show("Proporcione un RFC Valido del Proveedor ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.rFCTextBox.Focus(); return; }
                //}

                if (CA.IdProveedor == 0) //nuevo
                {
                    if (Permiso == 3)
                    {
                        MessageBox.Show("No Tiene los privilegios que le \n Permitan Agregar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        ListProveedor = ClsProveedor.ListProveedor();
                        clsProveedorBindingSource.DataSource = ListProveedor;                        
                        AccionesNavigator(0);
                        return;
                    }

                    if (ValidaProveedor(CA.Apell_Pat, CA.Apell_Mat, CA.Nombre, CA.RFC) == false)
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

                    if (Permiso != 1)
                    {
                        MessageBox.Show("No Tiene los privilegios que le \n Permitan Modificar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        ListProveedor = ClsProveedor.ListProveedor();
                        clsProveedorBindingSource.DataSource = ListProveedor;                        
                        AccionesNavigator(0);
                        return;
                    }

                    if (ValidaProveedor(CA.Apell_Pat, CA.Apell_Mat, CA.Nombre, CA.RFC) == false)
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

        //private void clsListasTipoPersonaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //No le Gusto al Anju
        //    //try
        //    //{
        //    //    if (Convert.ToInt16(clsListasTipoPersonaComboBox.SelectedValue) == 2) //Moral 2
        //    //    {
        //    //        rFCTextBox.MaxLength = 12;
        //    //        apell_PatTextBox.Enabled = false;
        //    //        apell_MatTextBox.Enabled = false;
        //    //        pnlApellidos.Visible = false;
        //    //    }
        //    //    else //Fisica 1
        //    //    {
        //    //        rFCTextBox.MaxLength = 13;
        //    //        apell_PatTextBox.Enabled = true;
        //    //        apell_MatTextBox.Enabled = true;
        //    //        pnlApellidos.Visible = true;
        //    //    }
        //    //}
        //    //catch (Exception Ex) { MessageBox.Show(Ex.Message + " -- " + Ex.InnerException); }
        //}

        private void txtBxBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            int posicion = 0;
            ProveedorFilter Filtro = new ProveedorFilter(this.txtBxBusqueda.Text.Trim(), TipoFiltro);
            Predicate<ClsProveedor> Filtrado = new Predicate<ClsProveedor>(Filtro.BuscaAll);

            posicion = ListProveedor.FindIndex(Filtrado);            
            if (posicion == 0)
            { this.clsProveedorBindingSource.Position = 0; }
            else
            { this.clsProveedorBindingSource.Position = posicion; }  
        }

        private void FrmProveedor_KeyUp(object sender, KeyEventArgs e)
        {
            #region Next Control
                if (e.KeyCode == Keys.Enter)
                { SendKeys.Send("{TAB}"); }
            #endregion
        }

        private void telefonoTextBox_TextChanged(object sender, EventArgs e)
        {

        }





    }
}