using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace CheckPoint2
{
    public partial class frmMain : Form
    {
        ArrayList actor = new ArrayList();

        public frmMain()
        {
            InitializeComponent();
        }

        public void LoadArrayList()
        {
            TextReader tr;
            string temp = "";
           
            tr = File.OpenText("C:\\Users\\Owen\\Documents\\Visual Studio 2015\\Projects\\CheckPoint2\\actors.txt");
            while ((temp = tr.ReadLine()) != null)
            {
                actor.Add(temp);
            }
            tr.Close();
        }

        public void WriteArrayList()
        {
            TextWriter tw;

            tw = File.CreateText("actors.txt");
            foreach (string names in actor)
            {
                tw.WriteLine(names);
            }
            tw.Close();

        }

        public void PopulateActors()
        {
            cboActors.Items.Clear();
            foreach (string name in actor)
            {
                cboActors.Items.Add(name);
            }
        }

        public void InsertIntoArraylist(string name, int i)
        {
            actor.Insert(i, name);
        }

        public void DeleteFromArraylist(int i)
        {
            actor.RemoveAt(i);
        }

        private void mnuRead_Click(object sender, EventArgs e)
        {
            this.LoadArrayList();
            this.PopulateActors(); 
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtActorName.Text;
                int index = int.Parse(txtPosition.Text);
                this.InsertIntoArraylist(name, index);
                this.PopulateActors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. Please enter values for position and actor name!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(txtPosition.Text);
                this.DeleteFromArraylist(index);
                this.PopulateActors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter position!");
            }
        }

        private void mnuWrite_Click(object sender, EventArgs e)
        {
            this.WriteArrayList();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
