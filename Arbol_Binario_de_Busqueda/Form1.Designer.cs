
namespace Arbol_Binario_de_Busqueda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Generar_Recorrido = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pre = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txt_in = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_post = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arbol Binario de Busqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar Numero: ";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(210, 52);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(215, 32);
            this.txt_numero.TabIndex = 2;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(55, 132);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(106, 28);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Generar_Recorrido
            // 
            this.btn_Generar_Recorrido.Location = new System.Drawing.Point(55, 413);
            this.btn_Generar_Recorrido.Name = "btn_Generar_Recorrido";
            this.btn_Generar_Recorrido.Size = new System.Drawing.Size(108, 56);
            this.btn_Generar_Recorrido.TabIndex = 5;
            this.btn_Generar_Recorrido.Text = "Generar Recorrido";
            this.btn_Generar_Recorrido.UseVisualStyleBackColor = true;
            this.btn_Generar_Recorrido.Click += new System.EventHandler(this.btn_Generar_Recorrido_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "PreOrden:";
            // 
            // txt_pre
            // 
            this.txt_pre.Location = new System.Drawing.Point(163, 491);
            this.txt_pre.Name = "txt_pre";
            this.txt_pre.Size = new System.Drawing.Size(288, 32);
            this.txt_pre.TabIndex = 7;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(178, 96);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(273, 373);
            this.treeView1.TabIndex = 8;
            // 
            // txt_in
            // 
            this.txt_in.Location = new System.Drawing.Point(163, 529);
            this.txt_in.Name = "txt_in";
            this.txt_in.Size = new System.Drawing.Size(288, 32);
            this.txt_in.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "InOrden:";
            // 
            // txt_post
            // 
            this.txt_post.Location = new System.Drawing.Point(163, 567);
            this.txt_post.Name = "txt_post";
            this.txt_post.Size = new System.Drawing.Size(288, 32);
            this.txt_post.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 570);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "PostOrden:";
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(55, 98);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(106, 28);
            this.btn_Insertar.TabIndex = 13;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 633);
            this.Controls.Add(this.btn_Insertar);
            this.Controls.Add(this.txt_post);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_in);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txt_pre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Generar_Recorrido);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Generar_Recorrido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pre;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txt_in;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_post;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Insertar;
    }
}

