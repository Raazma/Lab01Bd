namespace Tp01Bd
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lb_Ent = new System.Windows.Forms.ListBox();
            this.Btn_precedent = new System.Windows.Forms.Button();
            this.Btn_Suivant = new System.Windows.Forms.Button();
            this.Tb_Description = new System.Windows.Forms.TextBox();
            this.Lab_Num = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lab_Type = new System.Windows.Forms.Label();
            this.Btn_Modifier = new System.Windows.Forms.Button();
            this.Btn_Suprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Ajout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_Ent
            // 
            this.Lb_Ent.FormattingEnabled = true;
            this.Lb_Ent.ItemHeight = 16;
            this.Lb_Ent.Location = new System.Drawing.Point(35, 76);
            this.Lb_Ent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Lb_Ent.Name = "Lb_Ent";
            this.Lb_Ent.Size = new System.Drawing.Size(159, 148);
            this.Lb_Ent.TabIndex = 0;
            this.Lb_Ent.SelectedIndexChanged += new System.EventHandler(this.Lb_Ent_SelectedIndexChanged);
            // 
            // Btn_precedent
            // 
            this.Btn_precedent.Location = new System.Drawing.Point(364, 209);
            this.Btn_precedent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_precedent.Name = "Btn_precedent";
            this.Btn_precedent.Size = new System.Drawing.Size(37, 28);
            this.Btn_precedent.TabIndex = 1;
            this.Btn_precedent.Text = "<<";
            this.Btn_precedent.UseVisualStyleBackColor = true;
            this.Btn_precedent.Click += new System.EventHandler(this.Btn_precedent_Click);
            // 
            // Btn_Suivant
            // 
            this.Btn_Suivant.Location = new System.Drawing.Point(409, 209);
            this.Btn_Suivant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Suivant.Name = "Btn_Suivant";
            this.Btn_Suivant.Size = new System.Drawing.Size(40, 28);
            this.Btn_Suivant.TabIndex = 2;
            this.Btn_Suivant.Text = ">>";
            this.Btn_Suivant.UseVisualStyleBackColor = true;
            this.Btn_Suivant.Click += new System.EventHandler(this.Btn_Suivant_Click);
            // 
            // Tb_Description
            // 
            this.Tb_Description.Location = new System.Drawing.Point(283, 101);
            this.Tb_Description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tb_Description.Multiline = true;
            this.Tb_Description.Name = "Tb_Description";
            this.Tb_Description.Size = new System.Drawing.Size(217, 52);
            this.Tb_Description.TabIndex = 3;
            this.Tb_Description.TextChanged += new System.EventHandler(this.Tb_Description_TextChanged);
            // 
            // Lab_Num
            // 
            this.Lab_Num.AutoSize = true;
            this.Lab_Num.Location = new System.Drawing.Point(309, 64);
            this.Lab_Num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_Num.Name = "Lab_Num";
            this.Lab_Num.Size = new System.Drawing.Size(0, 17);
            this.Lab_Num.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // Lab_Type
            // 
            this.Lab_Type.AutoSize = true;
            this.Lab_Type.Location = new System.Drawing.Point(321, 177);
            this.Lab_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_Type.Name = "Lab_Type";
            this.Lab_Type.Size = new System.Drawing.Size(0, 17);
            this.Lab_Type.TabIndex = 6;
            // 
            // Btn_Modifier
            // 
            this.Btn_Modifier.Location = new System.Drawing.Point(457, 209);
            this.Btn_Modifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Modifier.Name = "Btn_Modifier";
            this.Btn_Modifier.Size = new System.Drawing.Size(76, 28);
            this.Btn_Modifier.TabIndex = 7;
            this.Btn_Modifier.Text = "Modifier";
            this.Btn_Modifier.UseVisualStyleBackColor = true;
            this.Btn_Modifier.Click += new System.EventHandler(this.Btn_Modifier_Click);
            // 
            // Btn_Suprimer
            // 
            this.Btn_Suprimer.Location = new System.Drawing.Point(275, 209);
            this.Btn_Suprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Suprimer.Name = "Btn_Suprimer";
            this.Btn_Suprimer.Size = new System.Drawing.Size(81, 28);
            this.Btn_Suprimer.TabIndex = 8;
            this.Btn_Suprimer.Text = "Suprimer";
            this.Btn_Suprimer.UseVisualStyleBackColor = true;
            this.Btn_Suprimer.Click += new System.EventHandler(this.Btn_Suprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Entreprises";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "#stage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Type de stage";
            // 
            // Btn_Ajout
            // 
            this.Btn_Ajout.Location = new System.Drawing.Point(439, 245);
            this.Btn_Ajout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Ajout.Name = "Btn_Ajout";
            this.Btn_Ajout.Size = new System.Drawing.Size(80, 38);
            this.Btn_Ajout.TabIndex = 12;
            this.Btn_Ajout.Text = "Ajouter";
            this.Btn_Ajout.UseVisualStyleBackColor = true;
            this.Btn_Ajout.Click += new System.EventHandler(this.Btn_Ajout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 298);
            this.Controls.Add(this.Btn_Ajout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Suprimer);
            this.Controls.Add(this.Btn_Modifier);
            this.Controls.Add(this.Lab_Type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lab_Num);
            this.Controls.Add(this.Tb_Description);
            this.Controls.Add(this.Btn_Suivant);
            this.Controls.Add(this.Btn_precedent);
            this.Controls.Add(this.Lb_Ent);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "xXX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lb_Ent;
        private System.Windows.Forms.Button Btn_precedent;
        private System.Windows.Forms.Button Btn_Suivant;
        private System.Windows.Forms.TextBox Tb_Description;
        private System.Windows.Forms.Label Lab_Num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lab_Type;
        private System.Windows.Forms.Button Btn_Modifier;
        private System.Windows.Forms.Button Btn_Suprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Ajout;

    }
}

