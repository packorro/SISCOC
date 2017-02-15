using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinDataSource;
using Infragistics.Win.UltraWinGrid;

using Infragistics.Win.UltraWinTabs;
using Infragistics.Win.UltraWinTabbedMdi;

using System.Diagnostics;
using SISCOC_BL;
using System.Reflection;

namespace SISCOC_FEL
{
    public partial class FrmPaginaPrincipal : Form
    {
        #region Variables
            int Permiso;
            string TipoPermiso;
            string Usuario;
            //**pestañas
            int Operador = 0;

            string srtusuarios = null;
            string srtproveedores = null;
            string srtclientes = null;           
            string srtArticulos = null;
            string srtkit = null;
            string srtobras = null;
            string srtreportobractes = null;
            string strarticulo_obra = null;
            string srtreportearticuloobra = null;
            string strtraspasos = null;
            string srtRespRestaurar = null;
            //****  

        #endregion               

        public FrmPaginaPrincipal()//(string _Usuario, int _Permiso)
        {
            try
            {
                InitializeComponent();

               
                FrmLogin Login= new FrmLogin();
                Login.ShowDialog();
                Permiso = Login.Permiso;
                Usuario = Login.usuario;              


                //Permiso = _Permiso;
                //Usuario = _Usuario;

                slblExe.Text = "SISCOC";
                slblVersion.Text = ShowAssemblyVersion(typeof(FrmPaginaPrincipal));
                tssEmpresa.Text ="ANJU";                
                slblNumUser.Text = Usuario;

                //TipoPermiso
                switch (Permiso)
                {
                    case 1: { TipoPermiso = "ADMINISTRADOR"; break; }
                    case 2: { TipoPermiso = "NORMAL"; break; }
                    case 3: { TipoPermiso = "LIMITADO"; break; }
                }

                tlStrpSttsLblVTipoUser.Text = TipoPermiso;
    
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }              
        }


        #region Metodos
            //Metodo para Obtener la version del Assembly
            private string ShowAssemblyVersion(Type type)
            {
                Assembly asm = Assembly.GetAssembly(type);
                string objVersion = "";
                if (asm != null)
                {
                    AssemblyName asmName = asm.GetName();
                    objVersion = String.Format("Version={1}", asmName.Name, asmName.Version);
                    return objVersion;
                }
                return objVersion;
            }

        #endregion
                  

        private static string funcion(string _text)
        {
            if (_text.Contains("&"))
            { _text = _text.Remove(_text.IndexOf("&"), 1); }
            return _text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime timer = DateTime.Now;
            SSLblfechHora.Text = timer.ToString();
        }                            

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que Desea Salir ?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            { Close(); } 
        }

