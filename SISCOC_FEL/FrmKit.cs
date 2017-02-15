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
    public partial class FrmKit : Form
    {
        int Permiso;
        int Entra = 0;
        //bool VALIDA;
        private Boolean ValAdd = false;


        List<ClsArticulo> ListaArti;
        DataTable table = GetTable();
        List<ClsKit> ListKit;
        List<ClsKit> BKit;

        public FrmKit(int _Permiso)
        {
            InitializeComponent();

            try
            {
                Permiso = _Permiso;

                BKit = ClsKit.BuscaKit(0, 0,"");
                this.ClsBindingKit.DataSource = BKit;

               // ClsKit CK = new ClsKit();
               // CK.IdArticulo = 0;

                //Borro el grid.
               // ClsKit.DeleteartKit(CK);

                if (BKit.Count == 0)
                {
                    ClsKit cont = new ClsKit();
                    BKit.Add(cont);
                    ClsBindingKit.DataSource = BKit;
                    ClsBindingKit.ResetBindings(false);
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

        private void FrmKit_Load(object sender, EventArgs e)
        {
            //Cargo los datos a la tabla temporal
            ClsKit CK = new ClsKit();

            CK.IdArticulo  = 0;
            CK.Articulo = "";
            CK.Descripcion = "";
            CK.Cantidad = 0;
            CK.PrecioU = 0;

            ClsKit.AddArtKit(CK, 2, Convert.ToInt32(this.textBox2.Text.Trim()));
        }

        private void btnBusca1_Click(object sender, EventArgs e)
        {
            ListaArti = ClsArticulo.ListaArticulo(1, this.txtArti.Text.Trim(),1);
            this.ClsArti_Binding.DataSource = ListaArti;           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            ClsKit CK = new ClsKit();
            
            try
            {

                if (ultraGrid1.Rows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar articulos para agregar...", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }

                foreach (Infragistics.Win.UltraWinGrid.UltraGridRow Rn in ultraGrid1.Rows)
                {
                    
                    if (Rn.Cells[9].Value != "" && Rn.Cells[9].Value != null && Rn.Cells[9].Text != "" )
                    {
                        //table.Rows.Add(Rn.Cells[0].Value, Rn.Cells[1].Value, Rn.Cells[2].Value, Rn.Cells[3].Value, Rn.Cells[9].Value);
                        //ClsBindingArti.DataSource = table;

                        CK.IdArticulo = Convert.ToInt32(Rn.Cells[0].Value);
                        CK.Articulo = Convert.ToString(Rn.Cells[1].Value);
                        CK.Descripcion = Convert.ToString(Rn.Cells[2].Value);
                        CK.Cantidad = Convert.ToDouble(Rn.Cells[9].Value);
                        CK.PrecioU = Convert.ToDouble(Rn.Cells[3].Value);

                        ClsKit.AddArtKit(CK,1,0);

                    }
                }

                ListKit = ClsKit.ListArtKit();
                ultraGrid2.DataSource = ListKit;

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message,"AVISO");
            }

        }

        static DataTable GetTable()
        {
            //
            // Here we create a DataTable with four columns.
            //
            DataTable table = new DataTable();
            table.Columns.Add("No.", typeof(int));
            table.Columns.Add("Articulo", typeof(string));
            table.Columns.Add("Descripción", typeof(string));
            table.Columns.Add("PrecioU", typeof(double));
            table.Columns.Add("Cantidad", typeof(double));
            table.Columns.Add("Eliminar");
                         

            //
            // Here we add five DataRows.
            //
            //table.Rows.Add(25, "Indocin", "David", DateTime.Now);
            //table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
            //table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
            //table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
            //table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);

            return table;
        }

        private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {

        }

        private void ultraGrid2_ClickCellButton(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            
        }

        private void ultraGrid2_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {

        }

        private void ultraGrid2_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            try
            {

                ClsKit CK = new ClsKit();

                int Ren;
                string Articulo = "";

                Ren = Convert.ToInt32(e.Row.Cells[0].Text);
                Articulo = Convert.ToString(e.Row.Cells[1].Text);

                if (e.Row.Cells[7].Activated == true)
                {

                    CK.IdArticulo = Ren;
                    CK.Articulo = Articulo;

                    DialogResult dr =
                       MessageBox.Show("Estas seguro de borrar el Articulo: " + CK.Articulo,
                       "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {

                        //Borro el articulo seleccionado
                        ClsKit.DeleteartKit(CK);

                        //Llenamos de nuevo el Grid de Articulos que contiene el Kit
                        ListKit = ClsKit.ListArtKit();
                        ultraGrid2.DataSource = ListKit;

                    }
                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ClsKit CK = new ClsKit();

            CK.IdArticulo = 0;

            //Borro el grid.
            ClsKit.DeleteartKit(CK);


            //Cargo de nuevo el grid.
            ListKit = ClsKit.ListArtKit();
            ultraGrid2.DataSource = ListKit;

            //Cierro la forma.
            this.Close(); 

        }

        private void BindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        //OPCION NAVIGATOR
        public void AccionesNavigator(int inAction) //**
        {
            try
            {
                // 0-Browse   1-Adding     2-Editing
                if (ClsBindingKit.DataSource != null && BindingNavigator.BindingSource != null)
                {
                    switch (inAction)
                    {
                        case 0:
                            {
                                setNavigatorDirections(true);
                                if (ClsBindingKit.AllowNew == false)
                                    ClsBindingKit.AllowNew = true;
                                cancelToolStripButton.Enabled = false;
                                bindingNavigatorAddNewItem.Enabled = true;
                                BindingNavigatorDeleteItem.Enabled = ClsBindingKit.Count > 0;
                                BindingNavigatorSaveItem.Enabled = ClsBindingKit.Count > 0;
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
                                if (ClsBindingKit.AllowNew == true)
                                    ClsBindingKit.AllowNew = false;
                                cancelToolStripButton.Enabled = true;
                                BindingNavigatorDeleteItem.Enabled = false;
                                BindingNavigatorSaveItem.Enabled = true;
                                //PermisostoolStripButton.Enabled = false;
                                //NotificaciontoolStripButton.Enabled = false;
                                //ConfiguraciontoolStripButton.Enabled = false;
                                toolStripTextBoxSearch.Visible = false;
                                //ultraGrid1.Enabled = false;
                                break;
                            }
                        case 2:
                            {
                                setNavigatorDirections(false);
                                if (ClsBindingKit.AllowNew == true)
                                    ClsBindingKit.AllowNew = false;
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
                    ClsKit cont = (ClsKit)ClsBindingKit.Current;
                    ClsBindingKit.ResetBindings(false);

                    textBox2.Enabled = false; 
                }
                else
                {
                    MessageBox.Show("No Tiene los privilegios que le \n Permitan Agregar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    AccionCancelar();

                    //Llenamos de nuevo el Grid de Articulos que contiene el Kit
                    ListKit = ClsKit.ListArtKit();
                    ultraGrid2.DataSource = ListKit;
                }
                //*****************
            }


        }

        private void cancelToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (cancelToolStripButton.Enabled != false)
                {
                    AccionCancelar();

                    textBox2.Enabled = true;
                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); } 
        }


        //OPCIÓN CANCELAR
        private void AccionCancelar()
        {
            ValAdd = false;
            ClsBindingKit.Position = ClsBindingKit.Count;
            ClsBindingKit.RemoveCurrent();
            ClsBindingKit.ResetBindings(false);

            if (BKit.Count == 0)
            {
                ClsKit cont = new ClsKit();
                BKit.Add(cont);
                //LArticulo.Add(cont);
                ClsBindingKit.DataSource = BKit;
                ClsBindingKit.ResetBindings(false);
                AccionesNavigator(1);
            }
            else
            { AccionesNavigator(0); }
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() == "") { MessageBox.Show("Falta capturar el nombre del Kit...", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK); this.textBox1.Focus(); }
                this.BindingNavigator.Focus();
                ClsKit CK =  (ClsKit)ClsBindingKit.Current;

                CK.NomKit = this.textBox1.Text.Trim();

                if (CK.IdKit == 0) //Nuevo
                {
                    if (Permiso == 3)
                    {
                        ClsKit ClKA = new ClsKit();
                        ClKA.IdArticulo = 0;  

                        MessageBox.Show("No Tiene los privilegios que le \n Permitan Agregar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        //Borro tabla temporal
                        ClsKit.DeleteartKit(ClKA);

                        //Cargo los datos a la tabla temporal             
                        ClKA.IdArticulo = 0;
                        ClKA.Articulo = "";
                        ClKA.Descripcion = "";
                        ClKA.Cantidad = 0;
                        ClKA.PrecioU = 0;
                        ClsKit.AddArtKit(ClKA, 2, Convert.ToInt32(this.textBox2.Text.Trim()));

                        ListKit = ClsKit.BuscaArti_Kit(Convert.ToInt32(this.textBox2.Text.Trim()));
                        ultraGrid2.DataSource = ListKit;                                      
                        AccionesNavigator(0);
                        return;
                    }

                    ClsKit.AddKit(CK);
                    ClsKit.AddArti_Kit(CK,2,0);  
                    MessageBox.Show("Registro agregado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else //Modificacion
                {
                    if (Permiso != 1)
                    {
                        ClsKit ClKA = new ClsKit();
                        ClKA.IdArticulo = 0;  

                        MessageBox.Show("No Tiene los privilegios que le \n Permitan Modificar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        //Borro tabla temporal
                        ClsKit.DeleteartKit(ClKA);

                        //Cargo los datos a la tabla temporal             
                        ClKA.IdArticulo = 0;
                        ClKA.Articulo = "";
                        ClKA.Descripcion = "";
                        ClKA.Cantidad = 0;
                        ClKA.PrecioU = 0;
                        ClsKit.AddArtKit(ClKA, 2, Convert.ToInt32(this.textBox2.Text.Trim()));

                        //Cargo grid
                        ListKit = ClsKit.BuscaArti_Kit(Convert.ToInt32(this.textBox2.Text.Trim()));
                        ultraGrid2.DataSource = ListKit;

                        AccionesNavigator(0);
                        return;   
                    }

                    ClsKit.UpdateKit(CK.IdKit,this.textBox1.Text.Trim());   

                    //foreach (Infragistics.Win.UltraWinGrid.UltraGridRow Rn in ultraGrid2.Rows)
                    //{

                    //    ClsKit.AddNewRowArtKitMan(1, Convert.ToInt32(Rn.Cells[0].Value), Convert.ToString(Rn.Cells[1].Value), Convert.ToString(Rn.Cells[2].Value), Convert.ToInt32(Rn.Cells[3].Value),Convert.ToDouble(Rn.Cells[4].Value));
                        
                    //}


                    ClsKit.AddArti_Kit(CK, 3, Convert.ToInt32(this.textBox2.Text.Trim()));
                    MessageBox.Show("Registro modificado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                    
                }

                textBox2.Enabled = true;

                BKit = ClsKit.BuscaKit(0, 0,"");
                this.ClsBindingKit.DataSource = BKit;
                AccionesNavigator(0); 

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);  
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {         


            //Cargo de nuevo el grid
            ultraGrid1.DataBind();  

            ListKit = ClsKit.BuscaArti_Kit(Convert.ToInt32(this.textBox2.Text.Trim()));                         
            ultraGrid2.DataSource = ListKit;


            //Cargo los datos a la tabla temporal
            ClsKit CK = new ClsKit();

            ClsKit.AddArtKit(CK, 2, Convert.ToInt32(this.textBox2.Text.Trim())); 


        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //preguntarle al pakito que pex
            //por que no tenia validado esto
            //
            try
            {
                if (Permiso != 1)
                {
                    ClsKit ClKA = new ClsKit();
                    ClKA.IdArticulo = 0;  

                    MessageBox.Show("No Tiene los privilegios que le \n Permitan Eliminar Registros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    
                    //Borro tabla temporal
                    ClsKit.DeleteartKit(ClKA);

                    //Cargo los datos a la tabla temporal             
                    ClKA.IdArticulo = 0;
                    ClKA.Articulo = "";
                    ClKA.Descripcion = "";
                    ClKA.Cantidad = 0;
                    ClKA.PrecioU = 0;                   
                    ClsKit.AddArtKit(ClKA, 2, Convert.ToInt32(this.textBox2.Text.Trim()));

                    //Cargo grid
                    ListKit = ClsKit.BuscaArti_Kit(Convert.ToInt32(this.textBox2.Text.Trim()));
                    ultraGrid2.DataSource = ListKit;
                    return;
                }

                DialogResult dr =
                   MessageBox.Show("Estas seguro de borrar el Registro ",
                   "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    ClsKit CA = (ClsKit)ClsBindingKit.Current;
                    
                    //CA.Status = 0;
                    //ClsKit.DeleteartKit(CA);
                    ClsKit.DeleteKit(Convert.ToInt32(this.textBox2.Text.Trim())); 
                    ClsBindingKit.RemoveCurrent();                    
                    MessageBox.Show("Registro Eliminado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (ListKit.Count == 0)
                {
                    AccionesNavigator(0);
                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }   
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string cadena = "";

            cadena = (string) dataGridArt.Rows[1].Cells[1].Value;   

        }

        private void dataGridArt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = 0;

            Row = e.RowIndex;

             DialogResult dr =
             MessageBox.Show("Estas seguro de borrar el Registro ",
             "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

             if (dr == DialogResult.Yes)
             {
                 this.dataGridArt.Rows.RemoveAt(Row);
             }
        }

        private void dataGridArt_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int Row = 0;
            int Col = 0;
            string Val = "";
            double  Vals = 0;

            Row = e.RowIndex; 
            Col = e.ColumnIndex;
            if (Col >= 1)
            {
                Val = (string)this.dataGridArt.Rows[Row].Cells[Col].Value;

                try
                {
                    Vals = Convert.ToDouble(Val);
                }
                catch (Exception EX)
                {
                    Vals = 0;
                    this.dataGridArt.Rows[Row].Cells[Col].Value = "0";
                    MessageBox.Show("Debe ingresar una cantidad numerica...");
                }
            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            ClsKit.AddNewRowArtKitMan(3,0,"","",0,0);
            ListKit = ClsKit.ListArtKit();
            ultraGrid2.DataSource = ListKit;
        }

        private void ultraGrid2_AfterCellUpdate(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            int col = 0;
            string Columna = "";
//            e.Cell.Row.Cells.GetItem(0);

            //char.IsNumber 


            //int x=0;
            //for ( x=0;x<e.Cell.Value.ToString().Length;x++ )
            // //e.Cell.Value.ToString()            
            //{
            //    char.IsNumber(e.Cell.Value.ToString().Substring(x, 1));    
            
            //}


            if (e.Cell.Column.Key.ToString().ToUpper() == "CANTIDAD")
            {
                if (Entra > 0)
                {
                    //e.Cell.Value = "";
                    e.Cell.Value = "";
                    MessageBox.Show("No puede actualizar los datos...");
                    return; 
                }
            }

            Columna = e.Cell.Column.Key.ToString().ToUpper();  
            
          
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow Rn in ultraGrid2.Rows)
            {

                if (Rn.Cells[0].Value.ToString() != "" && Rn.Cells[1].Value.ToString() != "" && Rn.Cells[2].Value.ToString() != "" && Rn.Cells[3].Value.ToString() != "" && Rn.Cells[4].Value.ToString() != "")
                {
                    ClsKit.AddNewRowArtKitMan(1, Convert.ToInt32(Rn.Cells[0].Value), Convert.ToString(Rn.Cells[1].Value).ToUpper(), Convert.ToString(Rn.Cells[2].Value).ToUpper(), Convert.ToInt32(Rn.Cells[3].Value), Convert.ToDouble(Rn.Cells[4].Value));  
                }
            }

            if (Columna == "PRECIOU")
            {
                ClsKit.AddNewRowArtKitMan(3, 0, "", "", 0, 0);
                ListKit = ClsKit.ListArtKit();
                ultraGrid2.DataSource = ListKit;
                int rows=0;
                rows = ultraGrid2.Rows.Count;   
                ultraGrid2.Rows[rows-1].Cells[1].Activated = true;        
                //e.Cell.Activated = true;   
            }

        }

        private void ultraGrid2_BeforeCellUpdate(object sender, Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs e)
        {
            int x = 0;
            char aux = ' ';
            Entra = 0;
            if (e.Cell.Text.ToString() != "")
            {
                for (x = 0; x < e.Cell.Text.ToString().Length; x++)
                //e.Cell.Value.ToString()            
                {
                    aux = Convert.ToChar(e.Cell.Text.ToString().Substring(x, 1));

                    if (!char.IsNumber(aux))
                    {
                        Entra++;
                    }

                }
            }
        }

        private void ultraGrid2_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            //if (char.IsNumber(e.KeyChar)) 
            //{
            //    e.Handled = true;
                
            //}
        }

        


    }
}