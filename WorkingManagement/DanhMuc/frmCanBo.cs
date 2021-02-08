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
    public partial class frmCanBo : Form
    {
       
        private BaseService<CanBo> _baseService;

        public frmCanBo()
        {
            InitializeComponent();

            _baseService = new BaseService<CanBo>();
            getList();
        }
        private void getList()
        {
            gridControl1.DataSource = _baseService.GetAll();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCanBoAdd frmAdd = new frmCanBoAdd();
            frmAdd.Name = "Thêm mới Cơ quan";
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
                CanBo obj = new CanBo();
                obj = _baseService.GetByID(IDObj);
                frmCanBoAdd frm = new frmCanBoAdd(obj);

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
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
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

        }
    }
}
