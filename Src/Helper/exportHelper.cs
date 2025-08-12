using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LoanSystem.Src.Helper
{
    internal class exportHelper
    {
        // Function 1: PDF with optional title and header lines
        public void ExportListViewToPdf(ListView listView, string title = null, params string[] headerLines)
        {
            using var sfd = new SaveFileDialog { Filter = "PDF Files|*.pdf", Title = "Export to PDF", FileName = Safe(string.IsNullOrWhiteSpace(title) ? "schedule" : title) + ".pdf" };
            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                using var fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                using var doc = new Document(PageSize.A4.Rotate(), 24, 24, 24, 24);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                if (!string.IsNullOrWhiteSpace(title))
                {
                    var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                    doc.Add(new Paragraph(title, titleFont) { SpacingAfter = 8f });
                }
                if (headerLines != null && headerLines.Length > 0)
                {
                    var headerFont = FontFactory.GetFont(FontFactory.HELVETICA, 11);
                    foreach (var line in headerLines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                            doc.Add(new Paragraph(line, headerFont));
                    }
                    doc.Add(new Paragraph(" ") { SpacingAfter = 6f });
                }

                var table = new PdfPTable(listView.Columns.Count) { WidthPercentage = 100 };
                foreach (ColumnHeader col in listView.Columns)
                    table.AddCell(new PdfPCell(new Phrase(col.Text)) { BackgroundColor = BaseColor.LIGHT_GRAY });
                foreach (ListViewItem item in listView.Items)
                {
                    for (int i = 0; i < listView.Columns.Count; i++)
                    {
                        string text = i == 0 ? item.Text : (item.SubItems.Count > i ? item.SubItems[i].Text : string.Empty);
                        table.AddCell(new Phrase(text ?? string.Empty));
                    }
                }
                doc.Add(table);
                MessageBox.Show("PDF exported.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF export failed: " + ex.Message);
            }
        }

        // Function 2: XLS/CSV with optional title and header lines
        public void ExportListViewToXls(ListView listView, string title = null, params string[] headerLines)
        {
            using var sfd = new SaveFileDialog { Filter = "Excel 97-2003 (*.xls)|*.xls|CSV (*.csv)|*.csv", Title = "Export to Excel", FileName = Safe(string.IsNullOrWhiteSpace(title) ? "schedule" : title) + ".xls" };
            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                string ext = Path.GetExtension(sfd.FileName).ToLowerInvariant();
                bool asCsv = ext == ".csv";

                using var sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8);
                // optional title
                if (!string.IsNullOrWhiteSpace(title))
                {
                    sw.WriteLine(title);
                }
                // header lines (write as simple two-column if contains ':')
                if (headerLines != null)
                {
                    foreach (var line in headerLines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        int idx = line.IndexOf(':');
                        if (idx > 0)
                        {
                            var key = line.Substring(0, idx).Trim();
                            var val = line.Substring(idx + 1).Trim();
                            sw.WriteLine(asCsv ? Csv(key) + "," + Csv(val) : key + "\t" + val);
                        }
                        else
                        {
                            sw.WriteLine(line);
                        }
                    }
                    sw.WriteLine();
                }

                // headers row
                for (int c = 0; c < listView.Columns.Count; c++)
                {
                    if (c > 0) sw.Write(asCsv ? "," : "\t");
                    sw.Write(asCsv ? Csv(listView.Columns[c].Text) : listView.Columns[c].Text);
                }
                sw.WriteLine();
                // data rows
                foreach (ListViewItem item in listView.Items)
                {
                    for (int c = 0; c < listView.Columns.Count; c++)
                    {
                        if (c > 0) sw.Write(asCsv ? "," : "\t");
                        string text = c == 0 ? item.Text : (item.SubItems.Count > c ? item.SubItems[c].Text : string.Empty);
                        sw.Write(asCsv ? Csv(text) : text);
                    }
                    sw.WriteLine();
                }
                MessageBox.Show(asCsv ? "CSV exported." : "XLS exported.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel export failed: " + ex.Message);
            }

            string Csv(string s)
            {
                if (s == null) return string.Empty;
                bool quote = s.Contains(",") || s.Contains("\"") || s.Contains("\n") || s.Contains("\r");
                if (quote) return '"' + s.Replace("\"", "\"\"") + '"';
                return s;
            }
        }

        private static string Safe(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return "export";
            foreach (char c in Path.GetInvalidFileNameChars()) s = s.Replace(c, '_');
            return s;
        }
    }
}
