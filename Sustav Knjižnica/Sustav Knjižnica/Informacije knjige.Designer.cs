
namespace Sustav_Knjižnica
{
    partial class Informacije_knjige
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
            this.dgvIzdaneKnjige = new System.Windows.Forms.DataGridView();
            this.dgvVraćeneKnjige = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdaneKnjige)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVraćeneKnjige)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(462, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izdane knjige";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(462, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vraćene knjige";
            // 
            // dgvIzdaneKnjige
            // 
            this.dgvIzdaneKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzdaneKnjige.Location = new System.Drawing.Point(12, 51);
            this.dgvIzdaneKnjige.Name = "dgvIzdaneKnjige";
            this.dgvIzdaneKnjige.Size = new System.Drawing.Size(1036, 183);
            this.dgvIzdaneKnjige.TabIndex = 2;
            // 
            // dgvVraćeneKnjige
            // 
            this.dgvVraćeneKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVraćeneKnjige.Location = new System.Drawing.Point(12, 293);
            this.dgvVraćeneKnjige.Name = "dgvVraćeneKnjige";
            this.dgvVraćeneKnjige.Size = new System.Drawing.Size(1036, 207);
            this.dgvVraćeneKnjige.TabIndex = 3;
            // 
            // Informacije_knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1060, 512);
            this.Controls.Add(this.dgvVraćeneKnjige);
            this.Controls.Add(this.dgvIzdaneKnjige);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Informacije_knjige";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacije_knjige";
            this.Load += new System.EventHandler(this.Informacije_knjige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdaneKnjige)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVraćeneKnjige)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvIzdaneKnjige;
        private System.Windows.Forms.DataGridView dgvVraćeneKnjige;
    }
}