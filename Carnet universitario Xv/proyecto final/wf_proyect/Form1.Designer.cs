namespace wf_proyect
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEstado = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cbxEstudiante = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ApellidoP = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.TextBox();
            this.lbl_DNi = new System.Windows.Forms.TextBox();
            this.lbl_ApellidoM = new System.Windows.Forms.TextBox();
            this.pkfoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(9, 79);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(75, 23);
            this.btnEstado.TabIndex = 0;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(25, 140);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 31);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // cbxEstudiante
            // 
            this.cbxEstudiante.FormattingEnabled = true;
            this.cbxEstudiante.Location = new System.Drawing.Point(9, 42);
            this.cbxEstudiante.Name = "cbxEstudiante";
            this.cbxEstudiante.Size = new System.Drawing.Size(154, 21);
            this.cbxEstudiante.TabIndex = 4;
            this.cbxEstudiante.SelectedIndexChanged += new System.EventHandler(this.cbxEstudiante_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_ApellidoP
            // 
            this.lbl_ApellidoP.Location = new System.Drawing.Point(493, 117);
            this.lbl_ApellidoP.Name = "lbl_ApellidoP";
            this.lbl_ApellidoP.Size = new System.Drawing.Size(119, 20);
            this.lbl_ApellidoP.TabIndex = 6;
            this.lbl_ApellidoP.TextChanged += new System.EventHandler(this.lbl_Estudio_TextChanged);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Location = new System.Drawing.Point(493, 169);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(119, 20);
            this.lbl_nombre.TabIndex = 7;
            // 
            // lbl_DNi
            // 
            this.lbl_DNi.Location = new System.Drawing.Point(520, 204);
            this.lbl_DNi.Name = "lbl_DNi";
            this.lbl_DNi.Size = new System.Drawing.Size(92, 20);
            this.lbl_DNi.TabIndex = 8;
            // 
            // lbl_ApellidoM
            // 
            this.lbl_ApellidoM.Location = new System.Drawing.Point(543, 143);
            this.lbl_ApellidoM.Name = "lbl_ApellidoM";
            this.lbl_ApellidoM.Size = new System.Drawing.Size(69, 20);
            this.lbl_ApellidoM.TabIndex = 9;
            // 
            // pkfoto
            // 
            this.pkfoto.Image = ((System.Drawing.Image)(resources.GetObject("pkfoto.Image")));
            this.pkfoto.Location = new System.Drawing.Point(618, 92);
            this.pkfoto.Name = "pkfoto";
            this.pkfoto.Size = new System.Drawing.Size(167, 196);
            this.pkfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pkfoto.TabIndex = 10;
            this.pkfoto.TabStop = false;
            this.pkfoto.Click += new System.EventHandler(this.pkfoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(877, 371);
            this.Controls.Add(this.pkfoto);
            this.Controls.Add(this.lbl_ApellidoM);
            this.Controls.Add(this.lbl_DNi);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_ApellidoP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbxEstudiante);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnEstado);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox cbxEstudiante;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lbl_ApellidoP;
        private System.Windows.Forms.TextBox lbl_nombre;
        private System.Windows.Forms.TextBox lbl_DNi;
        private System.Windows.Forms.TextBox lbl_ApellidoM;
        private System.Windows.Forms.PictureBox pkfoto;
    }
}

