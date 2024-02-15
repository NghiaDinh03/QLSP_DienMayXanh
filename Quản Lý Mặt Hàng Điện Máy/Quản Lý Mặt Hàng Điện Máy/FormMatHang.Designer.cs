namespace Quản_Lý_Mặt_Hàng_Điện_Máy
{
    partial class FormMatHang
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
            this.comboBoxHangSX = new System.Windows.Forms.ComboBox();
            this.comboBoxLoai = new System.Windows.Forms.ComboBox();
            this.listView = new System.Windows.Forms.ListView();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeaderSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTenHangHoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quanLyMatHangDienMayDataSet = new Quản_Lý_Mặt_Hàng_Điện_Máy.QuanLyMatHangDienMayDataSet();
            this.hangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangTableAdapter = new Quản_Lý_Mặt_Hàng_Điện_Máy.QuanLyMatHangDienMayDataSetTableAdapters.HangTableAdapter();
            this.contextMenuStripXoa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaMặtHàngĐãChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyMatHangDienMayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangBindingSource)).BeginInit();
            this.contextMenuStripXoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxHangSX
            // 
            this.comboBoxHangSX.DataSource = this.hangBindingSource;
            this.comboBoxHangSX.DisplayMember = "TenHangSx";
            this.comboBoxHangSX.FormattingEnabled = true;
            this.comboBoxHangSX.Location = new System.Drawing.Point(137, 12);
            this.comboBoxHangSX.Name = "comboBoxHangSX";
            this.comboBoxHangSX.Size = new System.Drawing.Size(287, 29);
            this.comboBoxHangSX.TabIndex = 0;
            this.comboBoxHangSX.SelectedIndexChanged += new System.EventHandler(this.comboBoxHangSX_SelectedIndexChanged);
            // 
            // comboBoxLoai
            // 
            this.comboBoxLoai.FormattingEnabled = true;
            this.comboBoxLoai.Location = new System.Drawing.Point(137, 47);
            this.comboBoxLoai.Name = "comboBoxLoai";
            this.comboBoxLoai.Size = new System.Drawing.Size(287, 29);
            this.comboBoxLoai.TabIndex = 0;
            this.comboBoxLoai.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoai_SelectedIndexChanged);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSTT,
            this.columnHeaderTenHangHoa});
            this.listView.ContextMenuStrip = this.contextMenuStripXoa;
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(12, 103);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(412, 340);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.Click += new System.EventHandler(this.listView_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(278, 450);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(146, 29);
            this.buttonThoat.TabIndex = 2;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hãng sản xuất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Danh sách mặt hàng:";
            // 
            // columnHeaderSTT
            // 
            this.columnHeaderSTT.Text = "STT";
            // 
            // columnHeaderTenHangHoa
            // 
            this.columnHeaderTenHangHoa.Text = "Tên Hàng Hóa";
            this.columnHeaderTenHangHoa.Width = 348;
            // 
            // quanLyMatHangDienMayDataSet
            // 
            this.quanLyMatHangDienMayDataSet.DataSetName = "QuanLyMatHangDienMayDataSet";
            this.quanLyMatHangDienMayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangBindingSource
            // 
            this.hangBindingSource.DataMember = "Hang";
            this.hangBindingSource.DataSource = this.quanLyMatHangDienMayDataSet;
            // 
            // hangTableAdapter
            // 
            this.hangTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStripXoa
            // 
            this.contextMenuStripXoa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaMặtHàngĐãChọnToolStripMenuItem});
            this.contextMenuStripXoa.Name = "contextMenuStripXoa";
            this.contextMenuStripXoa.Size = new System.Drawing.Size(195, 48);
            // 
            // xóaMặtHàngĐãChọnToolStripMenuItem
            // 
            this.xóaMặtHàngĐãChọnToolStripMenuItem.Name = "xóaMặtHàngĐãChọnToolStripMenuItem";
            this.xóaMặtHàngĐãChọnToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.xóaMặtHàngĐãChọnToolStripMenuItem.Text = "Xóa mặt hàng đã chọn";
            this.xóaMặtHàngĐãChọnToolStripMenuItem.Click += new System.EventHandler(this.xóaMặtHàngĐãChọnToolStripMenuItem_Click);
            // 
            // FormMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 485);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.comboBoxLoai);
            this.Controls.Add(this.comboBoxHangSX);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormMatHang";
            this.Text = "FormMatHang";
            this.Load += new System.EventHandler(this.FormMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyMatHangDienMayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangBindingSource)).EndInit();
            this.contextMenuStripXoa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxHangSX;
        private System.Windows.Forms.ComboBox comboBoxLoai;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeaderSTT;
        private System.Windows.Forms.ColumnHeader columnHeaderTenHangHoa;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private QuanLyMatHangDienMayDataSet quanLyMatHangDienMayDataSet;
        private System.Windows.Forms.BindingSource hangBindingSource;
        private QuanLyMatHangDienMayDataSetTableAdapters.HangTableAdapter hangTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripXoa;
        private System.Windows.Forms.ToolStripMenuItem xóaMặtHàngĐãChọnToolStripMenuItem;
    }
}