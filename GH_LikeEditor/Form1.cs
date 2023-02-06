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

namespace GH_LikeEditor
{
    public partial class Form1 : Form
    {
        Color[] colors = { Color.Gray, Color.Gray, Color.Gray, Color.Red, Color.Yellow, Color.Green, Color.Blue, Color.Gray };
        string filename = null;

        public Form1()
        {
            InitializeComponent();
            dataGridView.Enabled = false;
            dataGridView.Visible = false;
            ModeCombo.SelectedIndex = 0;
        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            filename = null;
            dataGridView.Rows.Clear();
            dataGridView.Enabled = true;
            dataGridView.Visible = true;
            AddRow();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files|*.*|Crea Guitar Hero|*.cgh|CSV|*.csv|Text Files|*.txt";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader streamReader = new StreamReader(openFileDialog1.FileName))
                {
                    filename = openFileDialog1.FileName;
                    dataGridView.Rows.Clear();
                    dataGridView.Enabled = true;
                    dataGridView.Visible = true;

                    string[] parameterLine = streamReader.ReadLine().Split(',');
                    try
                    {
                        BPMBox.Value = int.Parse(parameterLine[0]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        BPMBox.Value = 120;
                    }

                    int lineNbr = 1;
                    while (!streamReader.EndOfStream)
                    {
                        string[] curLine = streamReader.ReadLine().Split(',');
                        if (curLine.Length == 4)
                        {
                            string[] curColumns = { "-", lineNbr.ToString(), ((60 / BPMBox.Value) * (lineNbr - 1)).ToString("0.00") + "s",
                                curLine[0], curLine[1], curLine[2], curLine[3], "+" };

                            int curLineNbr = dataGridView.Rows.Add(curColumns);

                            for (int i = 3; i < curColumns.Length - 1; i++)
                            {
                                if (curColumns[i].Equals("x"))
                                {
                                    dataGridView.Rows[curLineNbr].Cells[i].Style.BackColor = colors[i];
                                    dataGridView.Rows[curLineNbr].Cells[i].Style.SelectionBackColor = colors[i];
                                    dataGridView.Rows[curLineNbr].Cells[i].Value = "";
                                }
                                else
                                {
                                    dataGridView.Rows[curLineNbr].Cells[i].Style.BackColor = dataGridView.DefaultCellStyle.BackColor;
                                    dataGridView.Rows[curLineNbr].Cells[i].Style.SelectionBackColor = dataGridView.DefaultCellStyle.SelectionBackColor;
                                }
                            }

                            lineNbr++;
                        }
                    }
                    if (lineNbr == 1)
                    {
                        AddRow();
                        lineNbr++;
                    }

                    TotalLinesLabel.Text = "Total Lines : " + (lineNbr - 1).ToString();
                    TotalDurationLabel.Text = "Total Duration : " + ((60 / BPMBox.Value) * (lineNbr - 2)).ToString("0.00") + "s";

                }
            }
        }

        void SaveFile(bool forceNew)
        {
            if (forceNew || filename == null || filename == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = saveFileDialog1.FileName;
                }
            }

