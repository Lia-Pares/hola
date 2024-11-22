
namespace Grafos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_origen = new System.Windows.Forms.TextBox();
            this.txt_destino = new System.Windows.Forms.TextBox();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Matriz = new System.Windows.Forms.Button();
            this.btn_bfs = new System.Windows.Forms.Button();
            this.btn_DFS = new System.Windows.Forms.Button();
            this.btn_orden = new System.Windows.Forms.Button();
            this.txt_amplitud = new System.Windows.Forms.TextBox();
            this.txt_profundidad = new System.Windows.Forms.TextBox();
            this.txt_orden = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Insertar);
            this.groupBox1.Controls.Add(this.txt_destino);
            this.groupBox1.Controls.Add(this.txt_origen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(71, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nodos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destino:";
            // 
            // txt_origen
            // 
            this.txt_origen.Location = new System.Drawing.Point(91, 31);
            this.txt_origen.Name = "txt_origen";
            this.txt_origen.Size = new System.Drawing.Size(92, 32);
            this.txt_origen.TabIndex = 2;
            // 
            // txt_destino
            // 
            this.txt_destino.Location = new System.Drawing.Point(91, 69);
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.Size = new System.Drawing.Size(92, 32);
            this.txt_destino.TabIndex = 3;
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(51, 107);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(85, 34);
            this.btn_Insertar.TabIndex = 4;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "GRAFOS DIRIGIDOS";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(81, 202);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(173, 280);
            this.listBox1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(283, 121);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(350, 362);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btn_Matriz
            // 
            this.btn_Matriz.Location = new System.Drawing.Point(326, 86);
            this.btn_Matriz.Name = "btn_Matriz";
            this.btn_Matriz.Size = new System.Drawing.Size(219, 29);
            this.btn_Matriz.TabIndex = 4;
            this.btn_Matriz.Text = "Matriz de Adyacencia";
            this.btn_Matriz.UseVisualStyleBackColor = true;
            this.btn_Matriz.Click += new System.EventHandler(this.btn_Matriz_Click);
            // 
            // btn_bfs
            // 
            this.btn_bfs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bfs.Location = new System.Drawing.Point(12, 486);
            this.btn_bfs.Name = "btn_bfs";
            this.btn_bfs.Size = new System.Drawing.Size(195, 34);
            this.btn_bfs.TabIndex = 5;
            this.btn_bfs.Text = "BFS - AMPLITUD";
            this.btn_bfs.UseVisualStyleBackColor = true;
            this.btn_bfs.Click += new System.EventHandler(this.btn_bfs_Click);
            // 
            // btn_DFS
            // 
            this.btn_DFS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DFS.Location = new System.Drawing.Point(12, 526);
            this.btn_DFS.Name = "btn_DFS";
            this.btn_DFS.Size = new System.Drawing.Size(195, 34);
            this.btn_DFS.TabIndex = 6;
            this.btn_DFS.Text = "DFS - PROFUNDIDAD";
            this.btn_DFS.UseVisualStyleBackColor = true;
            this.btn_DFS.Click += new System.EventHandler(this.btn_DFS_Click);
            // 
            // btn_orden
            // 
            this.btn_orden.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orden.Location = new System.Drawing.Point(12, 566);
            this.btn_orden.Name = "btn_orden";
            this.btn_orden.Size = new System.Drawing.Size(195, 34);
            this.btn_orden.TabIndex = 7;
            this.btn_orden.Text = "ORDEN TOPOLÓGICO";
            this.btn_orden.UseVisualStyleBackColor = true;
            this.btn_orden.Click += new System.EventHandler(this.btn_orden_Click);
            // 
            // txt_amplitud
            // 
            this.txt_amplitud.Location = new System.Drawing.Point(224, 489);
            this.txt_amplitud.Name = "txt_amplitud";
            this.txt_amplitud.Size = new System.Drawing.Size(476, 32);
            this.txt_amplitud.TabIndex = 5;
            // 
            // txt_profundidad
            // 
            this.txt_profundidad.Location = new System.Drawing.Point(224, 529);
            this.txt_profundidad.Name = "txt_profundidad";
            this.txt_profundidad.Size = new System.Drawing.Size(476, 32);
            this.txt_profundidad.TabIndex = 8;
            // 
            // txt_orden
            // 
            this.txt_orden.Location = new System.Drawing.Point(224, 568);
            this.txt_orden.Name = "txt_orden";
            this.txt_orden.Size = new System.Drawing.Size(476, 32);
            this.txt_orden.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 610);
            this.Controls.Add(this.txt_orden);
            this.Controls.Add(this.txt_profundidad);
            this.Controls.Add(this.txt_amplitud);
            this.Controls.Add(this.btn_orden);
            this.Controls.Add(this.btn_DFS);
            this.Controls.Add(this.btn_bfs);
            this.Controls.Add(this.btn_Matriz);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.TextBox txt_destino;
        private System.Windows.Forms.TextBox txt_origen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_Matriz;
        private System.Windows.Forms.Button btn_bfs;
        private System.Windows.Forms.Button btn_DFS;
        private System.Windows.Forms.Button btn_orden;
        private System.Windows.Forms.TextBox txt_amplitud;
        private System.Windows.Forms.TextBox txt_profundidad;
        private System.Windows.Forms.TextBox txt_orden;
    }
}

