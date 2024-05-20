using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCalvetTP1
{
    public partial class frmLocalQuenaken : Form
    {


        public frmLocalQuenaken()
        {
            InitializeComponent();
        }
        private void frmLocalQuenaken_Load(object sender, EventArgs e)
        {
            


        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            // panel contenedor para poner en una celda
            Panel panelAsiento = new Panel();
            int nro = 1; // número que tendrá el asiento
                         // crear el PictureBox
            PictureBox pic = new PictureBox();
            // agregar la imagen desde un archivo
            string ruta = Path.Combine(Application.StartupPath, "..", "..", "Resources", "asiento.png");
            pic.ImageLocation = ruta;
            // agregar el pictureBox al panel
            panelAsiento.Controls.Add(pic);
            // crear el Label
            Label lbl = new Label();
            // asignar el texto a mostrar
            lbl.Text = nro.ToString();
            // agregar el Label al panel
            panelAsiento.Controls.Add(lbl);
            // agregar el panel al TableLayoutPanel en la fila 0, columna 0
            tblAsientosAzules.Controls.Add(panelAsiento, 0, 0);
        }

        private void tblAsientosAzules_Paint(object sender, PaintEventArgs e)
        {
            tblAsientosAzules.ColumnStyles.Clear();
            tblAsientosAzules.ColumnCount = 10;
            for (int i = 0; i < 10; i++)
            {
                tblAsientosAzules.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,
                (float)10));
            }
        }



        private void tblAsientoVerde_Paint(object sender, PaintEventArgs e)
        {
            tblAsientosVerdes.ColumnStyles.Clear();
            tblAsientosVerdes.ColumnCount = 10;
            for (int i = 0; i < 10; i++)
            {
                tblAsientosVerdes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,
                (float)10));
            }
        }
    }




}

    
