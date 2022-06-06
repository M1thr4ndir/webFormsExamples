namespace WindowsFormsApp1
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
            this.btnRadioButtonPais = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listaPaises = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.botonFecha = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnIrBrowser = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBackBrowser = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saludosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.holaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despedidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lovimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felicitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bienahiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.formOneDato = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRadioButtonPais
            // 
            this.btnRadioButtonPais.Location = new System.Drawing.Point(343, 339);
            this.btnRadioButtonPais.Name = "btnRadioButtonPais";
            this.btnRadioButtonPais.Size = new System.Drawing.Size(75, 23);
            this.btnRadioButtonPais.TabIndex = 0;
            this.btnRadioButtonPais.Text = "Boton";
            this.btnRadioButtonPais.UseVisualStyleBackColor = true;
            this.btnRadioButtonPais.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(54, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(316, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 31);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(19, 54);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(535, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 201);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // listaPaises
            // 
            this.listaPaises.FormattingEnabled = true;
            this.listaPaises.Items.AddRange(new object[] {
            "Argentina",
            "Mexico",
            "Colombia"});
            this.listaPaises.Location = new System.Drawing.Point(100, 240);
            this.listaPaises.Name = "listaPaises";
            this.listaPaises.Size = new System.Drawing.Size(120, 95);
            this.listaPaises.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(535, 228);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // botonFecha
            // 
            this.botonFecha.Location = new System.Drawing.Point(566, 288);
            this.botonFecha.Name = "botonFecha";
            this.botonFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.botonFecha.Size = new System.Drawing.Size(121, 23);
            this.botonFecha.TabIndex = 11;
            this.botonFecha.Text = "Boton Fecha";
            this.botonFecha.UseVisualStyleBackColor = true;
            this.botonFecha.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(582, 339);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Usas teclado ingles?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(26, 480);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(762, 455);
            this.webBrowser1.TabIndex = 13;
            // 
            // btnIrBrowser
            // 
            this.btnIrBrowser.Location = new System.Drawing.Point(690, 442);
            this.btnIrBrowser.Name = "btnIrBrowser";
            this.btnIrBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnIrBrowser.TabIndex = 14;
            this.btnIrBrowser.Text = "Ir";
            this.btnIrBrowser.UseVisualStyleBackColor = true;
            this.btnIrBrowser.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 444);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btnBackBrowser
            // 
            this.btnBackBrowser.Location = new System.Drawing.Point(269, 441);
            this.btnBackBrowser.Name = "btnBackBrowser";
            this.btnBackBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBackBrowser.TabIndex = 16;
            this.btnBackBrowser.Text = "<";
            this.btnBackBrowser.UseVisualStyleBackColor = true;
            this.btnBackBrowser.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(170, 441);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 17;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saludosToolStripMenuItem,
            this.despedidasToolStripMenuItem,
            this.felicitacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saludosToolStripMenuItem
            // 
            this.saludosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holaToolStripMenuItem,
            this.hiToolStripMenuItem});
            this.saludosToolStripMenuItem.Name = "saludosToolStripMenuItem";
            this.saludosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.saludosToolStripMenuItem.Text = "Saludos";
            // 
            // holaToolStripMenuItem
            // 
            this.holaToolStripMenuItem.Name = "holaToolStripMenuItem";
            this.holaToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.holaToolStripMenuItem.Text = " Hola";
            this.holaToolStripMenuItem.Click += new System.EventHandler(this.holaToolStripMenuItem_Click);
            // 
            // hiToolStripMenuItem
            // 
            this.hiToolStripMenuItem.Name = "hiToolStripMenuItem";
            this.hiToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.hiToolStripMenuItem.Text = "Hi";
            // 
            // despedidasToolStripMenuItem
            // 
            this.despedidasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chauToolStripMenuItem,
            this.lovimoToolStripMenuItem});
            this.despedidasToolStripMenuItem.Name = "despedidasToolStripMenuItem";
            this.despedidasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.despedidasToolStripMenuItem.Text = "Despedidas";
            // 
            // chauToolStripMenuItem
            // 
            this.chauToolStripMenuItem.Name = "chauToolStripMenuItem";
            this.chauToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.chauToolStripMenuItem.Text = "Chau";
            // 
            // lovimoToolStripMenuItem
            // 
            this.lovimoToolStripMenuItem.Name = "lovimoToolStripMenuItem";
            this.lovimoToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.lovimoToolStripMenuItem.Text = "Lovimo";
            // 
            // felicitacionesToolStripMenuItem
            // 
            this.felicitacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bienahiToolStripMenuItem,
            this.gGToolStripMenuItem});
            this.felicitacionesToolStripMenuItem.Name = "felicitacionesToolStripMenuItem";
            this.felicitacionesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.felicitacionesToolStripMenuItem.Text = "Felicitaciones";
            // 
            // bienahiToolStripMenuItem
            // 
            this.bienahiToolStripMenuItem.Name = "bienahiToolStripMenuItem";
            this.bienahiToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.bienahiToolStripMenuItem.Text = "Bienahi";
            // 
            // gGToolStripMenuItem
            // 
            this.gGToolStripMenuItem.Name = "gGToolStripMenuItem";
            this.gGToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.gGToolStripMenuItem.Text = "GG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Formulario 2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // formOneDato
            // 
            this.formOneDato.Location = new System.Drawing.Point(127, 38);
            this.formOneDato.Name = "formOneDato";
            this.formOneDato.Size = new System.Drawing.Size(100, 20);
            this.formOneDato.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 947);
            this.Controls.Add(this.formOneDato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBackBrowser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIrBrowser);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.botonFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listaPaises);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRadioButtonPais);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "w";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRadioButtonPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listaPaises;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonFecha;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnIrBrowser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBackBrowser;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saludosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despedidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lovimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felicitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bienahiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gGToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox formOneDato;
    }
}

