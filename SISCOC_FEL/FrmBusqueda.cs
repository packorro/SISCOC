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
    public partial class FrmBusqueda : Form
    {


        int _Accion;
        string _Origen;

        List<ClsTraspaso> LObra;
        List<ClsKit> LKit;

        public FrmBusqueda(int Accion, string Origen)
        {
            _Accion = Accion;
            _Origen = Origen;

            InitializeComponent();
        }

        private void FrmObraDestino_Load(object sender, EventArgs e)
        {
            if (_Origen == "O")
            {
                this.Text = "Viviendas...";
            }
            if (_Origen == "P")
            {
                this.Text = "Proveedores...";
            }
            if (_Origen == "T")
            {
                this.Text = "Traspasos...";
            }
            if (_Origen == "A")
            {
                this.Text = "Kits...";
            }

            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_Origen == "O")
            {
                LObra = ClsTraspaso.BuscaObra(1, 1, this.txtDatos.Text.Trim());
                //this.clsObraBindig.DataSource = LObra;
                this.clsbindingBuscar.DataSource = LObra;
                this.ultraGrid1.Rows.ColumnFilters[13].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[14].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[15].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[16].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[0].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[1].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[2].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[3].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[4].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[5].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[6].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[9].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[10].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[11].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[12].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[17].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[18].Column.Hidden = true;

                

                this.ultraGrid1.Rows.ColumnFilters[7].Column.Header.Caption = "Clave";
                this.ultraGrid1.Rows.ColumnFilters[8].Column.Header.Caption = "Vivienda";

                this.ultraGrid1.Rows.ColumnFilters[7].Column.Width = 55;
                this.ultraGrid1.Rows.ColumnFilters[8].Column.Width = 415;
            }

            if (_Origen == "P")
            {                
                LObra = ClsTraspaso.BuscaProveedor(this.txtDatos.Text.Trim());      
                this.clsbindingBuscar.DataSource = LObra;                
                
                this.ultraGrid1.Rows.ColumnFilters[15].Column.Width = 55;
                this.ultraGrid1.Rows.ColumnFilters[16].Column.Width = 415;
                this.ultraGrid1.Rows.ColumnFilters[15].Column.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;  
                this.ultraGrid1.Rows.ColumnFilters[16].Column.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;  
                this.ultraGrid1.Rows.ColumnFilters[15].Column.Header.Caption = "Clave";
                this.ultraGrid1.Rows.ColumnFilters[16].Column.Header.Caption = "Proveedor";
                
                this.ultraGrid1.Rows.ColumnFilters[0].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[1].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[2].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[3].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[4].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[5].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[6].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[7].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[8].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[9].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[10].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[11].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[12].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[13].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[14].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[17].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[18].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[16].Column.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Left;                    
            }
            if (_Origen == "T")
            {
                LObra = ClsTraspaso.BuscaObra(1, 1, this.txtDatos.Text.Trim());
                this.clsbindingBuscar.DataSource = LObra;
                this.ultraGrid1.Rows.ColumnFilters[15].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[16].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[17].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[18].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[0].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[1].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[2].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[3].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[4].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[5].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[6].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[14].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[13].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[12].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[11].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[10].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[9].Column.Hidden = true;

                this.ultraGrid1.Rows.ColumnFilters[7].Column.Width = 55;
                this.ultraGrid1.Rows.ColumnFilters[8].Column.Width = 415;

                this.ultraGrid1.Rows.ColumnFilters[7].Column.Header.Caption = "Clave";
                this.ultraGrid1.Rows.ColumnFilters[8].Column.Header.Caption  = "Vivienda";

                

            }
            if (_Origen == "A")
            {
                LKit = ClsKit.BuscaKit(3, 0,this.txtDatos.Text.Trim());
                this.clsbindingBuscar.DataSource = LKit;
                this.ultraGrid1.Rows.ColumnFilters[5].Column.Width = 55;
                this.ultraGrid1.Rows.ColumnFilters[6].Column.Width = 415;
                this.ultraGrid1.Rows.ColumnFilters[5].Column.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
                this.ultraGrid1.Rows.ColumnFilters[6].Column.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
                this.ultraGrid1.Rows.ColumnFilters[2].Column.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
                this.ultraGrid1.Rows.ColumnFilters[0].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[1].Column.Hidden = true;
                //this.ultraGrid1.Rows.ColumnFilters[2].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[3].Column.Hidden = true;
                this.ultraGrid1.Rows.ColumnFilters[4].Column.Hidden = true;

                this.ultraGrid1.Rows.ColumnFilters[5].Column.Header.Caption = "Clave";
                this.ultraGrid1.Rows.ColumnFilters[6].Column.Header.Caption = "Nombre Kit";
                this.ultraGrid1.Rows.ColumnFilters[2].Column.Header.VisiblePosition = 7;
                this.ultraGrid1.Rows.ColumnFilters[2].Column.Header.Caption = "Precio U.";
                
            }

        }

        private void ultraGrid1_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {         
                     
            string IdObra = "";
            string Obra = "";
            string IdProv = "";
            string Prov = "";
            string IdKit = "";
            string NomKit = "";
            string preciou = "";
            


            if (_Origen == "O")
            {

                IdObra = Convert.ToString(e.Row.Cells[7].Text);
                Obra = Convert.ToString(e.Row.Cells[8].Text);

                if (_Accion == 0)
                {
                    FrmArticulo_Obra frmart = (FrmArticulo_Obra)Application.OpenForms["FrmArticulo_Obra"];
                    frmart.Controls["groupBox1"].Controls["textBox1"].Text = IdObra;
                    //frmart.Controls["groupBox1"].Controls["txtNombreObra"].Text = Obra;
                    frmart.Controls["groupBox1"].Controls["lblNomVivienda"].Text = Obra;  
                    frmart.Controls["groupBox1"].Controls["label3"].Text = IdObra;
                }

                if (_Accion == 1)
                {
                    FrmFiltroObra frmfilt = (FrmFiltroObra)Application.OpenForms["FrmFiltroObra"];
                    frmfilt.Controls["textBox1"].Text = IdObra;
                    frmfilt.Controls["textBox2"].Text = Obra;

                }
            }

            if (_Origen == "P")
            {
                IdProv = Convert.ToString(e.Row.Cells[15].Text);
                Prov = Convert.ToString(e.Row.Cells[16].Text);


                FrmArticulo_Obra frmartP = (FrmArticulo_Obra)Application.OpenForms["FrmArticulo_Obra"];
                frmartP.Controls["groupBox1"].Controls["txtIdProv"].Text = IdProv;
                //frmartP.Controls["groupBox1"].Controls["txtNomProv"].Text = Prov;
                frmartP.Controls["groupBox1"].Controls["lblNomProv"].Text = Prov;
                frmartP.Controls["groupBox1"].Controls["label4"].Text = IdProv;

            }

            if (_Origen == "T")
            {
                IdObra = Convert.ToString(e.Row.Cells[7].Text);
                Obra = Convert.ToString(e.Row.Cells[8].Text);

                
                FrmTraspaso  tras = (FrmTraspaso)Application.OpenForms["FrmTraspaso"];
                tras.Controls["groupBox3"].Controls["txtIdObraDest"].Text = IdObra;
                tras.Controls["groupBox3"].Controls["txtObraDest"].Text = Obra;   

            }


            if (_Origen == "A")
            {
                IdKit = Convert.ToString(e.Row.Cells[5].Text);
                NomKit = Convert.ToString(e.Row.Cells[6].Text);
                preciou = Convert.ToString(e.Row.Cells[2].Text);

                FrmArticulo Artis = (FrmArticulo)Application.OpenForms["FrmArticulo"];
                Artis.Controls["groupBox1"].Controls["txtArt"].Text = NomKit;
                Artis.Controls["groupBox1"].Controls["lblNKit"].Text = IdKit;
                Artis.Controls["groupBox1"].Controls["lblNKit2"].Text = IdKit;
                Artis.Controls["groupBox1"].Controls["txtPreU"].Text = preciou;
                Artis.Controls["groupBox1"].Controls["lblIdKit"].Visible = true;
                Artis.Controls["groupBox1"].Controls["lblNKit"].Visible = true;
                Artis.Controls["groupBox1"].Controls["lblNKit2"].Visible = true;
                
                
            }

                this.Close();
            
        }

        private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {

        }       
    }
}