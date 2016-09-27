using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        OpenFileDialog ofile = new OpenFileDialog();
        DialogResult dr;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            dr = ofile.ShowDialog();

            if (dr == DialogResult.OK)
            {
                var xml = XDocument.Load(ofile.FileName);
                var json = ((XElement)xml.FirstNode).Value;
                var list = JsonConvert.DeserializeObject<List<Fallecido>>(json);

                MessageBox.Show(list.First().Curp + "\n" + list.First().Nombre + "\n" + list.First().Paterno + "\n" + 
                    list.First().Materno + "\n" + list.First().Edad);
            }
        }
    }
}
