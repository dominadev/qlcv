using QLCV.Data.Dtos;
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

namespace WorkingManagement.DanhMuc
{
    public partial class frmLoaiTinBaoAdd : Form
    {
        public frmLoaiTinBaoAdd(LoaiTinBao obj = null)
        {
            InitializeComponent();
            _baseService = new BaseService<LoaiTinBao>();
            _obj = obj;
            if (obj != null)
            {
                txtID.Text = obj.ID.ToString();
                txtTen.Text = obj.Ten;
            }
        }
        private BaseService<LoaiTinBao> _baseService;
        public LoaiTinBao _obj;
      
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_obj != null)
            {
                Dapper.DynamicParameters paramss = new Dapper.DynamicParameters();
                paramss.Add("Ten", txtTen.Text);
                paramss.Add("ID", txtID.Text);
                var xxx = _baseService.ExcuteNonQuery("update LoaiTinBao set Ten = @Ten where ID = @ID", paramss);
                if (xxx > 0)
                {
                    MessageBox.Show("Sửa loại tin báo thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa  loại tin báo thất bại!");
                }
            }
            else
            {
                Dapper.DynamicParameters paramss = new Dapper.DynamicParameters();
                paramss.Add("Ten", txtTen.Text);
                var xxx = _baseService.ExcuteNonQuery("Insert into LoaiTinBao(Ten) Values(@Ten)", paramss);
                if (xxx > 0)
                {
                    MessageBox.Show("Thêm mới loại tin báo thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm mới loại tin báo thất bại!");
                }
            }

        }
    }
}
