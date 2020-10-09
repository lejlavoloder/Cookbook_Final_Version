using Cookbook.WinUI.Clanak;
using Cookbook.WinUI.Dokumenti;
using Cookbook.WinUI.Favoriti;
using Cookbook.WinUI.GrupaJela;
using Cookbook.WinUI.Kategorija;
using Cookbook.WinUI.MjernaJedinica;
using Cookbook.WinUI.MjernaKolicina;
using Cookbook.WinUI.Posjetitelj;
using Cookbook.WinUI.Recept;
using Cookbook.WinUI.Sastojak;
using Cookbook.WinUI.Slozenost;
using Cookbook.WinUI.VrstaClanka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookbook.WinUI
{
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

     
        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSastojak frm = new frmSastojak();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSastojakDetalji frm = new frmSastojakDetalji();
            frm.Show();
        }

        private void pretragaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmKategorija frm = new frmKategorija();
            frm.MdiParent = this;
            frm.Show();
        }

        private void novaKategorijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategorijaDetalji frm = new frmKategorijaDetalji();
            frm.Show();
        }

        private void pretragaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmMjernaJedinica frm = new frmMjernaJedinica();
            frm.MdiParent = this;
            frm.Show();
        }

        private void novaMjernaJedinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMjernaJedinicaDetalji frm = new frmMjernaJedinicaDetalji();
            frm.Show();
        }

        private void pretragaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmGrupaJela frm = new frmGrupaJela();
            frm.MdiParent = this;
            frm.Show();
        }

        private void novaGrupaJelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrupaJelaDetalji frm = new frmGrupaJelaDetalji();
            frm.Show();
        }

        private void pretragaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmSlozenost frm = new frmSlozenost();
            frm.MdiParent = this;
            frm.Show();
        }

        private void novaSloženostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSlozenostDetalji frm = new frmSlozenostDetalji();
            frm.Show();
        }

        private void pretragaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmMjernaKolicina frm = new frmMjernaKolicina();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajNovuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMjernaKolicinaDetalji frm = new frmMjernaKolicinaDetalji();
            frm.Show();
        }

        private void pretragaToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmVrstaClanka frm = new frmVrstaClanka();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajNovuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVrstaClankaDetalji frm = new frmVrstaClankaDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pretragaToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmClanak frm = new frmClanak();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajNoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClanakDetalji frm = new frmClanakDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajNoviToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDodajRecept frm = new frmDodajRecept();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajSastojakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajSastojak frm = new frmDodajSastojak();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pretragaRecepataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceptPretraga frm = new frmReceptPretraga();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pretragaToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmDokument frm = new frmDokument();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDokumentDetalji frm = new frmDokumentDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajNovogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPosjetiteljDetalji frm = new frmPosjetiteljDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pretragaToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frmPosjetitelj frm = new frmPosjetitelj();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pretragaToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmFavoriti frm = new frmFavoriti();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajNoviToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmFavoritiDetalji frm = new frmFavoritiDetalji();
            frm.MdiParent = this;
            frm.Show();

        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void receptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
