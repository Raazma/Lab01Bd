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
    public partial class Ajout_Form : Form
    {
        OracleConnection oracon = new OracleConnection();
        public Ajout_Form(OracleConnection oraconn )
        {
            InitializeComponent();
            oracon = oraconn;
        }

        private void Ajout_Form_Load(object sender, EventArgs e)
        {

            FilledCbEnt();
            Cb_Type.SelectedIndex = 0;
        }

        public void FilledCbEnt()
        { 
        
        
         string commande = "SELECT noment from entreprises";

           OracleCommand oraclecomm = new OracleCommand(commande, oracon);
            oraclecomm.CommandType = CommandType.Text;
            OracleDataReader oraread = oraclecomm.ExecuteReader();
           while (oraread.Read())
           {

               string ligne = oraread.GetString(0);         
               Cb_Ent.Items.Add(ligne.ToString());
            }         
           oraread.Close();

           if(Cb_Ent.Items.Count > 0)
           Cb_Ent.SelectedIndex = 0;
        
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            if (oracon.State == ConnectionState.Open)
            {
                string sql = "INSERT INTO stages (numstage , DESCRIPTION , typestg , numEnt)" +
                                    "values (:Lenum, :Descri, :letype,( select nument from entreprises where noment  = :lenument ) )";//,'ges','Xper'
                OracleCommand oraclecomm = new OracleCommand(sql, oracon);
                OracleParameter num = new OracleParameter(":Lenum", OracleDbType.Int32);
                OracleParameter Descrip = new OracleParameter(":Descri", OracleDbType.Varchar2, 100);
                OracleParameter thetype = new OracleParameter(":letype", OracleDbType.Char, 3);
                OracleParameter numentreprise = new OracleParameter(":lenument", OracleDbType.Varchar2, 40);
                num.Value = Tb_Num.Text;
                Descrip.Value = Tb_Description.Text;
                thetype.Value = Cb_Type.SelectedItem.ToString();
                numentreprise.Value = Cb_Ent.SelectedItem.ToString();
                oraclecomm.Parameters.Add(num);
                oraclecomm.Parameters.Add(Descrip);
                oraclecomm.Parameters.Add(thetype);
                oraclecomm.Parameters.Add(numentreprise);

                int i = oraclecomm.ExecuteNonQuery();
                MessageBox.Show(i.ToString() + " Ligne Inserer");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
          
        }

    
    }
}
