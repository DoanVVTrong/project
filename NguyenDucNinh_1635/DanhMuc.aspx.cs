using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NguyenDucNinh_1635
{
    public partial class DanhMuc : System.Web.UI.Page
    {
        KetNoi kn = new KetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            string sql = "";
            string maloai = Context.Items["maloai"] + "";
            if (maloai == "")
            {
                sql = "select * from TUIXACH";
            }
            else
            {
                sql = "select * from TUIXACH where MADANHMUC=" + maloai;
            }
            DataList1.DataSource = kn.docdulieu(sql);
            DataList1.DataBind();
        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string mahang = ((ImageButton)sender).CommandArgument;
            Response.Redirect("chitiet.aspx?mh=" + mahang);
        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string mahang = ((LinkButton)sender).CommandArgument;
            Response.Redirect("chitiet.aspx?mh=" + mahang);
        }
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            string mahang = ((LinkButton)sender).CommandArgument;
            Response.Redirect("chitiet.aspx?mh=" + mahang);
        }
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            string mahang = ((LinkButton)sender).CommandArgument;
            Response.Redirect("chitiet.aspx?mh=" + mahang);
        }
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            string mahang = ((LinkButton)sender).CommandArgument;
            Response.Redirect("chitiet.aspx?mh=" + mahang);
        }
        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            string mahang = ((LinkButton)sender).CommandArgument;
            Response.Redirect("chitiet.aspx?mh=" + mahang);
        }

    }
}