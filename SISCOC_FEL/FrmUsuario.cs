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
    public partial class FrmUsuario : Form
    {
        #region Listas_Variables
            List<ClsUsuario> ListUsuario;
            List<ClsListas> ListTipoUsuario;    
            //List<ClsListas> ListStatus;
            List<ClsListas> ListFiltroBusq;
                    
            private Boolean Nuevo = false;
            private Boolean ValAdd = false;
            private Boolean Guarda = true;
            
            int TipoFiltro = 0;
        #endregion


        public FrmUsuario()
        {
            InitializeComponent();

            //Tipo de Usuario
            ListTipoUsuario = ClsListas.ListTipoUsuario();
            clsListasTipoUsuaBindingSource.DataSource = ListTipoUsuario;

            //Filtro de Busqueda
            ListFiltroBusq = ClsListas.ListBusqueda();
            clsListasFiltrobindingSource.DataSource = ListFiltroBusq;
                  

            //Cargo la Lista de Usuario
            ListUsuario = ClsUsuario.ListUsuarioTodos();            
            clsUsuarioBindingSource.DataSource = ListUsuario;
            if (ListUsuario.Count == 0)
            {
                ClsUsuario cont = new ClsUsuario();
                ListUsuario.Add(cont);
                cont.Status = 1;
                clsUsuarioBindingSource.DataSource = ListUsuario;
                clsUsuarioBindingSource.ResetBindings(false);                
                AccionesNavigator(1);
            }
            else
            {
                AccionesNavigator(0);
            }


        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            clsListasFiltrocomboBox_SelectedIndexChanged(sender,e);
        }

        private void FrmUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            #region Next Control
                if (e.KeyCode == Keys.Enter)
                { SendKeys.Send("{TAB}"); }
            #endregion
        }


        #region Modulos    

            public void AccionesNavigator(int inAction) //**
            {
                try
                {
                    // 0-Browse   1-Adding     2-Editing
                    if (clsUsuarioBindingSource.DataSource != null && BindingNavigator.BindingSource != null)
                    {
                        switch (inAction)
                        {
                            case 0:
                                {
                                    setNavigatorDirections(true);
                                    if (clsUsuarioBindingSource.AllowNew == false)
                                        clsUsuarioBindingSource.AllowNew = true;
                                    cancelToolStripButton.Enabled = false;
                                    grpBxFiltro.Enabled = true;
                                    bindingNavigatorAddNewItem.Enabled = true;
                                    BindingNavigatorDeleteItem.Enabled = clsUsuarioBindingSource.Count > 0;
                                    BindingNavigatorSaveItem.Enabled = clsUsuarioBindingSource.Count > 0;
                                    //toolStripTextBoxSearch.Visible = true;
                                    uGridUsuario.Enabled = true;
                                    break;
                                }
                            case 1:
                                {
                                    setNavigatorDirections(false);
                                    if (clsUsuarioBindingSource.AllowNew == true)
                                        clsUsuarioBindingSource.AllowNew = false;
                                    cancelToolStripButton.Enabled = true;
                                    grpBxFiltro.Enabled = false;
                                    BindingNavigatorDeleteItem.Enabled = false;
                                    BindingNavigatorSaveItem.Enabled = true;
                                    //toolStripTextBoxSearch.Visible = false;
                                    uGridUsuario.Enabled = false;

                                    break;
                                }
                            case 2:
                                {
                                    setNavigatorDirections(false);

                                    if (clsUsuarioBindingSource.AllowNew == true)
                                        clsUsuarioBindingSource.AllowNew = false;

                                    cancelToolStripButton.Enabled = false;
                                    grpBxFiltro.Enabled = false;
                                    BindingNavigatorDeleteItem.Enabled = false;
                                    BindingNavigatorSaveItem.Enabled = true;
                                    //toolStripTextBoxSearch.Visible = false;
                                    uGridUsuario.Enabled = false;
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
                        //toolStripLabel2.Visible = inVisible;
                        //toolStripTextBoxSearch.Visible = inVisible;
                    }
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }

            private void AccionCancelar()
            {
                ValAdd = false;

                clsUsuarioBindingSource.Position = clsUsuarioBindingSource.Count;
                clsUsuarioBindingSource.RemoveCurrent();
                clsUsuarioBindingSource.ResetBindings(false);

                if (ListUsuario.Count == 0)
                {
                    ClsUsuario cont = new ClsUsuario();
                    ListUsuario.Add(cont);
                    clsUsuarioBindingSource.DataSource = ListUsuario;
                    clsUsuarioBindingSource.ResetBindings(false);                    
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
                            ClsUsuario NUsuario = new ClsUsuario();
                            ListUsuario.Add(NUsuario);
                            clsUsuarioBindingSource.Position = ListUsuario.Count;
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

            private bool validaUsuarioAdd(string Usuario) //**
            {
                int posicion = 0;
                UsuarioFilter Filtro = new UsuarioFilter(Usuario.Trim(), 4);                
                Predicate<ClsUsuario> Filtrado = new Predicate<ClsUsuario>(Filtro.BuscaAll);
                posicion = ListUsuario.FindIndex(Filtrado);
                clsUsuarioBindingSource.Position = posicion;
                ClsUsuario CA = (ClsUsuario)clsUsuarioBindingSource.Current;

                if (CA.Usuario == Usuario && CA.IdUsuario == 0)
                { return false; }
                else
                { return true; }
            }

            private bool validaUsuarioUpDate(string Usuario) //**
            {
                int cont = 0;

                for (int i = 0; i <= clsUsuarioBindingSource.Count - 1; i++)
                {
                    clsUsuarioBindingSource.Position = i;
                    ClsUsuario CA = (ClsUsuario)clsUsuarioBindingSource.Current;
                    if (CA.Usuario == Usuario)
                    { cont = cont + 1; }
                }

                if (cont >= 2)
                { return true; }
                else
                { return false; }
            }         

        #endregion


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (ValAdd == false)
            {
                ValAdd = true;
                AccionesNavigator(1);
                ClsUsuario cont = (ClsUsuario)clsUsuarioBindingSource.Current;
                cont.TipoUsuario = 2;
                cont.Status = 1;
                clsUsuarioBindingSource.ResetBindings(false);
                clsListasTipoUsuaComboBox.SelectedValue = 2;
                this.apell_PatTextBox.Focus();
            }
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr =
                   MessageBox.Show("Estas seguro de borrar el Registro ",
                   "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    ClsUsuario CA = (ClsUsuario)clsUsuarioBindingSource.Current;                    
                    CA.Status = 0;
                    ClsUsuario.UpdateUsuario(CA);
                    clsUsuarioBindingSource.RemoveCurrent();                    
                    MessageBox.Show("Registro Eliminado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (ListUsuario.Count == 0)
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
                if (this.apell_PatTextBox.Text == "") { MessageBox.Show("Proporcione un Apellido Paterno ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.apell_PatTextBox.Focus(); return; }
                if (this.apell_MatTextBox.Text == "") { MessageBox.Show("Proporcione un Apellido Materno ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.apell_MatTextBox.Focus(); return; }
                if (this.nombreTextBox.Text == "") { MessageBox.Show("Proporcione un Nombre ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.nombreTextBox.Focus(); return; }
                //Valido por este
                if (this.usuarioTextBox.Text == "") { MessageBox.Show("Proporcione un Nombre de Usuario ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.usuarioTextBox.Focus(); return; }
                if (this.contrasenaTextBox.Text == "") { MessageBox.Show("Proporcione una Contraseña ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.contrasenaTextBox.Focus(); return; }
                if (this.RepContrasenatextBox.Text == "") { MessageBox.Show("Debe de Repetir la Contraseña ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.RepContrasenatextBox.Focus(); return; }
                if (this.contrasenaTextBox.Text != this.RepContrasenatextBox.Text) { MessageBox.Show("Proporcione Contraseñas Iguales ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.contrasenaTextBox.Focus(); return; }
                
                if (this.clsListasTipoUsuaComboBox.SelectedValue == null) { MessageBox.Show("Proporcione un Tipo de Usuario ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.clsListasTipoUsuaComboBox.Focus(); return; }
                //if (this.clsListasStatusComboBox.SelectedValue == null) { MessageBox.Show("Proporcione un Status ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); this.clsListasStatusComboBox.Focus(); return; }

                BindingNavigator.Focus();
                apell_PatTextBox.Focus();
                ClsUsuario CA = (ClsUsuario)clsUsuarioBindingSource.Current;
                CA.Status = 1;
                if (CA.IdUsuario == 0) //nuevo
                {
                    if (validaUsuarioAdd(CA.Usuario) == false)
                    {
                        DialogResult Result = MessageBox.Show("Seguro que Desea Agregar el Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Result == DialogResult.Yes)
                        {
                            ClsUsuario.AddUsuario(CA);                            
                            MessageBox.Show("Registro agregado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error el Nombre del Usuario ya Existe...", "A v i s o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clsUsuarioBindingSource.Position = clsUsuarioBindingSource.Count;
                        this.usuarioTextBox.Text = ""; this.usuarioTextBox.Focus(); Focus(); return;                        
                    }
                }
                else //modifica
                {
                    if (validaUsuarioUpDate(CA.Usuario) == false)
                    {
                        DialogResult Result = MessageBox.Show("Seguro que Desea Modificar el Registro", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Result == DialogResult.Yes)
                        {
                            BindingNavigator.Focus();                            
                            ClsUsuario.UpdateUsuario(CA);                            
                            MessageBox.Show("Registro modificado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error el Nombre del Usuario ya Existe...", "A v i s o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListUsuario = ClsUsuario.ListUsuarioTodos();
                        clsUsuarioBindingSource.DataSource = ListUsuario;
                        clsUsuarioBindingSource.ResetBindings(false);                       
                        
                        this.usuarioTextBox.Focus(); return;                                                
                    }
                }
                ValAdd = false;
                ListUsuario = ClsUsuario.ListUsuarioTodos();
                clsUsuarioBindingSource.DataSource = ListUsuario;                
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

        private void usuarioTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            AtajosKeys(sender, e); 
        }

        private void contrasenaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            AtajosKeys(sender, e); 
        }

        private void RepContrasenatextBox_KeyDown(object sender, KeyEventArgs e)
        {
            AtajosKeys(sender, e); 
        }

        private void clsListasFiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoFiltro = Convert.ToInt16(clsListasFiltrocomboBox.SelectedValue);
        }

        private void txtBxBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            int posicion = 0;

            UsuarioFilter Filtro = new UsuarioFilter(this.txtBxBusqueda.Text.Trim(), TipoFiltro);            
            Predicate<ClsUsuario> Filtrado = new Predicate<ClsUsuario>(Filtro.BuscaAll);            
            posicion = ListUsuario.FindIndex(Filtrado);
            if (posicion == 0)
            { this.clsUsuarioBindingSource.Position = 0; }
            else
            { this.clsUsuarioBindingSource.Position = posicion; }   
        }


        

    }
}