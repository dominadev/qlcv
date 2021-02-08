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

namespace WorkingManagement.UserControls
{
     
    public partial class ucDanhMucList : UserControl
    {
        public EventHandler evDelete { get; set; }
        public EventHandler evAdd { get; set; }
        public EventHandler evEdit { get; set; }
        public EventHandler evBack { get; set; }
        public EventHandler evSave { get; set; }
        public ucDanhMucList()
        {
            InitializeComponent();
        }
        public void getList<T>()
        {
            var data = new BaseService<T>().GetAll();
            gridControl1.DataSource = data;
             
        }
        public void setColnumGrid<T>()
        {
            foreach (var item in typeof(T).GetProperties().ToList())
            {
                var attributes = item.GetCustomAttributes(typeof(DisplayNameAttribute), true);
                DisplayNameAttribute attribute = null;
                if (attributes.Length > 0)
                {
                    attribute = attributes[0] as DisplayNameAttribute;
                }
                dgvDanhMuc.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = item.Name, Caption = attribute?.DisplayName ?? item.Name, Visible = true });
            }
        }
       
       
        public void SetEvent()
        {
            btnDelete.Click += evDelete;
            btnEdit.Click += evEdit;
            btnAdd.Click += evAdd;
            
        }
 

        public bool delete<T>()
        {
      
            try
            {
                var result = true;
                var listRowsSelected = dgvDanhMuc.GetSelectedRows();
                if (listRowsSelected.Length <= 0)
                {
                    MessageBox.Show("Bạn chưa chọn dòng nào", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xoá những bản ghi đã chọn", "Warning!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (var item in listRowsSelected)
                        {
                            int ID = (int)dgvDanhMuc.GetRowCellValue(item,"ID");
                            result &= new BaseService<T>().Delete(ID) > 0;
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
               
                return result;
            }
            catch (Exception ex)
            {

                return false;
            }
          
        }

       
    }
}
