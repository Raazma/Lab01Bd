namespace Tp01Bd
{
    partial class Ajout_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tb_Description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_Ent = new System.Windows.Forms.ComboBox();
            this.Cb_Type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Ajouter = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Tb_Num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tb_Description
            // 
            this.Tb_Description.Location = new System.Drawing.Point(93, 48);
            this.Tb_Description.Multiline = true;
            this.Tb_Description.Name = "Tb_Description";
            this.Tb_Description.Size = new System.Drawing.Size(150, 59);
            this.Tb_Description.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description";
            // 
            // Cb_Ent
            // 
            this.Cb_Ent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Ent.FormattingEnabled = true;
            this.Cb_Ent.Location = new System.Drawing.Point(104, 123);
            this.Cb_Ent.Name = "Cb_Ent";
            this.Cb_Ent.Size = new System.Drawing.Size(115, 21);
            this.Cb_Ent.TabIndex = 2;
            // 
            // Cb_Type
            // 
            this.Cb_Type.AutoCompleteCustomSource.AddRange(new string[] {
            "ges",
            "ind"});
            this.Cb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Type.FormattingEnabled = true;
            this.Cb_Type.Items.AddRange(new object[] {
            "ges",
            "ind"});
            this.Cb_Type.Location = new System.Drawing.Point(121, 170);
            this.Cb_Type.Name = "Cb_Type";
            this.Cb_Type.Size = new System.Drawing.Size(48, 21);
            this.Cb_Type.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Conpagnie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "type de stage";
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.Location = new System.Drawing.Point(195, 219);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ajouter.TabIndex = 6;
            this.Btn_Ajouter.Text = "Ajouter";
            this.Btn_Ajouter.UseVisualStyleBackColor = true;
            this.Btn_Ajouter.Click += new System.EventHandler(this.Btn_Ajouter_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(104, 219);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 7;
            this.Btn_Cancel.Text = "Annuler";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Tb_Num
            // 
            this.Tb_Num.Location = new System.Drawing.Point(104, 12);
            this.Tb_Num.Name = "Tb_Num";
            this.Tb_Num.Size = new System.Drawing.Size(46, 20);
            this.Tb_Num.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "#Stage";
            // 
            // Ajout_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(301, 254);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tb_Num);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Ajouter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cb_Type);
            this.Controls.Add(this.Cb_Ent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_Description);
            this.Name = "Ajout_Form";
            this.Text = "Ajout_Form";
            this.Load += new System.EventHandler(this.Ajout_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_Ent;
        private System.Windows.Forms.ComboBox Cb_Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Ajouter;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.TextBox Tb_Num;
        private System.Windows.Forms.Label label4;
    }
}