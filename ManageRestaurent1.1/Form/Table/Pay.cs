using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRestaurent1._1
{
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();
        }
        manageTable t = new manageTable();
        private void guna2Button_cancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pay_Load(object sender, EventArgs e)
        {

        }
        public void fillTable(DataTable tb)
        {
            
        }
        bill b = new bill();
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            t.setEmptyTable(Global.table_id);
            
            b.checkoutBill(Global.bill_id);
            MessageBox.Show("Thanh Toán Thành Công", "Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void guna2Button_print_Click(object sender, EventArgs e)
        {
            string cost = label_total.Text;
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "*.docx";
            save.Filter = "DOCX Files|*.docx";
            if (save.ShowDialog() == DialogResult.OK && dataGridView_bill.Rows.Count + 1 > 0)
            {
                Spire.Doc.Document doc = new Spire.Doc.Document();

                Spire.Doc.Documents.Paragraph paragraph1 = doc.AddSection().AddParagraph();
                
                Spire.Doc.Fields.TextRange text1 = paragraph1.AppendText("\t\t\t\t\t RESTAURANT'S ORDER\n\n");
                string a =string.Format("\t\t\t\t\t\t\t\tTotal : {0} vnđ.\n",cost);
                Spire.Doc.Fields.TextRange text2 = paragraph1.AppendText(a);
                
                text1.CharacterFormat.FontName = "Times New Roman";
                text2.CharacterFormat.FontName = "Times New Roman";

                
                text1.CharacterFormat.FontSize = 15;
                text2.CharacterFormat.FontSize = 13;
                //paragraph1.Format.TextAlignment = TextAlignment.Center;              // văn bản canh giữa 
                paragraph1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;  // đoạn canh giữa

                Spire.Doc.Table table = doc.Sections[0].AddTable(true);

                // Số dòng và số cột cho bảng
                table.ResetCells(dataGridView_bill.Rows.Count + 1, dataGridView_bill.Columns.Count);
                for (int i = 0; i < dataGridView_bill.Columns.Count; i++)
                {
                    doc.Sections[0].Tables[0].Rows[0].Cells[i].Width = 200;
                }

                //Đặt hàng đầu tiên là header
                Spire.Doc.TableRow Frow = table.Rows[0];
                Frow.IsHeader = true;
                Frow.Height = 23;

                for (int i = 0; i < dataGridView_bill.Columns.Count; i++)
                {
                    Spire.Doc.Documents.Paragraph p = Frow.Cells[i].AddParagraph();
                    Frow.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                    p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                    Spire.Doc.Fields.TextRange tr = p.AppendText(dataGridView_bill.Columns[i].HeaderText);
                    tr.CharacterFormat.FontName = "Times New Roman";
                    tr.CharacterFormat.FontSize = 10;
                    tr.CharacterFormat.Bold = true;
                }

                for (int i = 0; i < dataGridView_bill.Rows.Count - 1; i++)
                {
                    Spire.Doc.TableRow DataRow = table.Rows[i + 1];
                    Spire.Doc.Documents.Paragraph paragraph;
                    for (int j = 0; j < dataGridView_bill.Columns.Count; j++)
                    {
                        DataRow.Height = 30;
                        DataRow.Cells[j].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                        paragraph = DataRow.Cells[j].AddParagraph();
                        paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        string textString = dataGridView_bill.Rows[i].Cells[j].Value.ToString();
                        Spire.Doc.Fields.TextRange text = paragraph.AppendText(dataGridView_bill.Rows[i].Cells[j].Value.ToString());
                        text.CharacterFormat.FontName = "Times New Roman";
                        text.CharacterFormat.FontSize = 10;
                    }
                }
                doc.SaveToFile(save.FileName);
                doc.Close();
            }
        }
    

        private void dataGridView_bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
