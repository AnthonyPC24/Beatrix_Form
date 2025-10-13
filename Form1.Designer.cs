namespace Beatrix_Formulario
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
            label1 = new Label();
            panel1 = new Panel();
            buttonInicioTareas = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 192, 205);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonInicioTareas);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 451);
            panel1.TabIndex = 2;
            // 
            // buttonInicioTareas
            // 
            buttonInicioTareas.Location = new Point(25, 196);
            buttonInicioTareas.Name = "buttonInicioTareas";
            buttonInicioTareas.Size = new Size(138, 31);
            buttonInicioTareas.TabIndex = 0;
            buttonInicioTareas.Text = "Inicio";
            buttonInicioTareas.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(25, 233);
            button1.Name = "button1";
            button1.Size = new Size(138, 31);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button buttonInicioTareas;
        private Button button1;
    }
}
