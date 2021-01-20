namespace MaquinaDeTuring
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcadena = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPasos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBorrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(175, -9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Máquina de Turing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar cadena:";
            // 
            // txtcadena
            // 
            this.txtcadena.BorderColorFocused = System.Drawing.Color.Black;
            this.txtcadena.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcadena.BorderColorMouseHover = System.Drawing.Color.Black;
            this.txtcadena.BorderThickness = 2;
            this.txtcadena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcadena.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcadena.ForeColor = System.Drawing.Color.Black;
            this.txtcadena.isPassword = false;
            this.txtcadena.Location = new System.Drawing.Point(275, 329);
            this.txtcadena.Margin = new System.Windows.Forms.Padding(4);
            this.txtcadena.Name = "txtcadena";
            this.txtcadena.Size = new System.Drawing.Size(335, 44);
            this.txtcadena.TabIndex = 2;
            this.txtcadena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcadena.OnValueChanged += new System.EventHandler(this.txtcadena_OnValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(275, 397);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "#";
            // 
            // btnPasos
            // 
            this.btnPasos.Activecolor = System.Drawing.Color.Black;
            this.btnPasos.BackColor = System.Drawing.Color.Black;
            this.btnPasos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPasos.BorderRadius = 0;
            this.btnPasos.ButtonText = "Pasos";
            this.btnPasos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasos.DisabledColor = System.Drawing.Color.Gray;
            this.btnPasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPasos.Iconimage = null;
            this.btnPasos.Iconimage_right = null;
            this.btnPasos.Iconimage_right_Selected = null;
            this.btnPasos.Iconimage_Selected = null;
            this.btnPasos.IconMarginLeft = 0;
            this.btnPasos.IconMarginRight = 0;
            this.btnPasos.IconRightVisible = true;
            this.btnPasos.IconRightZoom = 0D;
            this.btnPasos.IconVisible = true;
            this.btnPasos.IconZoom = 90D;
            this.btnPasos.IsTab = false;
            this.btnPasos.Location = new System.Drawing.Point(616, 329);
            this.btnPasos.Name = "btnPasos";
            this.btnPasos.Normalcolor = System.Drawing.Color.Black;
            this.btnPasos.OnHovercolor = System.Drawing.Color.Black;
            this.btnPasos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPasos.selected = false;
            this.btnPasos.Size = new System.Drawing.Size(109, 44);
            this.btnPasos.TabIndex = 5;
            this.btnPasos.Text = "Pasos";
            this.btnPasos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPasos.Textcolor = System.Drawing.Color.White;
            this.btnPasos.TextFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasos.Click += new System.EventHandler(this.btnPasos_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(304, 397);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(26, 29);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "#";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(332, 397);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(28, 29);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "#";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(366, 397);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(26, 29);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "#";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(395, 397);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(26, 29);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "#";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(426, 397);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(29, 29);
            this.textBox6.TabIndex = 14;
            this.textBox6.Text = "#";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(456, 397);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(29, 29);
            this.textBox7.TabIndex = 13;
            this.textBox7.Text = "#";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(491, 397);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(29, 29);
            this.textBox8.TabIndex = 12;
            this.textBox8.Text = "#";
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(526, 397);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(25, 29);
            this.textBox9.TabIndex = 11;
            this.textBox9.Text = "#";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(557, 397);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(22, 29);
            this.textBox10.TabIndex = 10;
            this.textBox10.Text = "#";
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(585, 397);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(25, 29);
            this.textBox11.TabIndex = 15;
            this.textBox11.Text = "#";
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.Crimson;
            this.textBox12.Location = new System.Drawing.Point(275, 424);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(26, 29);
            this.textBox12.TabIndex = 26;
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.ForeColor = System.Drawing.Color.Crimson;
            this.textBox13.Location = new System.Drawing.Point(304, 424);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(26, 29);
            this.textBox13.TabIndex = 25;
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.ForeColor = System.Drawing.Color.Crimson;
            this.textBox14.Location = new System.Drawing.Point(332, 424);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(26, 29);
            this.textBox14.TabIndex = 28;
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.ForeColor = System.Drawing.Color.Crimson;
            this.textBox15.Location = new System.Drawing.Point(366, 424);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(26, 29);
            this.textBox15.TabIndex = 27;
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.ForeColor = System.Drawing.Color.Crimson;
            this.textBox16.Location = new System.Drawing.Point(395, 424);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(26, 29);
            this.textBox16.TabIndex = 32;
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.ForeColor = System.Drawing.Color.Crimson;
            this.textBox17.Location = new System.Drawing.Point(426, 424);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(29, 29);
            this.textBox17.TabIndex = 31;
            // 
            // textBox18
            // 
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox18.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.ForeColor = System.Drawing.Color.Crimson;
            this.textBox18.Location = new System.Drawing.Point(456, 424);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(29, 29);
            this.textBox18.TabIndex = 30;
            // 
            // textBox19
            // 
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox19.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.ForeColor = System.Drawing.Color.Crimson;
            this.textBox19.Location = new System.Drawing.Point(491, 424);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(16, 29);
            this.textBox19.TabIndex = 29;
            // 
            // textBox20
            // 
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox20.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox20.ForeColor = System.Drawing.Color.Crimson;
            this.textBox20.Location = new System.Drawing.Point(526, 424);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(16, 29);
            this.textBox20.TabIndex = 36;
            // 
            // textBox21
            // 
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox21.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox21.ForeColor = System.Drawing.Color.Crimson;
            this.textBox21.Location = new System.Drawing.Point(557, 424);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(16, 29);
            this.textBox21.TabIndex = 35;
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox23.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.ForeColor = System.Drawing.Color.Crimson;
            this.textBox23.Location = new System.Drawing.Point(585, 424);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(16, 29);
            this.textBox23.TabIndex = 33;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.ForeColor = System.Drawing.Color.Crimson;
            this.lbEstado.Location = new System.Drawing.Point(457, 472);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(0, 34);
            this.lbEstado.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 34);
            this.label4.TabIndex = 40;
            this.label4.Text = "Estado:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Activecolor = System.Drawing.Color.Black;
            this.btnBorrar.BackColor = System.Drawing.Color.Crimson;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.BorderRadius = 0;
            this.btnBorrar.ButtonText = "Borrar";
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBorrar.Iconimage = null;
            this.btnBorrar.Iconimage_right = null;
            this.btnBorrar.Iconimage_right_Selected = null;
            this.btnBorrar.Iconimage_Selected = null;
            this.btnBorrar.IconMarginLeft = 0;
            this.btnBorrar.IconMarginRight = 0;
            this.btnBorrar.IconRightVisible = true;
            this.btnBorrar.IconRightZoom = 0D;
            this.btnBorrar.IconVisible = true;
            this.btnBorrar.IconZoom = 90D;
            this.btnBorrar.IsTab = false;
            this.btnBorrar.Location = new System.Drawing.Point(373, 520);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Normalcolor = System.Drawing.Color.Crimson;
            this.btnBorrar.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnBorrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBorrar.selected = false;
            this.btnBorrar.Size = new System.Drawing.Size(109, 44);
            this.btnBorrar.TabIndex = 42;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBorrar.Textcolor = System.Drawing.Color.White;
            this.btnBorrar.TextFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            this.bunifuElipse1.TargetControlResized += new System.EventHandler(this.bunifuElipse1_TargetControlResized);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Crimson;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Salir";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(766, 2);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(49, 26);
            this.bunifuFlatButton3.TabIndex = 43;
            this.bunifuFlatButton3.Text = "Salir";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaquinaDeTuring.Properties.Resources.grafoya;
            this.pictureBox1.Location = new System.Drawing.Point(119, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(606, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 629);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnPasos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtcadena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtcadena;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPasos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btnBorrar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

