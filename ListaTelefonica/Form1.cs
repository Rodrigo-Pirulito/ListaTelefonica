using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaTelefonica
{
    public partial class Form1 : Form
    {
        string[][] list;
        readonly int max = 100;
        string idAtual;
        public Form1()
        {
            InitializeComponent();
            list = new string[max][];

        }
        int Length(string[] e)
        {
            int itens = 0;
            for (int i = 0; i < e.Length; i++)
            {
                if (e[i] != null)
                {
                    itens++;
                }
            }
            return itens;
        }
        int Length(string[][] e)
        {
            int items = 0;
            for (int i = 0; i < e.Length; i++)
            {
                if (e[i] != null)
                {
                    items++;
                }
            }
            return items;
        }
        void Atualizar()
        {
            TelTable.Rows.Clear();
            for (int i = 0; i < Length(list); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(TelTable);
                for (int j = 0; j < Length(list[i]); j++)
                {
                    if (list[i][j] == null)
                        continue;
                    row.Cells[j].Value = list[i][j];
                }
                TelTable.Rows.Add(row);
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(NameTextBox.Text) || !TelTextBox.MaskFull)
            {
                MessageBox.Show("insira nome e telefone");
                return;
            }
            if(Length(list) == max)
            {
                MessageBox.Show("Lista cheia");
                return;
            }

            int id = 1;
            if(Length(list)> 0)
            {
                id = int.Parse(list[Length(list) - 1][0]) + 1;
            }
            if(idAtual != null)
            {
                for (int i = 0; i < Length(list); i++)
                {
                    if (list[i][0] == idAtual)
                    {
                        list[i][1] = NameTextBox.Text;
                        list[i][2] = TelTextBox.Text;
                        Atualizar();
                        apagarTxt();
                        return;
                    }
                }
            }
            list[Length(list)] = new string[] {id.ToString(), NameTextBox.Text, TelTextBox.Text } ;
            Atualizar();
            apagarTxt();

        }
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if(TelTable.SelectedCells.Count == 0)
            {
                MessageBox.Show("selecione uma célula");
                return;
            }

            DataGridViewCell cell = TelTable.SelectedCells[0];
            int linha = cell.RowIndex;
            string id = TelTable.Rows[linha].Cells[0].Value.ToString();
            int index = 0;
            for (index = 0; index < Length(list) && list[index][0] != id; index++) ;

            DialogResult r = MessageBox.Show($"Deseja mesmo remover {list[index][1]}?", "", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                for (int i = index; i < Length(list) - 1; i++)
                {
                    list[i] = list[i + 1];
                }
                list[Length(list) - 1] = null;
                Atualizar();
            }
        
        }
        void apagarTxt()
        {
            NameTextBox.Text = "";
            TelTextBox.Text = "";
            lblid.Text = "";
            idAtual = null;
        }

        private void TelTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || TelTable.SelectedCells.Count == 0) {
                return;
            }
            int linha = TelTable.SelectedCells[0].RowIndex;
            if (TelTable.Rows[linha].Cells[0].Value.ToString() == idAtual)
            {
                TelTable.ClearSelection();
                AddBtn.Text = "Adicionar";
                apagarTxt();
                return;
            }
            idAtual = TelTable.Rows[linha].Cells[0].Value.ToString();
            lblid.Text = idAtual;
            AddBtn.Text = "Alterar";
            NameTextBox.Text = TelTable.Rows[TelTable.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
            TelTextBox.Text = TelTable.Rows[TelTable.SelectedCells[0].RowIndex].Cells[2].Value.ToString();

        }
    }
}
