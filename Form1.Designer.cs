namespace CanoRuben_PR1x6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Desplegable_MedidaIzq = new System.Windows.Forms.ComboBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.Desplegable_MedidaDer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Desplegable_PesoDer = new System.Windows.Forms.ComboBox();
            this.valorDer = new System.Windows.Forms.TextBox();
            this.valorIzq = new System.Windows.Forms.TextBox();
            this.Desplegable_PesoIzq = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PesoButton = new FontAwesome.Sharp.IconButton();
            this.MedidaButton = new FontAwesome.Sharp.IconButton();
            this.infoValores = new System.Windows.Forms.ToolTip(this.components);
            this.infoDesplegablesMedida = new System.Windows.Forms.ToolTip(this.components);
            this.infoBotones = new System.Windows.Forms.ToolTip(this.components);
            this.infoDesplegablesPeso = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Desplegable_MedidaIzq
            // 
            this.Desplegable_MedidaIzq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(173)))), ((int)(((byte)(127)))));
            this.Desplegable_MedidaIzq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Desplegable_MedidaIzq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Desplegable_MedidaIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Desplegable_MedidaIzq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Desplegable_MedidaIzq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(55)))), ((int)(((byte)(29)))));
            this.Desplegable_MedidaIzq.FormattingEnabled = true;
            this.Desplegable_MedidaIzq.Items.AddRange(new object[] {
            "Milímetro",
            "Centímetro",
            "Decímetro",
            "Metro",
            "Decámetro",
            "Hectómetro",
            "Kilómetro",
            "Pulgada",
            "Pie",
            "Yarda",
            "Braza",
            "Milla",
            "Legua"});
            this.Desplegable_MedidaIzq.Location = new System.Drawing.Point(3, 25);
            this.Desplegable_MedidaIzq.Name = "Desplegable_MedidaIzq";
            this.Desplegable_MedidaIzq.Size = new System.Drawing.Size(120, 24);
            this.Desplegable_MedidaIzq.TabIndex = 0;
            this.Desplegable_MedidaIzq.SelectedIndexChanged += new System.EventHandler(this.Desplegable_SelectedIndexChanged);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(249)))), ((int)(((byte)(191)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(75)))), ((int)(((byte)(42)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Equals;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(75)))), ((int)(((byte)(42)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(220, 10);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 36);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // Desplegable_MedidaDer
            // 
            this.Desplegable_MedidaDer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(173)))), ((int)(((byte)(127)))));
            this.Desplegable_MedidaDer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Desplegable_MedidaDer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Desplegable_MedidaDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Desplegable_MedidaDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Desplegable_MedidaDer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(55)))), ((int)(((byte)(29)))));
            this.Desplegable_MedidaDer.FormattingEnabled = true;
            this.Desplegable_MedidaDer.Items.AddRange(new object[] {
            "Milímetro",
            "Centímetro",
            "Decímetro",
            "Metro",
            "Decámetro",
            "Hectómetro",
            "Kilómetro",
            "Pulgada",
            "Pie",
            "Yarda",
            "Braza",
            "Milla",
            "Legua"});
            this.Desplegable_MedidaDer.Location = new System.Drawing.Point(345, 25);
            this.Desplegable_MedidaDer.Name = "Desplegable_MedidaDer";
            this.Desplegable_MedidaDer.Size = new System.Drawing.Size(121, 24);
            this.Desplegable_MedidaDer.TabIndex = 2;
            this.Desplegable_MedidaDer.SelectedIndexChanged += new System.EventHandler(this.Desplegable_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Desplegable_PesoDer);
            this.panel1.Controls.Add(this.valorDer);
            this.panel1.Controls.Add(this.valorIzq);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.Desplegable_PesoIzq);
            this.panel1.Controls.Add(this.Desplegable_MedidaIzq);
            this.panel1.Controls.Add(this.Desplegable_MedidaDer);
            this.panel1.Location = new System.Drawing.Point(31, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 55);
            this.panel1.TabIndex = 6;
            // 
            // Desplegable_PesoDer
            // 
            this.Desplegable_PesoDer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(173)))), ((int)(((byte)(127)))));
            this.Desplegable_PesoDer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Desplegable_PesoDer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Desplegable_PesoDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Desplegable_PesoDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Desplegable_PesoDer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(55)))), ((int)(((byte)(29)))));
            this.Desplegable_PesoDer.FormattingEnabled = true;
            this.Desplegable_PesoDer.Items.AddRange(new object[] {
            "Miligramo",
            "Centigramo",
            "Decigramo",
            "Gramo",
            "Decagramo",
            "Hectogramo",
            "Kilogramo",
            "Quintal",
            "Tonelada",
            "Cuarto",
            "Grano",
            "Libra",
            "Onza",
            "Arroba",
            "stone"});
            this.Desplegable_PesoDer.Location = new System.Drawing.Point(345, 25);
            this.Desplegable_PesoDer.Name = "Desplegable_PesoDer";
            this.Desplegable_PesoDer.Size = new System.Drawing.Size(121, 24);
            this.Desplegable_PesoDer.TabIndex = 7;
            this.Desplegable_PesoDer.SelectedIndexChanged += new System.EventHandler(this.Desplegable_SelectedIndexChanged);
            // 
            // valorDer
            // 
            this.valorDer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(211)))), ((int)(((byte)(158)))));
            this.valorDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorDer.ForeColor = System.Drawing.Color.White;
            this.valorDer.Location = new System.Drawing.Point(345, 3);
            this.valorDer.Name = "valorDer";
            this.valorDer.Size = new System.Drawing.Size(121, 22);
            this.valorDer.TabIndex = 9;
            this.valorDer.TextChanged += new System.EventHandler(this.valorDer_TextChanged);
            this.valorDer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ConvertirMedidas);
            // 
            // valorIzq
            // 
            this.valorIzq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(211)))), ((int)(((byte)(158)))));
            this.valorIzq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorIzq.ForeColor = System.Drawing.Color.White;
            this.valorIzq.Location = new System.Drawing.Point(3, 3);
            this.valorIzq.Name = "valorIzq";
            this.valorIzq.Size = new System.Drawing.Size(120, 22);
            this.valorIzq.TabIndex = 8;
            this.valorIzq.TextChanged += new System.EventHandler(this.valorIzq_TextChanged);
            this.valorIzq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ConvertirMedidas);
            // 
            // Desplegable_PesoIzq
            // 
            this.Desplegable_PesoIzq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(173)))), ((int)(((byte)(127)))));
            this.Desplegable_PesoIzq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Desplegable_PesoIzq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Desplegable_PesoIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Desplegable_PesoIzq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desplegable_PesoIzq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(55)))), ((int)(((byte)(29)))));
            this.Desplegable_PesoIzq.FormattingEnabled = true;
            this.Desplegable_PesoIzq.Items.AddRange(new object[] {
            "Miligramo",
            "Centigramo",
            "Decigramo",
            "Gramo",
            "Decagramo",
            "Hectogramo",
            "Kilogramo",
            "Quintal",
            "Tonelada",
            "Cuarto",
            "Grano",
            "Libra",
            "Onza",
            "Arroba",
            "stone"});
            this.Desplegable_PesoIzq.Location = new System.Drawing.Point(3, 25);
            this.Desplegable_PesoIzq.Name = "Desplegable_PesoIzq";
            this.Desplegable_PesoIzq.Size = new System.Drawing.Size(120, 24);
            this.Desplegable_PesoIzq.TabIndex = 6;
            this.Desplegable_PesoIzq.SelectedIndexChanged += new System.EventHandler(this.Desplegable_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(102)))), ((int)(((byte)(63)))));
            this.panel3.Controls.Add(this.iconButton2);
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(536, 43);
            this.panel3.TabIndex = 8;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(448, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(36, 33);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(490, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(36, 33);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(189)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(5, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Conversor De Unidades";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(102)))), ((int)(((byte)(63)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(531, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 173);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(102)))), ((int)(((byte)(63)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 173);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(102)))), ((int)(((byte)(63)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(5, 211);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(526, 5);
            this.panel6.TabIndex = 11;
            // 
            // PesoButton
            // 
            this.PesoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PesoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(34)))));
            this.PesoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(140)))), ((int)(((byte)(175)))));
            this.PesoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PesoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(75)))), ((int)(((byte)(42)))));
            this.PesoButton.IconChar = FontAwesome.Sharp.IconChar.Weight;
            this.PesoButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(75)))), ((int)(((byte)(42)))));
            this.PesoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PesoButton.IconSize = 35;
            this.PesoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PesoButton.Location = new System.Drawing.Point(284, 137);
            this.PesoButton.Name = "PesoButton";
            this.PesoButton.Size = new System.Drawing.Size(58, 53);
            this.PesoButton.TabIndex = 12;
            this.PesoButton.Text = "Peso";
            this.PesoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PesoButton.UseVisualStyleBackColor = true;
            this.PesoButton.Click += new System.EventHandler(this.PesoButton_Click);
            // 
            // MedidaButton
            // 
            this.MedidaButton.BackColor = System.Drawing.Color.Transparent;
            this.MedidaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MedidaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(34)))));
            this.MedidaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(140)))), ((int)(((byte)(175)))));
            this.MedidaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MedidaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedidaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(75)))), ((int)(((byte)(42)))));
            this.MedidaButton.IconChar = FontAwesome.Sharp.IconChar.RulerHorizontal;
            this.MedidaButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(75)))), ((int)(((byte)(42)))));
            this.MedidaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MedidaButton.IconSize = 40;
            this.MedidaButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MedidaButton.Location = new System.Drawing.Point(193, 137);
            this.MedidaButton.Name = "MedidaButton";
            this.MedidaButton.Size = new System.Drawing.Size(58, 53);
            this.MedidaButton.TabIndex = 13;
            this.MedidaButton.Text = "Medida";
            this.MedidaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MedidaButton.UseVisualStyleBackColor = false;
            this.MedidaButton.Click += new System.EventHandler(this.MedidaButton_Click);
            // 
            // infoValores
            // 
            this.infoValores.IsBalloon = true;
            this.infoValores.Tag = "";
            this.infoValores.ToolTipTitle = "Valor a convertir";
            // 
            // infoDesplegablesMedida
            // 
            this.infoDesplegablesMedida.IsBalloon = true;
            // 
            // infoBotones
            // 
            this.infoBotones.IsBalloon = true;
            // 
            // infoDesplegablesPeso
            // 
            this.infoDesplegablesPeso.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(249)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(536, 216);
            this.Controls.Add(this.PesoButton);
            this.Controls.Add(this.MedidaButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Unidades";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Desplegable_MedidaIzq;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.ComboBox Desplegable_MedidaDer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Desplegable_PesoDer;
        private System.Windows.Forms.ComboBox Desplegable_PesoIzq;
        private System.Windows.Forms.TextBox valorDer;
        private System.Windows.Forms.TextBox valorIzq;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton PesoButton;
        private FontAwesome.Sharp.IconButton MedidaButton;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ToolTip infoValores;
        private System.Windows.Forms.ToolTip infoDesplegablesMedida;
        private System.Windows.Forms.ToolTip infoBotones;
        private System.Windows.Forms.ToolTip infoDesplegablesPeso;
    }
}

