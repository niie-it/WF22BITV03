using DemoQLBH.Entities;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQLBH
{
    public partial class FrmKhachHang : Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            QlbanHangContext ctx = new QlbanHangContext();

            dataGridView1.DataSource = ctx.KhachHangs
                .Select(p => new
                {
                    p.MaKh,
                    p.TenCty,
                    p.DiaChi,
                    p.DienThoai,
                    p.MaThanhPho,
                    p.MaThanhPhoNavigation.TenThanhPho
                })
                .OrderBy(p => p.TenThanhPho)
                .ToList();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Save as Excel File";
                    saveFileDialog.FileName = "ExportedData.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExportToExcel(dataGridView1, saveFileDialog.FileName);
                        MessageBox.Show("Data successfully exported to Excel!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No data available to export!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExportToExcel(DataGridView dgv, string filePath)
        {
            ExcelPackage.License.SetNonCommercialPersonal("My Name");
            using (ExcelPackage excel = new ExcelPackage())
            {
                // Create a worksheet
                ExcelWorksheet worksheet = excel.Workbook.Worksheets.Add("DS_KHACH_HANG");

                // Add the headers
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dgv.Columns[i].HeaderText;
                }

                // Add the rows
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dgv.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Save the file
                FileInfo excelFile = new FileInfo(filePath);
                excel.SaveAs(excelFile);
            }
        }
    }
}
