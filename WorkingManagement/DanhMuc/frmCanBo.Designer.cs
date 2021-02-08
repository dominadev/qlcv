
namespace WorkingManagement.DanhMuc
{
    partial class frmCanBo
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QueQuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CapBac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChucVuDang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChucVuChinhQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayVaoDang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayVaoDangChinhThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayVaoDoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayVaoNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrinhDoChuyenMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CacLoaiBangCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Anh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.AutoSize = true;
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Location = new System.Drawing.Point(0, 61);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelControl1.Size = new System.Drawing.Size(801, 385);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.Size = new System.Drawing.Size(797, 381);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Ma,
            this.Ten,
            this.NgaySinh,
            this.QueQuan,
            this.HoKhau,
            this.CapBac,
            this.ChucVuDang,
            this.ChucVuChinhQuyen,
            this.NgayVaoDang,
            this.NgayVaoDangChinhThuc,
            this.NgayVaoDoan,
            this.NgayVaoNganh,
            this.TrinhDoChuyenMon,
            this.CacLoaiBangCap,
            this.Anh});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // Ma
            // 
            this.Ma.Caption = "Mã";
            this.Ma.FieldName = "Ma";
            this.Ma.Name = "Ma";
            this.Ma.Visible = true;
            this.Ma.VisibleIndex = 1;
            // 
            // Ten
            // 
            this.Ten.Caption = "Họ tên";
            this.Ten.FieldName = "HoTen";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 2;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "Ngày sinh";
            this.NgaySinh.FieldName = "NgaySinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 3;
            // 
            // QueQuan
            // 
            this.QueQuan.Caption = "Quê quán";
            this.QueQuan.FieldName = "QueQuan";
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.Visible = true;
            this.QueQuan.VisibleIndex = 4;
            // 
            // HoKhau
            // 
            this.HoKhau.Caption = "Hộ khẩu";
            this.HoKhau.FieldName = "HoKhau";
            this.HoKhau.Name = "HoKhau";
            this.HoKhau.Visible = true;
            this.HoKhau.VisibleIndex = 5;
            // 
            // CapBac
            // 
            this.CapBac.Caption = "Cấp bậc";
            this.CapBac.FieldName = "CapBac";
            this.CapBac.Name = "CapBac";
            this.CapBac.Visible = true;
            this.CapBac.VisibleIndex = 6;
            // 
            // ChucVuDang
            // 
            this.ChucVuDang.Caption = "Chức vụ đảng";
            this.ChucVuDang.FieldName = "ChucVuDang";
            this.ChucVuDang.Name = "ChucVuDang";
            this.ChucVuDang.Visible = true;
            this.ChucVuDang.VisibleIndex = 7;
            // 
            // ChucVuChinhQuyen
            // 
            this.ChucVuChinhQuyen.Caption = "Chức vụ chính quyền";
            this.ChucVuChinhQuyen.FieldName = "ChucVuChinhQuyen";
            this.ChucVuChinhQuyen.Name = "ChucVuChinhQuyen";
            this.ChucVuChinhQuyen.Visible = true;
            this.ChucVuChinhQuyen.VisibleIndex = 8;
            // 
            // NgayVaoDang
            // 
            this.NgayVaoDang.Caption = "Ngày vào đảng";
            this.NgayVaoDang.FieldName = "NgayVaoDang";
            this.NgayVaoDang.Name = "NgayVaoDang";
            this.NgayVaoDang.Visible = true;
            this.NgayVaoDang.VisibleIndex = 9;
            // 
            // NgayVaoDangChinhThuc
            // 
            this.NgayVaoDangChinhThuc.Caption = "Ngày vào đảng chính thức";
            this.NgayVaoDangChinhThuc.FieldName = "NgayVaoDangChinhThuc";
            this.NgayVaoDangChinhThuc.Name = "NgayVaoDangChinhThuc";
            this.NgayVaoDangChinhThuc.Visible = true;
            this.NgayVaoDangChinhThuc.VisibleIndex = 10;
            // 
            // NgayVaoDoan
            // 
            this.NgayVaoDoan.Caption = "Ngày vào đoàn";
            this.NgayVaoDoan.FieldName = "NgayVaoDoan";
            this.NgayVaoDoan.Name = "NgayVaoDoan";
            this.NgayVaoDoan.Visible = true;
            this.NgayVaoDoan.VisibleIndex = 11;
            // 
            // NgayVaoNganh
            // 
            this.NgayVaoNganh.Caption = "Ngày vào ngành";
            this.NgayVaoNganh.FieldName = "NgayVaoNganh";
            this.NgayVaoNganh.Name = "NgayVaoNganh";
            this.NgayVaoNganh.Visible = true;
            this.NgayVaoNganh.VisibleIndex = 12;
            // 
            // TrinhDoChuyenMon
            // 
            this.TrinhDoChuyenMon.Caption = "Trình độ chuyên môn";
            this.TrinhDoChuyenMon.FieldName = "TrinhDoChuyenMon";
            this.TrinhDoChuyenMon.Name = "TrinhDoChuyenMon";
            this.TrinhDoChuyenMon.Visible = true;
            this.TrinhDoChuyenMon.VisibleIndex = 13;
            // 
            // CacLoaiBangCap
            // 
            this.CacLoaiBangCap.Caption = "Các loại bằng cấp";
            this.CacLoaiBangCap.FieldName = "CacLoaiBangCap";
            this.CacLoaiBangCap.Name = "CacLoaiBangCap";
            this.CacLoaiBangCap.Visible = true;
            this.CacLoaiBangCap.VisibleIndex = 14;
            // 
            // Anh
            // 
            this.Anh.Caption = "Ảnh";
            this.Anh.FieldName = "Anh";
            this.Anh.Name = "Anh";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(557, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(638, 35);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(719, 35);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl3.Controls.Add(this.btnDelete);
            this.panelControl3.Controls.Add(this.btnEdit);
            this.panelControl3.Controls.Add(this.btnAdd);
            this.panelControl3.Location = new System.Drawing.Point(2, 1);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(799, 63);
            this.panelControl3.TabIndex = 2;
            // 
            // frmCanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 449);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmCanBo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmCanBo";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn Ma;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn QueQuan;
        private DevExpress.XtraGrid.Columns.GridColumn HoKhau;
        private DevExpress.XtraGrid.Columns.GridColumn CapBac;
        private DevExpress.XtraGrid.Columns.GridColumn ChucVuDang;
        private DevExpress.XtraGrid.Columns.GridColumn ChucVuChinhQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn NgayVaoDang;
        private DevExpress.XtraGrid.Columns.GridColumn NgayVaoDangChinhThuc;
        private DevExpress.XtraGrid.Columns.GridColumn NgayVaoDoan;
        private DevExpress.XtraGrid.Columns.GridColumn NgayVaoNganh;
        private DevExpress.XtraGrid.Columns.GridColumn TrinhDoChuyenMon;
        private DevExpress.XtraGrid.Columns.GridColumn CacLoaiBangCap;
        private DevExpress.XtraGrid.Columns.GridColumn Anh;
    }
}