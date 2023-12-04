
namespace RentACar
{
    partial class FormResult
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picboxCarChosen = new System.Windows.Forms.PictureBox();
            this.btnEndProgram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCarChosen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanks For Ordering";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(509, 93);
            this.label2.TabIndex = 2;
            this.label2.Text = "The vehicle will be parked in our building \r\ncar park ready for pickup by the tim" +
    "e you \r\nget here.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RentACar.Properties.Resources.car_2ndfloor_main_ap_ps_180115_16x9_992;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(547, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 267);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // picboxCarChosen
            // 
            this.picboxCarChosen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxCarChosen.Location = new System.Drawing.Point(80, 115);
            this.picboxCarChosen.Name = "picboxCarChosen";
            this.picboxCarChosen.Size = new System.Drawing.Size(342, 225);
            this.picboxCarChosen.TabIndex = 1;
            this.picboxCarChosen.TabStop = false;
            // 
            // btnEndProgram
            // 
            this.btnEndProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndProgram.Location = new System.Drawing.Point(80, 381);
            this.btnEndProgram.Name = "btnEndProgram";
            this.btnEndProgram.Size = new System.Drawing.Size(342, 73);
            this.btnEndProgram.TabIndex = 4;
            this.btnEndProgram.Text = "Close";
            this.btnEndProgram.UseVisualStyleBackColor = true;
            this.btnEndProgram.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 492);
            this.Controls.Add(this.btnEndProgram);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picboxCarChosen);
            this.Controls.Add(this.label1);
            this.Name = "FormResult";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCarChosen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picboxCarChosen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEndProgram;
    }
}