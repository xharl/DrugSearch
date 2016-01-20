using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml.Linq;
using System.IO;

namespace DrugSearch
{
    public partial class DrugSearch : Form
    {
        public DrugSearch()
        {
            InitializeComponent();
        }

        static public string Sanitize(string s)
        {
            string admitted = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!-_+*°§ùàòèéìç£@#$^.()[] ";
            StringBuilder output = new StringBuilder(s.Length);
            bool found = false;

            foreach (char c in s)
            {
                found = false;
                foreach (char adm in admitted)
                {
                    if (c == adm)
                    {
                        found = true;
                        output.Append(c);
                    }
                }

            }

            return output.ToString();
        }
        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {

                // Convert byte[] to Image
                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            WebClient search = new WebClient();
            string xmlValue;
            int CSID;
            string inchikey;
            string query;
            string queryResult;

            lblResult.Text = "Looking...";
            lblResult.Visible = true;
            pgbQuery.Value = 0;
           
            try {
                query = String.Format("/Search.asmx/SimpleSearch?query={0}&token={1}", txtName.Text, "b5c4cf56-8064-46ef-b058-465ee70105ee");
                queryResult = search.DownloadString("http://www.chemspider.com" + query);
                xmlValue = XDocument.Parse(queryResult).Root.Elements().First().FirstNode.ToString();
                CSID = int.Parse(xmlValue);
                pgbQuery.Increment(14);
            }
            catch
            {
                lblResult.Text = "Search Failed";
                lblResult.ForeColor = Color.Red;
                lblResult.Visible = true;
                
                return;
            }

            
            try
            {
                query = String.Format("/Search.asmx/GetCompoundThumbnail?id={0}&token={1}", CSID, "b5c4cf56-8064-46ef-b058-465ee70105ee");
                queryResult = search.DownloadString("http://www.chemspider.com" + query);
                xmlValue = XDocument.Parse(queryResult).Elements().First().Value;
                pgbQuery.Increment(14);
            }
            catch
            { 
                lblResult.Text = "Search Failed";
                lblResult.Visible = true;
                return;
            }

            pctDrug.Image = Base64ToImage(xmlValue);
            pgbQuery.Increment(14);

            query = String.Format("/Search.asmx/GetCompoundInfo?CSID={0}&token={1}", CSID, "b5c4cf56-8064-46ef-b058-465ee70105ee");
            queryResult = search.DownloadString("http://www.chemspider.com" + query);
            XDocument xml = XDocument.Parse(queryResult);
            inchikey = xml.Descendants().Where(p => p.Name.LocalName == "InChIKey").First().Value;
            pgbQuery.Increment(14);

            query = String.Format("http://pubchem.ncbi.nlm.nih.gov/rest/pug/compound/inchikey/{0}/description/XML", inchikey);
            queryResult = search.DownloadString(query);
            xml = XDocument.Parse(queryResult);
            lbltxtName.Text = xml.Descendants().Where(p => p.Name.LocalName == "Title").First().Value.ToLower();
            lbltxtName.Visible = true;
            pgbQuery.Increment(14);
            try {
                query = String.Format("http://pubchem.ncbi.nlm.nih.gov/rest/pug/compound/inchikey/{0}/property/IUPACName,MolecularFormula,MolecularWeight/XML", inchikey);
                queryResult = search.DownloadString(query);
                xml = XDocument.Parse(queryResult);
                lbltxtIUPAC.Text = xml.Descendants().Where(p => p.Name.LocalName == "IUPACName").First().Value;
                lbltxtIUPAC.Visible = true;
                lbltxtMF.Text = xml.Descendants().Where(p => p.Name.LocalName == "MolecularFormula").First().Value;
                lbltxtMF.Visible = true;
                lbltxtMW.Text = xml.Descendants().Where(p => p.Name.LocalName == "MolecularWeight").First().Value;
                lbltxtMW.Visible = true;
                pgbQuery.Increment(14);
            }
            catch
            {
                lblResult.Text = "Error at pubchem";
                lblResult.Visible = true;
                return;
            }

            try
            {
                query = String.Format("https://en.wikipedia.org/w/api.php?action=query&titles={0}&prop=extracts&exintro=true&format=xml&explaintext=true&exsentences=4&redirects", lbltxtName.Text);
                queryResult = search.DownloadString(query);
                xml = XDocument.Parse(queryResult);
                lblDescription.Text = Sanitize(xml.Descendants().Where(p => p.Name.LocalName == "extract").First().Value);
                lblDescription.Visible = true;
                pgbQuery.Increment(14);
            }
            catch
            {
                lblResult.Text = "Error at wiki";
                lblResult.Visible = true;
                return;
            }
            lblResult.Text = "Search Succed";
            lblResult.ForeColor = Color.Black;
            pgbQuery.Increment(2);
            lblResult.Visible = true;
        }

        private void AddDrug_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
