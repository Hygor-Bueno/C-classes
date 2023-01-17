namespace FormsInWindow
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Txt_name = new System.Windows.Forms.TextBox();
            this.Lbl_result = new System.Windows.Forms.Label();
            this.Btn_confirm = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pd_PrintPage = new System.Windows.Forms.TextBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.printComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maisUmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dividirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListData = new System.Windows.Forms.ListView();
            this.DateItem = new System.Windows.Forms.DateTimePicker();
            this.QuantityItem = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnNewWindow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityItem)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_name
            // 
            this.Txt_name.Location = new System.Drawing.Point(38, 108);
            this.Txt_name.Name = "Txt_name";
            this.Txt_name.Size = new System.Drawing.Size(100, 20);
            this.Txt_name.TabIndex = 1;
            this.Txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // Lbl_result
            // 
            this.Lbl_result.AutoSize = true;
            this.Lbl_result.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_result.Location = new System.Drawing.Point(34, 170);
            this.Lbl_result.Name = "Lbl_result";
            this.Lbl_result.Size = new System.Drawing.Size(39, 21);
            this.Lbl_result.TabIndex = 2;
            this.Lbl_result.Text = "N/P";
            this.Lbl_result.Click += new System.EventHandler(this.lbl_result_Click);
            // 
            // Btn_confirm
            // 
            this.Btn_confirm.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_confirm.Location = new System.Drawing.Point(38, 200);
            this.Btn_confirm.Name = "Btn_confirm";
            this.Btn_confirm.Size = new System.Drawing.Size(100, 28);
            this.Btn_confirm.TabIndex = 3;
            this.Btn_confirm.Text = "Confirmar";
            this.Btn_confirm.UseVisualStyleBackColor = true;
            this.Btn_confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(191, 200);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(80, 28);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.BtnNewWindow);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ListData);
            this.panel1.Controls.Add(this.Pd_PrintPage);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.printComboBox);
            this.panel1.Controls.Add(this.Btn_confirm);
            this.panel1.Controls.Add(this.QuantityItem);
            this.panel1.Controls.Add(this.Txt_name);
            this.panel1.Controls.Add(this.DateItem);
            this.panel1.Controls.Add(this.Lbl_result);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 657);
            this.panel1.TabIndex = 7;
            // 
            // Pd_PrintPage
            // 
            this.Pd_PrintPage.Location = new System.Drawing.Point(339, 86);
            this.Pd_PrintPage.Multiline = true;
            this.Pd_PrintPage.Name = "Pd_PrintPage";
            this.Pd_PrintPage.Size = new System.Drawing.Size(541, 443);
            this.Pd_PrintPage.TabIndex = 10;
            this.Pd_PrintPage.TextChanged += new System.EventHandler(this.Pd_PrintPage_TextChanged);
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(759, 535);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(121, 37);
            this.btn_print.TabIndex = 9;
            this.btn_print.Text = "Imprimir";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // printComboBox
            // 
            this.printComboBox.FormattingEnabled = true;
            this.printComboBox.Location = new System.Drawing.Point(339, 535);
            this.printComboBox.Name = "printComboBox";
            this.printComboBox.Size = new System.Drawing.Size(246, 21);
            this.printComboBox.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem,
            this.maisUmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1240, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.testeToolStripMenuItem.Text = "Teste";
            // 
            // maisUmToolStripMenuItem
            // 
            this.maisUmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menosToolStripMenuItem,
            this.dividirToolStripMenuItem});
            this.maisUmToolStripMenuItem.Name = "maisUmToolStripMenuItem";
            this.maisUmToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.maisUmToolStripMenuItem.Text = "Mais um";
            // 
            // menosToolStripMenuItem
            // 
            this.menosToolStripMenuItem.Name = "menosToolStripMenuItem";
            this.menosToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.menosToolStripMenuItem.Text = "Menos";
            // 
            // dividirToolStripMenuItem
            // 
            this.dividirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doisToolStripMenuItem});
            this.dividirToolStripMenuItem.Name = "dividirToolStripMenuItem";
            this.dividirToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.dividirToolStripMenuItem.Text = "Dividir";
            // 
            // doisToolStripMenuItem
            // 
            this.doisToolStripMenuItem.Name = "doisToolStripMenuItem";
            this.doisToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.doisToolStripMenuItem.Text = "Dois";
            // 
            // ListData
            // 
            this.ListData.HideSelection = false;
            this.ListData.Location = new System.Drawing.Point(38, 237);
            this.ListData.Name = "ListData";
            this.ListData.Size = new System.Drawing.Size(278, 319);
            this.ListData.TabIndex = 12;
            this.ListData.UseCompatibleStateImageBehavior = false;
            this.ListData.SelectedIndexChanged += new System.EventHandler(this.ListData_SelectedIndexChanged);
            // 
            // DateItem
            // 
            this.DateItem.CalendarForeColor = System.Drawing.Color.Chocolate;
            this.DateItem.CalendarMonthBackground = System.Drawing.Color.Chocolate;
            this.DateItem.CalendarTitleBackColor = System.Drawing.Color.Chocolate;
            this.DateItem.CalendarTitleForeColor = System.Drawing.Color.Chocolate;
            this.DateItem.CalendarTrailingForeColor = System.Drawing.Color.Chocolate;
            this.DateItem.Location = new System.Drawing.Point(38, 147);
            this.DateItem.Name = "DateItem";
            this.DateItem.Size = new System.Drawing.Size(278, 20);
            this.DateItem.TabIndex = 5;
            // 
            // QuantityItem
            // 
            this.QuantityItem.Location = new System.Drawing.Point(228, 109);
            this.QuantityItem.Name = "QuantityItem";
            this.QuantityItem.Size = new System.Drawing.Size(88, 20);
            this.QuantityItem.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data:";
            // 
            // BtnNewWindow
            // 
            this.BtnNewWindow.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewWindow.Location = new System.Drawing.Point(277, 200);
            this.BtnNewWindow.Name = "BtnNewWindow";
            this.BtnNewWindow.Size = new System.Drawing.Size(39, 28);
            this.BtnNewWindow.TabIndex = 16;
            this.BtnNewWindow.Text = "+";
            this.BtnNewWindow.UseVisualStyleBackColor = true;
            this.BtnNewWindow.Click += new System.EventHandler(this.BtnNewWindow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EPP_XXIII";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_name;
        private System.Windows.Forms.Label Lbl_result;
        private System.Windows.Forms.Button Btn_confirm;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maisUmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dividirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doisToolStripMenuItem;
        private System.Windows.Forms.ComboBox printComboBox;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.TextBox Pd_PrintPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListData;
        private System.Windows.Forms.NumericUpDown QuantityItem;
        private System.Windows.Forms.DateTimePicker DateItem;
        private System.Windows.Forms.Button BtnNewWindow;
    }
}

