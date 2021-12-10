using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canny
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        public void layanh()
        {
            // Mở file mới với OpenFileDiaLog
            OpenFileDialog imagefileopen = new OpenFileDialog();
            // Load file với đuôi này 
            imagefileopen.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png) | *.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (imagefileopen.ShowDialog() == DialogResult.OK) // nếu file đc chọn 
            {
                Bitmap anh = new Bitmap(imagefileopen.FileName);
             // lblduongdananh2.Text = imagefileopen.FileName.ToString();

                imgAnhGoc.Image = new Bitmap(imagefileopen.FileName); // thì th picbox( tên th picturebox) sẽ đc mở

                rtbox_thongtinanhbandau.Text = "THÔNG SỐ ẢNH BAN ĐẦU: " + laythongtinanh(anh);
            }
        }
        public string laythongtinanh(Bitmap duongdanfile)
        {
            try
            {
                var kq = "\n\n";
                if (duongdanfile==null)
                {
                    return kq;
                }
                else { 
                
                Type type = duongdanfile.GetType();
                PropertyInfo[] props = type.GetProperties();
                string str = "\n ";
                foreach (var prop in props)
                {
                    str += (prop.Name + " : " + prop.GetValue(duongdanfile)) + "\n ";
                }
                kq += str.Remove(str.Length - 1) + "\n\n";
                return kq;
                }
            }
            catch (Exception x)
            {
                return x.ToString();
                //throw;
            }
            
        }

        /// <summary>
        /// Xử lý ảnh dùng thuật toán CANNY
        /// </summary>
        public void xulyCanny()
        {
            
            try
            {
                //lblthongbao.Text =  "Đang xử lý ....";
              
                Bitmap newBitmap1 = (Bitmap)imgAnhGoc.Image;

                rtbox_thongtinanhbandau.Text = "THÔNG SỐ ẢNH BAN ĐẦU: " + laythongtinanh(newBitmap1);
                if (newBitmap1==null)
                {
                    MessageBox.Show("Bạn hãy chọn ảnh!");
                }
                else
                {
                    // Xử lý hình ảnh - rồi load lên ô kết quả
                    cannyC doituong = new cannyC();
                    newBitmap1 = doituong.MakeGrayscale(newBitmap1); // chạy thuật toán làm cho hình sang màu xám
                   
                    // anhchuyenxam.Image = newBitmap1;
                    newBitmap1 = doituong.MakeSmooth(newBitmap1);// chạy thuật toán làm mịn điểm ảnh
                   
                    //  anhlammin.Image = newBitmap1;
                   
                    newBitmap1 = doituong.DetectEdge(newBitmap1);// chạy thuật toán phát hiên cảnh của nó
                    imgSauXuLy.Image = newBitmap1; // hiện hình trên cannyBox
                    rtbox_thongtinanhsaukhixuly.Text = "THÔNG SỐ ẢNH SAU KHI XỬ LÝ: " + laythongtinanh((Bitmap)imgSauXuLy.Image);
                    lblthongbao.Text = "Đã xử lý ....";
                }
                
            }
            catch (Exception EX)
            {
                lblthongbao.Text = "Lỗi khi xử lý ảnh ; " + EX.ToString();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            layanh();
        }
        private void BTNXULY_Click_1(object sender, EventArgs e)
        {
          
            xulyCanny();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            // kích cỡ của ảnh 
            imgAnhGoc.Width = 300;
            imgSauXuLy.Width = 300;
            imgAnhGoc.Height = 300;
            imgSauXuLy.Height = 300;
            rtbox_thongtinanhsaukhixuly.Text = "THÔNG SỐ ẢNH SAU KHI XỬ LÝ";
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TSMenuItem_GioiThieu_Click(object sender, EventArgs e)
        {
            String str = "Máy dò cạnh Canny là một thuật toán nhiều bước để phát hiện các cạnh cho bất kỳ hình ảnh đầu vào nào. Nó bao gồm các bước được đề cập bên dưới để được thực hiện trong khi phát hiện các cạnh của hình ảnh.\n 1. Loại bỏ nhiều trong hình ảnh đầu vào bằng bộ lọc Gaussian. \n 2. Tính toán đạo hàm của bộ lọc Gaussian để tính toán gradient của pixel ảnh để thu được độ lớn dọc theo chiều x và y. \n 3. Xem xét một nhóm lân cận của bất kỳ đường cong nào theo hướng vuông góc với cạnh đã cho, loại bỏ các điểm pixel đóng góp cạnh không tối đa. \n 4. Cuối cùng, sử dụng phương pháp Hysteresis Thresholding để bảo toàn các pixel cao hơn cường độ gradient và bỏ qua những pixel thấp hơn giá trị ngưỡng thấp. \n Trước khi đi sâu vào các bước dưới đây là ba kết luận mà JK Canny, người đã đưa ra thuật toán: \n - Phát hiện tốt: Máy dò tối ưu phải loại bỏ khả năng nhận được dương tính giá và âm tính giả. \n - Bản địa hóa tốt: Các cạnh được phát hiện phải gần với các cạnh thực.", title = "Giới thiệu";
            DialogResult res = MessageBox.Show(str, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            switch (res)
            {
                case DialogResult.OK:
                    break;
                default:
                    break;
            }
        }

        private void TSMenuItem_TacGia_Click(object sender, EventArgs e)
        {
            String str = "Nguyễn Vĩ Khang - 1800615 \nPhùng Thị Anh Thư - 1800656\n Ngô Anh Tú - 1800053",title = "Tác giả";
            DialogResult res = MessageBox.Show(str, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            switch (res)
            {
                case DialogResult.OK:
                    break;
                default:
                    break;
            }
        }
    }
}
