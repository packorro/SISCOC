using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SISCOC_BL;

namespace SISCOC_FEL
{
    public partial class FrmProspectoDireccion : Form
    {
        #region Listas_Variables

        List<ClsClienteDireccion> ListClienteDireccion;
        int IdCliente;
        int Permiso;

        private Boolean Nuevo = false;
        private Boolean ValAdd = false;
        private Boolean Guarda = true;

        #endregion


        public FrmProspectoDireccion(int _IdCliente,int _Permiso)
        {
            IdCliente = _IdCliente;
            Permiso = _Permiso;

            InitializeComponent();

            ListClienteDireccion = ClsClienteDireccion.ListClienteDireccion(IdCliente);
            clsClienteDireccionBindingSource.DataSource = ListClienteDireccion;
            if (ListClienteDireccion.Count == 0)
            {
                ClsClienteDireccion cont = new ClsClienteDireccion();
                cont.IdCliente = IdCliente;
                ListClienteDireccion.Add(cont);
                clsClienteDireccionBindingSource.DataSource = ListClienteDireccion;
                clsClienteDireccionBindingSource.ResetBindings(false);                  
                AccionesNavigator(1);
            }
            else
            {
                AccionesNavigator(0);
            }   
        }

        private void FrmClienteDireccion_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        #region Metodos
            //Para Cancelar la operacion Actual Reestablece 
            private void AccionCancelar()
            {
                ValAdd = false;
                clsClienteDireccionBindingSource.Position = clsClienteDireccionBindingSource.Count;
                clsClienteDireccionBindingSource.RemoveCurrent();
                clsClienteDireccionBindingSource.ResetBindings(false);                
                if (ListClienteDireccion.Count == 0)
                {
                    ClsClienteDireccion cont = new ClsClienteDireccion();
                    ListClienteDireccion.Add(cont);
                    clsClienteDireccionBindingSource.DataSource = ListClienteDireccion;
                    clsClienteDireccionBindingSource.ResetBindings(false);                    
                    //AccionesNavigator(1);
                }
                else
                { //AccionesNavigator(0); 
                }
            }

