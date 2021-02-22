namespace PruebaPWC.Frontend.UserControls
{
    partial class ucRegister
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ultraTextEditor1 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ultraTextEditor2 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextEditor3 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextEditor4 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton2 = new Infragistics.Win.Misc.UltraButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cboRol = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRol)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password (8 letras)";
            // 
            // ultraTextEditor1
            // 
            this.ultraTextEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraTextEditor1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "NombreCompleto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ultraTextEditor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraTextEditor1.Location = new System.Drawing.Point(21, 77);
            this.ultraTextEditor1.Name = "ultraTextEditor1";
            this.ultraTextEditor1.NullText = "Christian Romleo";
            appearance1.FontData.ItalicAsString = "True";
            appearance1.ForeColor = System.Drawing.Color.Silver;
            this.ultraTextEditor1.NullTextAppearance = appearance1;
            this.ultraTextEditor1.Size = new System.Drawing.Size(303, 31);
            this.ultraTextEditor1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(PruebaPWC.Api.API.RequestRegisterUser);
            // 
            // ultraTextEditor2
            // 
            this.ultraTextEditor2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraTextEditor2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Email", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ultraTextEditor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraTextEditor2.Location = new System.Drawing.Point(21, 253);
            this.ultraTextEditor2.Name = "ultraTextEditor2";
            this.ultraTextEditor2.NullText = "email@email.com";
            appearance2.BackColor = System.Drawing.Color.White;
            appearance2.FontData.ItalicAsString = "True";
            appearance2.ForeColor = System.Drawing.Color.Silver;
            this.ultraTextEditor2.NullTextAppearance = appearance2;
            this.ultraTextEditor2.Size = new System.Drawing.Size(303, 31);
            this.ultraTextEditor2.TabIndex = 3;
            // 
            // ultraTextEditor3
            // 
            this.ultraTextEditor3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraTextEditor3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ultraTextEditor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraTextEditor3.Location = new System.Drawing.Point(21, 138);
            this.ultraTextEditor3.Name = "ultraTextEditor3";
            this.ultraTextEditor3.NullText = "CRomero";
            appearance3.FontData.ItalicAsString = "True";
            appearance3.ForeColor = System.Drawing.Color.Silver;
            this.ultraTextEditor3.NullTextAppearance = appearance3;
            this.ultraTextEditor3.Size = new System.Drawing.Size(303, 31);
            this.ultraTextEditor3.TabIndex = 1;
            // 
            // ultraTextEditor4
            // 
            this.ultraTextEditor4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraTextEditor4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ultraTextEditor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraTextEditor4.Location = new System.Drawing.Point(21, 311);
            this.ultraTextEditor4.Name = "ultraTextEditor4";
            this.ultraTextEditor4.NullText = "No \"ñ\" - 1 letra mayus - 1 Número - 1 carácter especial";
            appearance4.FontData.ItalicAsString = "True";
            appearance4.ForeColor = System.Drawing.Color.Silver;
            this.ultraTextEditor4.NullTextAppearance = appearance4;
            this.ultraTextEditor4.PasswordChar = '●';
            this.ultraTextEditor4.Size = new System.Drawing.Size(303, 21);
            this.ultraTextEditor4.TabIndex = 4;
            // 
            // ultraButton1
            // 
            this.ultraButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            appearance7.Image = global::PruebaPWC.Frontend.Properties.Resources.User_Add_WF;
            appearance7.ImageHAlign = Infragistics.Win.HAlign.Right;
            this.ultraButton1.Appearance = appearance7;
            this.ultraButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraButton1.Location = new System.Drawing.Point(21, 350);
            this.ultraButton1.Name = "ultraButton1";
            this.ultraButton1.Size = new System.Drawing.Size(303, 37);
            this.ultraButton1.TabIndex = 5;
            this.ultraButton1.Text = "Registrarse";
            this.ultraButton1.Click += new System.EventHandler(this.ultraButton1_Click);
            // 
            // ultraButton2
            // 
            appearance8.Image = global::PruebaPWC.Frontend.Properties.Resources.back;
            appearance8.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance8.ImageVAlign = Infragistics.Win.VAlign.Middle;
            this.ultraButton2.Appearance = appearance8;
            this.ultraButton2.Location = new System.Drawing.Point(21, 16);
            this.ultraButton2.Name = "ultraButton2";
            this.ultraButton2.Size = new System.Drawing.Size(26, 28);
            this.ultraButton2.TabIndex = 6;
            this.ultraButton2.Click += new System.EventHandler(this.ultraButton2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rol";
            // 
            // cboRol
            // 
            this.cboRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "RoleUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cboRol.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cboRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRol.Location = new System.Drawing.Point(21, 198);
            this.cboRol.Name = "cboRol";
            this.cboRol.NullText = "[-Seleccionar-]";
            this.cboRol.Size = new System.Drawing.Size(303, 31);
            this.cboRol.TabIndex = 2;
            // 
            // ucRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ultraButton2);
            this.Controls.Add(this.ultraButton1);
            this.Controls.Add(this.ultraTextEditor4);
            this.Controls.Add(this.ultraTextEditor3);
            this.Controls.Add(this.ultraTextEditor2);
            this.Controls.Add(this.ultraTextEditor1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucRegister";
            this.Size = new System.Drawing.Size(356, 409);
            this.Load += new System.EventHandler(this.ucRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor3;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor4;
        private Infragistics.Win.Misc.UltraButton ultraButton1;
        private Infragistics.Win.Misc.UltraButton ultraButton2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label5;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cboRol;
    }
}
