namespace MySimpleRestouraunt
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
            this.label1 = new System.Windows.Forms.Label();
            this.Chiken = new System.Windows.Forms.RadioButton();
            this.Egg = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.submitrequest = new System.Windows.Forms.Button();
            this.copyrequest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.quality = new System.Windows.Forms.Label();
            this.preparefood = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // Chiken
            // 
            this.Chiken.Location = new System.Drawing.Point(17, 42);
            this.Chiken.Name = "Chiken";
            this.Chiken.Size = new System.Drawing.Size(58, 20);
            this.Chiken.TabIndex = 1;
            this.Chiken.TabStop = true;
            this.Chiken.Text = "Chiken";
            this.Chiken.UseVisualStyleBackColor = true;
            // 
            // Egg
            // 
            this.Egg.Location = new System.Drawing.Point(101, 42);
            this.Egg.Name = "Egg";
            this.Egg.Size = new System.Drawing.Size(47, 20);
            this.Egg.TabIndex = 2;
            this.Egg.TabStop = true;
            this.Egg.Text = "Egg";
            this.Egg.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(54, 88);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(39, 20);
            this.quantity.TabIndex = 4;
            // 
            // submitrequest
            // 
            this.submitrequest.Font = new System.Drawing.Font("Permanent Marker", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.submitrequest.Location = new System.Drawing.Point(111, 88);
            this.submitrequest.Name = "submitrequest";
            this.submitrequest.Size = new System.Drawing.Size(147, 20);
            this.submitrequest.TabIndex = 5;
            this.submitrequest.Text = "Submit new Request";
            this.submitrequest.UseVisualStyleBackColor = true;
            this.submitrequest.Click += new System.EventHandler(this.submitrequest_Click);
            // 
            // copyrequest
            // 
            this.copyrequest.Location = new System.Drawing.Point(13, 117);
            this.copyrequest.Name = "copyrequest";
            this.copyrequest.Size = new System.Drawing.Size(244, 26);
            this.copyrequest.TabIndex = 6;
            this.copyrequest.Text = "Copy the previous request";
            this.copyrequest.UseVisualStyleBackColor = true;
            this.copyrequest.Click += new System.EventHandler(this.copyrequest_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Egg Quality:";
            // 
            // quality
            // 
            this.quality.Location = new System.Drawing.Point(85, 157);
            this.quality.Name = "quality";
            this.quality.Size = new System.Drawing.Size(24, 22);
            this.quality.TabIndex = 8;
            this.quality.Text = "64";
            // 
            // preparefood
            // 
            this.preparefood.Location = new System.Drawing.Point(13, 182);
            this.preparefood.Name = "preparefood";
            this.preparefood.Size = new System.Drawing.Size(244, 23);
            this.preparefood.TabIndex = 9;
            this.preparefood.Text = "Prepare Food";
            this.preparefood.UseVisualStyleBackColor = true;
            this.preparefood.Click += new System.EventHandler(this.preparefood_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Results";
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Location = new System.Drawing.Point(15, 234);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(241, 131);
            this.result.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(280, 368);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.preparefood);
            this.Controls.Add(this.quality);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.copyrequest);
            this.Controls.Add(this.submitrequest);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Egg);
            this.Controls.Add(this.Chiken);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SimpleRestaurant";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label result;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button preparefood;

        private System.Windows.Forms.Label quality;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button copyrequest;

        private System.Windows.Forms.Button submitrequest;

        private System.Windows.Forms.TextBox quantity;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.RadioButton Chiken;
        private System.Windows.Forms.RadioButton Egg;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}