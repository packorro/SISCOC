using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SISCOC_BL;

namespace SISCOC_FEL
{
    public partial class FrmObra : Form
    {
        #region Variables
            List<ClsObra> ListObras;
            List<ClsListas> ListZona;
           //List<ClsListas> ListStatus;

            int Permiso;

            private Boolean ValAdd = false;
        #endregion

        public FrmObra(int _Permiso)
        {
           try
            {
                Permiso = _Permiso;

                InitializeComponent();

                ListZona = ClsListas.ListZona();
                clsListasZonaBindingSource.DataSource = ListZona;

                //ListStatus = ClsListas.ListCmbStatus();
                //clsListasStatusBindingSource.DataSource = ListStatus;

                ListObras = ClsObra.ListObras();
                clsObraBindingSource.DataSource = ListObras;
                if (ListObras.Count == 0)
                {
                    ClsObra cont = new ClsObra();

                    cont.Status = 1;
                    //this.fechaIniDateTimePicker.Value = DateTime.Now;
                    //cont.FechaIni = DateTime.Now;

                    //this.fechaFinDateTimePicker.Value = DateTime.Now;
                    //cont.FechaFin = DateTime.Now;
                    cont.Zona = 1;
                    clsListaZonaComboBox.SelectedValue = 1;
                    this.nombreObraTextBox.Focus();

                    ListObras.Add(cont);
                    clsObraBindingSource.DataSource = ListObras;
                    clsObraBindingSource.ResetBindings(false);                    
                    AccionesNavigator(1);
                }
                else
                {
                    AccionesNavigator(0);
                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message + " -- " + Ex.InnerException); }
        }
        
        private void FrmObra_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }


        #region Metodos        

            public void AccionesNavigator(int inAction) //**
            {
                try
                {
                    // 0-Browse   1-Adding     2-Editing
                    if (clsObraBindingSource.DataSource != null && BindingNavigator.BindingSource != null)
                    {
                        switch (inAction)
                        {
                            case 0:
                                {
                                    setNavigatorDirections(true);
                                    if (clsObraBindingSource.AllowNew == false)
                                        clsObraBindingSource.AllowNew = true;
                                    cancelToolStripButton.Enabled = false;
                                    bindingNavigatorAddNewItem.Enabled = true;
                                    BindingNavigatorDeleteItem.Enabled = clsObraBindingSource.Count > 0;
                                    BindingNavigatorSaveItem.Enabled = clsObraBindingSource.Count > 0;
                                    toolStripTextBoxSearch.Visible = true;
                                    uGridObras.Enabled = true;
                                    break;
                                }
                            case 1:
                                {
                                    setNavigatorDirections(false);
                                    if (clsObraBindingSource.AllowNew == true)
                                        clsObraBindingSource.AllowNew = false;
                                    cancelToolStripButton.Enabled = true;
                                    //bindingNavigatorAddNewItem.Enabled = false;
                                    BindingNavigatorDeleteItem.Enabled = false;
                                    BindingNavigatorSaveItem.Enabled = true;
                                    toolStripTextBoxSearch.Visible = false;
                                    uGridObras.Enabled = false;

                                    break;
                                }
                            case 2:
                                {
                                    setNavigatorDirections(false);

                                    if (clsObraBindingSource.AllowNew == true)
                                        clsObraBindingSource.AllowNew = false;

                                    cancelToolStripButton.Enabled = false;
                                    BindingNavigatorDeleteItem.Enabled = false;
                                    BindingNavigatorSaveItem.Enabled = true;
                                    toolStripTextBoxSearch.Visible = false;
                                    uGridObras.Enabled = false;
                                    break;
                                }
                        }
                    }
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }

            //OPCION NAVEGAR
            private void setNavigatorDirections(bool inVisible) //**
            {
                try
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
                        toolStripLabel2.Visible = inVisible;
                        toolStripTextBoxSearch.Visible = inVisible;
                    }
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }

