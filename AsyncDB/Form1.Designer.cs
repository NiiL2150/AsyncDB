namespace AsyncDB
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSync = new System.Windows.Forms.Button();
            this.buttonAsync = new System.Windows.Forms.Button();
            this.buttonHello = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSync
            // 
            this.buttonSync.Location = new System.Drawing.Point(412, 406);
            this.buttonSync.Name = "buttonSync";
            this.buttonSync.Size = new System.Drawing.Size(87, 23);
            this.buttonSync.TabIndex = 1;
            this.buttonSync.Text = "Get data sync";
            this.buttonSync.UseVisualStyleBackColor = true;
            this.buttonSync.Click += new System.EventHandler(this.buttonSync_Click);
            // 
            // buttonAsync
            // 
            this.buttonAsync.Location = new System.Drawing.Point(505, 406);
            this.buttonAsync.Name = "buttonAsync";
            this.buttonAsync.Size = new System.Drawing.Size(107, 23);
            this.buttonAsync.TabIndex = 2;
            this.buttonAsync.Text = "Get data async 1";
            this.buttonAsync.UseVisualStyleBackColor = true;
            this.buttonAsync.Click += new System.EventHandler(this.buttonAsync_Click);
            // 
            // buttonHello
            // 
            this.buttonHello.Location = new System.Drawing.Point(12, 406);
            this.buttonHello.Name = "buttonHello";
            this.buttonHello.Size = new System.Drawing.Size(75, 23);
            this.buttonHello.TabIndex = 3;
            this.buttonHello.Text = "Hello";
            this.buttonHello.UseVisualStyleBackColor = true;
            this.buttonHello.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.buttonHello);
            this.Controls.Add(this.buttonAsync);
            this.Controls.Add(this.buttonSync);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSync;
        private System.Windows.Forms.Button buttonAsync;
        private System.Windows.Forms.Button buttonHello;
    }
}

