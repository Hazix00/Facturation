﻿namespace Facturation
{
    partial class FormReleveElec
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
            this.textBoxNCompt = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxAnnee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTrimestre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNewIndex = new System.Windows.Forms.TextBox();
            this.textBoxNetPayer = new System.Windows.Forms.TextBox();
            this.textBoxPrevIndex = new System.Windows.Forms.TextBox();
            this.textBoxConsommation = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxNpolice = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMotif = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexPrec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNCompt
            // 
            this.textBoxNCompt.Location = new System.Drawing.Point(147, 150);
            this.textBoxNCompt.Name = "textBoxNCompt";
            this.textBoxNCompt.Size = new System.Drawing.Size(164, 20);
            this.textBoxNCompt.TabIndex = 49;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(147, 122);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(164, 20);
            this.textBoxAdress.TabIndex = 50;
            // 
            // textBoxAnnee
            // 
            this.textBoxAnnee.Location = new System.Drawing.Point(147, 178);
            this.textBoxAnnee.Name = "textBoxAnnee";
            this.textBoxAnnee.Size = new System.Drawing.Size(164, 20);
            this.textBoxAnnee.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Année :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "n° Compteur :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(26, 123);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(51, 13);
            this.label29.TabIndex = 46;
            this.label29.Text = "Adresse :";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(26, 96);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(55, 13);
            this.label30.TabIndex = 48;
            this.label30.Text = "n° Police :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Trimèstre :";
            // 
            // comboBoxTrimestre
            // 
            this.comboBoxTrimestre.FormattingEnabled = true;
            this.comboBoxTrimestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxTrimestre.Location = new System.Drawing.Point(147, 206);
            this.comboBoxTrimestre.Name = "comboBoxTrimestre";
            this.comboBoxTrimestre.Size = new System.Drawing.Size(164, 21);
            this.comboBoxTrimestre.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Date :";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(147, 235);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerDate.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Nouvel Index :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Index Précédent :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Consommation :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Net à Payer :";
            // 
            // textBoxNewIndex
            // 
            this.textBoxNewIndex.Location = new System.Drawing.Point(147, 263);
            this.textBoxNewIndex.Name = "textBoxNewIndex";
            this.textBoxNewIndex.Size = new System.Drawing.Size(164, 20);
            this.textBoxNewIndex.TabIndex = 52;
            this.textBoxNewIndex.TextChanged += new System.EventHandler(this.TextBoxNewIndex_TextChanged);
            // 
            // textBoxNetPayer
            // 
            this.textBoxNetPayer.Location = new System.Drawing.Point(135, 291);
            this.textBoxNetPayer.Name = "textBoxNetPayer";
            this.textBoxNetPayer.Size = new System.Drawing.Size(164, 20);
            this.textBoxNetPayer.TabIndex = 51;
            // 
            // textBoxPrevIndex
            // 
            this.textBoxPrevIndex.Location = new System.Drawing.Point(147, 291);
            this.textBoxPrevIndex.Name = "textBoxPrevIndex";
            this.textBoxPrevIndex.Size = new System.Drawing.Size(164, 20);
            this.textBoxPrevIndex.TabIndex = 50;
            // 
            // textBoxConsommation
            // 
            this.textBoxConsommation.Location = new System.Drawing.Point(135, 263);
            this.textBoxConsommation.Name = "textBoxConsommation";
            this.textBoxConsommation.Size = new System.Drawing.Size(164, 20);
            this.textBoxConsommation.TabIndex = 49;
            this.textBoxConsommation.TextChanged += new System.EventHandler(this.TextBoxConsommation_TextChanged);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(249, 508);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 25);
            this.confirm.TabIndex = 56;
            this.confirm.Text = "Confirmer";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(552, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(188, 24);
            this.labelTitle.TabIndex = 48;
            this.labelTitle.Text = "Relevé de l\'éléctricité";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.comboBoxNpolice);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxNetPayer);
            this.groupBox1.Controls.Add(this.textBoxMotif);
            this.groupBox1.Controls.Add(this.textBoxConsommation);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 419);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Données";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Autorisé :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Facturation.Properties.Resources.go;
            this.pictureBox1.Location = new System.Drawing.Point(267, 326);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxNpolice
            // 
            this.comboBoxNpolice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxNpolice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxNpolice.FormattingEnabled = true;
            this.comboBoxNpolice.Location = new System.Drawing.Point(135, 26);
            this.comboBoxNpolice.Name = "comboBoxNpolice";
            this.comboBoxNpolice.Size = new System.Drawing.Size(164, 21);
            this.comboBoxNpolice.TabIndex = 52;
            this.comboBoxNpolice.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNpolice_SelectedIndexChanged);
            this.comboBoxNpolice.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxNpolice_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(135, 337);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 64;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Motif :";
            this.label8.Visible = false;
            // 
            // textBoxMotif
            // 
            this.textBoxMotif.Location = new System.Drawing.Point(133, 372);
            this.textBoxMotif.Name = "textBoxMotif";
            this.textBoxMotif.Size = new System.Drawing.Size(164, 20);
            this.textBoxMotif.TabIndex = 51;
            this.textBoxMotif.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.annee,
            this.Trim,
            this.IndexNew,
            this.IndexPrec,
            this.Consom,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(344, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(942, 428);
            this.dataGridView2.TabIndex = 61;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "N° Police";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Adresse";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // annee
            // 
            this.annee.HeaderText = "Annee";
            this.annee.Name = "annee";
            this.annee.ReadOnly = true;
            // 
            // Trim
            // 
            this.Trim.HeaderText = "Trimmèstre";
            this.Trim.Name = "Trim";
            this.Trim.ReadOnly = true;
            // 
            // IndexNew
            // 
            this.IndexNew.HeaderText = "Nouveau Index";
            this.IndexNew.Name = "IndexNew";
            this.IndexNew.ReadOnly = true;
            // 
            // IndexPrec
            // 
            this.IndexPrec.HeaderText = "Index Précédent";
            this.IndexPrec.Name = "IndexPrec";
            this.IndexPrec.ReadOnly = true;
            // 
            // Consom
            // 
            this.Consom.HeaderText = "Consommation";
            this.Consom.Name = "Consom";
            this.Consom.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "netPayer";
            this.dataGridViewTextBoxColumn3.HeaderText = "Net à Payer";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Rapport";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FormReleveElec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1292, 611);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.comboBoxTrimestre);
            this.Controls.Add(this.textBoxNCompt);
            this.Controls.Add(this.textBoxPrevIndex);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxAnnee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNewIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormReleveElec";
            this.Text = "ReleveEauOuElec";
            this.Load += new System.EventHandler(this.ReleveElec_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNCompt;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxAnnee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTrimestre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNewIndex;
        private System.Windows.Forms.TextBox textBoxNetPayer;
        private System.Windows.Forms.TextBox textBoxPrevIndex;
        private System.Windows.Forms.TextBox textBoxConsommation;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBoxNpolice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn annee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trim;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexPrec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMotif;
    }
}