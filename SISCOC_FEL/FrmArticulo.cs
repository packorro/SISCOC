using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SISCOC_BL; 
using System.Diagnostics;
using System.Configuration;
using System.Reflection;   

namespace SISCOC_FEL
{
    public partial class FrmArticulo : Form
    {

        //bool VALIDA;
        private Boolean ValAdd = false;
        int Permiso;

       
        List<ClsListado> LBodega;
        List<ClsListado> LKit;
        List<ClsListado> LGrupo;
        List<ClsArticulo> LArticulo;
        List<ClsArticulo> ListaArticulo;

        public FrmArticulo(int _Permiso)
        {
            InitializeComponent();

            try
            {
                Permiso = _Permiso;

                LBodega = ClsListado.CmdBodega();
                this.ClsListado1.DataSource = LBodega;

                LKit = ClsListado.CmdKit();
                this.ClsListado2.DataSource = LKit;

                LArticulo = ClsArticulo.ListaArticulo(1,"",1);
                this.ClsArticuloBindingSource.DataSource = LArticulo;

                ClsArticuloBindingSource.DataSource = LArticulo;
                if (LArticulo.Count == 0)
                {
                    ClsArticulo cont = new ClsArticulo();
                    LArticulo.Add(cont);
                    ClsArticuloBindingSource.DataSource = LArticulo;
                    ClsArticuloBindingSource.ResetBindings(false);
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (ValAdd == false)
            {
                ValAdd = true;
                //***************
                if (Permiso != 3)
                {
                    ValAdd = true;
                    AccionesNavigator(1);
                    ClsArticulo cont = (ClsArticulo)ClsArticuloBindingSource.Current;
                    ClsArticuloBindingSource.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("No Tiene los privilegios que le \n Permitan Agregar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    AccionCancelar();
                }
                //*****************

            }


        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        //OPCION NAVIGATOR
        public void AccionesNavigator(int inAction) //**
        {
            try
            {
                // 0-Browse   1-Adding     2-Editing
                if (ClsArticuloBindingSource.DataSource != null && BindingNavigator.BindingSource != null)
                {
                    switch (inAction)
                    {
                        case 0:
                            {
                                setNavigatorDirections(true);
                                if (ClsArticuloBindingSource.AllowNew == false)
                                    ClsArticuloBindingSource.AllowNew = true;
                                cancelToolStripButton.Enabled = false;
                                bindingNavigatorAddNewItem.Enabled = true;
                                BindingNavigatorDeleteItem.Enabled = ClsArticuloBindingSource.Count > 0;
                                BindingNavigatorSaveItem.Enabled = ClsArticuloBindingSource.Count > 0;
                                //PermisostoolStripButton.Enabled = ClsArticuloBindingSource.Count > 0;
                                //NotificaciontoolStripButton.Enabled = ClsArticuloBindingSource.Count > 0;
                                //ConfiguraciontoolStripButton.Enabled = ClsArticuloBindingSource.Count > 0;
                                toolStripTextBoxSearch.Visible = true;
                                ultraGrid1.Enabled = true;
                                break;
                            }
                        case 1:
                            {
                                setNavigatorDirections(false);
                                if (ClsArticuloBindingSource.AllowNew == true)
                                    ClsArticuloBindingSource.AllowNew = false;
                                cancelToolStripButton.Enabled = true;
                                BindingNavigatorDeleteItem.Enabled = false;
                                BindingNavigatorSaveItem.Enabled = true;
                                //PermisostoolStripButton.Enabled = false;
                                //NotificaciontoolStripButton.Enabled = false;
                                //ConfiguraciontoolStripButton.Enabled = false;
                                toolStripTextBoxSearch.Visible = false;
                                ultraGrid1.Enabled = false;
                                break;
                            }
                        case 2:
                            {
                                setNavigatorDirections(false);
                                if (ClsArticuloBindingSource.AllowNew == true)
                                    ClsArticuloBindingSource.AllowNew = false;
                                cancelToolStripButton.Enabled = false;
                                BindingNavigatorDeleteItem.Enabled = false;
                                BindingNavigatorSaveItem.Enabled = true;
                                //PermisostoolStripButton.Enabled = false;
                                //NotificaciontoolStripButton.Enabled = false;
                                //ConfiguraciontoolStripButton.Enabled = false;
                                toolStripTextBoxSearch.Visible = false;
                                ultraGrid1.Enabled = false;
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


        //OPCIÓN CANCELAR
        private void AccionCancelar()
        {
            ValAdd = false;
            ClsArticuloBindingSource.Position = ClsArticuloBindingSource.Count;
            ClsArticuloBindingSource.RemoveCurrent();
            ClsArticuloBindingSource.ResetBindings(false);
            lblNKit2.Text = "0000";
            lblNKit2.Visible = false;

            if (LArticulo.Count == 0)
            {
                ClsArticulo cont = new ClsArticulo();
                LArticulo.Add(cont);
                ClsArticuloBindingSource.DataSource = LArticulo;
                ClsArticuloBindingSource.ResetBindings(false);
                AccionesNavigator(1);
                lblNKit2.Text = "0000";
                lblNKit2.Visible = false;
                
            }
            else
            { AccionesNavigator(0); }
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try 
            {
                if (this.txtArt.Text.Trim() == "") { MessageBox.Show("Falta capturar el Nombre del articulo...", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK); }
                if (this.txtPreU.Text.Trim() == "") { MessageBox.Show("Falta capturar el Precio Unitario del articulo...","MENSAJE DEL SISTEMA",MessageBoxButtons.OK);   }
                if (this.txtPreU.Text.Trim() == "0.00") { MessageBox.Show("Proporcione un Precio para el Articulo ", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.txtPreU.Focus(); return; }

                this.BindingNavigator.Focus();
                this.txtArt.Focus();
                ClsArticulo CA = (ClsArticulo)ClsArticuloBindingSource.Current;

                CA.NombreArti = this.txtArt.Text.Trim().ToUpper();
                CA.DescripcionArti = this.txtDescrip.Text.Trim().ToUpper();    
                CA.PrecioUnit = Convert.ToDouble(this.txtPreU.Text.Trim());
                //CA.Grupo = Convert.ToInt32(this.CmbGrupo.SelectedValue);
                CA.KitArti = Convert.ToInt32(this.comboBox2.SelectedValue);
                //CA.Status = Convert.ToInt16(this.comboBox4.SelectedValue); 
                CA.Bodega = Convert.ToInt16(this.comboBox3.SelectedValue);
                CA.IdArticulo = Convert.ToInt32(this.lblFol.Text);
                if (this.lblIdKit.Visible == true && (this.lblNKit2.Visible == true || this.lblNKit.Visible == true))
                {
                    CA.Kit = 1;
                    if (this.lblNKit2.Text.ToString().Trim() != "")
                    {
                        if (Convert.ToInt32(this.lblNKit2.Text).ToString()  != "0")
                        {
                            CA.ClaveKit = Convert.ToInt32(this.lblNKit2.Text);
                        }
                    }
                    else if (Convert.ToInt32(this.lblNKit.Text).ToString()  != "")
                    {
                        CA.ClaveKit = Convert.ToInt32(this.lblNKit.Text);
                    }
                }
                else
                {
                    CA.Kit = 0;
                    CA.ClaveKit = 0;
                }


                if (CA.IdArticulo == 0) //Nuevo
                {
                    if (Permiso == 3)
                    {
                        MessageBox.Show("No Tiene los privilegios que le \n Permitan Agregar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        ListaArticulo = ClsArticulo.ListaArticulo(1, "",1);
                        ClsArticuloBindingSource.DataSource = ListaArticulo;
                        ValAdd = false; 
                        AccionesNavigator(0);                        
                        return;
                    }

                    if (CA.ClaveKit != 0)
                    {
                        ListaArticulo = ClsArticulo.ListaArticulo(1, lblNKit2.Text, 2);

                        if (ListaArticulo.Count > 0)
                        {
                            MessageBox.Show("El Kit ya ha sido capturado, favor de revisar...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListaArticulo = ClsArticulo.ListaArticulo(1, "", 1);
                            ClsArticuloBindingSource.DataSource = ListaArticulo;
                            ValAdd = false; 
                            AccionesNavigator(0);
                            lblNKit2.Visible = false;                            
                            return;
                        }
                    }
                    DialogResult Result = MessageBox.Show("¿Seguro que Desea Agregar el Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Result == DialogResult.Yes)
                    {
                        ClsArticulo.AddArticulo(CA);
                        MessageBox.Show("Registro agregado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ValAdd = false;
                    }

                    this.lblNKit2.Text = "";
                    this.lblNKit2.Visible = false;  
                }
                else //Modificación.
                {
                    if (Permiso != 1)
                    {
                        MessageBox.Show("No Tiene los privilegios que le \n Permitan Modificar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        ListaArticulo = ClsArticulo.ListaArticulo(1, "",1);
                        ClsArticuloBindingSource.DataSource = ListaArticulo;
                        ValAdd = false; 
                        AccionesNavigator(0);
                        return;
                    }
                   
                    if (MessageBox.Show("Esta por Modificar un Articulo, ¿Desea Continuar?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {                     
                        ClsArticulo.UpdateArticulo(CA);  
                        MessageBox.Show("El Articulo ha Sido Modificado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ValAdd = false; 
                    }
                    this.lblNKit2.Text = "";
                    this.lblNKit2.Visible = false;  
                }

                ValAdd = false; 
                ListaArticulo = ClsArticulo.ListaArticulo(1,"",1);
                ClsArticuloBindingSource.DataSource = ListaArticulo;
                AccionesNavigator(0);
                //LimpioCtr();


            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message.ToString());     
            }
        }

       private void  LimpioCtr()
       {
           this.txtArt.Text = "";
           this.txtDescrip.Text = "";
           this.txtPreU.Text = "0.00";
       }

        private void toolStripTextBoxSearch_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            int posicion = 0;

            CatalogoArticuloFilter Filtro = new CatalogoArticuloFilter(this.toolStripTextBoxSearch.Text.Trim());
            Predicate<ClsArticulo> Filtrado = new Predicate<ClsArticulo>(Filtro.BuscaCatalogoArticuloLike);

            posicion = LArticulo.FindIndex(Filtrado);

            if (posicion == 0)
            {
                this.ClsArticuloBindingSource.Position = 0;

            }
            else
            { ClsArticuloBindingSource.Position = posicion; }
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

                ClsArticulo Dato = (ClsArticulo)ClsArticuloBindingSource.Current;

                DialogResult dr =
                   MessageBox.Show("Estas seguro de borrar el Articulo: " + Dato.NombreArti ,
                   "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    ClsArticulo CA = (ClsArticulo)ClsArticuloBindingSource.Current;
                    CA.Status = 0;
                    ClsArticulo.DeleteArticulo(CA);
                    ClsArticuloBindingSource.RemoveCurrent();
                    MessageBox.Show("Registro Eliminado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (this.LArticulo.Count == 0)
                {
                    AccionesNavigator(0);
                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }  
        }

        private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {

        }

        private void BindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBusqueda Buscar = new FrmBusqueda(0, "A");
            Buscar.Show();           
            
        }

        private void lblNKit_TextChanged(object sender, EventArgs e)
        {
            if (this.lblNKit.Text != "" && this.lblNKit.Text !="0"  )
            {
                this.lblNKit.Enabled = true;
                lblIdKit.Enabled = true; 
            }
            else
            {
                lblIdKit.Enabled = false;
                this.lblNKit.Enabled = false;
            }
        }

        private void lblNKit_Click(object sender, EventArgs e)
        {

        }

        

       

    }
}