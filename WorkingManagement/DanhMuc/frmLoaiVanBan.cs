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
    public partial class frmLoaiVanBan : Form
    {
        private BaseService<LoaiVanBan> _baseService;
        public frmLoaiVanBan()
        {
            InitializeComponent();
            _baseService = new BaseService<LoaiVanBan>();
            getList();
        }

        private void frmLoaiVanBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCVDataSet.LoaiVanBan' table. You can move, or remove it, as needed.
            //this.loaiVanBanTableAdapter.Fill(this.qLCVDataSet.LoaiVanBan);

        }
        private void getList()
        {
            gridControl1.DataSource = _baseService.GetAll();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmLoaiVanBanAdd frmAdd = new frmLoaiVanBanAdd();
            frmAdd.Name = "Thêm mới Loại văn bản";
            frmAdd.ShowDialog();
            getList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var x = gridView1.GetSelectedRows();
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
                 
                int IDObj = int.Parse(gridView1.GetRowCellValue(x[0], "ID").ToString());
                LoaiVanBan loaiVanBan = new LoaiVanBan();
                loaiVanBan = _baseService.GetByID(IDObj);
                frmLoaiVanBanAdd frm = new frmLoaiVanBanAdd(loaiVanBan);
               
                frm.ShowDialog();
                getList();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = true;
            var x = gridView1.GetSelectedRows();

            if (x.Length <= 0)
            {
                MessageBox.Show("Bạn chưa chọn dòng nào", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xoá những bản ghi đã chọn", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (var item in x)
                    {
                        int ID = (int)gridView1.GetRowCellValue(item, "ID");
                        result &= _baseService.Delete(ID) > 0;
                    }
                    if (result)
                    {
                        MessageBox.Show("Xoá thành công");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi xoá!");
                    }
                    getList();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }


            
            }
            
        }
    }
}
