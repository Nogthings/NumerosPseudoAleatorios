namespace Simulación
{
    partial class Metodo2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Metodo2));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtBoxIteraciones = new System.Windows.Forms.TextBox();
            this.txtBoxT = new System.Windows.Forms.TextBox();
            this.txtBoxSemilla = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtgvTabla = new System.Windows.Forms.DataGridView();
            this.Iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RnQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRnQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Val1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Val2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxSemilla2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(553, 11);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(40, 40);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtBoxIteraciones
            // 
            this.txtBoxIteraciones.Location = new System.Drawing.Point(303, 35);
            this.txtBoxIteraciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxIteraciones.MaxLength = 5;
            this.txtBoxIteraciones.Name = "txtBoxIteraciones";
            this.txtBoxIteraciones.Size = new System.Drawing.Size(76, 20);
            this.txtBoxIteraciones.TabIndex = 24;
            this.txtBoxIteraciones.TextChanged += new System.EventHandler(this.txtBoxIteraciones_TextChanged);
            this.txtBoxIteraciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxIteraciones_KeyPress);
            // 
            // txtBoxT
            // 
            this.txtBoxT.Location = new System.Drawing.Point(197, 35);
            this.txtBoxT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxT.MaxLength = 1;
            this.txtBoxT.Name = "txtBoxT";
            this.txtBoxT.Size = new System.Drawing.Size(76, 20);
            this.txtBoxT.TabIndex = 23;
            this.txtBoxT.TextChanged += new System.EventHandler(this.txtBoxT_TextChanged);
            this.txtBoxT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxT_KeyPress);
            // 
            // txtBoxSemilla
            // 
            this.txtBoxSemilla.Location = new System.Drawing.Point(14, 35);
            this.txtBoxSemilla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxSemilla.MaxLength = 4;
            this.txtBoxSemilla.Name = "txtBoxSemilla";
            this.txtBoxSemilla.Size = new System.Drawing.Size(76, 20);
            this.txtBoxSemilla.TabIndex = 22;
            this.txtBoxSemilla.TextChanged += new System.EventHandler(this.txtBoxSemilla_TextChanged);
            this.txtBoxSemilla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSemilla_KeyPress);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(597, 11);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(40, 40);
            this.btnRegresar.TabIndex = 21;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.Location = new System.Drawing.Point(465, 11);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(40, 40);
            this.btnGenerar.TabIndex = 20;
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtgvTabla
            // 
            this.dtgvTabla.AllowUserToAddRows = false;
            this.dtgvTabla.AllowUserToDeleteRows = false;
            this.dtgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteracion,
            this.Rn,
            this.Rn2,
            this.RnQ,
            this.MRnQ,
            this.Val1,
            this.Val2});
            this.dtgvTabla.Location = new System.Drawing.Point(9, 60);
            this.dtgvTabla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvTabla.Name = "dtgvTabla";
            this.dtgvTabla.ReadOnly = true;
            this.dtgvTabla.RowHeadersWidth = 51;
            this.dtgvTabla.RowTemplate.Height = 24;
            this.dtgvTabla.Size = new System.Drawing.Size(932, 503);
            this.dtgvTabla.TabIndex = 19;
            this.dtgvTabla.TabStop = false;
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
            this.Rn.HeaderText = "Rn1";
            this.Rn.MinimumWidth = 6;
            this.Rn.Name = "Rn";
            this.Rn.ReadOnly = true;
            this.Rn.Width = 125;
            // 
            // Rn2
            // 
            this.Rn2.HeaderText = "Rn2";
            this.Rn2.MinimumWidth = 6;
            this.Rn2.Name = "Rn2";
            this.Rn2.ReadOnly = true;
            this.Rn2.Width = 125;
            // 
            // RnQ
            // 
            this.RnQ.HeaderText = "Rn1*Rn2";
            this.RnQ.MinimumWidth = 6;
            this.RnQ.Name = "RnQ";
            this.RnQ.ReadOnly = true;
            this.RnQ.Width = 125;
            // 
            // MRnQ
            // 
            this.MRnQ.HeaderText = "M(Rn1*Rn2)";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Iteraciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "T";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Semilla1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Semilla2";
            // 
            // txtBoxSemilla2
            // 
            this.txtBoxSemilla2.Location = new System.Drawing.Point(106, 35);
            this.txtBoxSemilla2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxSemilla2.MaxLength = 4;
            this.txtBoxSemilla2.Name = "txtBoxSemilla2";
            this.txtBoxSemilla2.Size = new System.Drawing.Size(76, 20);
            this.txtBoxSemilla2.TabIndex = 27;
            this.txtBoxSemilla2.TextChanged += new System.EventHandler(this.txtBoxSemilla2_TextChanged);
            this.txtBoxSemilla2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSemilla2_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(509, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Metodo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 602);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxSemilla2);
            this.Controls.Add(this.label4);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Metodo2";
            this.Text = "Producto Medio";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtBoxIteraciones;
        private System.Windows.Forms.TextBox txtBoxT;
        private System.Windows.Forms.TextBox txtBoxSemilla;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dtgvTabla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxSemilla2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RnQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRnQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Val1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Val2;
        private System.Windows.Forms.Button button1;
    }
}