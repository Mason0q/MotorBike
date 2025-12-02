using MotorBike;

namespace MotorBike
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.motorbikeTile1 = new MotorBike.MotorbikeTile();
            this.motorbikeTile2 = new MotorBike.MotorbikeTile();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // motorbikeTile1
            // 
            this.motorbikeTile1.Location = new System.Drawing.Point(12, 12);
            this.motorbikeTile1.Name = "motorbikeTile1";
            this.motorbikeTile1.Size = new System.Drawing.Size(220, 300);
            this.motorbikeTile1.TabIndex = 0;
            // 
            // motorbikeTile2
            // 
            this.motorbikeTile2.Location = new System.Drawing.Point(250, 12);
            this.motorbikeTile2.Name = "motorbikeTile2";
            this.motorbikeTile2.Size = new System.Drawing.Size(220, 300);
            this.motorbikeTile2.TabIndex = 1;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonPrev.Location = new System.Drawing.Point(12, 320);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(220, 50);
            this.buttonPrev.TabIndex = 2;
            this.buttonPrev.Text = "< Назад";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonNext.Location = new System.Drawing.Point(250, 320);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(220, 50);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Вперёд >";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 386);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.motorbikeTile2);
            this.Controls.Add(this.motorbikeTile1);
            this.Name = "Form1";
            this.Text = "Мотоциклы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private MotorbikeTile motorbikeTile1;
        private MotorbikeTile motorbikeTile2;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
    }
}