namespace Beatrix_Formulario
{
    partial class Inicio
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
            btnReunion = new Button();
            btnTareas = new Button();
            btnProyectos = new Button();
            btnInicio = new Button();
            fotoUsuario = new PictureBox();
            panel1 = new Panel();
            monthCalendar1 = new MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)fotoUsuario).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnReunion
            // 
            btnReunion.Location = new Point(40, 424);
            btnReunion.Name = "btnReunion";
            btnReunion.Size = new Size(155, 45);
            btnReunion.TabIndex = 4;
            btnReunion.Text = "Reuniones";
            btnReunion.UseVisualStyleBackColor = true;
            // 
            // btnTareas
            // 
            btnTareas.Location = new Point(40, 359);
            btnTareas.Name = "btnTareas";
            btnTareas.Size = new Size(155, 45);
            btnTareas.TabIndex = 3;
            btnTareas.Text = "Tareas";
            btnTareas.UseVisualStyleBackColor = true;
            // 
            // btnProyectos
            // 
            btnProyectos.Location = new Point(40, 298);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.Size = new Size(155, 45);
            btnProyectos.TabIndex = 2;
            btnProyectos.Text = "Proyectos";
            btnProyectos.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(40, 247);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(155, 45);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // fotoUsuario
            // 
            fotoUsuario.Location = new Point(53, 54);
            fotoUsuario.Name = "fotoUsuario";
            fotoUsuario.Size = new Size(125, 125);
            fotoUsuario.TabIndex = 1;
            fotoUsuario.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 191, 205);
            panel1.Controls.Add(fotoUsuario);
            panel1.Controls.Add(btnReunion);
            panel1.Controls.Add(btnTareas);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(btnProyectos);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 531);
            panel1.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(313, 298);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 531);
            Controls.Add(monthCalendar1);
            Controls.Add(panel1);
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)fotoUsuario).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnInicio;
        private PictureBox fotoUsuario;
        private Button btnReunion;
        private Button btnTareas;
        private Button btnProyectos;
        private Panel panel1;
        private MonthCalendar monthCalendar1;
    }
}