using Cookbook.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace Cookbook.WinUI.Reporti
{
    public partial class ReceptSastojakForm : Form
    {
        private int id;
        private APIService _recept = new APIService("Recept");
        private APIService _receptsastojak = new APIService("ReceptSastojak");
        public ReceptSastojakForm(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private async void ReceptSastojakForm_Load(object sender, EventArgs e)
        {
            var recept = await _recept.GetById<Model.Recept>(id);
            var receptsastojci = (await _receptsastojak.Get<List<Model.ReceptSastojak>>(null)).Where(y=>y.ReceptId==recept.ReceptId);

            ReceptSastojakDataSet.tblReceptSastojakDataTable tbl = new ReceptSastojakDataSet.tblReceptSastojakDataTable();
            foreach(var m in receptsastojci)
            {
            ReceptSastojakDataSet.tblReceptSastojakRow red = tbl.NewtblReceptSastojakRow();
                red.MjernaJedinica = m.MjernaJedinica;
                red.Kolicina = m.MjernaKolicina;
                red.Sastojak = m.Sastojak;
                tbl.Rows.Add(red);
            }
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("Naziv", recept.Naziv));
            rpc.Add(new ReportParameter("Tekst", recept.Tekst));
            rpc.Add(new ReportParameter("BrojLjudi", recept.BrojLjudi.ToString()));
            rpc.Add(new ReportParameter("VrijemeKuhanja", recept.VrijemeKuhanja.ToString()));
            rpc.Add(new ReportParameter("VrijemePripreme", recept.VrijemePripreme.ToString()));
            rpc.Add(new ReportParameter("Slozenost", recept.Slozenost));
            rpc.Add(new ReportParameter("Kategorija", recept.Kategorija));
            rpc.Add(new ReportParameter("GrupaJela", recept.GrupaJela));
            rpc.Add(new ReportParameter("Slika", recept.Slika.ToString()));
            //rpc.Add(new ReportParameter("Datum", DateTime.Now.ToString("dd.MM.yyyy HH:mm")));

            ReportDataSource rds = new ReportDataSource();

            rds.Name = "ReceptSastojakDS";
            rds.Value = tbl;
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

       
    }
}
