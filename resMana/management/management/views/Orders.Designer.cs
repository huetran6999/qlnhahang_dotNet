﻿
namespace management
{
    partial class Orders
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
            this.tableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableName,
            this.tableStatus,
            this.openTime});
            this.dataGridView1.Location = new System.Drawing.Point(260, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(526, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rowSelected);
            // 
            // tableName
            // 
            this.tableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tableName.HeaderText = "Name";
            this.tableName.MinimumWidth = 6;
            this.tableName.Name = "tableName";
            // 
            // tableStatus
            // 
            this.tableStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tableStatus.HeaderText = "Status";
            this.tableStatus.MinimumWidth = 6;
            this.tableStatus.Name = "tableStatus";
            // 
            // openTime
            // 
            this.openTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.openTime.HeaderText = "open";
            this.openTime.MinimumWidth = 6;
            this.openTime.Name = "openTime";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dat Ban";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Huy Ban";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tro Lai";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnBack);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(46, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 55);
            this.button4.TabIndex = 4;
            this.button4.Text = "Goi mon";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnCall);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Orders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn openTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}