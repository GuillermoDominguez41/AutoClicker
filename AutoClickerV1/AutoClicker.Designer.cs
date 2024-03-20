namespace AutoClickerV1
{
    partial class AutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClicker));
            this.btn_Principal = new System.Windows.Forms.Button();
            this.num_Retraso = new System.Windows.Forms.NumericUpDown();
            this.lbl_Retraso = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_MinimizarVentana = new System.Windows.Forms.CheckBox();
            this.chk_MoverCursor = new System.Windows.Forms.CheckBox();
            this.chk_CentrarCursor = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_Retraso)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Principal
            // 
            this.btn_Principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Principal.Location = new System.Drawing.Point(51, 82);
            this.btn_Principal.Name = "btn_Principal";
            this.btn_Principal.Size = new System.Drawing.Size(144, 35);
            this.btn_Principal.TabIndex = 0;
            this.btn_Principal.Text = "Iniciar";
            this.btn_Principal.UseVisualStyleBackColor = true;
            this.btn_Principal.Click += new System.EventHandler(this.Btn_Principal_Evento);
            // 
            // num_Retraso
            // 
            this.num_Retraso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Retraso.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.num_Retraso.Location = new System.Drawing.Point(71, 45);
            this.num_Retraso.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Retraso.Name = "num_Retraso";
            this.num_Retraso.Size = new System.Drawing.Size(105, 24);
            this.num_Retraso.TabIndex = 1;
            this.num_Retraso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_Retraso.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbl_Retraso
            // 
            this.lbl_Retraso.AutoSize = true;
            this.lbl_Retraso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Retraso.Location = new System.Drawing.Point(70, 13);
            this.lbl_Retraso.Name = "lbl_Retraso";
            this.lbl_Retraso.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_Retraso.Size = new System.Drawing.Size(106, 20);
            this.lbl_Retraso.TabIndex = 2;
            this.lbl_Retraso.Text = "Retraso (min)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_CentrarCursor);
            this.groupBox1.Controls.Add(this.chk_MoverCursor);
            this.groupBox1.Controls.Add(this.chk_MinimizarVentana);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(273, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones Adicionales";
            // 
            // chk_MinimizarVentana
            // 
            this.chk_MinimizarVentana.AutoSize = true;
            this.chk_MinimizarVentana.Checked = true;
            this.chk_MinimizarVentana.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_MinimizarVentana.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_MinimizarVentana.Location = new System.Drawing.Point(9, 31);
            this.chk_MinimizarVentana.Name = "chk_MinimizarVentana";
            this.chk_MinimizarVentana.Size = new System.Drawing.Size(185, 22);
            this.chk_MinimizarVentana.TabIndex = 0;
            this.chk_MinimizarVentana.Text = "Minimizar ventana actual";
            this.chk_MinimizarVentana.UseVisualStyleBackColor = true;
            // 
            // chk_MoverCursor
            // 
            this.chk_MoverCursor.AutoSize = true;
            this.chk_MoverCursor.Checked = true;
            this.chk_MoverCursor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_MoverCursor.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_MoverCursor.Location = new System.Drawing.Point(9, 57);
            this.chk_MoverCursor.Name = "chk_MoverCursor";
            this.chk_MoverCursor.Size = new System.Drawing.Size(210, 22);
            this.chk_MoverCursor.TabIndex = 4;
            this.chk_MoverCursor.Text = "Mover cursor aleatoriamente";
            this.chk_MoverCursor.UseVisualStyleBackColor = true;
            // 
            // chk_CentrarCursor
            // 
            this.chk_CentrarCursor.AutoSize = true;
            this.chk_CentrarCursor.Checked = true;
            this.chk_CentrarCursor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_CentrarCursor.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_CentrarCursor.Location = new System.Drawing.Point(9, 83);
            this.chk_CentrarCursor.Name = "chk_CentrarCursor";
            this.chk_CentrarCursor.Size = new System.Drawing.Size(229, 22);
            this.chk_CentrarCursor.TabIndex = 5;
            this.chk_CentrarCursor.Text = "Centrar cursor automaticamente";
            this.chk_CentrarCursor.UseVisualStyleBackColor = true;
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 146);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Retraso);
            this.Controls.Add(this.num_Retraso);
            this.Controls.Add(this.btn_Principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoClicker";
            this.Text = "AutoClicker";
            ((System.ComponentModel.ISupportInitialize)(this.num_Retraso)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Principal;
        private System.Windows.Forms.NumericUpDown num_Retraso;
        private System.Windows.Forms.Label lbl_Retraso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_MinimizarVentana;
        private System.Windows.Forms.CheckBox chk_MoverCursor;
        private System.Windows.Forms.CheckBox chk_CentrarCursor;
    }
}

