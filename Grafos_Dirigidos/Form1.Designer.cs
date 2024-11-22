namespace Grafos_Dirigidos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.btn_Matriz_de_Cosoto = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Insertar_N = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Vertices = new System.Windows.Forms.TextBox();
            this.txt_Origen = new System.Windows.Forms.TextBox();
            this.txt_Destino = new System.Windows.Forms.TextBox();
            this.txt_Costo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese # Vertices:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Destino:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Costo:";
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(466, 57);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(96, 32);
            this.btn_Insertar.TabIndex = 5;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // btn_Matriz_de_Cosoto
            // 
            this.btn_Matriz_de_Cosoto.Location = new System.Drawing.Point(337, 107);
            this.btn_Matriz_de_Cosoto.Name = "btn_Matriz_de_Cosoto";
            this.btn_Matriz_de_Cosoto.Size = new System.Drawing.Size(263, 32);
            this.btn_Matriz_de_Cosoto.TabIndex = 6;
            this.btn_Matriz_de_Cosoto.Text = "Matriz de Costo";
            this.btn_Matriz_de_Cosoto.UseVisualStyleBackColor = true;
            this.btn_Matriz_de_Cosoto.Click += new System.EventHandler(this.btn_Matriz_de_Cosoto_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(337, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(263, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "DIJKSTRA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Insertar_N
            // 
            this.btn_Insertar_N.Location = new System.Drawing.Point(56, 248);
            this.btn_Insertar_N.Name = "btn_Insertar_N";
            this.btn_Insertar_N.Size = new System.Drawing.Size(96, 32);
            this.btn_Insertar_N.TabIndex = 8;
            this.btn_Insertar_N.Text = "Insertar";
            this.btn_Insertar_N.UseVisualStyleBackColor = true;
            this.btn_Insertar_N.Click += new System.EventHandler(this.btn_Insertar_N_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(16, 298);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 409);
            this.listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 27;
            this.listBox2.Location = new System.Drawing.Point(218, 433);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(501, 274);
            this.listBox2.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(218, 148);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(501, 230);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "GRAFOS DIRIGIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Origen:";
            // 
            // txt_Vertices
            // 
            this.txt_Vertices.Location = new System.Drawing.Point(310, 57);
            this.txt_Vertices.Name = "txt_Vertices";
            this.txt_Vertices.Size = new System.Drawing.Size(149, 35);
            this.txt_Vertices.TabIndex = 14;
            // 
            // txt_Origen
            // 
            this.txt_Origen.Location = new System.Drawing.Point(105, 119);
            this.txt_Origen.Name = "txt_Origen";
            this.txt_Origen.Size = new System.Drawing.Size(94, 35);
            this.txt_Origen.TabIndex = 16;
            // 
            // txt_Destino
            // 
            this.txt_Destino.Location = new System.Drawing.Point(105, 161);
            this.txt_Destino.Name = "txt_Destino";
            this.txt_Destino.Size = new System.Drawing.Size(94, 35);
            this.txt_Destino.TabIndex = 17;
            // 
            // txt_Costo
            // 
            this.txt_Costo.Location = new System.Drawing.Point(105, 207);
            this.txt_Costo.Name = "txt_Costo";
            this.txt_Costo.Size = new System.Drawing.Size(94, 35);
            this.txt_Costo.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 725);
            this.Controls.Add(this.txt_Costo);
            this.Controls.Add(this.txt_Destino);
            this.Controls.Add(this.txt_Origen);
            this.Controls.Add(this.txt_Vertices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Insertar_N);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Matriz_de_Cosoto);
            this.Controls.Add(this.btn_Insertar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Button btn_Matriz_de_Cosoto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Insertar_N;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Vertices;
        private System.Windows.Forms.TextBox txt_Origen;
        private System.Windows.Forms.TextBox txt_Destino;
        private System.Windows.Forms.TextBox txt_Costo;
    }
}

