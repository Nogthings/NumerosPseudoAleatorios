namespace Simulación
{
    partial class Metodo1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Metodo1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvTabla = new System.Windows.Forms.DataGridView();
            this.Iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RnQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRnQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Val1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Val2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtBoxSemilla = new System.Windows.Forms.TextBox();
            this.txtBoxT = new System.Windows.Forms.TextBox();
            this.txtBoxIteraciones = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Semilla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "T";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Iteraciones";
            // 
            // dtgvTabla
            // 
            this.dtgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteracion,
            this.Rn,
            this.RnQ,
            this.MRnQ,
            this.Val1,
            this.Val2});
            this.dtgvTabla.Location = new System.Drawing.Point(9, 74);
            this.dtgvTabla.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvTabla.Name = "dtgvTabla";
            this.dtgvTabla.ReadOnly = true;
            this.dtgvTabla.RowHeadersWidth = 51;
            this.dtgvTabla.RowTemplate.Height = 24;
            this.dtgvTabla.Size = new System.Drawing.Size(802, 436);
            this.dtgvTabla.TabIndex = 6;
            // 
            // Iteracion
            // 
            this.Iteracion.HeaderText = "Iteración";
            this.Iteracion.MinimumWidth = 6;
            this.Iteracion.Name = "Iteracion";
            this.Iteracion.ReadOnly = true;
            this.Iteracion.Width = 125;
            // 
            // Rn
            // 
            this.Rn.HeaderText = "Rn";
            this.Rn.MinimumWidth = 6;
            this.Rn.Name = "Rn";
            this.Rn.ReadOnly = true;
            this.Rn.Width = 125;
            // 
            // RnQ
            // 
            this.RnQ.HeaderText = "R(n)^2";
            this.RnQ.MinimumWidth = 6;
            this.RnQ.Name = "RnQ";
            this.RnQ.ReadOnly = true;
            this.RnQ.Width = 125;
            // 
            // MRnQ
            // 
            this.MRnQ.HeaderText = "MR(n)^2";
            this.MRnQ.MinimumWidth = 6;
            this.MRnQ.Name = "MRnQ";
            this.MRnQ.ReadOnly = true;
            this.MRnQ.Width = 125;
            // 
            // Val1
            // 
            this.Val1.HeaderText = "Val1";
            this.Val1.MinimumWidth = 6;
            this.Val1.Name = "Val1";
            this.Val1.ReadOnly = true;
            this.Val1.Width = 125;
            // 
            // Val2
            // 
            this.Val2.HeaderText = "Val2";
            this.Val2.MinimumWidth = 6;
            this.Val2.Name = "Val2";
            this.Val2.ReadOnly = true;
            this.Val2.Width = 125;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.Location = new System.Drawing.Point(433, 18);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(40, 40);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(521, 18);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(40, 40);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtBoxSemilla
            // 
            this.txtBoxSemilla.Location = new System.Drawing.Point(9, 35);
            this.txtBoxSemilla.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxSemilla.MaxLength = 4;
            this.txtBoxSemilla.Name = "txtBoxSemilla";
            this.txtBoxSemilla.Size = new System.Drawing.Size(75, 20);
            this.txtBoxSemilla.TabIndex = 12;
            this.txtBoxSemilla.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBoxSemilla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtBoxT
            // 
            this.txtBoxT.Location = new System.Drawing.Point(97, 35);
            this.txtBoxT.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxT.MaxLength = 1;
            this.txtBoxT.Name = "txtBoxT";
            this.txtBoxT.Size = new System.Drawing.Size(75, 20);
            this.txtBoxT.TabIndex = 13;
            this.txtBoxT.TextChanged += new System.EventHandler(this.txtBoxT_TextChanged);
            this.txtBoxT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxT_KeyPress);
            // 
            // txtBoxIteraciones
            // 
            this.txtBoxIteraciones.Location = new System.Drawing.Point(193, 35);
            this.txtBoxIteraciones.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxIteraciones.MaxLength = 2;
            this.txtBoxIteraciones.Name = "txtBoxIteraciones";
            this.txtBoxIteraciones.Size = new System.Drawing.Size(75, 20);
            this.txtBoxIteraciones.TabIndex = 14;
            this.txtBoxIteraciones.TextChanged += new System.EventHandler(this.txtBoxIteraciones_TextChanged);
            this.txtBoxIteraciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxIteraciones_KeyPress);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(477, 18);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(40, 40);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Metodo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 531);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtBoxIteraciones);
            this.Controls.Add(this.txtBoxT);
            this.Controls.Add(this.txtBoxSemilla);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtgvTabla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Metodo1";
            this.Text = "Cuadrado Medio";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Metodo1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvTabla;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtBoxSemilla;
        private System.Windows.Forms.TextBox txtBoxT;
        private System.Windows.Forms.TextBox txtBoxIteraciones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RnQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRnQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Val1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Val2;
    }
}