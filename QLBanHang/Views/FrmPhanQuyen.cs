using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang.Controls;
using QLBanHang.Objects;
using QLBanHang.Views;

namespace QLBanHang.Views
{
    public partial class FrmPhanQuyen : Form
    {
        ctrlQuyen _ctrlQuyen = new ctrlQuyen();

        ctrlPhanQuyen _ctrlPhanQuyen = new ctrlPhanQuyen();

        ctrlNhanVien _ctrlNhanVien = new ctrlNhanVien();

        DataTable _nhanVienDT = new DataTable();

        DataTable _quyenDT = new DataTable();

        int _idNhanVien = GlobalValues.IdNhanVien;



        public FrmPhanQuyen()
        {
            InitializeComponent();
            LoadNhanVien();
            PopulateTreeView();
            CheckTreeView();
        }
        /// <summary>
        /// Phân phối cây với các quyền
        /// </summary>
        private void PopulateTreeView()
        {
            _quyenDT = _ctrlQuyen.GetQuyenCha();

            TreeNode node;

            foreach(DataRow dr in _quyenDT.Rows)
            {
                node = new TreeNode(dr["TenQuyen"].ToString());
                node.Tag = Convert.ToInt32(dr["id"].ToString());
                GetSubQuyen(node);
                treeViewQuyen.Nodes.Add(node);
            }
        }

        /// <summary>
        /// Lấy các quyền con thuộc quyền cha
        /// </summary>
        /// <param name="nodeToAddTo"></param>
        private void GetSubQuyen(TreeNode nodeToAddTo)
        {
            TreeNode node;

            int idQuyenCha = (int)nodeToAddTo.Tag;
            DataTable tbSubQuyen = _ctrlQuyen.GetQuyenCha(idQuyenCha);

            if (tbSubQuyen == null) return;

            foreach (DataRow dr in tbSubQuyen.Rows)
            {
                node = new TreeNode(dr["TenQuyen"].ToString());
                node.Tag = Convert.ToInt32(dr["id"].ToString());
                GetSubQuyen(node);
                nodeToAddTo.Nodes.Add(node);
            }
        }

        /// <summary>
        /// Chekc các TreeNode nếu là quyền mà nhân viên sơ hữu
        /// </summary>
        private void CheckTreeView()
        {
            foreach (TreeNode node in treeViewQuyen.Nodes)
                CheckQuyen(_idNhanVien, node);
        }

        private void CheckQuyen(int idNhanVien,TreeNode nodeToCheck)
        {
            ///Đánh dấu nếu node này là quyền mà nhân viên được phân
            nodeToCheck.Checked = _ctrlPhanQuyen.GetTrangThai(_idNhanVien, (int)nodeToCheck.Tag);
            ///Kiểm tra xem các node con có là quyền mà nhân viên được phân hay không
            if (nodeToCheck.Nodes.Count > 0)
            {
                foreach (TreeNode node in nodeToCheck.Nodes)
                {
                    CheckQuyen(_idNhanVien, node);
                }
            }
        }
        /// <summary>
        /// Load theo nhân viên
        /// </summary>

        private void LoadNhanVien()
        {
            _nhanVienDT = _ctrlNhanVien.GetNhanVien();

            tsCmbNhanVien.ComboBox.DataSource = _nhanVienDT;

            tsCmbNhanVien.ComboBox.DisplayMember = "TenNhanVien";

            LoadIdNhanVien();
        }

        private void LoadIdNhanVien()
        {
            int index = tsCmbNhanVien.ComboBox.SelectedIndex;//Lấy index trên comboBox
            if (index >= 0)
            {
                DataRow row = _nhanVienDT.Rows[index];//Lấy row tương ứng với index
                _idNhanVien = Convert.ToInt32(row["id"].ToString());//gán vào _idCuaHang
            }
            else _idNhanVien = 0;
        }


        private void cmbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdNhanVien();
        }

        private void tsCmbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIdNhanVien();
            CheckTreeView();
        }

        private void UpdateQuyen()
        {
            foreach (TreeNode node in treeViewQuyen.Nodes)
                SetQuyen(_idNhanVien, node,node.Checked);
        }

        private void SetQuyen(int idNhanVien,TreeNode nodeToSet,bool trangThai)
        {

            ///Đánh dấu nếu node này là quyền mà nhân viên được phân
            _ctrlPhanQuyen.SetTrangThai(_idNhanVien,(int)nodeToSet.Tag,(bool)nodeToSet.Checked);
            ///Kiểm tra xem các node con có là quyền mà nhân viên được phân hay không
            if (nodeToSet.Nodes.Count > 0)
            {
                foreach (TreeNode node in nodeToSet.Nodes)
                {
                    SetQuyen(_idNhanVien, node, node.Checked);
                }
            }
        }

        private void tsBtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateQuyen();
            CheckTreeView();
        }
    }
}
