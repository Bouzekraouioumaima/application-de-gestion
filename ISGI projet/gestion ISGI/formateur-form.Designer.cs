namespace gestion_ISGI
{
    partial class formateur_form
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
            this.nom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtabs = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtanc = new System.Windows.Forms.TextBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.btnsup = new System.Windows.Forms.Button();
            this.btntrier = new System.Windows.Forms.Button();
            this.btnvider = new System.Windows.Forms.Button();
            this.btnquit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsalaire = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(254, 26);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(211, 24);
            this.nom.TabIndex = 0;
            this.nom.Text = "‌formation de formateur";
            this.nom.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "absence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "filiere";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "nom";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(115, 78);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 5;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(471, 78);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(100, 20);
            this.txtprenom.TabIndex = 6;
            // 
            // txtabs
            // 
            this.txtabs.Location = new System.Drawing.Point(471, 131);
            this.txtabs.Name = "txtabs";
            this.txtabs.Size = new System.Drawing.Size(100, 20);
            this.txtabs.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(12, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "l\'anciennter";
            // 
            // txtanc
            // 
            this.txtanc.Location = new System.Drawing.Point(115, 181);
            this.txtanc.Name = "txtanc";
            this.txtanc.Size = new System.Drawing.Size(100, 20);
            this.txtanc.TabIndex = 11;
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(64, 430);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(75, 23);
            this.btnajouter.TabIndex = 12;
            this.btnajouter.Text = "AJOUTER";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(171, 430);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(75, 23);
            this.btnmod.TabIndex = 13;
            this.btnmod.Text = "MODIFIER";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btnsup
            // 
            this.btnsup.Location = new System.Drawing.Point(285, 430);
            this.btnsup.Name = "btnsup";
            this.btnsup.Size = new System.Drawing.Size(75, 23);
            this.btnsup.TabIndex = 14;
            this.btnsup.Text = "SUPPRIMER";
            this.btnsup.UseVisualStyleBackColor = true;
            this.btnsup.Click += new System.EventHandler(this.btnsup_Click);
            // 
            // btntrier
            // 
            this.btntrier.Location = new System.Drawing.Point(390, 430);
            this.btntrier.Name = "btntrier";
            this.btntrier.Size = new System.Drawing.Size(75, 23);
            this.btntrier.TabIndex = 15;
            this.btntrier.Text = "TRIER";
            this.btntrier.UseVisualStyleBackColor = true;
            this.btntrier.Click += new System.EventHandler(this.btntrier_Click);
            // 
            // btnvider
            // 
            this.btnvider.Location = new System.Drawing.Point(496, 430);
            this.btnvider.Name = "btnvider";
            this.btnvider.Size = new System.Drawing.Size(75, 23);
            this.btnvider.TabIndex = 16;
            this.btnvider.Text = "VIDER";
            this.btnvider.UseVisualStyleBackColor = true;
            this.btnvider.Click += new System.EventHandler(this.btnvider_Click);
            // 
            // btnquit
            // 
            this.btnquit.Location = new System.Drawing.Point(596, 430);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(75, 23);
            this.btnquit.TabIndex = 17;
            this.btnquit.Text = "QUITTER";
            this.btnquit.UseVisualStyleBackColor = true;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "TDI",
            "TRI",
            "TDM",
            "TSC"});
            this.comboBox1.Location = new System.Drawing.Point(115, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "salaire";
            // 
            // txtsalaire
            // 
            this.txtsalaire.Location = new System.Drawing.Point(471, 184);
            this.txtsalaire.Name = "txtsalaire";
            this.txtsalaire.Size = new System.Drawing.Size(100, 20);
            this.txtsalaire.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "nom";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "prenom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "filiere";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "absence";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "l\'anciennter";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "salaire";
            this.Column6.Name = "Column6";
            // 
            // formateur_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 484);
            this.Controls.Add(this.txtsalaire);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnquit);
            this.Controls.Add(this.btnvider);
            this.Controls.Add(this.btntrier);
            this.Controls.Add(this.btnsup);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.txtanc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtabs);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nom);
            this.Name = "formateur_form";
            this.Text = "formateur_form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtabs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtanc;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btnsup;
        private System.Windows.Forms.Button btntrier;
        private System.Windows.Forms.Button btnvider;
        private System.Windows.Forms.Button btnquit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsalaire;
    }
}