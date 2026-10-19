namespace TeindaWinforms
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
            tb_id_producto = new TextBox();
            tb_cantidad = new TextBox();
            lb_id_prod = new Label();
            label2 = new Label();
            lb_nombre_produto = new Label();
            label4 = new Label();
            btn_guardar_venta = new Button();
            dgv_lista = new DataGridView();
            lb_total = new Label();
            btn_pagar = new Button();
            pcbimg = new PictureBox();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            pantalla2ToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgv_lista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbimg).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tb_id_producto
            // 
            tb_id_producto.Location = new Point(105, 45);
            tb_id_producto.Name = "tb_id_producto";
            tb_id_producto.Size = new Size(100, 23);
            tb_id_producto.TabIndex = 0;
            // 
            // tb_cantidad
            // 
            tb_cantidad.Location = new Point(105, 102);
            tb_cantidad.Name = "tb_cantidad";
            tb_cantidad.Size = new Size(100, 23);
            tb_cantidad.TabIndex = 2;
            // 
            // lb_id_prod
            // 
            lb_id_prod.AutoSize = true;
            lb_id_prod.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_id_prod.Location = new Point(0, 24);
            lb_id_prod.Name = "lb_id_prod";
            lb_id_prod.Size = new Size(145, 32);
            lb_id_prod.TabIndex = 3;
            lb_id_prod.Text = "ID Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 79);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Producto:";
            // 
            // lb_nombre_produto
            // 
            lb_nombre_produto.AutoSize = true;
            lb_nombre_produto.Location = new Point(131, 79);
            lb_nombre_produto.Name = "lb_nombre_produto";
            lb_nombre_produto.Size = new Size(16, 15);
            lb_nombre_produto.TabIndex = 5;
            lb_nombre_produto.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 105);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 6;
            label4.Text = "Cantidad:";
            // 
            // btn_guardar_venta
            // 
            btn_guardar_venta.BackColor = SystemColors.ActiveCaptionText;
            btn_guardar_venta.ForeColor = SystemColors.ButtonHighlight;
            btn_guardar_venta.Location = new Point(219, 71);
            btn_guardar_venta.Name = "btn_guardar_venta";
            btn_guardar_venta.Size = new Size(75, 23);
            btn_guardar_venta.TabIndex = 7;
            btn_guardar_venta.Text = "Agregar";
            btn_guardar_venta.UseVisualStyleBackColor = false;
            btn_guardar_venta.Click += btn_guardar_venta_Click;
            // 
            // dgv_lista
            // 
            dgv_lista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_lista.Location = new Point(80, 150);
            dgv_lista.Name = "dgv_lista";
            dgv_lista.Size = new Size(382, 125);
            dgv_lista.TabIndex = 8;
            // 
            // lb_total
            // 
            lb_total.AutoSize = true;
            lb_total.Location = new Point(362, 131);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(38, 15);
            lb_total.TabIndex = 9;
            lb_total.Text = "label1";
            // 
            // btn_pagar
            // 
            btn_pagar.Location = new Point(219, 281);
            btn_pagar.Name = "btn_pagar";
            btn_pagar.Size = new Size(75, 23);
            btn_pagar.TabIndex = 10;
            btn_pagar.Text = "Pagar";
            btn_pagar.UseVisualStyleBackColor = true;
            btn_pagar.Click += PagarCuenta;
            // 
            // pcbimg
            // 
            pcbimg.Location = new Point(332, 36);
            pcbimg.Name = "pcbimg";
            pcbimg.Size = new Size(100, 50);
            pcbimg.TabIndex = 11;
            pcbimg.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(239, 24);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { pantalla2ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(487, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // pantalla2ToolStripMenuItem
            // 
            pantalla2ToolStripMenuItem.Name = "pantalla2ToolStripMenuItem";
            pantalla2ToolStripMenuItem.Size = new Size(67, 20);
            pantalla2ToolStripMenuItem.Text = "Pantalla2";
            pantalla2ToolStripMenuItem.Click += pantalla2ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(487, 317);
            Controls.Add(button1);
            Controls.Add(pcbimg);
            Controls.Add(btn_pagar);
            Controls.Add(lb_total);
            Controls.Add(dgv_lista);
            Controls.Add(btn_guardar_venta);
            Controls.Add(label4);
            Controls.Add(lb_nombre_produto);
            Controls.Add(label2);
            Controls.Add(lb_id_prod);
            Controls.Add(tb_cantidad);
            Controls.Add(tb_id_producto);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "main";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_lista).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbimg).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_id_producto;
        private TextBox tb_cantidad;
        private Label lb_id_prod;
        private Label label2;
        private Label lb_nombre_produto;
        private Label label4;
        private Button btn_guardar_venta;
        private DataGridView dgv_lista;
        private Label lb_total;
        private Button btn_pagar;
        private PictureBox pcbimg;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem pantalla2ToolStripMenuItem;
    }
}
