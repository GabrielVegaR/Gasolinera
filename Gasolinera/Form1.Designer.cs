namespace Gasolinera
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRegular = new System.Windows.Forms.Button();
            this.btnPremium = new System.Windows.Forms.Button();
            this.btnSuperPremium = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroGalones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnRegular
            // 
            this.btnRegular.Location = new System.Drawing.Point(23, 60);
            this.btnRegular.Name = "btnRegular";
            this.btnRegular.Size = new System.Drawing.Size(99, 90);
            this.btnRegular.TabIndex = 0;
            this.btnRegular.Text = "Regular";
            this.btnRegular.UseVisualStyleBackColor = true;
            this.btnRegular.Click += new System.EventHandler(this.btnRegular_Click);
            // 
            // btnPremium
            // 
            this.btnPremium.Location = new System.Drawing.Point(163, 60);
            this.btnPremium.Name = "btnPremium";
            this.btnPremium.Size = new System.Drawing.Size(99, 90);
            this.btnPremium.TabIndex = 1;
            this.btnPremium.Text = "Premium";
            this.btnPremium.UseVisualStyleBackColor = true;
            this.btnPremium.Click += new System.EventHandler(this.btnPremium_Click);
            // 
            // btnSuperPremium
            // 
            this.btnSuperPremium.Location = new System.Drawing.Point(307, 60);
            this.btnSuperPremium.Name = "btnSuperPremium";
            this.btnSuperPremium.Size = new System.Drawing.Size(99, 90);
            this.btnSuperPremium.TabIndex = 2;
            this.btnSuperPremium.Text = "Super Premium";
            this.btnSuperPremium.UseVisualStyleBackColor = true;
            this.btnSuperPremium.Click += new System.EventHandler(this.btnSuperPremium_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "N de galones";
            // 
            // txtNumeroGalones
            // 
            this.txtNumeroGalones.Location = new System.Drawing.Point(102, 21);
            this.txtNumeroGalones.Name = "txtNumeroGalones";
            this.txtNumeroGalones.Size = new System.Drawing.Size(124, 23);
            this.txtNumeroGalones.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(306, 23);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 184);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroGalones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSuperPremium);
            this.Controls.Add(this.btnPremium);
            this.Controls.Add(this.btnRegular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegular;
        private Button btnPremium;
        private Button btnSuperPremium;
        private Label label1;
        private TextBox txtNumeroGalones;
        private Label label2;
        private Label lblTotal;
        private System.Windows.Forms.Timer timer1;
    }
}