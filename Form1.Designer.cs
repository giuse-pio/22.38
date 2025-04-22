namespace _22._38
{
    partial class Form1
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btmAdd = new System.Windows.Forms.Button();
            this.btmSottra = new System.Windows.Forms.Button();
            this.btmMolti = new System.Windows.Forms.Button();
            this.btmDiv = new System.Windows.Forms.Button();
            this.lstRis = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(117, 52);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(143, 20);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(117, 89);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(143, 20);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // btmAdd
            // 
            this.btmAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAdd.Location = new System.Drawing.Point(145, 134);
            this.btmAdd.Name = "btmAdd";
            this.btmAdd.Size = new System.Drawing.Size(91, 32);
            this.btmAdd.TabIndex = 2;
            this.btmAdd.Text = "+";
            this.btmAdd.UseVisualStyleBackColor = true;
            this.btmAdd.Click += new System.EventHandler(this.btmAdd_Click);
            // 
            // btmSottra
            // 
            this.btmSottra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSottra.Location = new System.Drawing.Point(145, 172);
            this.btmSottra.Name = "btmSottra";
            this.btmSottra.Size = new System.Drawing.Size(90, 32);
            this.btmSottra.TabIndex = 3;
            this.btmSottra.Text = "-";
            this.btmSottra.UseVisualStyleBackColor = true;
            this.btmSottra.Click += new System.EventHandler(this.btmSottra_Click);
            // 
            // btmMolti
            // 
            this.btmMolti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmMolti.Location = new System.Drawing.Point(145, 210);
            this.btmMolti.Name = "btmMolti";
            this.btmMolti.Size = new System.Drawing.Size(90, 32);
            this.btmMolti.TabIndex = 4;
            this.btmMolti.Text = "x";
            this.btmMolti.UseVisualStyleBackColor = true;
            this.btmMolti.Click += new System.EventHandler(this.btmMolti_Click);
            // 
            // btmDiv
            // 
            this.btmDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmDiv.Location = new System.Drawing.Point(144, 248);
            this.btmDiv.Name = "btmDiv";
            this.btmDiv.Size = new System.Drawing.Size(91, 32);
            this.btmDiv.TabIndex = 5;
            this.btmDiv.Text = "/";
            this.btmDiv.UseVisualStyleBackColor = true;
            this.btmDiv.Click += new System.EventHandler(this.btmDiv_Click);
            // 
            // lstRis
            // 
            this.lstRis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRis.FormattingEnabled = true;
            this.lstRis.Location = new System.Drawing.Point(340, 52);
            this.lstRis.Name = "lstRis";
            this.lstRis.Size = new System.Drawing.Size(293, 225);
            this.lstRis.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "numero 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 334);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRis);
            this.Controls.Add(this.btmDiv);
            this.Controls.Add(this.btmMolti);
            this.Controls.Add(this.btmSottra);
            this.Controls.Add(this.btmAdd);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btmAdd;
        private System.Windows.Forms.Button btmSottra;
        private System.Windows.Forms.Button btmMolti;
        private System.Windows.Forms.Button btmDiv;
        private System.Windows.Forms.ListBox lstRis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

