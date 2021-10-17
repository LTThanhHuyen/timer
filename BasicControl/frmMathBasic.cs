using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControl
{
    public partial class frmMathBasic : Form
    {
        public frmMathBasic()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txtsothunhat.Text;
                long nSoThuNhat = Convert.ToInt64(soThuNhat);

                var soThuHai = txtsothuhai.Text;
                long nSoThuHai = long.Parse(soThuHai);
                var ketQua = nSoThuNhat + nSoThuHai;

                lblKetqua.Text = ketQua.ToString("N0");
            }
            catch(FormatException ex)
            {
                MessageBox.Show($"Lỗi định dạng. Vui lòng nhập số không nhập kí tự. Chi tiết lỗi: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Lỗi số quá lớn.Vui lòng nhập số nhỏ thôi nhé. Chi tiết lỗi: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi rồi bạn nhé.Chi tiết lỗi: {ex.Message}");
            }
            
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txtsothunhat.Text;
                long nSoThuNhat = Convert.ToInt64(soThuNhat);

                var soThuHai = txtsothuhai.Text;
                long nSoThuHai = Convert.ToInt64(soThuHai);
                var ketQua = nSoThuNhat - nSoThuHai;

                lblKetqua.Text = ketQua.ToString("N0");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Lỗi định dạng. Vui lòng nhập số không nhập kí tự. Chi tiết lỗi: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Lỗi số quá lớn.Vui lòng nhập số nhỏ thôi nhé. Chi tiết lỗi: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi rồi bạn nhé.Chi tiết lỗi: {ex.Message}");
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txtsothunhat.Text;
                long nSoThuNhat = Convert.ToInt64(soThuNhat);

                var soThuHai = txtsothuhai.Text;
                long nSoThuHai = Convert.ToInt64(soThuHai);
                var ketQua = nSoThuNhat * nSoThuHai;

                lblKetqua.Text = ketQua.ToString("N0");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Lỗi định dạng. Vui lòng nhập số không nhập kí tự. Chi tiết lỗi: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Lỗi số quá lớn.Vui lòng nhập số nhỏ thôi nhé. Chi tiết lỗi: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi rồi bạn nhé.Chi tiết lỗi: {ex.Message}");
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txtsothunhat.Text;
                long nSoThuNhat = Convert.ToInt64(soThuNhat);

                var soThuHai = txtsothuhai.Text;
                long nSoThuHai = Convert.ToInt64(soThuHai);
                if (nSoThuHai == 0)
                    MessageBox.Show("Không thể chia cho 0");
                else
                {
                    var ketQua = nSoThuNhat / nSoThuHai;

                    lblKetqua.Text = ketQua.ToString("N0");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Lỗi định dạng. Vui lòng nhập số không nhập kí tự. Chi tiết lỗi: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Lỗi số quá lớn.Vui lòng nhập số nhỏ thôi nhé. Chi tiết lỗi: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi rồi bạn nhé.Chi tiết lỗi: {ex.Message}");
            }
        }
    }
}
