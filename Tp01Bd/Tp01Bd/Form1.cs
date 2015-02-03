using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Tp01Bd
{
    public partial class Form1 : Form
    {
       public OracleConnection oraconn = new OracleConnection();
        DataSet lesINFoCoalis = new DataSet();
        public Form1()
        {
            InitializeComponent();            
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            Connection();
            FilledListBox();          
           
        }
        public void Connection()
        {

            string Dsource = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
              "(HOST=205.237.244.251)(PORT=1521)))" + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";
            string chainedeconnexion = "DATA SOURCE =" + Dsource + ";USER ID =  PAQUETTE;PASSWORD = ORACLE1";
            try
            {
                oraconn.ConnectionString = chainedeconnexion;
                oraconn.Open();
            }

            catch (OracleException ex)
            {
                MessageBox.Show("La conection a echouer");
            }
        }

        public void FilledListBox()
        {
            string Sql = "Select  NomEnt from entreprises";
            OracleCommand ObjSelct = new OracleCommand(Sql, oraconn);
            OracleDataReader ObjeRead = ObjSelct.ExecuteReader();
            while (ObjeRead.Read())
            {
                string Ligne = ObjeRead.GetString(0);
                Lb_Ent.Items.Add(Ligne);
            }

           if(Lb_Ent.Items.Count > 0) 
           Lb_Ent.SelectedIndex = 1;//le premier il affiche rien c'est plus beau
        }

        public void FilledInfo()
        {
             ClearBinding();
             string Sql = "select * from stages where nument in (select nument from entreprises where noment = '" + Lb_Ent.SelectedItem.ToString() +"')";
             OracleDataAdapter orDataAdaptr = new OracleDataAdapter(Sql, oraconn);
             orDataAdaptr.Fill(lesINFoCoalis, "resEnt");

            Lab_Num.DataBindings.Add("TEXT", lesINFoCoalis, "resEnt.numstage");
            Tb_Description.DataBindings.Add("TEXT", lesINFoCoalis, "resEnt.Description");
            Lab_Type.DataBindings.Add("TEXT", lesINFoCoalis, "resEnt.typestg");
        
        }

        public void ClearBinding()
        {
            lesINFoCoalis.Clear();
            Lab_Num.DataBindings.Clear();
            Tb_Description.DataBindings.Clear();
            Lab_Type.DataBindings.Clear();    
        }
        private void Lb_Ent_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilledInfo();
        }

        private void Btn_Suivant_Click(object sender, EventArgs e)
        {           
          this.BindingContext[  lesINFoCoalis, "resEnt"].Position += 1;
        }

        private void Btn_precedent_Click(object sender, EventArgs e)
        {
            this.BindingContext[lesINFoCoalis, "resEnt"].Position -= 1;
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            string sql = "Update stages set Description = '" + Tb_Description.Text + "' where numstage = '" + Lab_Num.Text + "'" ;
            OracleCommand oraclecomm = new OracleCommand(sql, oraconn);
            oraclecomm.CommandType = CommandType.Text;
            int nombreligne = oraclecomm.ExecuteNonQuery();

            MessageBox.Show(nombreligne.ToString() + " Ligne Modifier");
        }

        private void Btn_Suprimer_Click(object sender, EventArgs e)
        {
            DeleteFromPostuler();
            DeleteFromStage();
        }

        public void DeleteFromStage()
        {
            string sql = "delete from stages where numstage = " + Lab_Num.Text;
            OracleCommand oraclecomm = new OracleCommand(sql, oraconn);
            oraclecomm.CommandType = CommandType.Text;
            int nombreligne = oraclecomm.ExecuteNonQuery();

            MessageBox.Show(nombreligne.ToString() + " Ligne Suprimmer");
        
        }
        public void DeleteFromPostuler()
        {
            string sql = "delete from postuler where numstage = " + Lab_Num.Text;
            OracleCommand oraclecomm = new OracleCommand(sql, oraconn);
            oraclecomm.CommandType = CommandType.Text;
            int nombreligne = oraclecomm.ExecuteNonQuery();

            MessageBox.Show(nombreligne.ToString() + " Ligne Suprimmer");

        }

        private void Btn_Ajout_Click(object sender, EventArgs e)
        {
            Ajout_Form form = new Ajout_Form(oraconn);
            form.ShowDialog();
        }

    }
}
