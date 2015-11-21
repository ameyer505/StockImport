namespace ImportStockDataGUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.cb_integratedSecurity = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_import = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_server = new System.Windows.Forms.TextBox();
            this.tb_database = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_symbol = new System.Windows.Forms.TextBox();
            this.cb_importAllStocks = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_allTime = new System.Windows.Forms.RadioButton();
            this.rb_oneWeek = new System.Windows.Forms.RadioButton();
            this.tb_newSymbol = new System.Windows.Forms.TextBox();
            this.tb_newName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_exchange = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_addNewStock = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database :";
            // 
            // cb_integratedSecurity
            // 
            this.cb_integratedSecurity.AutoSize = true;
            this.cb_integratedSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_integratedSecurity.Location = new System.Drawing.Point(21, 84);
            this.cb_integratedSecurity.Margin = new System.Windows.Forms.Padding(4);
            this.cb_integratedSecurity.Name = "cb_integratedSecurity";
            this.cb_integratedSecurity.Size = new System.Drawing.Size(171, 24);
            this.cb_integratedSecurity.TabIndex = 2;
            this.cb_integratedSecurity.Text = "Integrated Security";
            this.cb_integratedSecurity.UseVisualStyleBackColor = true;
            this.cb_integratedSecurity.CheckedChanged += new System.EventHandler(this.cbIntegratedSecurity_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password :";
            // 
            // btn_import
            // 
            this.btn_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.Location = new System.Drawing.Point(13, 324);
            this.btn_import.Margin = new System.Windows.Forms.Padding(4);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(179, 55);
            this.btn_import.TabIndex = 5;
            this.btn_import.Text = "Import Stock Data";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stock Symbol :";
            // 
            // tb_server
            // 
            this.tb_server.Location = new System.Drawing.Point(97, 15);
            this.tb_server.Margin = new System.Windows.Forms.Padding(4);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(599, 22);
            this.tb_server.TabIndex = 7;
            // 
            // tb_database
            // 
            this.tb_database.Location = new System.Drawing.Point(124, 46);
            this.tb_database.Margin = new System.Windows.Forms.Padding(4);
            this.tb_database.Name = "tb_database";
            this.tb_database.Size = new System.Drawing.Size(570, 22);
            this.tb_database.TabIndex = 8;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(152, 118);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(544, 22);
            this.tb_username.TabIndex = 9;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(152, 147);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(544, 22);
            this.tb_password.TabIndex = 10;
            // 
            // tb_symbol
            // 
            this.tb_symbol.Location = new System.Drawing.Point(46, 294);
            this.tb_symbol.Margin = new System.Windows.Forms.Padding(4);
            this.tb_symbol.Name = "tb_symbol";
            this.tb_symbol.Size = new System.Drawing.Size(234, 22);
            this.tb_symbol.TabIndex = 11;
            // 
            // cb_importAllStocks
            // 
            this.cb_importAllStocks.AutoSize = true;
            this.cb_importAllStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_importAllStocks.Location = new System.Drawing.Point(21, 243);
            this.cb_importAllStocks.Name = "cb_importAllStocks";
            this.cb_importAllStocks.Size = new System.Drawing.Size(158, 24);
            this.cb_importAllStocks.TabIndex = 12;
            this.cb_importAllStocks.Text = "Import All Stocks";
            this.cb_importAllStocks.UseVisualStyleBackColor = true;
            this.cb_importAllStocks.CheckedChanged += new System.EventHandler(this.cbImportAllStocks_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Log:";
            // 
            // tb_log
            // 
            this.tb_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_log.Location = new System.Drawing.Point(13, 409);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.Size = new System.Drawing.Size(681, 131);
            this.tb_log.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_allTime);
            this.groupBox1.Controls.Add(this.rb_oneWeek);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 52);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import Duration";
            // 
            // rb_allTime
            // 
            this.rb_allTime.AutoSize = true;
            this.rb_allTime.Location = new System.Drawing.Point(167, 25);
            this.rb_allTime.Name = "rb_allTime";
            this.rb_allTime.Size = new System.Drawing.Size(91, 24);
            this.rb_allTime.TabIndex = 1;
            this.rb_allTime.Text = "All Time";
            this.rb_allTime.UseVisualStyleBackColor = true;
            // 
            // rb_oneWeek
            // 
            this.rb_oneWeek.AutoSize = true;
            this.rb_oneWeek.Checked = true;
            this.rb_oneWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_oneWeek.Location = new System.Drawing.Point(7, 25);
            this.rb_oneWeek.Name = "rb_oneWeek";
            this.rb_oneWeek.Size = new System.Drawing.Size(108, 24);
            this.rb_oneWeek.TabIndex = 0;
            this.rb_oneWeek.TabStop = true;
            this.rb_oneWeek.Text = "One Week";
            this.rb_oneWeek.UseVisualStyleBackColor = true;
            // 
            // tb_newSymbol
            // 
            this.tb_newSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_newSymbol.Location = new System.Drawing.Point(421, 182);
            this.tb_newSymbol.Name = "tb_newSymbol";
            this.tb_newSymbol.Size = new System.Drawing.Size(275, 27);
            this.tb_newSymbol.TabIndex = 20;
            // 
            // tb_newName
            // 
            this.tb_newName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_newName.Location = new System.Drawing.Point(421, 220);
            this.tb_newName.Name = "tb_newName";
            this.tb_newName.Size = new System.Drawing.Size(275, 27);
            this.tb_newName.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(323, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Exchange :";
            // 
            // cb_exchange
            // 
            this.cb_exchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_exchange.FormattingEnabled = true;
            this.cb_exchange.Items.AddRange(new object[] {
            "NYSE",
            "NASDAQ"});
            this.cb_exchange.Location = new System.Drawing.Point(421, 253);
            this.cb_exchange.Name = "cb_exchange";
            this.cb_exchange.Size = new System.Drawing.Size(275, 28);
            this.cb_exchange.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(323, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Name :";
            // 
            // btn_addNewStock
            // 
            this.btn_addNewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNewStock.Location = new System.Drawing.Point(510, 324);
            this.btn_addNewStock.Name = "btn_addNewStock";
            this.btn_addNewStock.Size = new System.Drawing.Size(186, 55);
            this.btn_addNewStock.TabIndex = 23;
            this.btn_addNewStock.Text = "Add New Stock";
            this.btn_addNewStock.UseVisualStyleBackColor = true;
            this.btn_addNewStock.Click += new System.EventHandler(this.btnAddNewStock_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Symbol :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 554);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_addNewStock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.cb_exchange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_importAllStocks);
            this.Controls.Add(this.tb_newName);
            this.Controls.Add(this.tb_newSymbol);
            this.Controls.Add(this.tb_symbol);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_database);
            this.Controls.Add(this.tb_server);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_integratedSecurity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Import Stock Data";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_integratedSecurity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.TextBox tb_database;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_symbol;
        private System.Windows.Forms.CheckBox cb_importAllStocks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_allTime;
        private System.Windows.Forms.RadioButton rb_oneWeek;
        private System.Windows.Forms.TextBox tb_newSymbol;
        private System.Windows.Forms.TextBox tb_newName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_exchange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_addNewStock;
        private System.Windows.Forms.Label label8;
    }
}

