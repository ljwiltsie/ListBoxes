namespace ListBoxes
{
    partial class ListBox
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
            this.lblNums = new System.Windows.Forms.Label();
            this.lblHeroes = new System.Windows.Forms.Label();
            this.btnNewNums = new System.Windows.Forms.Button();
            this.btnSortNums = new System.Windows.Forms.Button();
            this.btnNewHoreos = new System.Windows.Forms.Button();
            this.btnSortHeroes = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lstHeroes = new System.Windows.Forms.ListBox();
            this.lblNumRemove = new System.Windows.Forms.Label();
            this.lblHeroAdd = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblHeroRemove = new System.Windows.Forms.Label();
            this.btnRemoveAllNums = new System.Windows.Forms.Button();
            this.btnRemoveNum = new System.Windows.Forms.Button();
            this.btnAddHero = new System.Windows.Forms.Button();
            this.btnRemoveHero = new System.Windows.Forms.Button();
            this.txtRemoveHero = new System.Windows.Forms.TextBox();
            this.txtAddHero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNums
            // 
            this.lblNums.AutoSize = true;
            this.lblNums.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNums.Location = new System.Drawing.Point(84, 28);
            this.lblNums.Name = "lblNums";
            this.lblNums.Size = new System.Drawing.Size(119, 29);
            this.lblNums.TabIndex = 0;
            this.lblNums.Text = "Numbers";
            // 
            // lblHeroes
            // 
            this.lblHeroes.AutoSize = true;
            this.lblHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroes.Location = new System.Drawing.Point(331, 28);
            this.lblHeroes.Name = "lblHeroes";
            this.lblHeroes.Size = new System.Drawing.Size(98, 29);
            this.lblHeroes.TabIndex = 1;
            this.lblHeroes.Text = "Heroes";
            // 
            // btnNewNums
            // 
            this.btnNewNums.Location = new System.Drawing.Point(86, 60);
            this.btnNewNums.Name = "btnNewNums";
            this.btnNewNums.Size = new System.Drawing.Size(75, 23);
            this.btnNewNums.TabIndex = 2;
            this.btnNewNums.Text = "New List";
            this.btnNewNums.UseVisualStyleBackColor = true;
            // 
            // btnSortNums
            // 
            this.btnSortNums.Location = new System.Drawing.Point(167, 60);
            this.btnSortNums.Name = "btnSortNums";
            this.btnSortNums.Size = new System.Drawing.Size(75, 23);
            this.btnSortNums.TabIndex = 3;
            this.btnSortNums.Text = "Sort";
            this.btnSortNums.UseVisualStyleBackColor = true;
            // 
            // btnNewHoreos
            // 
            this.btnNewHoreos.Location = new System.Drawing.Point(336, 60);
            this.btnNewHoreos.Name = "btnNewHoreos";
            this.btnNewHoreos.Size = new System.Drawing.Size(75, 23);
            this.btnNewHoreos.TabIndex = 4;
            this.btnNewHoreos.Text = "New List";
            this.btnNewHoreos.UseVisualStyleBackColor = true;
            // 
            // btnSortHeroes
            // 
            this.btnSortHeroes.Location = new System.Drawing.Point(417, 60);
            this.btnSortHeroes.Name = "btnSortHeroes";
            this.btnSortHeroes.Size = new System.Drawing.Size(75, 23);
            this.btnSortHeroes.TabIndex = 5;
            this.btnSortHeroes.Text = "Sort";
            this.btnSortHeroes.UseVisualStyleBackColor = true;
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 16;
            this.lstNumbers.Location = new System.Drawing.Point(86, 89);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(156, 148);
            this.lstNumbers.TabIndex = 6;
            // 
            // lstHeroes
            // 
            this.lstHeroes.FormattingEnabled = true;
            this.lstHeroes.ItemHeight = 16;
            this.lstHeroes.Location = new System.Drawing.Point(336, 89);
            this.lstHeroes.Name = "lstHeroes";
            this.lstHeroes.Size = new System.Drawing.Size(156, 148);
            this.lstHeroes.TabIndex = 7;
            // 
            // lblNumRemove
            // 
            this.lblNumRemove.AutoSize = true;
            this.lblNumRemove.Location = new System.Drawing.Point(83, 240);
            this.lblNumRemove.Name = "lblNumRemove";
            this.lblNumRemove.Size = new System.Drawing.Size(178, 17);
            this.lblNumRemove.TabIndex = 8;
            this.lblNumRemove.Text = "Select a number to remove";
            // 
            // lblHeroAdd
            // 
            this.lblHeroAdd.AutoSize = true;
            this.lblHeroAdd.Location = new System.Drawing.Point(333, 240);
            this.lblHeroAdd.Name = "lblHeroAdd";
            this.lblHeroAdd.Size = new System.Drawing.Size(170, 17);
            this.lblHeroAdd.TabIndex = 9;
            this.lblHeroAdd.Text = "Enter a hero name to add";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(83, 335);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // lblHeroRemove
            // 
            this.lblHeroRemove.AutoSize = true;
            this.lblHeroRemove.Location = new System.Drawing.Point(333, 291);
            this.lblHeroRemove.Name = "lblHeroRemove";
            this.lblHeroRemove.Size = new System.Drawing.Size(193, 17);
            this.lblHeroRemove.TabIndex = 11;
            this.lblHeroRemove.Text = "Enter a hero name to remove";
            // 
            // btnRemoveAllNums
            // 
            this.btnRemoveAllNums.Location = new System.Drawing.Point(167, 260);
            this.btnRemoveAllNums.Name = "btnRemoveAllNums";
            this.btnRemoveAllNums.Size = new System.Drawing.Size(94, 23);
            this.btnRemoveAllNums.TabIndex = 12;
            this.btnRemoveAllNums.Text = "Remove All";
            this.btnRemoveAllNums.UseVisualStyleBackColor = true;
            // 
            // btnRemoveNum
            // 
            this.btnRemoveNum.Location = new System.Drawing.Point(86, 260);
            this.btnRemoveNum.Name = "btnRemoveNum";
            this.btnRemoveNum.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveNum.TabIndex = 13;
            this.btnRemoveNum.Text = "Remove";
            this.btnRemoveNum.UseVisualStyleBackColor = true;
            // 
            // btnAddHero
            // 
            this.btnAddHero.Location = new System.Drawing.Point(451, 260);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(75, 23);
            this.btnAddHero.TabIndex = 14;
            this.btnAddHero.Text = "Add";
            this.btnAddHero.UseVisualStyleBackColor = true;
            // 
            // btnRemoveHero
            // 
            this.btnRemoveHero.Location = new System.Drawing.Point(451, 315);
            this.btnRemoveHero.Name = "btnRemoveHero";
            this.btnRemoveHero.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveHero.TabIndex = 15;
            this.btnRemoveHero.Text = "Remove";
            this.btnRemoveHero.UseVisualStyleBackColor = true;
            // 
            // txtRemoveHero
            // 
            this.txtRemoveHero.Location = new System.Drawing.Point(336, 316);
            this.txtRemoveHero.Name = "txtRemoveHero";
            this.txtRemoveHero.Size = new System.Drawing.Size(109, 22);
            this.txtRemoveHero.TabIndex = 16;
            // 
            // txtAddHero
            // 
            this.txtAddHero.Location = new System.Drawing.Point(336, 261);
            this.txtAddHero.Name = "txtAddHero";
            this.txtAddHero.Size = new System.Drawing.Size(109, 22);
            this.txtAddHero.TabIndex = 17;
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.txtAddHero);
            this.Controls.Add(this.txtRemoveHero);
            this.Controls.Add(this.btnRemoveHero);
            this.Controls.Add(this.btnAddHero);
            this.Controls.Add(this.btnRemoveNum);
            this.Controls.Add(this.btnRemoveAllNums);
            this.Controls.Add(this.lblHeroRemove);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblHeroAdd);
            this.Controls.Add(this.lblNumRemove);
            this.Controls.Add(this.lstHeroes);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnSortHeroes);
            this.Controls.Add(this.btnNewHoreos);
            this.Controls.Add(this.btnSortNums);
            this.Controls.Add(this.btnNewNums);
            this.Controls.Add(this.lblHeroes);
            this.Controls.Add(this.lblNums);
            this.Name = "ListBox";
            this.Text = "Using Lists";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNums;
        private System.Windows.Forms.Label lblHeroes;
        private System.Windows.Forms.Button btnNewNums;
        private System.Windows.Forms.Button btnSortNums;
        private System.Windows.Forms.Button btnNewHoreos;
        private System.Windows.Forms.Button btnSortHeroes;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.ListBox lstHeroes;
        private System.Windows.Forms.Label lblNumRemove;
        private System.Windows.Forms.Label lblHeroAdd;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblHeroRemove;
        private System.Windows.Forms.Button btnRemoveAllNums;
        private System.Windows.Forms.Button btnRemoveNum;
        private System.Windows.Forms.Button btnAddHero;
        private System.Windows.Forms.Button btnRemoveHero;
        private System.Windows.Forms.TextBox txtRemoveHero;
        private System.Windows.Forms.TextBox txtAddHero;
    }
}

