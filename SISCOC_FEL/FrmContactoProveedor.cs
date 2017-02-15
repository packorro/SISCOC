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
    public partial class FrmContactoProveedor : Form
    {
        #region Listas_Variables
            List<ClsProveedor> ListProveedor;
            List<ClsContactoProveedor> ListContactoProv;
            
            List<ClsListas> ListFiltroBusq;
            

            int IdProveedor;
            int TipoFiltro = 0;
            int Permiso;

            private Boolean Nuevo = false;
            private Boolean ValAdd = false;
            private Boolean Guarda = true;
        #endregion
        
        public FrmContactoProveedor(int _Proveedor, int _Permiso)
        {
            try
            {

                InitializeComponent();

                IdProveedor = _Proveedor;
                Permiso = _Permiso;
                            

                //Filtro de Busqueda
                ListFiltroBusq = ClsListas.ListBusqueda();
                clsListasFiltrobindingSource.DataSource = ListFiltroBusq;


                //Cargo la lista de Proveedores
                ListProveedor = ClsProveedor.ListProveedor();
                clsProveedorBindingSource.DataSource = ListProveedor;
                clsProveedorComboBox.SelectedValue = IdProveedor;


                //Cargo la lista de Contacto del Proveedor
                ListContactoProv = ClsContactoProveedor.ListContactoProveedor(IdProveedor);
                clsContactoProveedorBindingSource.DataSource = ListContactoProv;
                if (ListContactoProv.Count == 0)
                {
                    ClsContactoProveedor cont = new ClsContactoProveedor();
                    cont.Status = 1;
                    cont.IdProveedor = Convert.ToInt16(clsProveedorComboBox.SelectedValue);
                    ListContactoProv.Add(cont);

                    clsContactoProveedorBindingSource.DataSource = ListContactoProv;
                    clsContactoProveedorBindingSource.ResetBindings(false);
                    AccionesNavigator(1);                    
                    apell_PatTextBox.Focus();
                }
                else
                {
                    AccionesNavigator(0);
                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message + " -- " + Ex.InnerException); }

        }

        private void FrmContactoProveedor_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        #region Metodos
            //Para Cancelar la operacion Actual Reestablece 
            private void AccionCancelar()
            {
                ValAdd = false;

                clsContactoProveedorBindingSource.Position = clsContactoProveedorBindingSource.Count;
                clsContactoProveedorBindingSource.RemoveCurrent();
                clsContactoProveedorBindingSource.ResetBindings(false);                
                if (ListContactoProv.Count == 0)
                {
                    ClsContactoProveedor cont = new ClsContactoProveedor();                    
                    cont.Status = 1;
                    cont.IdProveedor = Convert.ToInt16(clsProveedorComboBox.SelectedValue);
                    ListContactoProv.Add(cont);

                    clsContactoProveedorBindingSource.DataSource = ListContactoProv;
                    clsContactoProveedorBindingSource.ResetBindings(false);                    
                    AccionesNavigator(1);
                    this.apell_PatTextBox.Focus();                    
                }
                else
                { AccionesNavigator(0); }
            }

            //ACCIONES DEL NAVEGADOR
            public void AccionesNavigator(int inAction) //**
            {
                // 0-Browse   1-Adding     2-Editing
                if (this.clsContactoProveedorBindingSource.DataSource != null && this.BindingNavigator.BindingSource != null)
                {
                    switch (inAction)
                    {
                        case 0:
                            {
                                setNavigatorDirections(true);
                                if (clsContactoProveedorBindingSource.AllowNew == false)
                                    clsContactoProveedorBindingSource.AllowNew = true;
                                cancelToolStripButton.Enabled = false;
                                grpBxFiltro.Enabled = clsContactoProveedorBindingSource.Count > 0;
                                bindingNavigatorAddNewItem.Enabled = true;
                                BindingNavigatorDeleteItem.Enabled = clsContactoProveedorBindingSource.Count > 0;
                                //ContactoProvtoolStripButton.Enabled = clsContactoProveedorBindingSource.Count > 0;
                                BindingNavigatorSaveItem.Enabled = clsContactoProveedorBindingSource.Count > 0;
                                uGridContactoProv.Enabled = true;
                                break;
                            }

                        case 1:
                            {
                                setNavigatorDirections(false);
                                if (clsContactoProveedorBindingSource.AllowNew == true)
                                    clsContactoProveedorBindingSource.AllowNew = false;
                                cancelToolStripButton.Enabled = true;
                                grpBxFiltro.Enabled = false;
                                BindingNavigatorDeleteItem.Enabled = false;
                                //ContactoProvtoolStripButton.Enabled = false;
                                BindingNavigatorSaveItem.Enabled = true;
                                uGridContactoProv.Enabled = false;
                                break;
                            }

                        case 2:
                            {
                                setNavigatorDirections(false);

                                if (clsContactoProveedorBindingSource.AllowNew == true)
                                    clsContactoProveedorBindingSource.AllowNew = false;
                                cancelToolStripButton.Enabled = false;
                                grpBxFiltro.Enabled = false;
                                BindingNavigatorDeleteItem.Enabled = false;
                                //ContactoProvtoolStripButton.Enabled = false;
                                BindingNavigatorSaveItem.Enabled = true;
                                uGridContactoProv.Enabled = false;
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

            //VALIDA CONTACTO PROVEEDOR
            private bool ValidaContactoProv(string Apell_Pat, string Apell_Mat, string Nombre) 
            {
                int cont = 0;

                for (int i = 0; i <=clsContactoProveedorBindingSource.Count - 1; i++)
                {
                    clsContactoProveedorBindingSource.Position = i;
                    ClsContactoProveedor CA = (ClsContactoProveedor)clsContactoProveedorBindingSource.Current;
                    
                    if (CA.Apell_Pat.Trim() == Apell_Pat.Trim() && CA.Apell_Mat.Trim() == Apell_Mat.Trim() && CA.Nombre.Trim() == Nombre.Trim())
                    { cont = cont + 1; }                   
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
                            ClsContactoProveedor cont = new ClsContactoProveedor();
                            cont.IdProveedor = Convert.ToInt16(clsProveedorComboBox.SelectedValue);
                            cont.Status = 1;
                            ListContactoProv.Add(cont);

                            clsContactoProveedorBindingSource.Position = ListContactoProv.Count;
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
                    //if (e.KeyCode == Keys.F7)
                    //{
                    //    ContactoProvtoolStripButton_Click(sender, e);
                    //}
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

        private void txtBxBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            int posicion = 0;
            ContactoProveedorFilter Filtro = new ContactoProveedorFilter(this.txtBxBusqueda.Text.Trim(), TipoFiltro);
            Predicate<ClsContactoProveedor> Filtrado = new Predicate<ClsContactoProveedor>(Filtro.BuscaAll);

            posicion = ListContactoProv.FindIndex(Filtrado);            
            if (posicion == 0)
            { this.clsContactoProveedorBindingSource.Position = 0; }
            else
            { this.clsContactoProveedorBindingSource.Position = posicion; }  
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (ValAdd == false)
            {
                ValAdd = true;                
                if (Permiso != 3)
                {
                    AccionesNavigator(1);
                    ClsContactoProveedor cont = (ClsContactoProveedor)clsContactoProveedorBindingSource.Current;
                    cont.IdProveedor = Convert.ToInt16(clsProveedorComboBox.SelectedValue);
                    cont.Status = 1;
                    
                    clsContactoProveedorBindingSource.ResetBindings(false);
                    this.apell_PatTextBox.Focus();                    
                }
                else
                {
                    MessageBox.Show("No Tiene los privilegios que le \n Permitan Agregar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    AccionCancelar();
                }                
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
                    ClsContactoProveedor CA = (ClsContactoProveedor)clsContactoProveedorBindingSource.Current;
                    
                    CA.Status = 0;
                    clsContactoProveedorBindingSource.ResetBindings(false);
                    ClsContactoProveedor.UpdateContactoProveedor(CA);                    

                    MessageBox.Show("El Contacto del Proveedor se ha sido Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ValAdd = false;
                ListContactoProv = ClsContactoProveedor.ListContactoProveedor(IdProveedor);
                clsContactoProveedorBindingSource.DataSource = ListContactoProv;                                
                AccionesNavigator(0);
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (this.apell_PatTextBox.Text == "") { MessageBox.Show("Proporcione un Apellido Paterno de Contacto Proveedor ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.apell_PatTextBox.Focus(); return; }
                if (this.apell_MatTextBox.Text == "") { MessageBox.Show("Proporcione un Apellido Materno de Contacto Proveedor ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.apell_MatTextBox.Focus(); return; }
                if (this.nombreTextBox.Text == "") { MessageBox.Show("Proporcione un Nombre de Contacto Proveedor ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.nombreTextBox.Focus(); return; }
                                  
                BindingNavigator.Focus();

                nombreTextBox.Focus();
                ClsContactoProveedor CA = (ClsContactoProveedor)clsContactoProveedorBindingSource.Current;
                CA.IdProveedor = Convert.ToInt16(clsProveedorComboBox.SelectedValue);
                CA.Status = 1;               

                if (CA.IdContactoProveedor == 0) //nuevo
                {
                    if (Permiso == 3)
                    {
                        MessageBox.Show("No Tiene los privilegios que le \n Permitan Agregar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        ListContactoProv = ClsContactoProveedor.ListContactoProveedor(IdProveedor);
                        clsContactoProveedorBindingSource.DataSource = ListContactoProv;                        
                        AccionesNavigator(0);
                        return;
                    }

                    if (ValidaContactoProv(CA.Apell_Pat, CA.Apell_Mat, CA.Nombre) == false)
                    {
                        DialogResult Result = MessageBox.Show("Seguro que Desea Agregar el Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Result == DialogResult.Yes)
                        {
                            ClsContactoProveedor.AddContactoProveedor(CA);                            
                            MessageBox.Show("Registro agregado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error el Contacto de Proveedor ya Existe...", "A v i s o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clsContactoProveedorBindingSource.Position = clsContactoProveedorBindingSource.Count;                        
                        this.nombreTextBox.Text = ""; this.nombreTextBox.Focus(); return;
                    }
                }
                else //modifica
                {

                    if (Permiso != 1)
                    {
                        MessageBox.Show("No Tiene los privilegios que le \n Permitan Modificar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        ListContactoProv = ClsContactoProveedor.ListContactoProveedor(IdProveedor);
                        clsContactoProveedorBindingSource.DataSource = ListContactoProv;                        
                        AccionesNavigator(0);
                        return;
                    }

                    if (ValidaContactoProv(CA.Apell_Pat, CA.Apell_Mat, CA.Nombre) == false)
                    {
                        DialogResult Result = MessageBox.Show("Seguro que Desea Modificar el Registro", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Result == DialogResult.Yes)
                        {
                            BindingNavigator.Focus();
                            this.nombreTextBox.Focus();
                            ClsContactoProveedor.UpdateContactoProveedor(CA);                            
                            MessageBox.Show("Registro modificado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error el Contacto de Proveedor ya Existe...", "A v i s o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListContactoProv = ClsContactoProveedor.ListContactoProveedor(IdProveedor);
                        clsContactoProveedorBindingSource.DataSource = ListContactoProv;
                        clsContactoProveedorBindingSource.ResetBindings(false);                        
                        this.nombreTextBox.Focus(); return;
                    }
                }
                ValAdd = false;
                ListContactoProv = ClsContactoProveedor.ListContactoProveedor(IdProveedor);
                clsContactoProveedorBindingSource.DataSource = ListContactoProv;                
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

        private void FrmContactoProveedor_KeyUp(object sender, KeyEventArgs e)
        {
            #region Next Control
                if (e.KeyCode == Keys.Enter)
                { SendKeys.Send("{TAB}"); }
            #endregion
        }

        private void telCasaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == 8))//Validate numbers and Tab keys
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                //if (e.KeyChar == 46)
                //{
                //    if (montoTextBox.Text.IndexOf('.') >= 0)
                //    { e.Handled = true; }
                //    else
                //    {
                //        e.Handled = false;
                //    }
                //}
                //else
                //{ e.Handled = true; }
            }
        }

        private void telCelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == 8))//Validate numbers and Tab keys
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                //if (e.KeyChar == 46)
                //{
                //    if (montoTextBox.Text.IndexOf('.') >= 0)
                //    { e.Handled = true; }
                //    else
                //    {
                //        e.Handled = false;
                //    }
                //}
                //else
                //{ e.Handled = true; }
            }

        }

        private void telEmpresaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == 8))//Validate numbers and Tab keys
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                //if (e.KeyChar == 46)
                //{
                //    if (montoTextBox.Text.IndexOf('.') >= 0)
                //    { e.Handled = true; }
                //    else
                //    {
                //        e.Handled = false;
                //    }
                //}
                //else
                //{ e.Handled = true; }
            }

        }

        private void extensionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == 8))//Validate numbers and Tab keys
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                //if (e.KeyChar == 46)
                //{
                //    if (montoTextBox.Text.IndexOf('.') >= 0)
                //    { e.Handled = true; }
                //    else
                //    {
                //        e.Handled = false;
                //    }
                //}
                //else
                //{ e.Handled = true; }
            }

        }
               


    }
}