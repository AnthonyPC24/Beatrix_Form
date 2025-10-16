namespace Beatrix_Formulario
{
    partial class FormTareasTho2
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
            panelBarraOpciones = new Panel();
            labelBeatrix = new Label();
            buttonReuniones = new Button();
            buttonTareas = new Button();
            buttonProyetos = new Button();
            buttonInicio = new Button();
            panelBarraOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // panelBarraOpciones
            // 
            panelBarraOpciones.BackColor = Color.FromArgb(41, 195, 205);
            panelBarraOpciones.Controls.Add(labelBeatrix);
            panelBarraOpciones.Controls.Add(buttonReuniones);
            panelBarraOpciones.Controls.Add(buttonTareas);
            panelBarraOpciones.Controls.Add(buttonProyetos);
            panelBarraOpciones.Controls.Add(buttonInicio);
            panelBarraOpciones.Location = new Point(0, 0);
            panelBarraOpciones.Name = "panelBarraOpciones";
            panelBarraOpciones.Size = new Size(165, 450);
            panelBarraOpciones.TabIndex = 3;
            // 
            // labelBeatrix
            // 
            labelBeatrix.AutoSize = true;
            labelBeatrix.Font = new Font("Montserrat Black", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBeatrix.ForeColor = Color.Transparent;
            labelBeatrix.Location = new Point(12, 18);
            labelBeatrix.Name = "labelBeatrix";
            labelBeatrix.Size = new Size(112, 38);
            labelBeatrix.TabIndex = 4;
            labelBeatrix.Text = "Beatrix";
            // 
            // buttonReuniones
            // 
            buttonReuniones.BackColor = Color.FromArgb(41, 195, 205);
            buttonReuniones.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReuniones.Location = new Point(22, 327);
            buttonReuniones.Name = "buttonReuniones";
            buttonReuniones.Size = new Size(115, 23);
            buttonReuniones.TabIndex = 3;
            buttonReuniones.Text = "Reuniones";
            buttonReuniones.UseVisualStyleBackColor = false;
            // 
            // buttonTareas
            // 
            buttonTareas.BackColor = Color.FromArgb(41, 195, 205);
            buttonTareas.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTareas.Location = new Point(22, 298);
            buttonTareas.Name = "buttonTareas";
            buttonTareas.Size = new Size(115, 23);
            buttonTareas.TabIndex = 2;
            buttonTareas.Text = "Tareas";
            buttonTareas.UseVisualStyleBackColor = false;
            // 
            // buttonProyetos
            // 
            buttonProyetos.BackColor = Color.FromArgb(41, 195, 205);
            buttonProyetos.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProyetos.Location = new Point(22, 269);
            buttonProyetos.Name = "buttonProyetos";
            buttonProyetos.Size = new Size(115, 23);
            buttonProyetos.TabIndex = 1;
            buttonProyetos.Text = "Proyectos";
            buttonProyetos.UseVisualStyleBackColor = false;
            // 
            // buttonInicio
            // 
            buttonInicio.BackColor = Color.FromArgb(41, 195, 205);
            buttonInicio.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInicio.ForeColor = Color.Black;
            buttonInicio.Location = new Point(22, 240);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(115, 23);
            buttonInicio.TabIndex = 0;
            buttonInicio.Text = "Inicio";
            buttonInicio.UseVisualStyleBackColor = false;
            // 
            // FormTareasTho2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelBarraOpciones);
            Name = "FormTareasTho2";
            Text = "FormTareasTho2";
            panelBarraOpciones.ResumeLayout(false);
            panelBarraOpciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBarraOpciones;
        private Label labelBeatrix;
        private Button buttonReuniones;
        private Button buttonTareas;
        private Button buttonProyetos;
        private Button buttonInicio;
    }
}