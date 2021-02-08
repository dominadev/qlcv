
namespace WorkingManagement
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnOpenCongVanDen = new DevExpress.XtraBars.BarButtonItem();
            this.btnOpenCongVanDi = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiVanBan = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiTinBao = new DevExpress.XtraBars.BarButtonItem();
            this.btnCoQuan = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLyCanBo = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pnlContainer = new DevExpress.XtraEditors.PanelControl();
            this.btnKhenThuong = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnOpenCongVanDen,
            this.btnOpenCongVanDi,
            this.btnLoaiVanBan,
            this.btnLoaiTinBao,
            this.btnCoQuan,
            this.btnQuanLyCanBo,
            this.btnKhenThuong});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5,
            this.ribbonPage6});
            this.ribbonControl1.Size = new System.Drawing.Size(800, 169);
            // 
            // btnOpenCongVanDen
            // 
            this.btnOpenCongVanDen.Caption = "Công văn đến";
            this.btnOpenCongVanDen.Hint = "Quản lý công văn đến";
            this.btnOpenCongVanDen.Id = 1;
            this.btnOpenCongVanDen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenCongVanDen.ImageOptions.Image")));
            this.btnOpenCongVanDen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOpenCongVanDen.ImageOptions.LargeImage")));
            this.btnOpenCongVanDen.Name = "btnOpenCongVanDen";
            // 
            // btnOpenCongVanDi
            // 
            this.btnOpenCongVanDi.Caption = "Công vắn đi";
            this.btnOpenCongVanDi.Hint = "Quản lý công văn đi";
            this.btnOpenCongVanDi.Id = 3;
            this.btnOpenCongVanDi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenCongVanDi.ImageOptions.Image")));
            this.btnOpenCongVanDi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOpenCongVanDi.ImageOptions.LargeImage")));
            this.btnOpenCongVanDi.Name = "btnOpenCongVanDi";
            // 
            // btnLoaiVanBan
            // 
            this.btnLoaiVanBan.Caption = "Loại văn bản";
            this.btnLoaiVanBan.Id = 4;
            this.btnLoaiVanBan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoaiVanBan.ImageOptions.Image")));
            this.btnLoaiVanBan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLoaiVanBan.ImageOptions.LargeImage")));
            this.btnLoaiVanBan.Name = "btnLoaiVanBan";
            this.btnLoaiVanBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiVanBan_ItemClick);
            // 
            // btnLoaiTinBao
            // 
            this.btnLoaiTinBao.Caption = "Loại tin báo";
            this.btnLoaiTinBao.Id = 5;
            this.btnLoaiTinBao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoaiTinBao.ImageOptions.Image")));
            this.btnLoaiTinBao.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLoaiTinBao.ImageOptions.LargeImage")));
            this.btnLoaiTinBao.Name = "btnLoaiTinBao";
            this.btnLoaiTinBao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiTinBao_ItemClick);
            // 
            // btnCoQuan
            // 
            this.btnCoQuan.Caption = "Cơ Quan";
            this.btnCoQuan.Id = 6;
            this.btnCoQuan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCoQuan.ImageOptions.Image")));
            this.btnCoQuan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCoQuan.ImageOptions.LargeImage")));
            this.btnCoQuan.Name = "btnCoQuan";
            this.btnCoQuan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCoQuan_ItemClick);
            // 
            // btnQuanLyCanBo
            // 
            this.btnQuanLyCanBo.Caption = "Quản lý cán bộ";
            this.btnQuanLyCanBo.Id = 7;
            this.btnQuanLyCanBo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyCanBo.ImageOptions.Image")));
            this.btnQuanLyCanBo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyCanBo.ImageOptions.LargeImage")));
            this.btnQuanLyCanBo.Name = "btnQuanLyCanBo";
            this.btnQuanLyCanBo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuanLyCanBo_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Công văn";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOpenCongVanDen);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOpenCongVanDi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Tin tố giác";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.ImageOptions.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Cán bộ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQuanLyCanBo);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage4.ImageOptions.Image")));
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Vũ khí, Công cụ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage5.ImageOptions.Image")));
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Đối tượng";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage6.ImageOptions.Image")));
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Danh mục";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonPageGroup6.ItemLinks.Add(this.btnLoaiVanBan);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnLoaiTinBao);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnKhenThuong);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnCoQuan);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 169);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(800, 281);
            this.pnlContainer.TabIndex = 1;
            // 
            // btnKhenThuong
            // 
            this.btnKhenThuong.Caption = "Hình thức khen thưởng";
            this.btnKhenThuong.Id = 8;
            this.btnKhenThuong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnKhenThuong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnKhenThuong.Name = "btnKhenThuong";
            this.btnKhenThuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhenThuong_ItemClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnOpenCongVanDen;
        private DevExpress.XtraBars.BarButtonItem btnOpenCongVanDi;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnLoaiVanBan;
        private DevExpress.XtraBars.BarButtonItem btnLoaiTinBao;
        private DevExpress.XtraEditors.PanelControl pnlContainer;
        private DevExpress.XtraBars.BarButtonItem btnCoQuan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyCanBo;
        private DevExpress.XtraBars.BarButtonItem btnKhenThuong;
    }
}