using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.DAO;
using PROJECT.DTO;

namespace PROJECT.BUS
{
    public class NhomBUS
    {
        private static NhomBUS instance;

        public static NhomBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhomBUS();
                return instance;
            }
        }

        private NhomBUS() { }

        public void GetAll(DataGridView data)
        {
            data.DataSource = NhomDAO.Instance.GetAll();
        }

        public NHOM GetByID(string id)
        {
            return NhomDAO.Instance.GetByID(id);
        }

        public bool updateNhom(string MaNhom,NHOM nh)
        {
            //DataGridViewRow row = data.SelectedCells[0].OwningRow;
            //string MaNhom = row.Cells["MaNhom"].Value.ToString();
            //string TenNhom = row.Cells["TenNhom"].Value.ToString();
            //bool TrangThai = (bool)row.Cells["TrangThai"].Value;

            //NHOM nh = new NHOM(MaNhom, TenNhom, TrangThai);

            return NhomDAO.Instance.updateNhom(MaNhom, nh);
        }

        public bool insertNhom(string MaNhom, string TenNhom, bool TrangThai)
        {
            NHOM nh = new NHOM(MaNhom, TenNhom, TrangThai);
            return NhomDAO.Instance.insertNhom(nh);
        }

        public bool deleteNhom(string id)
        {
            return NhomDAO.Instance.deleteNhom(id);
        }

        //lấy nhóm cuối:
        public NHOM GetNhomLast()
        {
            return NhomDAO.Instance.GetNhomLast();
        }

        //tạo mã nhóm
        public string CreateCode()
        {
            return NhomDAO.Instance.CreateCode();
        }

        public List<string> GetListMaNhom(string MaMCD)
        {
            return NhomDAO.Instance.GetListMaNhom(MaMCD);
        }
    }
}
