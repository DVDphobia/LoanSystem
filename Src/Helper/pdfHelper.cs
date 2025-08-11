using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanSystem.Src.Helper
{
    internal class pdfHelper
    {
        public void ExportToPdf(DataGridView dgv)
        {
            using (var sfd = new SaveFileDialog() { Filter = "PDF Files|*.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            Document doc = new Document(PageSize.A4.Rotate());
                            PdfWriter writer = PdfWriter.GetInstance(doc, fs);

                            doc.Open();

                            PdfPTable table = new PdfPTable(dgv.Columns.Count);
                            table.WidthPercentage = 100;

                            // Headers
                            foreach (DataGridViewColumn column in dgv.Columns)
                            {
                                table.AddCell(new Phrase(column.HeaderText));
                            }

                            // Data rows
                            foreach (DataGridViewRow row in dgv.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        table.AddCell(new Phrase(cell.Value?.ToString() ?? ""));
                                    }
                                }
                            }

                            doc.Add(table);
                            doc.Close();
                        }

                        MessageBox.Show("PDF Exported Successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
