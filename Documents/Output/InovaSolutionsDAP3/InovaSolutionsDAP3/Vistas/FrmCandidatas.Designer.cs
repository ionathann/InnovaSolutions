namespace InovaSolutionsDAP3
{
    partial class FrmCandidatas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCandidatas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fotografia = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCandidatas
            // 
            this.dgvCandidatas.AllowDrop = true;
            this.dgvCandidatas.AllowUserToAddRows = false;
            this.dgvCandidatas.AllowUserToDeleteRows = false;
            this.dgvCandidatas.AllowUserToOrderColumns = true;
            this.dgvCandidatas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCandidatas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCandidatas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvCandidatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCandidatas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Fecha_nacimiento,
            this.CURP,
            this.Fotografia});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandidatas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCandidatas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvCandidatas.EnableHeadersVisualStyles = false;
            this.dgvCandidatas.Location = new System.Drawing.Point(12, 38);
            this.dgvCandidatas.MultiSelect = false;
            this.dgvCandidatas.Name = "dgvCandidatas";
            this.dgvCandidatas.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCandidatas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCandidatas.RowHeadersVisible = false;
            this.dgvCandidatas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCandidatas.Size = new System.Drawing.Size(670, 289);
            this.dgvCandidatas.TabIndex = 112;
            this.dgvCandidatas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCandidatas_CellContentClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 89.66638F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 89.66638F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Fecha_nacimiento
            // 
            this.Fecha_nacimiento.FillWeight = 89.66638F;
            this.Fecha_nacimiento.HeaderText = "Fecha_nacimiento";
            this.Fecha_nacimiento.Name = "Fecha_nacimiento";
            this.Fecha_nacimiento.ReadOnly = true;
            // 
            // CURP
            // 
            this.CURP.FillWeight = 89.66638F;
            this.CURP.HeaderText = "CURP";
            this.CURP.Name = "CURP";
            this.CURP.ReadOnly = true;
            // 
            // Fotografia
            // 
            this.Fotografia.FillWeight = 30F;
            this.Fotografia.HeaderText = "Fotografia";
            this.Fotografia.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Fotografia.Name = "Fotografia";
            this.Fotografia.ReadOnly = true;
            this.Fotografia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fotografia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::InovaSolutionsDAP3.Properties.Resources.iconnew;
            this.pictureBox3.Location = new System.Drawing.Point(658, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 111;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "5";
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbuscar.AutoSize = true;
            this.btnbuscar.Location = new System.Drawing.Point(593, 9);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(59, 23);
            this.btnbuscar.TabIndex = 110;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscar.Location = new System.Drawing.Point(12, 12);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(575, 20);
            this.TxtBuscar.TabIndex = 109;
            this.TxtBuscar.Text = "Introducir NOMBRE...";
            this.TxtBuscar.Click += new System.EventHandler(this.TxtBuscar_Click);
            // 
            // FrmCandidatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 339);
            this.Controls.Add(this.dgvCandidatas);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Name = "FrmCandidatas";
            this.Text = "CANDIDATAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCandidatas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCandidatas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURP;
        private System.Windows.Forms.DataGridViewImageColumn Fotografia;
    }
}