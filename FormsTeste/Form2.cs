using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTeste
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*Carregar Campos na GRID*/
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Id", typeof (Int16)));
            dt.Columns.Add(new DataColumn("Nome", typeof(String)));
            var row = dt.NewRow();
            row["Id"] = 1;
            row["Nome"] = "Nome 1";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Id"] = 2;
            row["Nome"] = "Nome 2";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Id"] = 3;
            row["Nome"] = "Nome 3";
            dt.Rows.Add(row);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DataSource = dt;

        }

        private void btnCarregaSelecionado_Click(object sender, EventArgs e)
        {
var form = Application.OpenForms.OfType<Form1>().First(); // Busca o Form Pai Aberto  
if (form != null) // Caso encontrar o Pai preenche os campos 
{
    //caso nao estiver selecionado nenhum deixa vazio
    form.txtForm1.Text = dataGridView1.CurrentRow != null? dataGridView1.CurrentRow.Cells["Id"].Value.ToString() :"";
    form.txt2Form1.Text = dataGridView1.CurrentRow != null? dataGridView1.CurrentRow.Cells["Nome"].Value.ToString():""; 
}
this.Close();//Fecha o Form Filho
        }
    }
}
