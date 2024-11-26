namespace presentacion
{
    partial class VentanaMain
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
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.heading1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.txtValorBusqueda = new System.Windows.Forms.TextBox();
            this.listaCriterio = new System.Windows.Forms.ComboBox();
            this.listaCampo = new System.Windows.Forms.ComboBox();
            this.imgInicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalogo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvCatalogo.Location = new System.Drawing.Point(37, 91);
            this.dgvCatalogo.MultiSelect = false;
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.ReadOnly = true;
            this.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogo.Size = new System.Drawing.Size(681, 267);
            this.dgvCatalogo.TabIndex = 0;
            this.dgvCatalogo.SelectionChanged += new System.EventHandler(this.dgvCatalogo_SelectionChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(36, 59);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(359, 26);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Text = "Buscar artículo";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // heading1
            // 
            this.heading1.AutoSize = true;
            this.heading1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading1.Location = new System.Drawing.Point(31, 21);
            this.heading1.Name = "heading1";
            this.heading1.Size = new System.Drawing.Size(195, 26);
            this.heading1.TabIndex = 0;
            this.heading1.Text = "Catálogo de compra";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(401, 59);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(133, 26);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar registros";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(540, 59);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 26);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar artículo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(669, 59);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 26);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar artículo";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(798, 59);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 26);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar artículo";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVerDetalles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalles.ForeColor = System.Drawing.Color.White;
            this.btnVerDetalles.Location = new System.Drawing.Point(36, 363);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(165, 26);
            this.btnVerDetalles.TabIndex = 6;
            this.btnVerDetalles.Text = "Ver detalles del artículo";
            this.btnVerDetalles.UseVisualStyleBackColor = false;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBusquedaAvanzada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusquedaAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaAvanzada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaAvanzada.ForeColor = System.Drawing.Color.White;
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(775, 363);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(144, 26);
            this.btnBusquedaAvanzada.TabIndex = 7;
            this.btnBusquedaAvanzada.Text = "Busqueda avanzada";
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = false;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.btnBusquedaAvanzada_Click);
            // 
            // txtValorBusqueda
            // 
            this.txtValorBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorBusqueda.BackColor = System.Drawing.Color.White;
            this.txtValorBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorBusqueda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorBusqueda.ForeColor = System.Drawing.Color.Black;
            this.txtValorBusqueda.Location = new System.Drawing.Point(567, 365);
            this.txtValorBusqueda.Multiline = true;
            this.txtValorBusqueda.Name = "txtValorBusqueda";
            this.txtValorBusqueda.Size = new System.Drawing.Size(199, 24);
            this.txtValorBusqueda.TabIndex = 10;
            this.txtValorBusqueda.TextChanged += new System.EventHandler(this.txtValorBusqueda_TextChanged);
            // 
            // listaCriterio
            // 
            this.listaCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaCriterio.FormattingEnabled = true;
            this.listaCriterio.Location = new System.Drawing.Point(429, 365);
            this.listaCriterio.MaxDropDownItems = 10;
            this.listaCriterio.Name = "listaCriterio";
            this.listaCriterio.Size = new System.Drawing.Size(132, 24);
            this.listaCriterio.TabIndex = 11;
            // 
            // listaCampo
            // 
            this.listaCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaCampo.FormattingEnabled = true;
            this.listaCampo.Location = new System.Drawing.Point(263, 365);
            this.listaCampo.MaxDropDownItems = 10;
            this.listaCampo.Name = "listaCampo";
            this.listaCampo.Size = new System.Drawing.Size(160, 24);
            this.listaCampo.TabIndex = 12;
            this.listaCampo.SelectedIndexChanged += new System.EventHandler(this.listaCampo_SelectedIndexChanged);
            // 
            // imgInicio
            // 
            this.imgInicio.BackColor = System.Drawing.Color.White;
            this.imgInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgInicio.Location = new System.Drawing.Point(724, 91);
            this.imgInicio.Name = "imgInicio";
            this.imgInicio.Size = new System.Drawing.Size(195, 266);
            this.imgInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInicio.TabIndex = 13;
            this.imgInicio.TabStop = false;
            // 
            // VentanaMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 414);
            this.Controls.Add(this.imgInicio);
            this.Controls.Add(this.listaCampo);
            this.Controls.Add(this.listaCriterio);
            this.Controls.Add(this.txtValorBusqueda);
            this.Controls.Add(this.btnBusquedaAvanzada);
            this.Controls.Add(this.btnVerDetalles);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.heading1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvCatalogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VentanaMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo";
            this.Load += new System.EventHandler(this.VentanaMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label heading1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.TextBox txtValorBusqueda;
        private System.Windows.Forms.ComboBox listaCriterio;
        private System.Windows.Forms.ComboBox listaCampo;
        private System.Windows.Forms.PictureBox imgInicio;
    }
}

