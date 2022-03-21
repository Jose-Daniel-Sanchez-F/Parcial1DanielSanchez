namespace Parcial1DanielSanchez
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxEquipo = new System.Windows.Forms.TextBox();
            this.comboBoxJugadores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxGoles = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEquipo
            // 
            this.textBoxEquipo.Location = new System.Drawing.Point(662, 343);
            this.textBoxEquipo.Name = "textBoxEquipo";
            this.textBoxEquipo.Size = new System.Drawing.Size(213, 23);
            this.textBoxEquipo.TabIndex = 0;
            // 
            // comboBoxJugadores
            // 
            this.comboBoxJugadores.FormattingEnabled = true;
            this.comboBoxJugadores.Location = new System.Drawing.Point(662, 257);
            this.comboBoxJugadores.Name = "comboBoxJugadores";
            this.comboBoxJugadores.Size = new System.Drawing.Size(213, 23);
            this.comboBoxJugadores.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(518, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. del jugador: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(662, 298);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBoxGoles
            // 
            this.textBoxGoles.Location = new System.Drawing.Point(662, 385);
            this.textBoxGoles.Name = "textBoxGoles";
            this.textBoxGoles.Size = new System.Drawing.Size(213, 23);
            this.textBoxGoles.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(518, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha del juego:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(459, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Equipo al que anoto gol:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(468, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "No. de goles anotados:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial1DanielSanchez.Properties.Resources.partidos;
            this.ClientSize = new System.Drawing.Size(1031, 530);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxGoles);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxJugadores);
            this.Controls.Add(this.textBoxEquipo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxEquipo;
        private ComboBox comboBoxJugadores;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxGoles;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}