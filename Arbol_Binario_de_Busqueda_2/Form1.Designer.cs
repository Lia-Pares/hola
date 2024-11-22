namespace Arbol_Binario_de_Busqueda_2
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
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.txt_sueldo = new System.Windows.Forms.TextBox();
            this.txt_PostOrden = new System.Windows.Forms.TextBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Minimo = new System.Windows.Forms.Button();
            this.btn_Maximo = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_PostOrden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arbol Binario de Busqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa número: ";
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(82, 98);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(115, 30);
            this.btn_Insertar.TabIndex = 2;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // txt_sueldo
            // 
            this.txt_sueldo.Location = new System.Drawing.Point(212, 50);
            this.txt_sueldo.Name = "txt_sueldo";
            this.txt_sueldo.Size = new System.Drawing.Size(224, 32);
            this.txt_sueldo.TabIndex = 3;
            // 
            // txt_PostOrden
            // 
            this.txt_PostOrden.Location = new System.Drawing.Point(158, 301);
            this.txt_PostOrden.Name = "txt_PostOrden";
            this.txt_PostOrden.Size = new System.Drawing.Size(333, 32);
            this.txt_PostOrden.TabIndex = 5;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(82, 134);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(115, 30);
            this.btn_Eliminar.TabIndex = 6;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Minimo
            // 
            this.btn_Minimo.Location = new System.Drawing.Point(82, 170);
            this.btn_Minimo.Name = "btn_Minimo";
            this.btn_Minimo.Size = new System.Drawing.Size(115, 30);
            this.btn_Minimo.TabIndex = 7;
            this.btn_Minimo.Text = "Minimo";
            this.btn_Minimo.UseVisualStyleBackColor = true;
            // 
            // btn_Maximo
            // 
            this.btn_Maximo.Location = new System.Drawing.Point(82, 206);
            this.btn_Maximo.Name = "btn_Maximo";
            this.btn_Maximo.Size = new System.Drawing.Size(115, 30);
            this.btn_Maximo.TabIndex = 8;
            this.btn_Maximo.Text = "Maximo";
            this.btn_Maximo.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(82, 242);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(115, 30);
            this.btn_Buscar.TabIndex = 9;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(212, 94);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(224, 195);
            this.treeView1.TabIndex = 10;
            // 
            // btn_PostOrden
            // 
            this.btn_PostOrden.Location = new System.Drawing.Point(21, 300);
            this.btn_PostOrden.Name = "btn_PostOrden";
            this.btn_PostOrden.Size = new System.Drawing.Size(115, 30);
            this.btn_PostOrden.TabIndex = 11;
            this.btn_PostOrden.Text = "PostOrden";
            this.btn_PostOrden.UseVisualStyleBackColor = true;
            this.btn_PostOrden.Click += new System.EventHandler(this.btn_PostOrden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 349);
            this.Controls.Add(this.btn_PostOrden);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Maximo);
            this.Controls.Add(this.btn_Minimo);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.txt_PostOrden);
            this.Controls.Add(this.txt_sueldo);
            this.Controls.Add(this.btn_Insertar);
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
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.TextBox txt_sueldo;
        private System.Windows.Forms.TextBox txt_PostOrden;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Minimo;
        private System.Windows.Forms.Button btn_Maximo;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_PostOrden;
    }
}