        private void FrmPaginaPrincipal_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            //FrmLogin.ActiveForm.Close();
            if (Permiso == 1)
            {
                UsuarioToolStripMenuItem.Visible = true;
                toolStripMenuItem1.Visible = true;
                RespRestaurartoolStripMenuItem.Visible = true;
            }
            else
            {
                UsuarioToolStripMenuItem.Visible = false;
                toolStripMenuItem1.Visible = false;
                RespRestaurartoolStripMenuItem.Visible = false;
            }          
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ultraTabbedMdiManager1.ActiveTab != null && srtclientes == "Catalogo Prospectos")
            {
                MdiTabGroup tabGroup = this.ultraTabbedMdiManager1.TabGroups[0];
                for (int j = tabGroup.Tabs.Count - 1; j >= 0; j--)
                {
                    Operador = j;
                    if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador])).TextResolved == "Catalogo Prospectos")
                    {
                        int Ren = (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador]))).Index;
                        ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs[Ren].Activate();
                    }
                    else
                    {
                        Boolean ban = false;
                        for (int x = tabGroup.Tabs.Count - 1; x >= 0; x--)
                        {
                            if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[x])).TextResolved == "Catalogo Prospectos")
                            { ban = true; }
                        }
                        if (ban == false)
                        {
                            srtclientes = string.Format("Catalogo Prospectos");
                            FrmProspecto Cliente = new FrmProspecto(Permiso);
                            Cliente.Text = srtclientes;
                            Cliente.MdiParent = this;
                            Cliente.Show();   
                        }
                    }
                }
            }
            else
            {
                srtclientes = string.Format("Catalogo Prospectos");
                FrmProspecto Cliente = new FrmProspecto(Permiso);
                Cliente.Text = srtclientes;
                Cliente.MdiParent = this;
                Cliente.Show();  
            }                   
        }

        private void ObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ultraTabbedMdiManager1.ActiveTab != null && srtobras == "Catalogo de Vivienda")
            {
                MdiTabGroup tabGroup = this.ultraTabbedMdiManager1.TabGroups[0];
                for (int j = tabGroup.Tabs.Count - 1; j >= 0; j--)
                {
                    Operador = j;
                    if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador])).TextResolved == "Catalogo de Vivienda")
                    {
                        int Ren = (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador]))).Index;
                        ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs[Ren].Activate();
                    }
                    else
                    {
                        Boolean ban = false;
                        for (int x = tabGroup.Tabs.Count - 1; x >= 0; x--)
                        {
                            if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[x])).TextResolved == "Catalogo de Vivienda")
                            { ban = true; }
                        }
                        if (ban == false)
                        {
                            srtobras = string.Format("Catalogo de Vivienda");
                            FrmObra Obra = new FrmObra(Permiso);
                            Obra.Text = srtobras;
                            Obra.MdiParent = this;
                            Obra.Show();  
                        }
                    }
                }
            }
            else
            {
                srtobras = string.Format("Catalogo de Vivienda");
                FrmObra Obra = new FrmObra(Permiso);
                Obra.Text = srtobras;
                Obra.MdiParent = this;
                Obra.Show();  
            }                
        }

        private void UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ultraTabbedMdiManager1.ActiveTab != null && srtusuarios == "Catalogo Usuarios")
            {
                MdiTabGroup tabGroup = this.ultraTabbedMdiManager1.TabGroups[0];
                for (int j = tabGroup.Tabs.Count - 1; j >= 0; j--)
                {
                    Operador = j;
                    if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador])).TextResolved == "Catalogo Usuarios")
                    {
                        int Ren = (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador]))).Index;
                        ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs[Ren].Activate();
                    }
                    else
                    {
                        Boolean ban = false;
                        for (int x = tabGroup.Tabs.Count - 1; x >= 0; x--)
                        {
                            if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[x])).TextResolved == "Catalogo Usuarios")
                            { ban = true; }
                        }
                        if (ban == false)
                        {
                            srtusuarios = string.Format("Catalogo Usuarios");                            
                            FrmUsuario Usuario = new FrmUsuario();
                            Usuario.Text =srtusuarios;
                            Usuario.MdiParent = this;
                            Usuario.Show();                             
                        }
                    }
                }
            }
            else
            {
                srtusuarios = string.Format("Catalogo Usuarios");
                FrmUsuario Usuario = new FrmUsuario();
                Usuario.Text = srtusuarios;
                Usuario.MdiParent = this;
                Usuario.Show();   
            }                        
        }

        private void ArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ultraTabbedMdiManager1.ActiveTab != null &&  srtArticulos == "Catalogo Articulos")
            {
                MdiTabGroup tabGroup = this.ultraTabbedMdiManager1.TabGroups[0];
                for (int j = tabGroup.Tabs.Count - 1; j >= 0; j--)
                {
                    Operador = j;
                    if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador])).TextResolved == "Catalogo Articulos")
                    {
                        int Ren = (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador]))).Index;
                        ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs[Ren].Activate();
                    }
                    else
                    {
                        Boolean ban = false;
                        for (int x = tabGroup.Tabs.Count - 1; x >= 0; x--)
                        {
                            if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[x])).TextResolved == "Catalogo Articulos")
                            { ban = true; }
                        }
                        if (ban == false)
                        {
                            srtArticulos = string.Format("Catalogo Articulos");
                            FrmArticulo Arti = new FrmArticulo(Permiso);
                            Arti.Text = srtArticulos;
                            Arti.MdiParent = this;
                            Arti.Show();                            
                        }
                    }
                }
            }
            else
            {
                srtArticulos = string.Format("Catalogo Articulos");
                FrmArticulo Arti = new FrmArticulo(Permiso);
                Arti.Text = srtArticulos;
                Arti.MdiParent = this;
                Arti.Show(); 
            }       
        }

        private void kitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ultraTabbedMdiManager1.ActiveTab != null && srtkit == "Kits de Articulos")
            {
                MdiTabGroup tabGroup = this.ultraTabbedMdiManager1.TabGroups[0];
                for (int j = tabGroup.Tabs.Count - 1; j >= 0; j--)
                {
                    Operador = j;
                    if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador])).TextResolved == "Kits de Articulos")
                    {
                        int Ren = (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador]))).Index;
                        ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs[Ren].Activate();
                    }
                    else
                    {
                        Boolean ban = false;
                        for (int x = tabGroup.Tabs.Count - 1; x >= 0; x--)
                        {
                            if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[x])).TextResolved == "Kits de Articulos")
                            { ban = true; }
                        }
                        if (ban == false)
                        {
                            srtkit = string.Format("Kits de Articulos");
                            FrmKit Kit = new FrmKit(Permiso);
                            Kit.Text = srtkit;
                            Kit.MdiParent = this;
                            Kit.Show(); 
                        }
                    }
                }
            }
            else
            {
                srtkit = string.Format("Kits de Articulos");
                FrmKit Kit = new FrmKit(Permiso);
                Kit.Text = srtkit;
                Kit.MdiParent = this;
                Kit.Show(); 
            }         
        }                  

        private void ProveedortoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ultraTabbedMdiManager1.ActiveTab != null && srtproveedores == "Catalogo de Proveedores")
            {
                MdiTabGroup tabGroup = this.ultraTabbedMdiManager1.TabGroups[0];
                for (int j = tabGroup.Tabs.Count - 1; j >= 0; j--)
                {
                    Operador = j;
                    if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador])).TextResolved == "Catalogo de Proveedores")
                    {
                        int Ren = (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador]))).Index;
                        ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs[Ren].Activate();
                    }
                    else
                    {
                        Boolean ban = false;
                        for (int x = tabGroup.Tabs.Count - 1; x >= 0; x--)
                        {
                            if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[x])).TextResolved == "Catalogo de Proveedores")
                            { ban = true; }
                        }
                        if (ban == false)
                        {
                            srtproveedores = string.Format("Catalogo de Proveedores");
                            FrmProveedor Proveedor = new FrmProveedor(Permiso);
                            Proveedor.Text = srtproveedores;
                            Proveedor.MdiParent = this;
                            Proveedor.Show();
                        }
                    }
                }
            }
            else
            {
                srtproveedores = string.Format("Catalogo de Proveedores");
                FrmProveedor Proveedor = new FrmProveedor(Permiso);
                Proveedor.Text = srtproveedores;
                Proveedor.MdiParent = this;
                Proveedor.Show();
            }                      
        }

        private void ReportObraCtetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ultraTabbedMdiManager1.ActiveTab != null && srtreportobractes == "Reporte de Vivienda - Prospecto")
            {
                MdiTabGroup tabGroup = this.ultraTabbedMdiManager1.TabGroups[0];
                for (int j = tabGroup.Tabs.Count - 1; j >= 0; j--)
                {
                    Operador = j;
                    if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador])).TextResolved == "Reporte de Vivienda - Prospecto")
                    {
                        int Ren = (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador]))).Index;
                        ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs[Ren].Activate();
                    }
                    else
                    {
                        Boolean ban = false;
                        for (int x = tabGroup.Tabs.Count - 1; x >= 0; x--)
                        {
                            if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[x])).TextResolved == "Reporte de Vivienda - Prospecto")
                            { ban = true; }
                        }
                        if (ban == false)
                        {
                            srtreportobractes = string.Format("Reporte de Vivienda - Prospecto");
                            FrmReporteCliente RepCliente = new FrmReporteCliente();
                            RepCliente.Text = srtreportobractes;
                            RepCliente.MdiParent = this;
                            RepCliente.Show();   
                        }
                    }
                }
            }
            else
            {
                srtreportobractes = string.Format("Reporte de Vivienda - Prospecto");
                FrmReporteCliente RepCliente = new FrmReporteCliente();
                RepCliente.Text = srtreportobractes;
                RepCliente.MdiParent = this;
                RepCliente.Show();   
            }        
        }

        private void ArticuloObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // FrmArticulo_Obra
            if (ultraTabbedMdiManager1.ActiveTab != null && strarticulo_obra == "Articulo Vivienda")
            {
                MdiTabGroup tabGroup = this.ultraTabbedMdiManager1.TabGroups[0];
                for (int j = tabGroup.Tabs.Count - 1; j >= 0; j--)
                {
                    Operador = j;
                    if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador])).TextResolved == "Articulo Vivienda")
                    {
                        int Ren = (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador]))).Index;
                        ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs[Ren].Activate();
                    }
                    else
                    {
                        Boolean ban = false;
                        for (int x = tabGroup.Tabs.Count - 1; x >= 0; x--)
                        {
                            if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[x])).TextResolved == "Articulo Vivienda")
                            { ban = true; }
                        }
                        if (ban == false)
                        {
                            strarticulo_obra = string.Format("Articulo Vivienda");
                            FrmArticulo_Obra RepArti_Obra = new FrmArticulo_Obra(Permiso);
                            RepArti_Obra.Text = strarticulo_obra;
                            RepArti_Obra.MdiParent = this;
                            RepArti_Obra.Show();
                        }
                    }
                }
            }
            else
            {
                strarticulo_obra = string.Format("Articulo Vivienda");
                FrmArticulo_Obra RepArti_Obra = new FrmArticulo_Obra(Permiso);
                RepArti_Obra.Text = strarticulo_obra;
                RepArti_Obra.MdiParent = this;
                RepArti_Obra.Show();
            }        
        }

        private void articuloObraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ultraTabbedMdiManager1.ActiveTab != null && srtreportearticuloobra == "Reporte de Articulo - Vivienda")
            {
                MdiTabGroup tabGroup = this.ultraTabbedMdiManager1.TabGroups[0];
                for (int j = tabGroup.Tabs.Count - 1; j >= 0; j--)
                {
                    Operador = j;
                    if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador])).TextResolved == "Reporte de Articulo - Vivienda")
                    {
                        int Ren = (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador]))).Index;
                        ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs[Ren].Activate();
                    }
                    else
                    {
                        Boolean ban = false;
                        for (int x = tabGroup.Tabs.Count - 1; x >= 0; x--)
                        {
                            if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[x])).TextResolved == "Reporte de Articulo - Vivienda")
                            { ban = true; }
                        }
                        if (ban == false)
                        {
                            srtreportearticuloobra = string.Format("Reporte de Articulo  - Vivienda");
                            FrmFiltroObra RepCliente = new FrmFiltroObra();
                            RepCliente.Text = srtreportearticuloobra;
                            RepCliente.MdiParent = this;
                            RepCliente.Show();
                        }
                    }
                }
            }
            else
            {
                srtreportearticuloobra = string.Format("Reporte de Articulo - Vivienda");
                FrmFiltroObra RepCliente = new FrmFiltroObra();
                RepCliente.Text = srtreportearticuloobra;
                RepCliente.MdiParent = this;
                RepCliente.Show();
            }        
        }

        private void TraspasosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmTraspaso

            if (ultraTabbedMdiManager1.ActiveTab != null && strtraspasos == "Traspasos de Artículos")
            {
                MdiTabGroup tabGroup = this.ultraTabbedMdiManager1.TabGroups[0];
                for (int j = tabGroup.Tabs.Count - 1; j >= 0; j--)
                {
                    Operador = j;
                    if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador])).TextResolved == "Traspasos de Artículos")
                    {
                        int Ren = (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador]))).Index;
                        ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs[Ren].Activate();
                    }
                    else
                    {
                        Boolean ban = false;
                        for (int x = tabGroup.Tabs.Count - 1; x >= 0; x--)
                        {
                            if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[x])).TextResolved == "Traspasos de Artículos")
                            { ban = true; }
                        }
                        if (ban == false)
                        {
                            strtraspasos = string.Format("Traspasos de Artículos");
                            FrmTraspaso Traspasos = new FrmTraspaso(Permiso);
                            Traspasos.Text = strtraspasos;
                            Traspasos.MdiParent = this;
                            Traspasos.Show();
                        }
                    }
                }
            }
            else
            {
                strtraspasos = string.Format("Traspasos de Artículos");
                FrmTraspaso Traspasos = new FrmTraspaso(Permiso);
                Traspasos.Text = strtraspasos;
                Traspasos.MdiParent = this;
                Traspasos.Show();
            }                      

        }

        private void RespRestaurartoolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mandar un parametro que nos regrese si se cerrara la pantalla principal
            if (ultraTabbedMdiManager1.ActiveTab != null && srtRespRestaurar == "Respaldar/Restaurar Base de Datos")
            {
                MdiTabGroup tabGroup = this.ultraTabbedMdiManager1.TabGroups[0];
                for (int j = tabGroup.Tabs.Count - 1; j >= 0; j--)
                {
                    Operador = j;
                    if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador])).TextResolved == "Respaldar/Restaurar Base de Datos")
                    {
                        int Ren = (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[Operador]))).Index;
                        ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs[Ren].Activate();
                    }
                    else
                    {
                        Boolean ban = false;
                        for (int x = tabGroup.Tabs.Count - 1; x >= 0; x--)
                        {
                            if (((Infragistics.Win.UltraWinTabbedMdi.MdiTab)(this.ultraTabbedMdiManager1.ActiveTab.TabGroup.Tabs.All[x])).TextResolved == "Respaldar/Restaurar Base de Datos")
                            { ban = true; }
                        }
                        if (ban == false)
                        {
                            srtRespRestaurar = string.Format("Respaldar/Restaurar Base de Datos");
                            FrmUtileria Utileria = new FrmUtileria();
                            Utileria.Text = srtRespRestaurar;
                            Utileria.MdiParent = this;
                            Utileria.Show();
                        }
                    }
                }
            }
            else
            {
                srtRespRestaurar = string.Format("Respaldar/Restaurar Base de Datos");
                FrmUtileria Utileria = new FrmUtileria();
                Utileria.Text = srtRespRestaurar;
                Utileria.MdiParent = this;
                Utileria.Show();
            }                  
            
        }

        private void configuracionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }    


   
    }
}