using QLCV.Data.Dtos;
using QLCV.Data.Helper;
using QLCV.Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingManagement.DanhMuc
{
    
    public partial class frmCanBoAdd : Form
    {
        private string _img = "";
        private BaseService<CanBo> _baseService;
        public CanBo _obj;
        public frmCanBoAdd(CanBo obj = null)
        {
            InitializeComponent();
            _baseService = new BaseService<CanBo>();
            SetFormat();
            _obj = obj;
            if (obj != null)
            {
                txtID.Text = obj.ID.ToString();
                txtMa.Text = obj.Ma.ToString();
                txtTen.Text = obj.HoTen.ToString();
                dateNgaySinh.Text = obj.NgaySinh.ToString();
                txtQueQuan.Text = obj.QueQuan.ToString();
                txtHoKhau.Text = obj.HoKhau.ToString();
                txtCapBac.Text = obj.CapBac.ToString();
                txtChucVuDang.Text = obj.ChucVuDang.ToString();
                txtChucVuChinhQuyen.Text = obj.ChucVuChinhQuyen.ToString();
                dateNgayVaoDang.Text = obj.NgayVaoDang.ToString();
                dateNgayVaoDangChinhThuc.Text = obj.NgayVaoDangChinhThuc.ToString();
                dateNgayVaoDoan.Text = obj.NgayVaoDoan.ToString();
                dateNgayVaoNganh.Text = obj.NgayVaoNganh.ToString();
                txtTrinhDoChuyenMon.Text = obj.TrinhDoChuyenMon.ToString();
                if (!string.IsNullOrEmpty(obj.Anh))
                {
                    try
                    {
                        var assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                        var assemblyParentPath = Path.GetDirectoryName(assemblyPath);
                        var imageDir = Path.Combine(assemblyParentPath, "Assests/images");
                        imgAva.Image = new Bitmap($"{imageDir}/{obj.Anh}");
                    }
                    catch(Exception ex)  
                    {
                         
                    }
                }
                rtbCacLoaiBangCap.Text = obj.CacLoaiBangCap;
                getListGD();
                getListCV();
                getListKT();
            }
            else
            {
                EnableOrDisable(false);
            }
            
        }
     
        private void EnableOrDisable(bool isEnsable)
        {
            pnlGD.Enabled = isEnsable;
            pnlCV.Enabled = isEnsable;
            pnlKT.Enabled = isEnsable;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetFormat()
        {
            dateNgaySinh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            dateNgaySinh.Properties.Mask.EditMask = "dd/MM/yyyy";
            dateNgaySinh.Properties.Mask.UseMaskAsDisplayFormat = true;

            dateNgayVaoDang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            dateNgayVaoDang.Properties.Mask.EditMask = "dd/MM/yyyy";
            dateNgayVaoDang.Properties.Mask.UseMaskAsDisplayFormat = true;

            dateNgayVaoDangChinhThuc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            dateNgayVaoDangChinhThuc.Properties.Mask.EditMask = "dd/MM/yyyy";
            dateNgayVaoDangChinhThuc.Properties.Mask.UseMaskAsDisplayFormat = true;

            dateNgayVaoDoan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            dateNgayVaoDoan.Properties.Mask.EditMask = "dd/MM/yyyy";
            dateNgayVaoDoan.Properties.Mask.UseMaskAsDisplayFormat = true;

            dateNgayVaoNganh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            dateNgayVaoNganh.Properties.Mask.EditMask = "dd/MM/yyyy";
            dateNgayVaoNganh.Properties.Mask.UseMaskAsDisplayFormat = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_obj != null)
            {


                Dapper.DynamicParameters paramss = new Dapper.DynamicParameters();
                var assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                var assemblyParentPath = Path.GetDirectoryName(assemblyPath);
                var imageDir = Path.Combine(assemblyParentPath, "Assests/images");

                if (!Directory.Exists(imageDir))
                    Directory.CreateDirectory(imageDir);
                if (!string.IsNullOrEmpty(_img))
                {
                    imgAva.Image.Save(imageDir + "/" + _img);
                }
                 
                paramss.Add("Ma", txtMa.Text);
                paramss.Add("HoTen", txtTen.Text);
                paramss.Add("NgaySinh", dateNgaySinh.Text);
                paramss.Add("QueQuan", txtQueQuan.Text);
                paramss.Add("HoKhau", txtHoKhau.Text);
                paramss.Add("CapBac", txtCapBac.Text);
                paramss.Add("ChucVuDang", txtChucVuDang.Text);
                paramss.Add("ChucVuChinhQuyen", txtChucVuChinhQuyen.Text);
                paramss.Add("NgayVaoDang", dateNgayVaoDang.Text);
                paramss.Add("NgayVaoDangChinhThuc", dateNgayVaoDangChinhThuc.Text);
                paramss.Add("NgayVaoDoan", dateNgayVaoDoan.Text);
                paramss.Add("NgayVaoNganh", dateNgayVaoNganh.Text);
                paramss.Add("TrinhDoChuyenMon", txtTrinhDoChuyenMon.Text);
                paramss.Add("CacLoaiBangCap", rtbCacLoaiBangCap.Text);
                paramss.Add("Anh", string.IsNullOrEmpty(_img) ? _obj.Anh : _img);
                paramss.Add("ID", _obj.ID, DbType.Int32);
                var xxx = _baseService.ExcuteNonQuery(@"UPDATE CanBo set Ma = @Ma 
                                                        , HoTen = @HoTen 
														, NgaySinh = @NgaySinh
                                                        , QueQuan = @QueQuan
                                                        , HoKhau = @HoKhau
                                                        , CapBac = @CapBac
                                                        , ChucVuDang = @ChucVuDang
                                                        , ChucVuChinhQuyen = @ChucVuChinhQuyen
                                                        , NgayVaoDang = @NgayVaoDang
                                                        , NgayVaoDangChinhThuc = @NgayVaoDangChinhThuc
                                                        , NgayVaoDoan = @NgayVaoDoan
                                                        , NgayVaoNganh = @NgayVaoNganh
                                                        , TrinhDoChuyenMon = @TrinhDoChuyenMon
                                                        , CacLoaiBangCap = @CacLoaiBangCap
                                                        , Anh = @Anh where ID = @ID", paramss);
                if (xxx > 0)
                {
                    MessageBox.Show("Sửa cán bộ thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa cán bộ thất bại!");
                }
            }
            else
            {
                var assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                var assemblyParentPath = Path.GetDirectoryName(assemblyPath);
                var imageDir = Path.Combine(assemblyParentPath, "Assests/images");

                if (!Directory.Exists(imageDir))
                    Directory.CreateDirectory(imageDir);
                if (!string.IsNullOrEmpty(_img))
                {
                    imgAva.Image.Save(imageDir + "/" + _img);
                }
               

                Dapper.DynamicParameters paramss = new Dapper.DynamicParameters();
                paramss.Add("Ma", txtMa.Text);
                paramss.Add("HoTen", txtTen.Text);
                paramss.Add("NgaySinh", dateNgaySinh.Text);
                paramss.Add("QueQuan", txtQueQuan.Text);
                paramss.Add("HoKhau", txtHoKhau.Text);
                paramss.Add("CapBac", txtCapBac.Text); 
                paramss.Add("ChucVuDang", txtChucVuDang.Text);
                paramss.Add("ChucVuChinhQuyen", txtChucVuChinhQuyen.Text);
                paramss.Add("NgayVaoDang", dateNgayVaoDang.Text);
                paramss.Add("NgayVaoDangChinhThuc", dateNgayVaoDangChinhThuc.Text);
                paramss.Add("NgayVaoDoan", dateNgayVaoDoan.Text);
                paramss.Add("NgayVaoNganh", dateNgayVaoNganh.Text);
                paramss.Add("TrinhDoChuyenMon", txtTrinhDoChuyenMon.Text);
                paramss.Add("CacLoaiBangCap", rtbCacLoaiBangCap.Text);
                paramss.Add("Anh", _img);
                int id = 0;
                string table = "CanBo";
                var xxx = _baseService.ExcuteNonQuery(@"
                    INSERT INTO CanBo
                         (Ma, HoTen, NgaySinh, QueQuan, HoKhau, CapBac, ChucVuDang, ChucVuChinhQuyen, NgayVaoDang, NgayVaoDangChinhThuc, NgayVaoDoan, Anh, CacLoaiBangCap, TrinhDoChuyenMon, NgayVaoNganh)
                        VALUES (@Ma, @HoTen, @NgaySinh, @QueQuan, @HoKhau, @CapBac, @ChucVuDang, @ChucVuChinhQuyen, @NgayVaoDang, @NgayVaoDangChinhThuc, @NgayVaoDoan, @Anh, @CacLoaiBangCap, @TrinhDoChuyenMon, @NgayVaoNganh)", paramss);

                
                if (xxx > 0)
                {
                    MessageBox.Show("Thêm mới cán bộ thành công!");
                    var Id = _baseService.GetMaxId(@"CanBo");
                    txtID.Text = Id.ToString();
                    EnableOrDisable(true);
                }
                else
                {
                    MessageBox.Show("Thêm mới cán bộ thất bại!");
                }
            }

        }

        private void imgAva_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imgAva.Image = new Bitmap(open.FileName);
                _img = $"{DateTime.Now.ToString("yyyMMddHHmmss")}_{open.SafeFileName}";
            }
          
         
        }

        private void imgAva_Click(object sender, EventArgs e)
        {

        }
        private void getListGD()
        {
            gridGD.DataSource = new BaseService<ThanhVienGiaDinh>().GetAll($"Where IDCanBo = {_obj.ID}");
        }
        private void getListCV()
        {
            //gridCV.DataSource = new BaseService<CongViec>().GetAll();
        }
        private void getListKT()
        {
            gridKT.DataSource = new CanBoService().GetList(_obj.ID);
             
        }
        private void btnAddGD_Click(object sender, EventArgs e)
        {
            frmThanhVienAdd frmAdd = new frmThanhVienAdd();
            frmAdd.Text = "Thêm mới thành viên";
            frmAdd.IDCanBo = _obj.ID;
            frmAdd.ShowDialog();
            getListGD();
        }

        private void btnEditGD_Click(object sender, EventArgs e)
        {
            
            var x = dgvGiaDinh.GetSelectedRows();
            if (x.Length > 1)
            {
                MessageBox.Show("Bạn chọn quá nhiều dòng", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (x.Length <= 0)
            {
                MessageBox.Show("Bạn chưa chọn dòng nào", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int IDObj = int.Parse(dgvGiaDinh.GetRowCellValue(x[0], "ID").ToString());
                ThanhVienGiaDinh obj = new ThanhVienGiaDinh();
                obj = new BaseService<ThanhVienGiaDinh>().GetByID(IDObj);
                frmThanhVienAdd frm = new frmThanhVienAdd(obj);
                frm.Text = "Sửa thành viên";
                frm.IDCanBo = _obj.ID;
                frm.ShowDialog();
                getListGD();

            }
        }

        private void btnAddKT_Click(object sender, EventArgs e)
        {
            frmKhenThuong_CanBo frmAdd = new frmKhenThuong_CanBo();
            frmAdd.Text = "Thêm mới khen thưởng";
            frmAdd._canBo = _obj;
            frmAdd.ShowDialog();
            getListKT();
        }

        private void btnEditKT_Click(object sender, EventArgs e)
        {
            var x = dgvKT.GetSelectedRows();
            if (x.Length > 1)
            {
                MessageBox.Show("Bạn chọn quá nhiều dòng", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (x.Length <= 0)
            {
                MessageBox.Show("Bạn chưa chọn dòng nào", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int IDObj = int.Parse(dgvKT.GetRowCellValue(x[0], "ID").ToString());
                KhenThuong_CanBo obj = new KhenThuong_CanBo();
                obj = new BaseService<KhenThuong_CanBo>().GetByID(IDObj);
                frmKhenThuong_CanBo frm = new frmKhenThuong_CanBo(obj);
                frm.Text = "Sửa khen thưởng";
                frm._canBo = _obj;
                frm.ShowDialog();
                getListKT();

            }
        }

        private void btnEditCV_Click(object sender, EventArgs e)
        {

        }
    }
}
