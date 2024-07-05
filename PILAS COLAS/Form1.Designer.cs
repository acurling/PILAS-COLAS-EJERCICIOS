namespace PILAS_COLAS
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
            this.bagregar = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.lresultado = new System.Windows.Forms.Label();
            this.tnumeros = new System.Windows.Forms.TextBox();
            this.tcolas = new System.Windows.Forms.TextBox();
            this.lcolas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.beiminarcola = new System.Windows.Forms.Button();
            this.bagregarcola = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bagregar
            // 
            this.bagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagregar.ForeColor = System.Drawing.Color.Red;
            this.bagregar.Location = new System.Drawing.Point(75, 119);
            this.bagregar.Name = "bagregar";
            this.bagregar.Size = new System.Drawing.Size(133, 49);
            this.bagregar.TabIndex = 0;
            this.bagregar.Text = "AGREGAR";
            this.bagregar.UseVisualStyleBackColor = true;
            this.bagregar.Click += new System.EventHandler(this.bagregar_Click);
            // 
            // beliminar
            // 
            this.beliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beliminar.ForeColor = System.Drawing.Color.Red;
            this.beliminar.Location = new System.Drawing.Point(226, 119);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(128, 49);
            this.beliminar.TabIndex = 1;
            this.beliminar.Text = "ELIMINAR";
            this.beliminar.UseVisualStyleBackColor = true;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.Red;
            this.Label.Location = new System.Drawing.Point(75, 53);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(61, 24);
            this.Label.TabIndex = 2;
            this.Label.Text = "PILAS";
            // 
            // lresultado
            // 
            this.lresultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lresultado.Location = new System.Drawing.Point(75, 188);
            this.lresultado.Name = "lresultado";
            this.lresultado.Size = new System.Drawing.Size(231, 24);
            this.lresultado.TabIndex = 3;
            // 
            // tnumeros
            // 
            this.tnumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnumeros.Location = new System.Drawing.Point(75, 84);
            this.tnumeros.Name = "tnumeros";
            this.tnumeros.Size = new System.Drawing.Size(119, 29);
            this.tnumeros.TabIndex = 4;
            // 
            // tcolas
            // 
            this.tcolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcolas.Location = new System.Drawing.Point(57, 290);
            this.tcolas.Name = "tcolas";
            this.tcolas.Size = new System.Drawing.Size(151, 29);
            this.tcolas.TabIndex = 9;
            // 
            // lcolas
            // 
            this.lcolas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lcolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcolas.Location = new System.Drawing.Point(57, 394);
            this.lcolas.Name = "lcolas";
            this.lcolas.Size = new System.Drawing.Size(231, 24);
            this.lcolas.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(57, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "COLAS";
            // 
            // beiminarcola
            // 
            this.beiminarcola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beiminarcola.ForeColor = System.Drawing.Color.Red;
            this.beiminarcola.Location = new System.Drawing.Point(208, 325);
            this.beiminarcola.Name = "beiminarcola";
            this.beiminarcola.Size = new System.Drawing.Size(128, 49);
            this.beiminarcola.TabIndex = 6;
            this.beiminarcola.Text = "ELIMINAR";
            this.beiminarcola.UseVisualStyleBackColor = true;
            this.beiminarcola.Click += new System.EventHandler(this.beiminarcola_Click);
            // 
            // bagregarcola
            // 
            this.bagregarcola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagregarcola.ForeColor = System.Drawing.Color.Red;
            this.bagregarcola.Location = new System.Drawing.Point(57, 325);
            this.bagregarcola.Name = "bagregarcola";
            this.bagregarcola.Size = new System.Drawing.Size(133, 49);
            this.bagregarcola.TabIndex = 5;
            this.bagregarcola.Text = "AGREGAR";
            this.bagregarcola.UseVisualStyleBackColor = true;
            this.bagregarcola.Click += new System.EventHandler(this.bagregarcola_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "CONSULTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 557);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tcolas);
            this.Controls.Add(this.lcolas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.beiminarcola);
            this.Controls.Add(this.bagregarcola);
            this.Controls.Add(this.tnumeros);
            this.Controls.Add(this.lresultado);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.beliminar);
            this.Controls.Add(this.bagregar);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bagregar;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label lresultado;
        private System.Windows.Forms.TextBox tnumeros;
        private System.Windows.Forms.TextBox tcolas;
        private System.Windows.Forms.Label lcolas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button beiminarcola;
        private System.Windows.Forms.Button bagregarcola;
        private System.Windows.Forms.Button button1;
    }
}

