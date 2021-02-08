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
    public partial class frmKhenThuong_CanBo : Form
    {
        private BaseService<KhenThuong_CanBo> _baseService;
        public KhenThuong_CanBo _obj;
        public CanBo _canBo;
        public frmKhenThuong_CanBo(KhenThuong_CanBo obj = null)
        {
            InitializeComponent();
            LoadHinhThucKhenThuong();
            LoadFormat();
            _baseService = new BaseService<KhenThuong_CanBo>();
            _obj = obj;
            if (obj != null)
            {
                txtID.Text = obj.ID.ToString();
                cbbHinhThuc.SelectedValue = obj.IDKhenThuong.ToString();
             
                dateNgayThang.Text = obj.NgayThang;
                txtCapKhenThuong.Text = obj.CapKhenThuong;

            }
          
        }
   

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadHinhThucKhenThuong()
        {
            var data = new BaseService<KhenThuong>().GetAll();
            cbbHinhThuc.DataSource = data;
            cbbHinhThuc.DisplayMember = "Ten";
            cbbHinhThuc.ValueMember = "ID";
            
        }
        private void LoadFormat()
        {
            dateNgayThang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            dateNgayThang.Properties.Mask.EditMask = "dd/MM/yyyy";
            dateNgayThang.Properties.Mask.UseMaskAsDisplayFormat = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_obj != null)
            {


                Dapper.DynamicParameters paramss = new Dapper.DynamicParameters();
                paramss.Add("IDKhenThuong", cbbHinhThuc.SelectedValue.ToString());
                paramss.Add("IDCanBo", _canBo.ID);
                paramss.Add("NgayThang", dateNgayThang.Text);
                paramss.Add("CapKhenThuong", txtCapKhenThuong.Text);
                paramss.Add("ID", _obj.ID);
                var xxx = _baseService.ExcuteNonQuery("update KhenThuong_CanBo set IDKhenThuong = @IDKhenThuong, IDCanBo = @IDCanBo, NgayThang = @NgayThang, CapKhenThuong = @CapKhenThuong where ID = @ID", paramss);
                if (xxx > 0)
                {
                    MessageBox.Show("Sửa khen thưởng thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa khen thưởng thất bại!");
                }
            }
            else
            {

                Dapper.DynamicParameters paramss = new Dapper.DynamicParameters();
                paramss.Add("IDKhenThuong", cbbHinhThuc.SelectedValue.ToString());
                paramss.Add("IDCanBo", _canBo.ID);
                paramss.Add("NgayThang", dateNgayThang.Text);
                paramss.Add("CapKhenThuong", txtCapKhenThuong.Text);

                var xxx = _baseService.ExcuteNonQuery("Insert into KhenThuong_CanBo(IDKhenThuong,IDCanBo,NgayThang,CapKhenThuong) Values(@IDKhenThuong,@IDCanBo,@NgayThang,@CapKhenThuong)", paramss);
                if (xxx > 0)
                {
                    MessageBox.Show("Thêm mới khen thưởng thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm mới khen thưởng thất bại!");
                }
            }

        }
    }
}