            //ACCIONES DEL NAVEGADOR
            public void AccionesNavigator(int inAction) //**
            {
                // 0-Browse   1-Adding     2-Editing
                if (this.clsClienteDireccionBindingSource.DataSource != null && this.BindingNavigator.BindingSource != null)
                {
                    switch (inAction)
                    {
                        case 0:
                            {
                                //setNavigatorDirections(true);
                                if (clsClienteDireccionBindingSource.AllowNew == false)
                                    clsClienteDireccionBindingSource.AllowNew = true;
                                cancelToolStripButton.Enabled = false;                                
                                BindingNavigatorDeleteItem.Enabled = clsClienteDireccionBindingSource.Count > 0; //(chequeraBindingSource.Count > 0);                                
                                BindingNavigatorSaveItem.Enabled = clsClienteDireccionBindingSource.Count > 0;//(chequeraBindingSource.Count > 0);                                
                                break;
                            }

                        case 1:
                            {
                                //setNavigatorDirections(false);
                                if (clsClienteDireccionBindingSource.AllowNew == true)
                                    clsClienteDireccionBindingSource.AllowNew = false;
                                cancelToolStripButton.Enabled = true;
                                BindingNavigatorDeleteItem.Enabled = false;                                
                                BindingNavigatorSaveItem.Enabled = true;                                
                                break;
                            }

                        case 2:
                            {
                                //setNavigatorDirections(false);

                                if (clsClienteDireccionBindingSource.AllowNew == true)
                                    clsClienteDireccionBindingSource.AllowNew = false;
                                cancelToolStripButton.Enabled = false;
                                BindingNavigatorDeleteItem.Enabled = false;                                
                                BindingNavigatorSaveItem.Enabled = true;                                
                                break;
                            }
                    }
                }

            }
                
          
            private void AtajosKeys(object sender, KeyEventArgs e)//atajos de teclado 
            {
                //#region Ayuda_F1
                //if (e.KeyCode == Keys.F1) { }
                //#endregion

                #region Nueva_F2
                    if (e.KeyCode == Keys.F2)
                    {
                        //ClsClienteDireccion cont = new ClsClienteDireccion();
                        //ListClienteDireccion.Add(cont);
                        //clsClienteDireccionBindingSource.Position = ListClienteDireccion.Count;
                        
                        //bindingNavigatorAddNewItem_Click(sender, e);
                    }
                #endregion

                #region Busca_F3
                    //if (e.KeyCode == Keys.F3 == true)
                    //{
                    //    toolStripTextBoxSearch.Focus();
                    //}
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

                #region Cancelaraccion_F7
                    if (e.KeyCode == Keys.F7)
                    {
                        //CuentastoolStripButton_Click(sender, e);
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
                    ClsClienteDireccion CA = (ClsClienteDireccion)clsClienteDireccionBindingSource.Current;                    
                    //CA.Status = 0;
                    clsClienteDireccionBindingSource.ResetBindings(false);
                    ClsClienteDireccion.UpdateClienteDireccion(CA);                           
                    MessageBox.Show("La direccion del Prospecto se ha sido Eliminado Correctamente...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ValAdd = false;
                ListClienteDireccion = ClsClienteDireccion.ListClienteDireccion(IdCliente);
                clsClienteDireccionBindingSource.DataSource = ListClienteDireccion;                
                AccionesNavigator(0);
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.idClienteTextBox.Text == "") { MessageBox.Show("Proporcione un Identificador de Prospecto ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.idClienteTextBox.Focus(); return; }
                //if (this.emailTextBox.Text == "") { MessageBox.Show("Proporcione un Correo ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.emailTextBox.Focus(); return; }
                if (this.domicilioTextBox.Text == "") { MessageBox.Show("Proporcione un Domicilio ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.domicilioTextBox.Focus(); return; }
                if (this.coloniaTextBox.Text == "") { MessageBox.Show("Proporcione una Colonia ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.coloniaTextBox.Focus(); return; }
                if (this.ciudadTextBox.Text == "") { MessageBox.Show("Proporcione una Ciudad ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.ciudadTextBox.Focus(); return; }
                //if (this.telCelTextBox.Text == "") { MessageBox.Show("Proporcione un Telefono Celular ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.telCelTextBox.Focus(); return; }
                //if (this.telCasaTextBox.Text == "") { MessageBox.Show("Proporcione un Telefono residencial ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.telCasaTextBox.Focus(); return; }
                //if (this.empresaTextBox.Text == "") { MessageBox.Show("Proporcione una Empresa ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.empresaTextBox.Focus(); return; }
                //if (this.telEmpresaTextBox.Text == "") { MessageBox.Show("Proporcione un Telefono de la Empresa ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.telEmpresaTextBox.Focus(); return; }

                BindingNavigator.Focus();

                this.emailTextBox.Focus();
                ClsClienteDireccion CA = (ClsClienteDireccion)clsClienteDireccionBindingSource.Current;

                if (CA.Email == null) { CA.Email = ""; }
                if (CA.TelCel == null) { CA.TelCel = ""; }
                if (CA.TelCasa == null) { CA.TelCasa = ""; }
                if (CA.Empresa == null) { CA.Empresa = ""; }
                if (CA.TelEmpresa == null) { CA.TelEmpresa = ""; }                

                if (CA.IdClienteDireccion == 0) //nuevo
                {

                    if (Permiso == 3)
                    {
                        MessageBox.Show("No Tiene los privilegios que le \n Permitan Agregar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        ListClienteDireccion = ClsClienteDireccion.ListClienteDireccion(IdCliente);
                        clsClienteDireccionBindingSource.DataSource = ListClienteDireccion;                        
                        AccionesNavigator(0);
                        return;
                    }
                    
                        DialogResult Result = MessageBox.Show("Seguro que Desea Agregar el Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Result == DialogResult.Yes)
                        {
                            ClsClienteDireccion.AddClienteDireccion(CA);                           
                            MessageBox.Show("Registro agregado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                }
                else //modifica
                {

                    if (Permiso != 1)
                    {
                        MessageBox.Show("No Tiene los privilegios que le \n Permitan Modificar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        ListClienteDireccion = ClsClienteDireccion.ListClienteDireccion(IdCliente);
                        clsClienteDireccionBindingSource.DataSource = ListClienteDireccion;                        
                        AccionesNavigator(0);
                        return;
                    }

                        DialogResult Result = MessageBox.Show("Seguro que Desea Modificar el Registro", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Result == DialogResult.Yes)
                        {
                            BindingNavigator.Focus();
                            this.emailTextBox.Focus();
                            ClsClienteDireccion.UpdateClienteDireccion(CA);                         
                            MessageBox.Show("Registro modificado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }                  
                  
                }
                ValAdd = false;                
                ListClienteDireccion = ClsClienteDireccion.ListClienteDireccion(IdCliente);                
                clsClienteDireccionBindingSource.DataSource = ListClienteDireccion;                
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

        private void telCelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == 8))//Validate numbers and Tab keys
            { e.Handled = false; }
            else
            {
                e.Handled = true;             
            }
        }

        private void telCasaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == 8))//Validate numbers and Tab keys
            { e.Handled = false; }
            else
            {
                e.Handled = true;
            }
        }

        private void telEmpresaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == 8))//Validate numbers and Tab keys
            { e.Handled = false; }
            else
            {
                e.Handled = true;
            }
        }

        private void FrmClienteDireccion_KeyUp(object sender, KeyEventArgs e)
        {
            #region Next Control
                if (e.KeyCode == Keys.Enter)
                { SendKeys.Send("{TAB}"); }
            #endregion
        }




    }
}