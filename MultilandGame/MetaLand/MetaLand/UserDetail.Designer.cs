namespace MetaLand
{
    partial class UserDetail
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
            this.metaLandDataSet3 = new MetaLand.MetaLandDataSet3();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.arsalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arsalarTableAdapter = new MetaLand.MetaLandDataSet3TableAdapters.ArsalarTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.useridToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.useridToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.metaLandDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsalarBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // metaLandDataSet3
            // 
            this.metaLandDataSet3.DataSetName = "MetaLandDataSet3";
            this.metaLandDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 212);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(466, 252);
            this.dataGridView2.TabIndex = 0;
            // 
            // arsalarBindingSource
            // 
            this.arsalarBindingSource.DataMember = "Arsalar";
            this.arsalarBindingSource.DataSource = this.metaLandDataSet3;
            // 
            // arsalarTableAdapter
            // 
            this.arsalarTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useridToolStripLabel,
            this.useridToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(491, 27);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // useridToolStripLabel
            // 
            this.useridToolStripLabel.Name = "useridToolStripLabel";
            this.useridToolStripLabel.Size = new System.Drawing.Size(52, 24);
            this.useridToolStripLabel.Text = "userid:";
            // 
            // useridToolStripTextBox
            // 
            this.useridToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.useridToolStripTextBox.Name = "useridToolStripTextBox";
            this.useridToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(13, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(466, 168);
            this.dataGridView3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserDetail
            // 
            this.ClientSize = new System.Drawing.Size(491, 540);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView2);
            this.Name = "UserDetail";
            this.Load += new System.EventHandler(this.UserDetail_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.metaLandDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsalarBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource metaLandDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNickNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountFoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn userTypeDataGridViewCheckBoxColumn;
        private MetaLandDataSet3 metaLandDataSet3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource arsalarBindingSource;
        private MetaLandDataSet3TableAdapters.ArsalarTableAdapter arsalarTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel useridToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox useridToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button2;
    }
}