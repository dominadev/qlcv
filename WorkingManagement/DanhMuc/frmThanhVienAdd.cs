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
    public partial class frmThanhVienAdd : Form
    {
        private BaseService<ThanhVienGiaDinh> _baseService;
        public ThanhVienGiaDinh _obj;
        public int IDCanBo = 0;
        public frmThanhVienAdd(ThanhVienGiaDinh obj = null)
        {
            InitializeComponent();
            _baseService = new BaseService<ThanhVienGiaDinh>();
            _obj = obj;
            if (obj != null)
            {
                 
            }
        }
       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_obj != null)
            {


                Dapper.DynamicParameters paramss = new Dapper.DynamicParameters();
                paramss.Add("QuanHe", txtQuanHe.Text);
                paramss.Add("HoTen", txtHoTen.Text);
                paramss.Add("NgaySinh", dateNgaySinh.Text);
                paramss.Add("QueQuan", txtQueQuan.Text);
                paramss.Add("HoKhau", txtHoKhau.Text);
                paramss.Add("CongViec", txtCongViec.Text);
                paramss.Add("IDCanBo", IDCanBo);
                paramss.Add("ID", txtID.Text);
                var xxx = _baseService.ExcuteNonQuery("update ThanhVienGiaDinh set QuanHe = @QuanHe, HoTen = @HoTen, NgaySinh = @NgaySinh, QueQuan = @QueQuan, HoKhau = @HoKhau, CongViec = @CongViec,IDCanBo = @IDCanBo where ID = @ID", paramss);
                if (xxx > 0)
                {
                    MessageBox.Show("Sửa thành viên thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thành viên thất bại!");
                }
            }
            else
            {

                Dapper.DynamicParameters paramss = new Dapper.DynamicParameters();
                paramss.Add("QuanHe", txtQuanHe.Text);
                paramss.Add("HoTen", txtHoTen.Text);
                paramss.Add("NgaySinh", dateNgaySinh.Text);
                paramss.Add("QueQuan", txtQueQuan.Text);
                paramss.Add("HoKhau", txtHoKhau.Text);
                paramss.Add("CongViec", txtCongViec.Text);
                paramss.Add("IDCanBo", IDCanBo);
             
                var xxx = _baseService.ExcuteNonQuery("Insert into ThanhVienGiaDinh(QuanHe,HoTen,NgaySinh,QueQuan,HoKhau,CongViec,IDCanBo) Values(@QuanHe,@HoTen,@NgaySinh,@QueQuan,@HoKhau,@CongViec,@IDCanBo)", paramss);
                if (xxx > 0)
                {
                    MessageBox.Show("Thêm mới thành viên thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm mới thành viên thất bại!");
                }
            }

        }
    }
}
