namespace Arbol_Binario_de_Busqueda_3
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txt_postorden = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_inorden = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_preorden = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.btn_Generar_Recorrido = new System.Windows.Forms.Button();
            this.btn_Altura = new System.Windows.Forms.Button();
            this.btn_Maximo = new System.Windows.Forms.Button();
            this.btn_Minimo = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(161, 105);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(329, 274);
            this.treeView1.TabIndex = 33;
            // 
            // txt_postorden
            // 
            this.txt_postorden.Location = new System.Drawing.Point(161, 473);
            this.txt_postorden.Name = "txt_postorden";
            this.txt_postorden.Size = new System.Drawing.Size(329, 32);
            this.txt_postorden.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "POSTORDEN";
            // 
            // txt_inorden
            // 
            this.txt_inorden.Location = new System.Drawing.Point(161, 435);
            this.txt_inorden.Name = "txt_inorden";
            this.txt_inorden.Size = new System.Drawing.Size(329, 32);
            this.txt_inorden.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "INORDEN";
            // 
            // txt_preorden
            // 
            this.txt_preorden.Location = new System.Drawing.Point(161, 397);
            this.txt_preorden.Name = "txt_preorden";
            this.txt_preorden.Size = new System.Drawing.Size(329, 32);
            this.txt_preorden.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "PREORDEN";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(185, 62);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(284, 32);
            this.txt_numero.TabIndex = 26;
            // 
            // btn_Generar_Recorrido
            // 
            this.btn_Generar_Recorrido.Location = new System.Drawing.Point(32, 321);
            this.btn_Generar_Recorrido.Name = "btn_Generar_Recorrido";
            this.btn_Generar_Recorrido.Size = new System.Drawing.Size(106, 58);
            this.btn_Generar_Recorrido.TabIndex = 25;
            this.btn_Generar_Recorrido.Text = "Generar Recorrido";
            this.btn_Generar_Recorrido.UseVisualStyleBackColor = true;
            this.btn_Generar_Recorrido.Click += new System.EventHandler(this.btn_Generar_Recorrido_Click);
            // 
            // btn_Altura
            // 
            this.btn_Altura.Location = new System.Drawing.Point(32, 285);
            this.btn_Altura.Name = "btn_Altura";
            this.btn_Altura.Size = new System.Drawing.Size(106, 30);
            this.btn_Altura.TabIndex = 24;
            this.btn_Altura.Text = "Altura";
            this.btn_Altura.UseVisualStyleBackColor = true;
            this.btn_Altura.Click += new System.EventHandler(this.btn_Altura_Click);
            // 
            // btn_Maximo
            // 
            this.btn_Maximo.Location = new System.Drawing.Point(32, 249);
            this.btn_Maximo.Name = "btn_Maximo";
            this.btn_Maximo.Size = new System.Drawing.Size(106, 30);
            this.btn_Maximo.TabIndex = 23;
            this.btn_Maximo.Text = "Maximo";
            this.btn_Maximo.UseVisualStyleBackColor = true;
            this.btn_Maximo.Click += new System.EventHandler(this.btn_Maximo_Click);
            // 
            // btn_Minimo
            // 
            this.btn_Minimo.Location = new System.Drawing.Point(32, 213);
            this.btn_Minimo.Name = "btn_Minimo";
            this.btn_Minimo.Size = new System.Drawing.Size(106, 30);
            this.btn_Minimo.TabIndex = 22;
            this.btn_Minimo.Text = "Minimo";
            this.btn_Minimo.UseVisualStyleBackColor = true;
            this.btn_Minimo.Click += new System.EventHandler(this.btn_Minimo_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(32, 177);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(106, 30);
            this.btn_Eliminar.TabIndex = 21;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(32, 141);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(106, 30);
            this.btn_Buscar.TabIndex = 20;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(32, 105);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(106, 30);
            this.btn_Insertar.TabIndex = 19;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ingresar Número: ";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(105, 16);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(314, 31);
            this.A.TabIndex = 17;
            this.A.Text = "Arbol Binario de Busqueda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 517);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txt_postorden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_inorden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_preorden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.btn_Generar_Recorrido);
            this.Controls.Add(this.btn_Altura);
            this.Controls.Add(this.btn_Maximo);
            this.Controls.Add(this.btn_Minimo);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Insertar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.A);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txt_postorden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_inorden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_preorden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Button btn_Generar_Recorrido;
        private System.Windows.Forms.Button btn_Altura;
        private System.Windows.Forms.Button btn_Maximo;
        private System.Windows.Forms.Button btn_Minimo;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label A;
    }
}

