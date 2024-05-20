namespace pryCalvetTP1
{
    partial class frmLocalQuenaken
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tblAsientosAzules = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblAsientosVerdes = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tblAsientosVerdes);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.tblAsientosAzules);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(896, 349);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // tblAsientosAzules
            // 
            this.tblAsientosAzules.BackColor = System.Drawing.Color.MediumBlue;
            this.tblAsientosAzules.ColumnCount = 1;
            this.tblAsientosAzules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAsientosAzules.Location = new System.Drawing.Point(3, 190);
            this.tblAsientosAzules.Name = "tblAsientosAzules";
            this.tblAsientosAzules.RowCount = 4;
            this.tblAsientosAzules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAsientosAzules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAsientosAzules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAsientosAzules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAsientosAzules.Size = new System.Drawing.Size(893, 128);
            this.tblAsientosAzules.TabIndex = 1;
            this.tblAsientosAzules.Paint += new System.Windows.Forms.PaintEventHandler(this.tblAsientosAzules_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 47);
            this.panel1.TabIndex = 2;
            // 
            // tblAsientosVerdes
            // 
            this.tblAsientosVerdes.BackColor = System.Drawing.Color.Lime;
            this.tblAsientosVerdes.ColumnCount = 1;
            this.tblAsientosVerdes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAsientosVerdes.Location = new System.Drawing.Point(3, 3);
            this.tblAsientosVerdes.Name = "tblAsientosVerdes";
            this.tblAsientosVerdes.RowCount = 4;
            this.tblAsientosVerdes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAsientosVerdes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAsientosVerdes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAsientosVerdes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAsientosVerdes.Size = new System.Drawing.Size(893, 128);
            this.tblAsientosVerdes.TabIndex = 2;
            this.tblAsientosVerdes.Paint += new System.Windows.Forms.PaintEventHandler(this.tblAsientoVerde_Paint);
            // 
            // frmLocalQuenaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 584);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLocalQuenaken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Quenaken";
            this.Load += new System.EventHandler(this.frmLocalQuenaken_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tblAsientosAzules;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tblAsientosVerdes;
    }
}