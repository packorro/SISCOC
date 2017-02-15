using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using SISCOC_BL; 
using System.Windows.Forms;

namespace SISCOC_FEL
{
    public partial class FrmArticulo_Obra : Form
    {
        int Permiso;
        bool VALIDA;
        bool Adding;
        int Ctn = 0;
        private Boolean ValAdd = false;

        List<ClsListado> Prov;
        List<ClsArticulo> ListArtis;
        List<ClsArticuloObra> LArtiObra;
        List<ClsArticuloObra> ArtiObra;
        List<ClsArticuloObra> LTmp;
        
        public FrmArticulo_Obra(int _Permiso)
        {
            InitializeComponent();

            try
            {
                Permiso = _Permiso;
                ArtiObra = ClsArticuloObra.ListaArticuloObra(0, 0);
                ClsBindingArtiObra.DataSource = ArtiObra;           


                ClsArticuloObra CAO = new ClsArticuloObra();

                //Borro la tabla temporal.
                ClsArticuloObra.DeleteTmpArtiObra(CAO);

                if (ArtiObra.Count == 0)
                {
                    ClsArticuloObra Cont = new ClsArticuloObra();
                    ArtiObra.Add(Cont);                    
                    AccionesNavigator(1);

                }
                else
                {
                    AccionesNavigator(0);
                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

        }

        private void btnBuscObra_Click(object sender, EventArgs e)
        {
            FrmBusqueda Buscar = new FrmBusqueda(0,"O");
            Buscar.Show();
            label3.Text = "";
            label3.Visible = true; 
        }

        private void FrmArticulo_Obra_Load(object sender, EventArgs e)
        {
            ClsArticuloObra CAO = new ClsArticuloObra();

            CAO.IdArticulo = 0;
            CAO.IdObra = 0;
            CAO.Proveedor = "";
            CAO.IdProveedor = 0;
            CAO.Factura = "";
            CAO.ArticuloTmp = "";
            CAO.CantidadArt = 0;
            CAO.Descripcion = "";
            CAO.IdArticuloObra = 0;
            CAO.IdArticuloTmp = 0;

            int Folio = 0;

            //AddArtObraTmp
            if (lblFol.Text.Trim() == "")
            {
                Folio = 0;
            }
            else
            {
                Folio = Convert.ToInt32(this.lblFol.Text.Trim());
            }

            ClsArticuloObra.AddArtObraTmp(CAO, 2, Convert.ToInt32(Folio));

            label3.Text = "";
            label4.Text = "";
            this.lblNomProv.Text = "";
            this.lblNomVivienda.Text = ""; 

            //GridArticulos();

            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Busco Articulos
            ListArtis = ClsArticulo.ListaArticulo(1, txtBuscaArt.Text.Trim(),1);
            ClsArticulos.DataSource = ListArtis;
                     

            ////Desactivo la columna de Seleccion.
            //foreach (Infragistics.Win.UltraWinGrid.UltraGridRow Rn in ListArti.Rows)
            //{
            //    Rn.Cells[9].Value = false;
            //}

            LimpiaGrid(); 

        }

        public void LimpiaGrid()
        {
            //Desactivo la columna de Seleccion.
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow Rn in ListArti.Rows)
            {
                Rn.Cells[11].Value = false;
                Rn.Cells[12].Value = "0"; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Cierro la forma.
            this.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ClsArticuloObra CAO = new ClsArticuloObra();  

            try
            {

                if (ListArti.Rows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar articulos para agregar...", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Ctn = Ctn + 1;

                foreach (Infragistics.Win.UltraWinGrid.UltraGridRow Rn in this.ListArti.Rows)
                {
                    if (Rn.Cells[11].Value.ToString().ToUpper()  == "TRUE")
                    {

                        CAO.IdArticulo = Convert.ToInt32(Rn.Cells[0].Value);
                        CAO.Descripcion = Convert.ToString(Rn.Cells[1].Value);  
                        CAO.CantidadArt  = Convert.ToDecimal(Rn.Cells[12].Value);

                        ClsArticuloObra.AddArtObraTmp(CAO, 1,0);                        
                    }                                        
                }

                LTmp = ClsArticuloObra.ListadoTmp();
                ListArtiObra.DataSource = LTmp;

                this.ListArtiObra.Rows.ColumnFilters[4].Column.Header.Caption = "Cantidad";
                try
                {
                    this.ListArtiObra.Rows.Band.Columns.Add("Elim", "Eliminar");
                    this.ListArtiObra.Rows.ColumnFilters[11].Column.CellAppearance.ImageBackground = SISCOC_FEL.Properties.Resources.delete1;
                    this.ListArtiObra.Rows.ColumnFilters[11].Column.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Image;
                    this.ListArtiObra.Rows.ColumnFilters[11].Column.Width = 65;
                }
                catch (Exception EX)
                { 
                
                }

                GridArticulosTmp("");
              
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message.ToString());
            }

        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {            
                                
                this.BindingNavigator.Focus();
                ClsArticuloObra CA = (ClsArticuloObra)ClsBindingArtiObra.Current;

                if (label3.Text.Trim() != "" || label4.Text.Trim() !=  "") //Cuando es un registro nuevo entra.
                {
                    if (label3.Text.Trim() != "" && ValAdd == false)
                    {
                        CA.IdObra = Convert.ToInt32(label3.Text);
                    }
                    else
                    {
                        CA.IdObra = Convert.ToInt32(textBox1.Text);
                    }

                    if (label4.Text.Trim() != "" && ValAdd == false)
                    {
                        CA.IdProveedor = Convert.ToInt32(this.label4.Text);
                    }
                    else
                    {
                        CA.IdProveedor = Convert.ToInt32(this.txtIdProv.Text);
                    }

                    //CA.IdObra = Convert.ToInt32(label3.Text);
                    //CA.IdProveedor = Convert.ToInt32(this.label4.Text);
                    CA.Factura = this.txtFactura.Text;
                }

                if (CA.IdArticuloObra == 0) //Nuevo
                {
                    if (Permiso == 3)
                    {
                        MessageBox.Show("No Tiene los privilegios que le \n Permitan Agregar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        LArtiObra = ClsArticuloObra.ListaArticuloObra(0, 0);
                        ClsBindingArtiObra.DataSource = LArtiObra;
                        AccionesNavigator(0);
                        return;
                    }

                    //Reviso el grid de los articulos.
                    if (ListArti.Rows.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar articulos para continuar...", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    //Reviso si esta capturada la factura.
                    if (txtFactura.Text.Trim() == "") { MessageBox.Show("Falta capturar la referencia de la Factura...", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK); return; }

                    ClsArticuloObra.AddArtiObra(CA, 1);
                    ClsArticuloObra.AddArtiObra(CA, 2);

                    txtBuscaArt.Text = "";
                    ListArti.DataBind();

                    label3.Visible = false;
                    label4.Visible = false;
                    this.lblNomProv.Visible = false;
                    this.lblNomVivienda.Visible = false; 

                    ValAdd = true;
                    LimpiaGrid();

                    MessageBox.Show("Registro agregado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }

                //Modificación
                else
                {

                    if (Permiso != 1)
                    {
                        MessageBox.Show("No Tiene los privilegios que le \n Permitan Modificar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        label3.Visible = false;
                        label4.Visible = false;
                        this.lblNomProv.Visible = false;
                        this.lblNomVivienda.Visible = false; 

                        LimpiaGrid();

                        ArtiObra = ClsArticuloObra.ListaArticuloObra(0, 0);
                        this.ClsBindingArtiObra.DataSource = ArtiObra;
                        AccionesNavigator(0);
                        return; 
                    }

                    if (MessageBox.Show("Esta por Modificar un Registro, ¿Desea Continuar?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        ClsArticuloObra.UpdateArticuloObra(CA, 1);
                        ClsArticuloObra.AddArtiObra(CA, 3);

                        MessageBox.Show("Registro modificado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
                //btnBuscObra.Enabled = false;
                //btnBuscaProv.Enabled = false;
                //btnBuscaArti.Enabled = false;

                label3.Visible = false;
                label4.Visible = false;
                this.lblNomProv.Visible = false;
                this.lblNomVivienda.Visible = false; 

                LimpiaGrid();

                ArtiObra = ClsArticuloObra.ListaArticuloObra(0, 0);
                this.ClsBindingArtiObra.DataSource = ArtiObra;
                AccionesNavigator(0);

                btnBuscaFactura.Enabled = true; 

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);
            }
        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ValAdd = false;
            Ctn = 0;
            lblNomVivienda.Text = "";
            lblNomProv.Text = "";
            label3.Text = "";
            label4.Text =""; 
            if (ValAdd == false)
            {
                ValAdd = true;
                if (Permiso != 3)
                {
                    ValAdd = false;
                    AccionesNavigator(1);
                    ClsArticuloObra cont = (ClsArticuloObra)ClsArtiObra.Current;                      
                    ClsArtiObra.ResetBindings(false);

                    btnBuscObra.Enabled = true;
                    btnBuscaProv.Enabled = true;
                    btnBuscaArti.Enabled = true; 

                    label3.Visible = true; 
                    label4.Visible = true;
                    this.lblNomProv.Visible =true;
                    this.lblNomVivienda.Visible = true;
  
                    ClsArticuloObra CAO = new ClsArticuloObra(); 

                    //Borro el grid de Articulos del Kit.
                    ClsArticuloObra.DeleteTmpArtiObra(CAO);

                    ListArtiObra.DataSource = null;
                    ListArtiObra.DataBind(); 

                    //Deshabilito boton de busqueda de facturas...
                    btnBuscaFactura.Enabled = false; 
                }
                else
                {
                    MessageBox.Show("No Tiene los privilegios que le \n Permitan Agregar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    AccionCancelar();
                }             
            }
            
        }

        //OPCIÓN CANCELAR
        private void AccionCancelar()
        {
            ValAdd = false;
            ClsBindingArtiObra.Position = ClsBindingArtiObra.Count;
            ClsBindingArtiObra.RemoveCurrent();
            ClsBindingArtiObra.ResetBindings(false);


            if (ArtiObra.Count == 0)
            {
                ClsArticuloObra cont = new ClsArticuloObra();
                ArtiObra.Add(cont);
                ClsBindingArtiObra.DataSource = ArtiObra;
                ClsBindingArtiObra.ResetBindings(false);
                AccionesNavigator(1);
            }
            else
            { AccionesNavigator(0); }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {



            this.BindingNavigator.Focus();
            ClsArticuloObra CA = (ClsArticuloObra)ClsBindingArtiObra.Current;

            if (Permiso != 1)
            {
                MessageBox.Show("No tiene los privilegios que le \n Permitan Eliminar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                LArtiObra = ClsArticuloObra.ListaArticuloObra(0, 0);
                ClsBindingArtiObra.DataSource = LArtiObra;
                AccionesNavigator(0);
                return;
            }

            DialogResult Result = MessageBox.Show("¿Seguro que Desea Eliminar el Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {                
                ClsArticuloObra.UpdateArticuloObra(CA, 2);
                LArtiObra = ClsArticuloObra.ListaArticuloObra(0, 0);
                ClsBindingArtiObra.DataSource = LArtiObra;
                AccionesNavigator(0);
                return;

                MessageBox.Show("Registro eliminado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }


            
        }


        private void cancelToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (cancelToolStripButton.Enabled != false)
                {
                    AccionCancelar();
                    label3.Visible = false;
                    label4.Visible = false;
                    this.lblNomProv.Visible = false;
                    this.lblNomVivienda.Visible = false; 
                    //ListArtiObra.DataBind();
                    //ListArti.DataBind();                    

                    //Busco Articulos
                    //ListArtis = ClsArticulo.ListaArticulo(1,"0",1);
                    //ClsArticulos.DataSource = ListArtis;

                    //Articulos Actuales
                    LArtiObra = ClsArticuloObra.BuscaArti_Obra(1, Convert.ToInt32(this.lblFol.Text));
                    ListArtiObra.DataSource = LArtiObra;         


                    txtBuscaArt.Text = "";
                    GridArticulos();
                    Ctn = 0;
                    btnBuscaFactura.Enabled = true; 

                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); } 
        }
           

        private void lblFol_TextChanged(object sender, EventArgs e)
        {
            //Cargo el grid  de Articulo
            this.ListArti.DataBind();

            LArtiObra =  ClsArticuloObra.BuscaArti_Obra(1, Convert.ToInt32(this.lblFol.Text));
            ListArtiObra.DataSource = LArtiObra;

            GridArticulos();

            ClsArticuloObra CA = new ClsArticuloObra();
 
            //Agrego los Articulos al Grid
            ClsArticuloObra.AddArtObraTmp(CA, 2, Convert.ToInt32(this.lblFol.Text));

            

        }

        private void label3_TextChanged(object sender, EventArgs e)
        {
            
        }

        //OPCION NAVIGATOR
        public void AccionesNavigator(int inAction) //**
        {
            try
            {
                // 0-Browse   1-Adding     2-Editing
                if (ClsBindingArtiObra.DataSource != null && BindingNavigator.BindingSource != null)
                {
                    switch (inAction)
                    {
                        case 0:
                            {
                                setNavigatorDirections(true);
                                if (ClsBindingArtiObra.AllowNew == false)
                                    ClsBindingArtiObra.AllowNew = true;
                                cancelToolStripButton.Enabled = false;
                                bindingNavigatorAddNewItem.Enabled = true;
                                BindingNavigatorDeleteItem.Enabled = ClsBindingArtiObra.Count > 0;
                                BindingNavigatorSaveItem.Enabled = ClsBindingArtiObra.Count > 0;
                                //PermisostoolStripButton.Enabled = ClsArticuloBindingSource.Count > 0;
                                //NotificaciontoolStripButton.Enabled = ClsArticuloBindingSource.Count > 0;
                                //ConfiguraciontoolStripButton.Enabled = ClsArticuloBindingSource.Count > 0;
                                toolStripTextBoxSearch.Visible = true;
                                ListArti.Enabled = true;

                                //btnBuscObra.Enabled = false;
                                //btnBuscaProv.Enabled = false;
                                //btnBuscaArti.Enabled = false; 
                                break;
                            }
                        case 1:
                            {
                                setNavigatorDirections(false);
                                if (ClsBindingArtiObra.AllowNew == true)
                                    ClsBindingArtiObra.AllowNew = false;
                                cancelToolStripButton.Enabled = true;
                                BindingNavigatorDeleteItem.Enabled = false;
                                BindingNavigatorSaveItem.Enabled = true;
                                //bindingNavigatorAddNewItem.Enabled = false;
                                //PermisostoolStripButton.Enabled = false;
                                //NotificaciontoolStripButton.Enabled = false;
                                //ConfiguraciontoolStripButton.Enabled = false;
                                toolStripTextBoxSearch.Visible = false;
                                //ultraGrid1.Enabled = false;
                                btnBuscObra.Enabled = true;
                                btnBuscaProv.Enabled = true; 
                                btnBuscaArti.Enabled = true;
                                Adding = true; 
                                break;
                            }
                        case 2:
                            {
                                setNavigatorDirections(false);
                                if (ClsBindingArtiObra.AllowNew == true)
                                    ClsBindingArtiObra.AllowNew = false;
                                cancelToolStripButton.Enabled = false;
                                BindingNavigatorDeleteItem.Enabled = false;
                                BindingNavigatorSaveItem.Enabled = true;
                                //PermisostoolStripButton.Enabled = false;
                                //NotificaciontoolStripButton.Enabled = false;
                                //ConfiguraciontoolStripButton.Enabled = false;
                                toolStripTextBoxSearch.Visible = false;
                                ListArti.Enabled = false;
                                break;
                            }
                    }
                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }


        //OPCION PARA LA NAVEGACIÓN
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

        private void BindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripTextBoxSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscaProv_Click(object sender, EventArgs e)
        {
            FrmBusqueda Buscar = new FrmBusqueda(0, "P");
            label4.Text = "";
            label4.Visible = true; 
            Buscar.Show();            
        }

        public void GridArticulos()
        {
            this.ListArtiObra.Rows.ColumnFilters[3].Column.Header.Caption = "Clave";
            this.ListArtiObra.Rows.ColumnFilters[4].Column.Header.Caption = "Cantidad";            
            this.ListArtiObra.Rows.ColumnFilters[5].Column.Header.Caption = "Descripción";
            this.ListArtiObra.Rows.ColumnFilters[4].Column.Width = 90;
            this.ListArtiObra.Rows.ColumnFilters[5].Column.Width = 370;
            this.ListArtiObra.Rows.ColumnFilters[4].Column.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            this.ListArtiObra.Rows.ColumnFilters[5].Column.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            this.ListArtiObra.Rows.ColumnFilters[3].Column.Hidden = false;
            this.ListArtiObra.Rows.ColumnFilters[5].Column.Hidden = false;
            this.ListArtiObra.Rows.ColumnFilters[0].Column.Hidden = true;
            this.ListArtiObra.Rows.ColumnFilters[1].Column.Hidden = true;
            this.ListArtiObra.Rows.ColumnFilters[2].Column.Hidden = true;
            this.ListArtiObra.Rows.ColumnFilters[8].Column.Hidden = true;
            this.ListArtiObra.Rows.ColumnFilters[9].Column.Hidden = true;
            this.ListArtiObra.Rows.ColumnFilters[6].Column.Hidden = true;
            this.ListArtiObra.Rows.ColumnFilters[7].Column.Hidden = true;
            this.ListArtiObra.Rows.ColumnFilters[10].Column.Hidden = true;
        }

        public void GridArticulosTmp(string Origen)
        {
            this.ListArtiObra.Rows.ColumnFilters[0].Column.Hidden = true;
            this.ListArtiObra.Rows.ColumnFilters[1].Column.Hidden = true;
            this.ListArtiObra.Rows.ColumnFilters[2].Column.Hidden = true;
            this.ListArtiObra.Rows.ColumnFilters[3].Column.Hidden = true;
            this.ListArtiObra.Rows.ColumnFilters[5].Column.Hidden = true;
            //this.ListArtiObra.Rows.ColumnFilters[6].Column.Hidden = false;
            this.ListArtiObra.Rows.ColumnFilters[8].Column.Hidden = true;
            this.ListArtiObra.Rows.ColumnFilters[9].Column.Hidden = true;
            this.ListArtiObra.Rows.ColumnFilters[10].Column.Hidden = true;
            this.ListArtiObra.Rows.ColumnFilters[6].Column.Header.Caption = "Clave";
            this.ListArtiObra.Rows.ColumnFilters[7].Column.Header.Caption = "Descripción";
            this.ListArtiObra.Rows.ColumnFilters[6].Column.Hidden = false;
            this.ListArtiObra.Rows.ColumnFilters[7].Column.Hidden = false;   
            

            if (ValAdd == true && Ctn == 1 && Origen != "E")
            {
                this.ListArtiObra.Rows.Band.Columns.Add("Elim", "Eliminar");
                this.ListArtiObra.Rows.ColumnFilters[11].Column.CellAppearance.ImageBackground = SISCOC_FEL.Properties.Resources.delete1;
                this.ListArtiObra.Rows.ColumnFilters[11].Column.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Image;
                this.ListArtiObra.Rows.ColumnFilters[11].Column.Width = 65;
            }
                

            //this.ListArtiObra.Rows.ColumnFilters[4].Column.Hidden = false;            
            //this.ListArtiObra.Rows.ColumnFilters[7].Column.Hidden = false;
            ////this.ListArtiObra.Rows.ColumnFilters[3].Column.Header.VisiblePosition = 4;

            this.ListArtiObra.Rows.ColumnFilters[4].Column.Header.VisiblePosition = 10;            
            //this.ListArtiObra.Rows.ColumnFilters[7].Column.Header.Caption = "Descripcion";
            //this.ListArtiObra.Rows.ColumnFilters[4].Column.Header.Caption = "Cantidad";
            this.ListArtiObra.Rows.ColumnFilters[4].Column.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Right;
            this.ListArtiObra.Rows.ColumnFilters[4].Column.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;                    
            this.ListArtiObra.Rows.ColumnFilters[7].Column.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Left;   
            this.ListArtiObra.Rows.ColumnFilters[7].Column.Width = 370;

            //this.ListArtiObra.Rows.ColumnFilters[4].Column.Header.Caption = "Cantidad";
            //this.ListArtiObra.Rows.ColumnFilters[5].Column.Header.Caption = "Descripcion";
            this.ListArtiObra.Rows.ColumnFilters[4].Column.Width = 90;
            this.ListArtiObra.Rows.ColumnFilters[5].Column.Width = 370;
            this.ListArtiObra.Rows.ColumnFilters[4].Column.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            this.ListArtiObra.Rows.ColumnFilters[5].Column.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;


        }

        private void ListArtiObra_DoubleClick(object sender, EventArgs e)
        {

        }

        private void ListArtiObra_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            try
            {

                ClsArticuloObra CAo = new ClsArticuloObra(); 

                int Ren=0;
                string Articulo = "";

                //if ((ValAdd == true || Adding == true) || Adding == false)
                //{
                //    Ren = Convert.ToInt32(e.Row.Cells[6].Text);
                //}
                //else
                //{
                //    Ren = Convert.ToInt32(e.Row.Cells[3].Text);                    
                //}

                if (e.Row.Cells[3].Text.ToString() != "0")
                {
                    Ren = Convert.ToInt32(e.Row.Cells[3].Text);
                    Articulo = Convert.ToString(e.Row.Cells[5].Text);
                }
                else
                {
                    Ren = Convert.ToInt32(e.Row.Cells[6].Text);
                    Articulo = Convert.ToString(e.Row.Cells[7].Text);
                }

                //Articulo = Convert.ToString(e.Row.Cells[5].Text);

                
                if (e.Row.Cells[11].Activated == true)
                {
                    CAo.IdArticuloTmp = Ren;   

                    DialogResult dr =
                           MessageBox.Show("Estas seguro de borrar el Articulo: " + Articulo.ToString(),"AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {

                        //Borro el articulo seleccionado
                        ClsArticuloObra.DeleteTmpArtiObra(CAo);

                        //Llenamos de nuevo el Grid de Articulos que contiene el Kit
                        LTmp = ClsArticuloObra.ListadoTmp();
                        ListArtiObra.DataSource = LTmp;

                        GridArticulosTmp("E");
                    }

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message.ToString());
            }

        }

        private void toolStripTextBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            int posicion = 0;

            FilterFactura Filtro = new FilterFactura(this.toolStripTextBoxSearch.Text.Trim());
            Predicate<ClsArticuloObra> Filtrado = new Predicate<ClsArticuloObra>(Filtro.BuscaFacturaLike);
            posicion = ArtiObra.FindIndex(Filtrado);

            if (posicion == 0)
            {
                this.ClsBindingArtiObra.Position = 0;
            }
            else
            {
                this.ClsBindingArtiObra.Position = posicion;  
            }

            
        }

        private void lblProveedor_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}