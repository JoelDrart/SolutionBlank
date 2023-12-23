namespace Presentacion
{
    partial class Frm_Buscar
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
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.TXT_Codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_Codigo = new System.Windows.Forms.Label();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBL_Nivel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.BackColor = System.Drawing.Color.DarkKhaki;
            this.BTN_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_Cancelar.Location = new System.Drawing.Point(133, 127);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(95, 35);
            this.BTN_Cancelar.TabIndex = 17;
            this.BTN_Cancelar.Text = "Buscar";
            this.BTN_Cancelar.UseVisualStyleBackColor = false;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // TXT_Codigo
            // 
            this.TXT_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Codigo.Location = new System.Drawing.Point(151, 86);
            this.TXT_Codigo.Name = "TXT_Codigo";
            this.TXT_Codigo.Size = new System.Drawing.Size(100, 26);
            this.TXT_Codigo.TabIndex = 16;
            this.TXT_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_Codigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "BUSCAR";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBL_Nivel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.LBL_Nombre);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LBL_Codigo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(86, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 166);
            this.panel1.TabIndex = 18;
            this.panel1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Código:";
            // 
            // LBL_Codigo
            // 
            this.LBL_Codigo.AutoSize = true;
            this.LBL_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Codigo.Location = new System.Drawing.Point(79, 19);
            this.LBL_Codigo.Name = "LBL_Codigo";
            this.LBL_Codigo.Size = new System.Drawing.Size(59, 20);
            this.LBL_Codigo.TabIndex = 20;
            this.LBL_Codigo.Text = "Codigo";
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Nombre.Location = new System.Drawing.Point(79, 53);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(59, 20);
            this.LBL_Nombre.TabIndex = 22;
            this.LBL_Nombre.Text = "Codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nombre:";
            // 
            // LBL_Nivel
            // 
            this.LBL_Nivel.AutoSize = true;
            this.LBL_Nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Nivel.Location = new System.Drawing.Point(79, 87);
            this.LBL_Nivel.Name = "LBL_Nivel";
            this.LBL_Nivel.Size = new System.Drawing.Size(59, 20);
            this.LBL_Nivel.TabIndex = 24;
            this.LBL_Nivel.Text = "Codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nivel:";
            // 
            // Frm_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 334);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_Cancelar);
            this.Controls.Add(this.TXT_Codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Buscar";
            this.Text = "Frm_Buscar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.TextBox TXT_Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_Nivel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBL_Codigo;
        private System.Windows.Forms.Label label3;
    }
}