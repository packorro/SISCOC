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
    public partial class FrmProspecto : Form
    {
        #region Listas_Variables

            List<ClsCliente> ListCliente;
            List<ClsListas> ListFiltroBusq;
            List<ClsListas> ListTipoPersona;
            List<ClsListas> ListZona;
            List<ClsListas> ListStatus;

            int IdCliente;
            int TipoFiltro = 0;
            int Permiso;

            decimal Suma;
            decimal Subsidio;
            decimal Monto;

            private Boolean Nuevo = false;
            private Boolean ValAdd = false;
            private Boolean Guarda = true;

        #endregion


        public FrmProspecto(int _Permiso)
        {
            InitializeComponent();

            Permiso = _Permiso;

            //Tipo de persona (Cliente)
            ListTipoPersona = ClsListas.ListTipoPersona();
            clsListasTipoPersonaBindingSource.DataSource = ListTipoPersona;

            //Filtro de Busqueda
            ListFiltroBusq = ClsListas.ListBusqueda();
            clsListasFiltrobindingSource.DataSource = ListFiltroBusq;

            //Zona de Cliente
            ListZona = ClsListas.ListZona();
            clsListasZonaBindingSource.DataSource = ListZona;

            //Status de Cliente: 1-Normal,0-Suspendido
            //ListStatus = ClsListas.ListCmbStatus();
            //clsListasStatusBindingSource.DataSource = ListStatus;

            //Cargo la lista de Clientes
            ListCliente = ClsCliente.ListCliente();
            clsClienteBindingSource.DataSource = ListCliente;
            if (ListCliente.Count == 0)
            {
                ClsCliente cont = new ClsCliente();
                ListCliente.Add(cont);
                cont.Status = 1;
                cont.TipoPersona = 1;
                clsListasTipoPersonaComboBox.SelectedValue = 1;
                cont.Zona = 1;
                clsListasComboBox.SelectedValue = 1;
                cont.FechaNac = DateTime.Now;
                this.fechaNacDateTimePicker.Value = DateTime.Now;              

                clsClienteBindingSource.DataSource = ListCliente;
                clsClienteBindingSource.ResetBindings(false);                
                AccionesNavigator(1);
                clsListasTipoPersonaComboBox.Focus();
            }
            else
            {                
                AccionesNavigator(0);
            }   
        }
        
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            clsListasFiltrocomboBox_SelectedIndexChanged(sender, e);

        }

        #region Metodos
            //Para Cancelar la operacion Actual Reestablece 
            private void AccionCancelar()
            {
                ValAdd = false;
                
                clsClienteBindingSource.Position = clsClienteBindingSource.Count;
                clsClienteBindingSource.RemoveCurrent();
                clsClienteBindingSource.ResetBindings(false);
                if (ListCliente.Count == 0)
                {
                    ClsCliente cont = new ClsCliente();
                    ListCliente.Add(cont);
                    clsClienteBindingSource.DataSource =ListCliente;
                    clsClienteBindingSource.ResetBindings(false);
                    AccionesNavigator(1);
                }
                else
                { AccionesNavigator(0); }
            }

            //ACCIONES DEL NAVEGADOR
            public void AccionesNavigator(int inAction) //**
            {
                // 0-Browse   1-Adding     2-Editing
                if (this.clsClienteBindingSource.DataSource != null && this.BindingNavigator.BindingSource != null)
                {
                    switch (inAction)
                    {
                        case 0:
                            {
                                setNavigatorDirections(true);
                                if (clsClienteBindingSource.AllowNew == false)
                                    clsClienteBindingSource.AllowNew = true;
                                cancelToolStripButton.Enabled = false;
                                grpBxFiltro.Enabled = true;
                                bindingNavigatorAddNewItem.Enabled = true;
                                BindingNavigatorDeleteItem.Enabled = clsClienteBindingSource.Count > 0; 
                                CteDirtoolStripButton.Enabled = clsClienteBindingSource.Count > 0;
                                BindingNavigatorSaveItem.Enabled = clsClienteBindingSource.Count > 0;
                                uGridCliente.Enabled = true;
                                break;
                            }

                        case 1:
                            {                               
                                    setNavigatorDirections(false);
                                    if (clsClienteBindingSource.AllowNew == true)
                                        clsClienteBindingSource.AllowNew = false;
                                    cancelToolStripButton.Enabled = true;
                                    grpBxFiltro.Enabled = false;
                                    BindingNavigatorDeleteItem.Enabled = false;
                                    CteDirtoolStripButton.Enabled = false;
                                    BindingNavigatorSaveItem.Enabled = true;                                    
                                    uGridCliente.Enabled = false;
                                    break;
                            }

                        case 2:
                            {
                                setNavigatorDirections(false);

                                if (clsClienteBindingSource.AllowNew == true)
                                    clsClienteBindingSource.AllowNew = false;
                                cancelToolStripButton.Enabled = false;
                                grpBxFiltro.Enabled =false;
                                BindingNavigatorDeleteItem.Enabled = false;
                                CteDirtoolStripButton.Enabled = false;
                                BindingNavigatorSaveItem.Enabled = true;                                
                                uGridCliente.Enabled = false;
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
        
            //VALIDA CLIENTE
            private bool validaCliente(string Apell_Pat, string Apell_Mat, string Nombre, string RFC) //**
            {
                int cont = 0;

                for (int i = 0; i <= clsClienteBindingSource.Count - 1; i++)
                {
                    clsClienteBindingSource.Position = i;
                    ClsCliente CA = (ClsCliente)clsClienteBindingSource.Current;

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
                            ClsCliente cont = new ClsCliente();
                            ListCliente.Add(cont);
                            clsClienteBindingSource.Position = ListCliente.Count;
                            bindingNavigatorAddNewItem_Click(sender, e);
                        }
                    }
                #endregion

                #region Busca_F3
                    if (e.KeyCode == Keys.F3 == true)
                    {
                        //toolStripTextBoxSearch.Focus();
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (ValAdd == false)
            {
                ValAdd = true;

                //***************
                if (Permiso != 3)
                {
                    AccionesNavigator(1);
                    ClsCliente cont = (ClsCliente)clsClienteBindingSource.Current;
                    cont.Status = 1;
                    cont.TipoPersona = 1;
                    clsListasTipoPersonaComboBox.SelectedValue = 1;
                    cont.Zona = 1;
                    cont.FechaNac = DateTime.Now;
                    this.fechaNacDateTimePicker.Value = DateTime.Now;
                    clsListasComboBox.SelectedValue = 1;
                    clsClienteBindingSource.ResetBindings(false);
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

                DialogResult Result = MessageBox.Show("Seguro que desea Eliminar el registro", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    ClsCliente CA = (ClsCliente)clsClienteBindingSource.Current;
                    CA.Status = 0;
                    clsClienteBindingSource.ResetBindings(false);

                    ClsCliente.UpdateCliente(CA);
                    //ClsCliente.UpdateCatalogoCliente(CA);

                    MessageBox.Show("El Prospecto se ha sido Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                ValAdd = false;
                ListCliente = ClsCliente.ListCliente();                
                clsClienteBindingSource.DataSource = ListCliente;
                AccionesNavigator(0);
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.nombreTextBox.Text == "") { MessageBox.Show("Proporcione un Nombre de Prospecto ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.nombreTextBox.Focus(); return; }
                if ((this.subsidioTextBox.Text == "") || (Convert.ToDecimal(this.subsidioTextBox.Text) <= 0)) { MessageBox.Show("Proporcione una cantidad de Subsidio ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.subsidioTextBox.Focus(); return; }
                if ((this.montoTextBox.Text == "") || (Convert.ToDecimal(this.montoTextBox.Text) <= 0)) { MessageBox.Show("Proporcione un Monto ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.montoTextBox.Focus(); return; }
                //if ((this.montoBrutoTextBox.Text == "") || (Convert.ToDecimal(this.montoBrutoTextBox.Text) <= 0)) { MessageBox.Show("Debe de Calcularse un Monto Bruto ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.montoBrutoTextBox.Focus(); return; }

                if (this.clsListasTipoPersonaComboBox.SelectedValue == null) { MessageBox.Show("Proporcione un Tipo de Persona ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.clsListasTipoPersonaComboBox.Focus(); return; }
                //if (this.clsListasStatusComboBox.SelectedValue == null) { MessageBox.Show("Proporcione un Status ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.clsListasStatusComboBox.Focus(); return; }


                BindingNavigator.Focus();

                nombreTextBox.Focus();
                ClsCliente CA = (ClsCliente)clsClienteBindingSource.Current;

                if (CA.CURP == null) { CA.CURP = ""; }
                if (CA.NSS == null) { CA.NSS = ""; }
                if (CA.RFC == null) { CA.RFC = ""; }               

                CA.Subsidio = Convert.ToDecimal(this.subsidioTextBox.Text);
                CA.Monto = Convert.ToDecimal(this.montoTextBox.Text);
                CA.MontoBruto = CA.Subsidio + CA.Monto;
                CA.Status = 1;

                if (Convert.ToInt16(this.clsListasTipoPersonaComboBox.SelectedValue) == 1) //Fisica 1
                {
                    if (this.apell_PatTextBox.Text == "") { MessageBox.Show("Proporcione un Apellido Paterno de Prospecto ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.apell_PatTextBox.Focus(); return; }
                    if (this.apell_MatTextBox.Text == "") { MessageBox.Show("Proporcione un Apellido Materno de Prospecto ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.apell_MatTextBox.Focus(); return; }
                    if ((CA.RFC.Trim().Length < 13) && (this.rFCTextBox.Text != ""))
                    { MessageBox.Show("Proporcione un RFC Valido del Prospecto ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.rFCTextBox.Focus(); return; }
                }
                else //Moral 2
                {
                    CA.Apell_Pat = ""; CA.Apell_Mat = "";
                    if ((CA.RFC.Trim().Length < 12) && (this.rFCTextBox.Text != ""))
                    { MessageBox.Show("Proporcione un RFC Valido del Prospecto ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.rFCTextBox.Focus(); return; }
                }
                
                if (CA.IdCliente == 0) //nuevo
                {
                    if (Permiso == 3)
                    {
                        MessageBox.Show("No Tiene los privilegios que le \n Permitan Agregar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        ListCliente = ClsCliente.ListCliente();
                        clsClienteBindingSource.DataSource = ListCliente;                        
                        AccionesNavigator(0);
                        return;
                    }

                    if (validaCliente(CA.Apell_Pat,CA.Apell_Mat,CA.Nombre,CA.RFC) == false)
                    {
                        DialogResult Result = MessageBox.Show("Seguro que Desea Agregar el Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Result == DialogResult.Yes)
                        {
                            ClsCliente.AddCliente(CA);                            
                            MessageBox.Show("Registro agregado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error el Prospecto ya Existe...", "A v i s o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clsClienteBindingSource.Position = clsClienteBindingSource.Count;
                        this.nombreTextBox.Text = ""; this.nombreTextBox.Focus(); return;
                    }
                }
                else //modifica
                {

                    if (Permiso != 1)
                    {
                        MessageBox.Show("No Tiene los privilegios que le \n Permitan Modificar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        ListCliente = ClsCliente.ListCliente();
                        clsClienteBindingSource.DataSource = ListCliente;                        
                        AccionesNavigator(0);
                        return;
                    }

                    if (validaCliente(CA.Apell_Pat, CA.Apell_Mat, CA.Nombre, CA.RFC) == false)
                    {
                        DialogResult Result = MessageBox.Show("Seguro que Desea Modificar el Registro", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Result == DialogResult.Yes)
                        {
                            BindingNavigator.Focus();
                            this.nombreTextBox.Focus();
                            ClsCliente.UpdateCliente(CA);                            
                            MessageBox.Show("Registro Modificado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error el Prospecto ya Existe...", "A v i s o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListCliente = ClsCliente.ListCliente();
                        clsClienteBindingSource.DataSource = ListCliente;
                        clsClienteBindingSource.ResetBindings(false);                                                                       
                        this.nombreTextBox.Focus(); return;
                    }
                }
                ValAdd = false;                
                ListCliente = ClsCliente.ListCliente();
                clsClienteBindingSource.DataSource = ListCliente;                
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
                  
        private void subsidioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == 8))//Validate numbers and Tab keys
            { e.Handled = false;              
            }
            else
            {
                if (e.KeyChar == 46)
                {
                    if (subsidioTextBox.Text.IndexOf('.') >= 0)
                    { e.Handled = true; }
                    else
                    { e.Handled = false;                      
                    }
                }
                else
                { e.Handled = true; }
            }
          
        }

        private void montoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == 8))//Validate numbers and Tab keys
            { e.Handled = false;            
            }
            else
            {
                if (e.KeyChar == 46)
                {
                    if (montoTextBox.Text.IndexOf('.') >= 0)
                    { e.Handled = true; }
                    else
                    { e.Handled = false;                    
                    }
                }
                else
                { e.Handled = true; }
            }
        }
                
        private void FrmCliente_KeyUp(object sender, KeyEventArgs e)
        {
            #region Next Control
                if (e.KeyCode == Keys.Enter)
                { SendKeys.Send("{TAB}"); }
            #endregion
        }

        private void clsListasFiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoFiltro = Convert.ToInt16(clsListasFiltrocomboBox.SelectedValue);
        }

        private void txtBxBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            int posicion = 0;
            ClienteFilter Filtro = new ClienteFilter(this.txtBxBusqueda.Text.Trim(), TipoFiltro);
            Predicate<ClsCliente> Filtrado = new Predicate<ClsCliente>(Filtro.BuscaAll);

            posicion = ListCliente.FindIndex(Filtrado);
            if (posicion == 0)
            { this.clsClienteBindingSource.Position = 0; }
            else
            { this.clsClienteBindingSource.Position = posicion; }  
        }

        private void clsListasTipoPersonaComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(clsListasTipoPersonaComboBox.SelectedValue) == 2) //Moral 2
                {
                    rFCTextBox.MaxLength = 12;                    
                    apell_PatTextBox.Enabled = false;
                    apell_MatTextBox.Enabled = false;
                    pnlApellidos.Visible = false;
                }
                else //Fisica 1
                {
                    rFCTextBox.MaxLength = 13;                    
                    apell_PatTextBox.Enabled = true;
                    apell_MatTextBox.Enabled = true;
                    pnlApellidos.Visible = true;
                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message + " -- " + Ex.InnerException); }
        }

        private void clsListasTipoPersonaComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            AtajosKeys(sender, e); 
        }

        private void apell_PatTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            AtajosKeys(sender, e); 
        }

        private void apell_MatTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            AtajosKeys(sender, e); 
        }

        private void nombreTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            AtajosKeys(sender, e); 
        }

        private void fechaNacDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            AtajosKeys(sender, e); 
        }

        private void rFCTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            AtajosKeys(sender, e); 
        }

        private void cURPTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            AtajosKeys(sender, e); 
        }

        private void nSSTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            AtajosKeys(sender, e); 
        }

        private void subsidioTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            AtajosKeys(sender, e); 
        }

        private void montoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            AtajosKeys(sender, e); 
        }

        //private void montoBrutoTextBox_KeyDown(object sender, KeyEventArgs e)
        //{
        //    AtajosKeys(sender, e); 
        //}

        private void clsListasComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            AtajosKeys(sender, e); 
        }

        private void CteDirtoolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClsCliente Cliente = (ClsCliente)clsClienteBindingSource.Current;
                IdCliente = Cliente.IdCliente;
                FrmProspectoDireccion ClienteDireccion = new FrmProspectoDireccion(IdCliente, Permiso);
                ClienteDireccion.ShowDialog();
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message + " -- " + Ex.InnerException); }  
        }

        private void subsidioTextBox_TextChanged(object sender, EventArgs e)
        {            
            //try
            //{
            //    if (subsidioTextBox.Text!="")
            //    {
            //        Suma = Convert.ToDecimal(this.subsidioTextBox.Text) + Convert.ToDecimal(this.montoTextBox.Text);
            //        this.montoBrutoTextBox.Text = Suma.ToString();
            //    }
                
            //}
            //catch (Exception Ex) { MessageBox.Show(Ex.Message + " -- " + Ex.InnerException); } 
            clsClienteBindingSource_PositionChanged(sender, e);
        }

        private void montoTextBox_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (montoTextBox.Text != "")
            //    {
            //        Suma = Convert.ToDecimal(this.subsidioTextBox.Text) + Convert.ToDecimal(this.montoTextBox.Text);
            //        this.montoBrutoTextBox.Text = Suma.ToString();
            //    }

            //}
            //catch (Exception Ex) { MessageBox.Show(Ex.Message + " -- " + Ex.InnerException); } 

            clsClienteBindingSource_PositionChanged(sender, e);

        }

        private void clsClienteBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                if (subsidioTextBox.Text == "")
                { subsidioTextBox.Text = "0"; }
                if (montoTextBox.Text == "")
                { montoTextBox.Text = "0"; }

                this.montoBrutoTextBox.Text = Convert.ToString(Convert.ToDecimal(this.subsidioTextBox.Text) + Convert.ToDecimal(this.montoTextBox.Text));
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message + " -- " + Ex.InnerException); } 
        }

        private void clsClienteBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
           // clsClienteBindingSource.Position = 1;
        }

        private void uGridCliente_BeforeRowActivate(object sender, RowEventArgs e)
        {
            clsClienteBindingSource_PositionChanged(sender, e);
            //try
            //{
            //    if (subsidioTextBox.Text == "")
            //    { subsidioTextBox.Text = "0"; }
            //    if (montoTextBox.Text == "")
            //    { montoTextBox.Text = "0"; }

            //    this.montoBrutoTextBox.Text = Convert.ToString(Convert.ToDecimal(this.subsidioTextBox.Text) + Convert.ToDecimal(this.montoTextBox.Text));
            //}
            //catch (Exception Ex) { MessageBox.Show(Ex.Message + " -- " + Ex.InnerException); } 
        }

        private void rFCTextBox_TextChanged(object sender, EventArgs e)
        {

        }   

     
     






    }
}