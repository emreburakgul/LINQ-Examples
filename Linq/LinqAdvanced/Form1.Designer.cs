
namespace LinqAdvanced
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
            this.btnShow = new System.Windows.Forms.Button();
            this.lstShowList = new System.Windows.Forms.ListBox();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.btnShow3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(196, 44);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(118, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Grupla";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lstShowList
            // 
            this.lstShowList.FormattingEnabled = true;
            this.lstShowList.ItemHeight = 15;
            this.lstShowList.Location = new System.Drawing.Point(404, 31);
            this.lstShowList.Name = "lstShowList";
            this.lstShowList.Size = new System.Drawing.Size(210, 349);
            this.lstShowList.TabIndex = 1;
            // 
            // btnShow2
            // 
            this.btnShow2.Location = new System.Drawing.Point(161, 99);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(184, 23);
            this.btnShow2.TabIndex = 2;
            this.btnShow2.Text = "İki Parametrli Grupla";
            this.btnShow2.UseVisualStyleBackColor = true;
            this.btnShow2.Click += new System.EventHandler(this.btnShow2_Click);
            // 
            // btnShow3
            // 
            this.btnShow3.Location = new System.Drawing.Point(161, 163);
            this.btnShow3.Name = "btnShow3";
            this.btnShow3.Size = new System.Drawing.Size(186, 23);
            this.btnShow3.TabIndex = 3;
            this.btnShow3.Text = "Kategoriye Göre Ürün Sayısı";
            this.btnShow3.UseVisualStyleBackColor = true;
            this.btnShow3.Click += new System.EventHandler(this.btnShow3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow3);
            this.Controls.Add(this.btnShow2);
            this.Controls.Add(this.lstShowList);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListBox lstShowList;
        private System.Windows.Forms.Button btnShow2;
        private System.Windows.Forms.Button btnShow3;
    }
}

