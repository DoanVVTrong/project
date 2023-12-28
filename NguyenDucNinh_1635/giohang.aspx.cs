using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NguyenDucNinh_1635
{
    public partial class giohang : System.Web.UI.Page
    {
        KetNoi kn = new KetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            string tendangnhap = Session["username"] + "";
            if (tendangnhap != "")
            {
                string sql = "select TUIXACH.MATUIXACH, TENTUIXACH, MOTA, MAUSAC, DONGIA, SOLUONG, DONGIA * SOLUONG AS THANHTIEN" +
                    " from TUIXACH, DONHANG" +
                    " where TUIXACH.MATUIXACH = DONHANG.MATUIXACH AND TENDANGNHAP='" + tendangnhap + "'";
                GridView1.DataSource = kn.docdulieu(sql);
                GridView1.DataBind();
            }
        }
    }
}