            private void AccionCancelar()
            {
                ValAdd = false;

                clsObraBindingSource.Position = clsObraBindingSource.Count;
                clsObraBindingSource.RemoveCurrent();
                clsObraBindingSource.ResetBindings(false);

                if (ListObras.Count == 0)
                {
                    ClsObra cont = new ClsObra();
                    ListObras.Add(cont);
                    clsObraBindingSource.DataSource = ListObras;
                    clsObraBindingSource.ResetBindings(false);                
                    AccionesNavigator(1);
                }
                else
                { AccionesNavigator(0); }
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
                            ClsObra NObra = new ClsObra();
                            ListObras.Add(NObra);
                            clsObraBindingSource.Position = ListObras.Count;
                            bindingNavigatorAddNewItem_Click(sender, e);
                        }
                    }
                #endregion

                #region Busca_F3
                    if (e.KeyCode == Keys.F3 == true)
                    {
                        toolStripTextBoxSearch.Focus();
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

            private bool validanombreAdd(string NombreObra) //**
            {
                int posicion = 0;                        
                CatalogoObraFilter Filtro=new CatalogoObraFilter(NombreObra.Trim());
                Predicate<ClsObra> Filtrado = new Predicate<ClsObra>(Filtro.BuscaCatalogoObraNombre);
                posicion = ListObras.FindIndex(Filtrado);
                clsObraBindingSource.Position = posicion;
                ClsObra CA = (ClsObra)clsObraBindingSource.Current;            
                if (CA.NombreObra ==NombreObra && CA.IdObra == 0)
                { return false; }
                else
                { return true; }
            }

            private bool validanombreUpDate(string NombreObra) //**
            {
                int cont = 0;

                for (int i = 0; i <=clsObraBindingSource.Count - 1; i++)
                {
                    clsObraBindingSource.Position = i;
                    ClsObra CA = (ClsObra)clsObraBindingSource.Current;                
                    if (CA.NombreObra==NombreObra)
                    { cont = cont + 1; }
                }
                if (cont >= 2)
                { return true; }
                else
                { return false; }
            }

        #endregion


        private void montoEstimadoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == 8))//Validate numbers and Tab keys
            { e.Handled = false; }
            else
            {
                if (e.KeyChar == 46)
                {
                    if (montoEstimadoTextBox.Text.IndexOf('.') >= 0)
                    { e.Handled = true; }
                    else
                    { e.Handled = false; }
                }
                else
                { e.Handled = true; }
            }
        }

        private void FrmObra_KeyUp(object sender, KeyEventArgs e)
        {
            #region Next Control
                if (e.KeyCode == Keys.Enter)
                { SendKeys.Send("{TAB}"); }
            #endregion
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (ValAdd == false)
            {
                ValAdd = true;
                //***************
                if (Permiso!=3)
                {
                    AccionesNavigator(1);
                    ClsObra cont = (ClsObra)clsObraBindingSource.Current;
                    cont.Status = 1;
                    //this.fechaIniDateTimePicker.Value = DateTime.Now;
                    //cont.FechaIni = DateTime.Now;

                    //this.fechaFinDateTimePicker.Value = DateTime.Now;
                    //cont.FechaFin = DateTime.Now;
                    cont.Zona = 1;
                    clsListaZonaComboBox.SelectedValue = 1;
                    nombreObraTextBox.Focus();
                    clsObraBindingSource.ResetBindings(false);
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

                DialogResult dr =
                   MessageBox.Show("Estas seguro de borrar el Registro ",
                   "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    ClsObra CA = (ClsObra)clsObraBindingSource.Current;
                    CA.Status = 0;
                    ClsObra.UpdateObra(CA);
                    clsObraBindingSource.RemoveCurrent();                    
                    MessageBox.Show("Registro Eliminado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (ListObras.Count == 0)
                {
                    AccionesNavigator(0);
                }                
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }   
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.nombreObraTextBox.Text == "") { MessageBox.Show("Proporcione un Nombre de Vivienda ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.nombreObraTextBox.Focus(); return; }
                if (this.descripcionObraTextBox.Text == "") { MessageBox.Show("Proporcione una Descripcion de Vivienda ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.descripcionObraTextBox.Focus(); return; }                                
                //if (fechaIniDateTimePicker.Value > this.fechaFinDateTimePicker.Value) { MessageBox.Show("La Fecha Inicial debe ser Menor o Igual a la Fecha Final ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.fechaIniDateTimePicker.Focus(); return; }                
                if (this.montoEstimadoTextBox.Text == "") { MessageBox.Show("Proporcione un Monto Estimado de Vivienda ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.montoEstimadoTextBox.Focus(); return; }

                if (Convert.ToDecimal(this.montoEstimadoTextBox.Text) <= 0) { MessageBox.Show("Proporcione el Importe del Monto Estimado ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.montoEstimadoTextBox.Focus(); return; }
                if (this.clsListaZonaComboBox.SelectedValue == null) { MessageBox.Show("Proporcione una Zona de Vivienda ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.clsListaZonaComboBox.Focus(); return; }
                //if (this.clsListaStatusComboBox.SelectedValue == null) { MessageBox.Show("Proporcione un Status de Obra ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.clsListaStatusComboBox.Focus(); return; }

                BindingNavigator.Focus();
                nombreObraTextBox.Focus();
                ClsObra CA = (ClsObra)clsObraBindingSource.Current;
                CA.FechaIni = DateTime.Now;
                CA.FechaFin = DateTime.Now;
                CA.Status = 1;

                if (CA.IdObra== 0) //Nuevo
                {
                    if (Permiso==3)
                    {
                        MessageBox.Show("No Tiene los privilegios que le \n Permitan Agregar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        ListObras = ClsObra.ListObras();
                        clsObraBindingSource.DataSource = ListObras;                        
                        AccionesNavigator(0);
                        return;
                    }

                    if (validanombreAdd(CA.NombreObra) == false)
                    {
                        DialogResult Result = MessageBox.Show("Seguro que Desea Agregar el Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Result == DialogResult.Yes)
                        {
                            ClsObra.AddObra(CA);                            
                            MessageBox.Show("Registro agregado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error el Nombre de la Vivienda ya Existe...", "A v i s o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clsObraBindingSource.Position = clsObraBindingSource.Count;
                        this.nombreObraTextBox.Text = ""; this.nombreObraTextBox.Focus(); return;
                    }
                }
                else //Modifica
                {
                    if (Permiso != 1)
                    {
                        MessageBox.Show("No Tiene los privilegios que le \n Permitan Modificar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        ListObras = ClsObra.ListObras();
                        clsObraBindingSource.DataSource = ListObras;                        
                        AccionesNavigator(0);
                        return;
                    }

                    if (validanombreUpDate(CA.NombreObra) == false)
                    {
                        DialogResult Result = MessageBox.Show("Seguro que Desea Modificar el Registro", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Result == DialogResult.Yes)
                        {
                            BindingNavigator.Focus();
                            this.nombreObraTextBox.Focus();
                            ClsObra.UpdateObra(CA);                            
                            MessageBox.Show("Registro modificado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error el Nombre de la Vivienda ya Existe...", "A v i s o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListObras = ClsObra.ListObras();                        
                        clsObraBindingSource.DataSource = ListObras;                        
                        clsObraBindingSource.ResetBindings(false);                          
                        this.nombreObraTextBox.Focus(); return;
                    }
                }
                ValAdd = false;
                ListObras = ClsObra.ListObras();
                clsObraBindingSource.DataSource = ListObras;                
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
            catch (Exception Ex) { MessageBox.Show(Ex.Message); } 
        }

        private void nombreObraTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            AtajosKeys(sender, e); 
        }

        private void descripcionObraTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            AtajosKeys(sender, e); 
        }

        private void toolStripTextBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            int posicion = 0;

            CatalogoObraFilter Filtro = new CatalogoObraFilter(this.toolStripTextBoxSearch.Text.Trim());
            Predicate<ClsObra> Filtrado = new Predicate<ClsObra>(Filtro.BuscaCatalogoObraNombreLike);
            posicion = ListObras.FindIndex(Filtrado);                                  

            if (posicion == 0)
            { this.clsObraBindingSource.Position = 0; }
            else
            {clsObraBindingSource.Position = posicion; }
        }

        private void clsObraBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //this.montoEstimadoTextBox.Text.ToString("##,###,##0.00");
            
        }

    

      




    }
}