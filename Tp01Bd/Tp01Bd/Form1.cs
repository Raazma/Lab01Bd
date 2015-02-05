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
                MessageBox.Show("La conection a échouer");
            }
        }

        public void FilledListBox()
        {
             if (oraconn.State == ConnectionState.Open)
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
                 else
            {
                MessageBox.Show("Connection intérompue à la Base de donnée");
            }
        }

        public void FilledInfo()
        {
             ClearBinding();
             if (oraconn.State == ConnectionState.Open)
            {
             string Sql = "select * from stages where nument in (select nument from entreprises where noment = '" + Lb_Ent.SelectedItem.ToString() +"')";
             OracleDataAdapter orDataAdaptr = new OracleDataAdapter(Sql, oraconn);
             orDataAdaptr.Fill(lesINFoCoalis, "resEnt");

            Lab_Num.DataBindings.Add("TEXT", lesINFoCoalis, "resEnt.numstage");
            Tb_Description.DataBindings.Add("TEXT", lesINFoCoalis, "resEnt.Description");
            Lab_Type.DataBindings.Add("TEXT", lesINFoCoalis, "resEnt.typestg");
                  }
                 else
            {
                MessageBox.Show("Connection intérompue à la Base de donnée");
            }
            //enable ou disable le bouton modifier
            Btn_Modifier.Enabled = verifymodif();
            Btn_Suivant.Enabled=true;
            Btn_precedent.Enabled=false;
            if (this.BindingContext[lesINFoCoalis, "resEnt"].Count < 1)
            {
                Btn_Suprimer.Enabled = false;
                Btn_Suivant.Enabled = false;
            }
            else
                Btn_Suprimer.Enabled = true;
            
        
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
            if (this.BindingContext[lesINFoCoalis, "resEnt"].Count > this.BindingContext[lesINFoCoalis, "resEnt"].Position)
            {
                this.BindingContext[  lesINFoCoalis, "resEnt"].Position += 1;
                Btn_precedent.Enabled = true;
            }
            if (this.BindingContext[lesINFoCoalis, "resEnt"].Count-1 <= this.BindingContext[lesINFoCoalis, "resEnt"].Position)
            {
                Btn_Suivant.Enabled = false;
            }
        }

        private void Btn_precedent_Click(object sender, EventArgs e)
        {
            
            if (this.BindingContext[lesINFoCoalis, "resEnt"].Position>=0)
            {
                this.BindingContext[lesINFoCoalis, "resEnt"].Position -= 1;
                Btn_Suivant.Enabled = true;
            }
            if (this.BindingContext[lesINFoCoalis, "resEnt"].Position <=0)
            {
                Btn_precedent.Enabled = false;
            }
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
             if (oraconn.State == ConnectionState.Open)
            {
            string sql = "Update stages set Description = '" + Tb_Description.Text + "' where numstage = '" + Lab_Num.Text + "'" ;
            OracleCommand oraclecomm = new OracleCommand(sql, oraconn);
            oraclecomm.CommandType = CommandType.Text;
            int nombreligne = oraclecomm.ExecuteNonQuery();
             }
                 else
            {
                MessageBox.Show("Connection intérompue à la Base de donnée");
            }
            //MessageBox.Show(nombreligne.ToString() + " Ligne Modifier");
        }

        private void Btn_Suprimer_Click(object sender, EventArgs e)
        {
            DeleteFromPostuler();
            DeleteFromStage();
        }

        public void DeleteFromStage()
        {
             if (oraconn.State == ConnectionState.Open)
            {
            string sql = "delete from stages where numstage = " + Lab_Num.Text;
            OracleCommand oraclecomm = new OracleCommand(sql, oraconn);
            oraclecomm.CommandType = CommandType.Text;
            int nombreligne = oraclecomm.ExecuteNonQuery();
            
            //MessageBox.Show(nombreligne.ToString() + " Ligne Suprimmer");
            FilledInfo();
                  }
                 else
            {
                MessageBox.Show("Connection intérompue à la Base de donnée");
            }
        
        }
        public void DeleteFromPostuler()
        {
             if (oraconn.State == ConnectionState.Open)
            {
            string sql = "delete from postuler where numstage = " + Lab_Num.Text;
            OracleCommand oraclecomm = new OracleCommand(sql, oraconn);
            oraclecomm.CommandType = CommandType.Text;
            int nombreligne = oraclecomm.ExecuteNonQuery();
            }
             else
             {
                 MessageBox.Show("Connection intérompue à la Base de donnée");
             }
            //MessageBox.Show(nombreligne.ToString() + " Ligne Suprimmer");

        }

        private void Btn_Ajout_Click(object sender, EventArgs e)
        {
            Ajout_Form form = new Ajout_Form(oraconn);
            form.ShowDialog();
            FilledInfo();
            
        }

        private void Tb_Description_TextChanged(object sender, EventArgs e)
        {
            Btn_Modifier.Enabled = verifymodif();
        }

        private bool verifymodif()
        {
            bool valide = false;
            if(String.IsNullOrEmpty(Tb_Description.Text))
            {
                Tb_Description.BackColor=Color.Red;
                valide |= !false;
            }
             else
            {
                Tb_Description.BackColor = Color.White;
                valide |= !true;
            }

            if (this.BindingContext[lesINFoCoalis, "resEnt"].Count < 1)
                valide |= !false;
            else
                valide |= !true;

            return !valide;
        }

    }
}
