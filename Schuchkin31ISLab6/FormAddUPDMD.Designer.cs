namespace Schuchkin31ISLab6
{
    partial class FormAddUPDMD
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxMileage = new System.Windows.Forms.TextBox();
            this.textBoxHorsepower = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelMiliage = new System.Windows.Forms.Label();
            this.labelHorsepower = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(543, 355);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(155, 40);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxMileage
            // 
            this.textBoxMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxMileage.Location = new System.Drawing.Point(140, 367);
            this.textBoxMileage.Name = "textBoxMileage";
            this.textBoxMileage.Size = new System.Drawing.Size(301, 32);
            this.textBoxMileage.TabIndex = 24;
            this.textBoxMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMileage_KeyPress);
            // 
            // textBoxHorsepower
            // 
            this.textBoxHorsepower.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxHorsepower.Location = new System.Drawing.Point(140, 301);
            this.textBoxHorsepower.Name = "textBoxHorsepower";
            this.textBoxHorsepower.Size = new System.Drawing.Size(301, 32);
            this.textBoxHorsepower.TabIndex = 23;
            this.textBoxHorsepower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHorsepower_KeyPress);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxPrice.Location = new System.Drawing.Point(140, 247);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(301, 32);
            this.textBoxPrice.TabIndex = 22;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxBrand.Location = new System.Drawing.Point(140, 192);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(301, 32);
            this.textBoxBrand.TabIndex = 21;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxModel.Location = new System.Drawing.Point(140, 136);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(301, 32);
            this.textBoxModel.TabIndex = 20;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(31, 52);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 40);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelMiliage
            // 
            this.labelMiliage.AutoSize = true;
            this.labelMiliage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelMiliage.Location = new System.Drawing.Point(36, 369);
            this.labelMiliage.Name = "labelMiliage";
            this.labelMiliage.Size = new System.Drawing.Size(85, 26);
            this.labelMiliage.TabIndex = 18;
            this.labelMiliage.Text = "Пробег";
            // 
            // labelHorsepower
            // 
            this.labelHorsepower.AutoSize = true;
            this.labelHorsepower.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelHorsepower.Location = new System.Drawing.Point(36, 307);
            this.labelHorsepower.Name = "labelHorsepower";
            this.labelHorsepower.Size = new System.Drawing.Size(50, 26);
            this.labelHorsepower.TabIndex = 17;
            this.labelHorsepower.Text = "Л/С";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelPrice.Location = new System.Drawing.Point(36, 249);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(64, 26);
            this.labelPrice.TabIndex = 16;
            this.labelPrice.Text = "Цена";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelBrand.Location = new System.Drawing.Point(36, 194);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(77, 26);
            this.labelBrand.TabIndex = 15;
            this.labelBrand.Text = "Марка";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelModel.Location = new System.Drawing.Point(36, 138);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(92, 26);
            this.labelModel.TabIndex = 14;
            this.labelModel.Text = "Модель";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(471, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 141);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormAddUPDMD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxMileage);
            this.Controls.Add(this.textBoxHorsepower);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelMiliage);
            this.Controls.Add(this.labelHorsepower);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAddUPDMD";
            this.Text = "FormAddUPDMD";
            this.Load += new System.EventHandler(this.FormAddUPDMD_Load);
            this.Click += new System.EventHandler(this.FormAddUPDMD_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxMileage;
        private System.Windows.Forms.TextBox textBoxHorsepower;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelMiliage;
        private System.Windows.Forms.Label labelHorsepower;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}