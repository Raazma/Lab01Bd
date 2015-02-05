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
            this.Tb_Description.Location = new System.Drawing.Point(124, 59);
            this.Tb_Description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tb_Description.MaxLength = 100;
            this.Tb_Description.Multiline = true;
            this.Tb_Description.Name = "Tb_Description";
            this.Tb_Description.Size = new System.Drawing.Size(199, 72);
            this.Tb_Description.TabIndex = 1;
            this.Tb_Description.TextChanged += new System.EventHandler(this.Tb_Description_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description";
            // 
            // Cb_Ent
            // 
            this.Cb_Ent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Ent.FormattingEnabled = true;
            this.Cb_Ent.Location = new System.Drawing.Point(139, 151);
            this.Cb_Ent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cb_Ent.Name = "Cb_Ent";
            this.Cb_Ent.Size = new System.Drawing.Size(152, 24);
            this.Cb_Ent.TabIndex = 3;
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
            this.Cb_Type.Location = new System.Drawing.Point(161, 209);
            this.Cb_Type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cb_Type.Name = "Cb_Type";
            this.Cb_Type.Size = new System.Drawing.Size(63, 24);
            this.Cb_Type.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Conpagnie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "type de stage";
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.Location = new System.Drawing.Point(180, 270);
            this.Btn_Ajouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(100, 28);
            this.Btn_Ajouter.TabIndex = 5;
            this.Btn_Ajouter.Text = "Ajouter";
            this.Btn_Ajouter.UseVisualStyleBackColor = true;
            this.Btn_Ajouter.Click += new System.EventHandler(this.Btn_Ajouter_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(288, 270);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(100, 28);
            this.Btn_Cancel.TabIndex = 6;
            this.Btn_Cancel.Text = "Annuler";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Tb_Num
            // 
            this.Tb_Num.Location = new System.Drawing.Point(139, 15);
            this.Tb_Num.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tb_Num.Name = "Tb_Num";
            this.Tb_Num.Size = new System.Drawing.Size(60, 22);
            this.Tb_Num.TabIndex = 0;
            this.Tb_Num.TextChanged += new System.EventHandler(this.Tb_Num_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "#Stage";
            // 
            // Ajout_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(401, 313);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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