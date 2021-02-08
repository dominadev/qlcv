using QLCV.Data.Dtos;
using QLCV.Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingManagement.DanhMuc
{
    public partial class frmCoQuanAdd : Form
    {
       
        public frmCoQuanAdd(CoQuan obj = null)
        {
            InitializeComponent();
            _baseService = new BaseService<CoQuan>();
            _obj = obj;
            if (obj != null)
            {
                txtID.Text = obj.ID.ToString();
                txtMa.Text = obj.Ma;
                txtTen.Text = obj.Ten;
                txtDiaChi.Text = obj.DiaChi;
            }
        }
        private BaseService<CoQuan> _baseService;
        public CoQuan _obj;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_obj != null)
            {

                
                Dapper.DynamicParameters paramss = new Dapper.DynamicParameters();
                paramss.Add("Ma", txtMa.Text);
                paramss.Add("Ten", txtTen.Text);
                paramss.Add("DiaChi", txtDiaChi.Text);
                paramss.Add("ID", txtID.Text);
                var xxx = _baseService.ExcuteNonQuery("update CoQuan set Ma = @Ma, Ten = @Ten, DiaChi = @DiaChi where ID = @ID", paramss);
                if (xxx > 0)
                {
                    MessageBox.Show("Sửa cơ quan thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa cơ quan thất bại!");
                }
            }
            else
            {
                
                Dapper.DynamicParameters paramss = new Dapper.DynamicParameters();
                paramss.Add("Ma", txtMa.Text);
                paramss.Add("Ten", txtTen.Text);
                paramss.Add("DiaChi", txtDiaChi.Text);
                var xxx = _baseService.ExcuteNonQuery("Insert into CoQuan(Ma,Ten,DiaChi) Values(@Ma,@Ten,@DiaChi)", paramss);
                if (xxx > 0)
                {
                    MessageBox.Show("Thêm mới cơ quan thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm mới cơ quan thất bại!");
                }
            }

        }
    }
}
