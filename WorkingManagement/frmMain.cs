using QLCV.Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkingManagement.DanhMuc;

namespace WorkingManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
           
            InitializeComponent();
        }

        private void btnLoaiVanBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form it in pnlContainer.Controls)
            {
                it.Close();
            }
            pnlContainer.Controls.Clear();
            frmLoaiVanBan frm = new frmLoaiVanBan();
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            pnlContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btnLoaiTinBao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form it in pnlContainer.Controls)
            {
                it.Close();
            }
            pnlContainer.Controls.Clear();
            frmLoaiTinBao frm = new frmLoaiTinBao();
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            pnlContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btnCoQuan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form it in pnlContainer.Controls)
            {
                it.Close();
            }
            pnlContainer.Controls.Clear();
            frmCoQuan frm = new frmCoQuan();
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            pnlContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btnQuanLyCanBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form it in pnlContainer.Controls)
            {
                it.Close();
            }
            pnlContainer.Controls.Clear();
            frmCanBo frm = new frmCanBo();
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            pnlContainer.Controls.Add(frm);
            frm.Show();
        }

        private void btnKhenThuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form it in pnlContainer.Controls)
            {
                it.Close();
            }
            pnlContainer.Controls.Clear();
            frmKhenThuong frm = new frmKhenThuong();
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            pnlContainer.Controls.Add(frm);
            frm.Show();
        }
    }
}