            if (filename != null && filename != "")
            {
                using (StreamWriter streamWriter = new StreamWriter(filename))
                {
                    streamWriter.WriteLine(BPMBox.Value.ToString());
                    for (int i = 0; i < dataGridView.RowCount; i++)
                    {
                        string curLine = "";

                        if (dataGridView.Rows[i].Cells[3].Style.BackColor != dataGridView.DefaultCellStyle.BackColor)
                            curLine += "x";
                        else
                            curLine += " ";
                        curLine += ",";
                        if (dataGridView.Rows[i].Cells[4].Style.BackColor != dataGridView.DefaultCellStyle.BackColor)
                            curLine += "x";
                        else
                            curLine += " ";
                        curLine += ",";
                        if (dataGridView.Rows[i].Cells[5].Style.BackColor != dataGridView.DefaultCellStyle.BackColor)
                            curLine += "x";
                        else
                            curLine += " ";
                        curLine += ",";
                        if (dataGridView.Rows[i].Cells[6].Style.BackColor != dataGridView.DefaultCellStyle.BackColor)
                            curLine += "x";
                        else
                            curLine += " ";

                        streamWriter.WriteLine(curLine);
                    }
                }
            }
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile(false);
        }

        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile(true);
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filename = null;
            dataGridView.Rows.Clear();
            dataGridView.Enabled = false;
            dataGridView.Visible = false;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (ModeCombo.SelectedIndex == 0)
                {
                    dataGridView.Rows[i].Cells[3].Style.SelectionBackColor = colors[3];
                    dataGridView.Rows[i].Cells[4].Style.SelectionBackColor = colors[4];
                    dataGridView.Rows[i].Cells[5].Style.SelectionBackColor = colors[5];
                    dataGridView.Rows[i].Cells[6].Style.SelectionBackColor = colors[6];
                }
                else if (ModeCombo.SelectedIndex == 1)
                {
                    dataGridView.Rows[i].Cells[3].Style.SelectionBackColor = dataGridView.DefaultCellStyle.SelectionBackColor;
                    dataGridView.Rows[i].Cells[4].Style.SelectionBackColor = dataGridView.DefaultCellStyle.SelectionBackColor;
                    dataGridView.Rows[i].Cells[5].Style.SelectionBackColor = dataGridView.DefaultCellStyle.SelectionBackColor;
                    dataGridView.Rows[i].Cells[6].Style.SelectionBackColor = dataGridView.DefaultCellStyle.SelectionBackColor;
                }
            }
        }

        private void dataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            DataGridView grid = dataGridView;
            if (grid.SelectedCells.Count == 1)
            {
                DataGridViewCell cell = grid.SelectedCells[0];
                if (cell.RowIndex < 0 || cell.ColumnIndex < 0)
                    return;

                if (cell.ColumnIndex >= 3 && cell.ColumnIndex <= 7)
                {
                    if (cell.Style.BackColor == grid.DefaultCellStyle.BackColor)
                    {
                        cell.Style.BackColor = colors[cell.ColumnIndex];
                    }
                    else
                    {
                        cell.Style.BackColor = grid.DefaultCellStyle.BackColor;
                    }
                }
            }
            else
            {
                foreach (var cellObj in grid.SelectedCells)
                {
                    DataGridViewCell cell = (DataGridViewCell)cellObj;
                    if (cell.RowIndex < 0 || cell.ColumnIndex < 0)
                        continue;

                    if (cell.ColumnIndex >= 3 && cell.ColumnIndex <= 7)
                    {
                        if (ModeCombo.SelectedIndex == 0)
                        {
                            cell.Style.BackColor = colors[cell.ColumnIndex];
                        }
                        else if (ModeCombo.SelectedIndex == 1)
                        {
                            cell.Style.BackColor = grid.DefaultCellStyle.BackColor;
                        }
                    }
                }
            }
            grid.ClearSelection();
        }

        void AddRow()
        {
            if (dataGridView.Enabled)
            {
                string[] curColumns = { "-",(dataGridView.RowCount + 1).ToString(), ((60 / BPMBox.Value) * (dataGridView.RowCount)).ToString("0.00") + "s",
                    "", "", "", "", "+" };

                int curLineNbr = dataGridView.Rows.Add(curColumns);
                for (int i = 3; i < curColumns.Length - 1; i++)
                {
                    dataGridView.Rows[curLineNbr].Cells[i].Style.BackColor = dataGridView.DefaultCellStyle.BackColor;
                    dataGridView.Rows[curLineNbr].Cells[i].Style.SelectionBackColor = dataGridView.DefaultCellStyle.SelectionBackColor;
                }

                TotalLinesLabel.Text = "Total Lines : " + (curLineNbr + 1).ToString();
                TotalDurationLabel.Text = "Total Duration : " + ((60 / BPMBox.Value) * (curLineNbr)).ToString("0.00") + "s";
            }
        }

        private void PlusBut_Click(object sender, EventArgs e)
        {
            AddRow();
        }

        private void MoinsBut_Click(object sender, EventArgs e)
        {
            if (dataGridView.Enabled)
            {
                if (dataGridView.Rows.GetLastRow(DataGridViewElementStates.None) > 0)
                    dataGridView.Rows.Remove(dataGridView.Rows[dataGridView.Rows.GetLastRow(DataGridViewElementStates.None)]);

                TotalLinesLabel.Text = "Total Lines : " + (dataGridView.Rows.GetLastRow(DataGridViewElementStates.None) + 1).ToString();
                TotalDurationLabel.Text = "Total Duration : " + ((60 / BPMBox.Value) * (dataGridView.Rows.GetLastRow(DataGridViewElementStates.None))).ToString("0.00") + "s";

            }
        }

        private void BPMBox_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView.Rows[i].Cells[2].Value = ((60 / BPMBox.Value) * (i)).ToString("0.00") + "s";
            }
            TotalDurationLabel.Text = "Total Duration : " + ((60 / BPMBox.Value) * (dataGridView.Rows.GetLastRow(DataGridViewElementStates.None))).ToString("0.00") + "s";
        }

        void DeleteRowAt(int _id)
        {
            dataGridView.Rows.RemoveAt(_id);

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView.Rows[i].Cells[1].Value = (i + 1).ToString();
                dataGridView.Rows[i].Cells[2].Value = ((60 / BPMBox.Value) * (i)).ToString("0.00") + "s";
            }

            TotalLinesLabel.Text = "Total Lines : " + (dataGridView.Rows.GetLastRow(DataGridViewElementStates.None) + 1).ToString();
            TotalDurationLabel.Text = "Total Duration : " + ((60 / BPMBox.Value) * (dataGridView.Rows.GetLastRow(DataGridViewElementStates.None))).ToString("0.00") + "s";

        }

        void AddRowAt(int _id)
        {
            string[] curColumns = { "-",(dataGridView.RowCount + 1).ToString(), ((60 / BPMBox.Value) * (dataGridView.RowCount)).ToString("0.00") + "s",
                    "", "", "", "", "+" };
            dataGridView.Rows.Insert(_id + 1, curColumns);
            for (int i = 3; i < curColumns.Length - 1; i++)
            {
                dataGridView.Rows[_id + 1].Cells[i].Style.BackColor = dataGridView.DefaultCellStyle.BackColor;
                dataGridView.Rows[_id + 1].Cells[i].Style.SelectionBackColor = dataGridView.DefaultCellStyle.SelectionBackColor;
            }

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView.Rows[i].Cells[1].Value = (i + 1).ToString();
                dataGridView.Rows[i].Cells[2].Value = ((60 / BPMBox.Value) * (i)).ToString("0.00") + "s";
            }

            TotalLinesLabel.Text = "Total Lines : " + (dataGridView.Rows.GetLastRow(DataGridViewElementStates.None) + 1).ToString();
            TotalDurationLabel.Text = "Total Duration : " + ((60 / BPMBox.Value) * (dataGridView.Rows.GetLastRow(DataGridViewElementStates.None))).ToString("0.00") + "s";
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Enabled)
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                    return;

                DataGridView grid = (DataGridView)sender;
                DataGridViewCell cell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.ColumnIndex == 0 && dataGridView.Rows.GetLastRow(DataGridViewElementStates.None) > 0)
                {
                    DeleteRowAt(cell.RowIndex);
                }
                else if (cell.ColumnIndex == 7)
                {
                    AddRowAt(cell.RowIndex);
                }
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CellClick(sender, e);
        }
    }
}
