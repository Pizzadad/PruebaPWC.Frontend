namespace PruebaPWC.Frontend.Vista
{
    partial class frmCUProducto
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
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinToolbars.UltraToolbar ultraToolbar1 = new Infragistics.Win.UltraWinToolbars.UltraToolbar("UltraToolbar1");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool1 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool2 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ultraNumericEditor1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ultraTextEditor2 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraTextEditor1 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ultraToolbarsManager1 = new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(this.components);
            this._frmCUProducto_Toolbars_Dock_Area_Left = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._frmCUProducto_Toolbars_Dock_Area_Right = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._frmCUProducto_Toolbars_Dock_Area_Top = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._frmCUProducto_Toolbars_Dock_Area_Bottom = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraToolbarsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ultraNumericEditor1);
            this.groupBox1.Controls.Add(this.ultraTextEditor2);
            this.groupBox1.Controls.Add(this.ultraTextEditor1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ultraNumericEditor1
            // 
            this.ultraNumericEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraNumericEditor1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "CantidadProducto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ultraNumericEditor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraNumericEditor1.Location = new System.Drawing.Point(12, 160);
            this.ultraNumericEditor1.MaxValue = 40;
            this.ultraNumericEditor1.MinValue = 0;
            this.ultraNumericEditor1.Name = "ultraNumericEditor1";
            this.ultraNumericEditor1.PromptChar = ' ';
            this.ultraNumericEditor1.Size = new System.Drawing.Size(235, 24);
            this.ultraNumericEditor1.TabIndex = 11;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(PruebaPWC.Api.API.ProductoDto);
            // 
            // ultraTextEditor2
            // 
            this.ultraTextEditor2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraTextEditor2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ultraTextEditor2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "TipoProducto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ultraTextEditor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraTextEditor2.Location = new System.Drawing.Point(12, 100);
            this.ultraTextEditor2.Name = "ultraTextEditor2";
            this.ultraTextEditor2.Size = new System.Drawing.Size(235, 24);
            this.ultraTextEditor2.TabIndex = 10;
            // 
            // ultraTextEditor1
            // 
            this.ultraTextEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraTextEditor1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ultraTextEditor1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "NombreProducto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ultraTextEditor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraTextEditor1.Location = new System.Drawing.Point(12, 39);
            this.ultraTextEditor1.Name = "ultraTextEditor1";
            this.ultraTextEditor1.Size = new System.Drawing.Size(235, 24);
            this.ultraTextEditor1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // ultraToolbarsManager1
            // 
            this.ultraToolbarsManager1.DesignerFlags = 1;
            this.ultraToolbarsManager1.DockWithinContainer = this;
            this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof(System.Windows.Forms.Form);
            ultraToolbar1.DockedColumn = 0;
            ultraToolbar1.DockedRow = 0;
            ultraToolbar1.NonInheritedTools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool1});
            ultraToolbar1.Text = "UltraToolbar1";
            this.ultraToolbarsManager1.Toolbars.AddRange(new Infragistics.Win.UltraWinToolbars.UltraToolbar[] {
            ultraToolbar1});
            buttonTool2.SharedPropsInternal.Caption = "Guardar";
            buttonTool2.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText;
            this.ultraToolbarsManager1.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool2});
            this.ultraToolbarsManager1.ToolClick += new Infragistics.Win.UltraWinToolbars.ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
            // 
            // _frmCUProducto_Toolbars_Dock_Area_Left
            // 
            this._frmCUProducto_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._frmCUProducto_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control;
            this._frmCUProducto_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            this._frmCUProducto_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this._frmCUProducto_Toolbars_Dock_Area_Left.Location = new System.Drawing.Point(0, 25);
            this._frmCUProducto_Toolbars_Dock_Area_Left.Name = "_frmCUProducto_Toolbars_Dock_Area_Left";
            this._frmCUProducto_Toolbars_Dock_Area_Left.Size = new System.Drawing.Size(0, 215);
            this._frmCUProducto_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _frmCUProducto_Toolbars_Dock_Area_Right
            // 
            this._frmCUProducto_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._frmCUProducto_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control;
            this._frmCUProducto_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            this._frmCUProducto_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
            this._frmCUProducto_Toolbars_Dock_Area_Right.Location = new System.Drawing.Point(259, 25);
            this._frmCUProducto_Toolbars_Dock_Area_Right.Name = "_frmCUProducto_Toolbars_Dock_Area_Right";
            this._frmCUProducto_Toolbars_Dock_Area_Right.Size = new System.Drawing.Size(0, 215);
            this._frmCUProducto_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _frmCUProducto_Toolbars_Dock_Area_Top
            // 
            this._frmCUProducto_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._frmCUProducto_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control;
            this._frmCUProducto_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            this._frmCUProducto_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            this._frmCUProducto_Toolbars_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
            this._frmCUProducto_Toolbars_Dock_Area_Top.Name = "_frmCUProducto_Toolbars_Dock_Area_Top";
            this._frmCUProducto_Toolbars_Dock_Area_Top.Size = new System.Drawing.Size(259, 25);
            this._frmCUProducto_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _frmCUProducto_Toolbars_Dock_Area_Bottom
            // 
            this._frmCUProducto_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._frmCUProducto_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control;
            this._frmCUProducto_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            this._frmCUProducto_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._frmCUProducto_Toolbars_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 240);
            this._frmCUProducto_Toolbars_Dock_Area_Bottom.Name = "_frmCUProducto_Toolbars_Dock_Area_Bottom";
            this._frmCUProducto_Toolbars_Dock_Area_Bottom.Size = new System.Drawing.Size(259, 0);
            this._frmCUProducto_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // frmCUProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 240);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._frmCUProducto_Toolbars_Dock_Area_Left);
            this.Controls.Add(this._frmCUProducto_Toolbars_Dock_Area_Right);
            this.Controls.Add(this._frmCUProducto_Toolbars_Dock_Area_Bottom);
            this.Controls.Add(this._frmCUProducto_Toolbars_Dock_Area_Top);
            this.Name = "frmCUProducto";
            this.Text = "Administrar Producto";
            this.Load += new System.EventHandler(this.frmCUProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraNumericEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraToolbarsManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor ultraNumericEditor1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsManager ultraToolbarsManager1;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _frmCUProducto_Toolbars_Dock_Area_Left;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _frmCUProducto_Toolbars_Dock_Area_Right;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _frmCUProducto_Toolbars_Dock_Area_Bottom;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _frmCUProducto_Toolbars_Dock_Area_Top;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}