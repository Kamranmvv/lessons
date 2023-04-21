namespace PersonGenerator
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
            this.dataGridViewPersons = new System.Windows.Forms.DataGridView();
            this.btnGeneratePerson = new System.Windows.Forms.Button();
            this.btnGetPersonStatistics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersons
            // 
            this.dataGridViewPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersons.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPersons.Name = "dataGridViewPersons";
            this.dataGridViewPersons.RowTemplate.Height = 24;
            this.dataGridViewPersons.Size = new System.Drawing.Size(971, 551);
            this.dataGridViewPersons.TabIndex = 0;
            // 
            // btnGeneratePerson
            // 
            this.btnGeneratePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePerson.Location = new System.Drawing.Point(12, 569);
            this.btnGeneratePerson.Name = "btnGeneratePerson";
            this.btnGeneratePerson.Size = new System.Drawing.Size(444, 131);
            this.btnGeneratePerson.TabIndex = 1;
            this.btnGeneratePerson.Text = "Generate Persons";
            this.btnGeneratePerson.UseVisualStyleBackColor = true;
            this.btnGeneratePerson.Click += new System.EventHandler(this.btnGeneratePerson_Click);
            // 
            // btnGetPersonStatistics
            // 
            this.btnGetPersonStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPersonStatistics.Location = new System.Drawing.Point(480, 569);
            this.btnGetPersonStatistics.Name = "btnGetPersonStatistics";
            this.btnGetPersonStatistics.Size = new System.Drawing.Size(503, 131);
            this.btnGetPersonStatistics.TabIndex = 2;
            this.btnGetPersonStatistics.Text = "Get Person Statistics";
            this.btnGetPersonStatistics.UseVisualStyleBackColor = true;
            this.btnGetPersonStatistics.Click += new System.EventHandler(this.btnGetPersonStatistics_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 712);
            this.Controls.Add(this.btnGetPersonStatistics);
            this.Controls.Add(this.btnGeneratePerson);
            this.Controls.Add(this.dataGridViewPersons);
            this.Name = "Form1";
            this.Text = "Person Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersons;
        private System.Windows.Forms.Button btnGeneratePerson;
        private System.Windows.Forms.Button btnGetPersonStatistics;
    }
}

