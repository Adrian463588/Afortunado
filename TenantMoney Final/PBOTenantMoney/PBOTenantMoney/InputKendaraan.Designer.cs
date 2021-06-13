
namespace PBOTenantMoney
{
    partial class InputKendaraan
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
            this.btnInput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbPlatNomor = new System.Windows.Forms.TextBox();
            this.tbMerek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.OrangeRed;
            this.btnInput.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Bold);
            this.btnInput.ForeColor = System.Drawing.Color.Transparent;
            this.btnInput.Location = new System.Drawing.Point(312, 153);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(137, 44);
            this.btnInput.TabIndex = 16;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.125F);
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "HARGA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.125F);
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "PLAT NOMOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.125F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "MEREK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(175, 99);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(275, 22);
            this.tbHarga.TabIndex = 10;
            // 
            // tbPlatNomor
            // 
            this.tbPlatNomor.Location = new System.Drawing.Point(175, 52);
            this.tbPlatNomor.Name = "tbPlatNomor";
            this.tbPlatNomor.Size = new System.Drawing.Size(275, 22);
            this.tbPlatNomor.TabIndex = 11;
            // 
            // tbMerek
            // 
            this.tbMerek.Location = new System.Drawing.Point(175, 11);
            this.tbMerek.Name = "tbMerek";
            this.tbMerek.Size = new System.Drawing.Size(275, 22);
            this.tbMerek.TabIndex = 12;
            // 
            // InputKendaraan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.tbPlatNomor);
            this.Controls.Add(this.tbMerek);
            this.Name = "InputKendaraan";
            this.Text = "InputKendaraan";
            this.Load += new System.EventHandler(this.InputKendaraan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbPlatNomor;
        private System.Windows.Forms.TextBox tbMerek;
    }
}