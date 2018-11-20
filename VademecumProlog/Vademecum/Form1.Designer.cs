namespace Vademecum
{
    partial class Form1
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
            this.ListBox_Medicamentos = new System.Windows.Forms.ListBox();
            this.receta = new MaterialSkin.Controls.MaterialRadioButton();
            this.especialista = new MaterialSkin.Controls.MaterialRadioButton();
            this.diagnosticar = new MaterialSkin.Controls.MaterialRadioButton();
            this.enterButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.sintoma = new System.Windows.Forms.ComboBox();
            this.paisesComboBox = new System.Windows.Forms.ComboBox();
            this.sintoma2 = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.sintoma3 = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.Initial = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // ListBox_Medicamentos
            // 
            this.ListBox_Medicamentos.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Medicamentos.FormattingEnabled = true;
            this.ListBox_Medicamentos.ItemHeight = 22;
            this.ListBox_Medicamentos.Location = new System.Drawing.Point(35, 145);
            this.ListBox_Medicamentos.Name = "ListBox_Medicamentos";
            this.ListBox_Medicamentos.Size = new System.Drawing.Size(436, 356);
            this.ListBox_Medicamentos.TabIndex = 4;
            // 
            // receta
            // 
            this.receta.AutoSize = true;
            this.receta.Depth = 0;
            this.receta.Font = new System.Drawing.Font("Roboto", 10F);
            this.receta.Location = new System.Drawing.Point(536, 106);
            this.receta.Margin = new System.Windows.Forms.Padding(0);
            this.receta.MouseLocation = new System.Drawing.Point(-1, -1);
            this.receta.MouseState = MaterialSkin.MouseState.HOVER;
            this.receta.Name = "receta";
            this.receta.Ripple = true;
            this.receta.Size = new System.Drawing.Size(83, 30);
            this.receta.TabIndex = 7;
            this.receta.TabStop = true;
            this.receta.Text = "Receta";
            this.receta.UseVisualStyleBackColor = true;
            this.receta.CheckedChanged += new System.EventHandler(this.receta_CheckedChanged);
            // 
            // especialista
            // 
            this.especialista.AutoSize = true;
            this.especialista.Depth = 0;
            this.especialista.Font = new System.Drawing.Font("Roboto", 10F);
            this.especialista.Location = new System.Drawing.Point(536, 164);
            this.especialista.Margin = new System.Windows.Forms.Padding(0);
            this.especialista.MouseLocation = new System.Drawing.Point(-1, -1);
            this.especialista.MouseState = MaterialSkin.MouseState.HOVER;
            this.especialista.Name = "especialista";
            this.especialista.Ripple = true;
            this.especialista.Size = new System.Drawing.Size(123, 30);
            this.especialista.TabIndex = 8;
            this.especialista.TabStop = true;
            this.especialista.Text = "Especialista";
            this.especialista.UseVisualStyleBackColor = true;
            this.especialista.CheckedChanged += new System.EventHandler(this.especialista_CheckedChanged);
            // 
            // diagnosticar
            // 
            this.diagnosticar.AutoSize = true;
            this.diagnosticar.Depth = 0;
            this.diagnosticar.Font = new System.Drawing.Font("Roboto", 10F);
            this.diagnosticar.Location = new System.Drawing.Point(536, 222);
            this.diagnosticar.Margin = new System.Windows.Forms.Padding(0);
            this.diagnosticar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.diagnosticar.MouseState = MaterialSkin.MouseState.HOVER;
            this.diagnosticar.Name = "diagnosticar";
            this.diagnosticar.Ripple = true;
            this.diagnosticar.Size = new System.Drawing.Size(127, 30);
            this.diagnosticar.TabIndex = 9;
            this.diagnosticar.TabStop = true;
            this.diagnosticar.Text = "Diagnosticar";
            this.diagnosticar.UseVisualStyleBackColor = true;
            this.diagnosticar.CheckedChanged += new System.EventHandler(this.diagnosticar_CheckedChanged);
            // 
            // enterButton
            // 
            this.enterButton.AutoSize = true;
            this.enterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enterButton.Depth = 0;
            this.enterButton.Icon = null;
            this.enterButton.Location = new System.Drawing.Point(580, 425);
            this.enterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.enterButton.Name = "enterButton";
            this.enterButton.Primary = true;
            this.enterButton.Size = new System.Drawing.Size(88, 36);
            this.enterButton.TabIndex = 11;
            this.enterButton.Text = "Buscar";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(543, 281);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 24);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Síntoma";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(543, 344);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(67, 24);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Países";
            // 
            // sintoma
            // 
            this.sintoma.FormattingEnabled = true;
            this.sintoma.Location = new System.Drawing.Point(646, 280);
            this.sintoma.Name = "sintoma";
            this.sintoma.Size = new System.Drawing.Size(200, 24);
            this.sintoma.TabIndex = 15;
            // 
            // paisesComboBox
            // 
            this.paisesComboBox.FormattingEnabled = true;
            this.paisesComboBox.Location = new System.Drawing.Point(646, 346);
            this.paisesComboBox.Name = "paisesComboBox";
            this.paisesComboBox.Size = new System.Drawing.Size(200, 24);
            this.paisesComboBox.TabIndex = 16;
            // 
            // sintoma2
            // 
            this.sintoma2.FormattingEnabled = true;
            this.sintoma2.Location = new System.Drawing.Point(646, 322);
            this.sintoma2.Name = "sintoma2";
            this.sintoma2.Size = new System.Drawing.Size(200, 24);
            this.sintoma2.TabIndex = 18;
            this.sintoma2.Visible = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(543, 323);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(80, 24);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Síntoma";
            this.materialLabel3.Visible = false;
            // 
            // sintoma3
            // 
            this.sintoma3.FormattingEnabled = true;
            this.sintoma3.Location = new System.Drawing.Point(646, 362);
            this.sintoma3.Name = "sintoma3";
            this.sintoma3.Size = new System.Drawing.Size(200, 24);
            this.sintoma3.TabIndex = 20;
            this.sintoma3.Visible = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(543, 363);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(80, 24);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "Síntoma";
            this.materialLabel4.Visible = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel5.ForeColor = System.Drawing.Color.Red;
            this.materialLabel5.Location = new System.Drawing.Point(31, 504);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(73, 22);
            this.materialLabel5.TabIndex = 21;
            this.materialLabel5.Text = "Síntoma";
            this.materialLabel5.Visible = false;
            // 
            // Initial
            // 
            this.Initial.AutoSize = true;
            this.Initial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Initial.Depth = 0;
            this.Initial.Icon = null;
            this.Initial.Location = new System.Drawing.Point(559, 425);
            this.Initial.MouseState = MaterialSkin.MouseState.HOVER;
            this.Initial.Name = "Initial";
            this.Initial.Primary = true;
            this.Initial.Size = new System.Drawing.Size(228, 36);
            this.Initial.TabIndex = 22;
            this.Initial.Text = "Inicializar Vademecum";
            this.Initial.UseVisualStyleBackColor = true;
            this.Initial.Click += new System.EventHandler(this.Initial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 561);
            this.Controls.Add(this.Initial);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.sintoma3);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.sintoma2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.paisesComboBox);
            this.Controls.Add(this.sintoma);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.diagnosticar);
            this.Controls.Add(this.especialista);
            this.Controls.Add(this.receta);
            this.Controls.Add(this.ListBox_Medicamentos);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International Vademecum";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListBox_Medicamentos;
        private MaterialSkin.Controls.MaterialRadioButton receta;
        private MaterialSkin.Controls.MaterialRadioButton especialista;
        private MaterialSkin.Controls.MaterialRadioButton diagnosticar;
        private MaterialSkin.Controls.MaterialRaisedButton enterButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox sintoma;
        private System.Windows.Forms.ComboBox paisesComboBox;
        private System.Windows.Forms.ComboBox sintoma2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox sintoma3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRaisedButton Initial;
    }
}

