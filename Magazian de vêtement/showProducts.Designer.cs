namespace Magazian_de_vêtement
{
    partial class showProducts
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
            flowLayoutPanel=new FlowLayoutPanel();
            panel=new Panel();
            panel1=new Panel();
            label4=new Label();
            label6=new Label();
            label2=new Label();
            label3=new Label();
            label1=new Label();
            Close1=new Button();
            Delete=new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll=true;
            flowLayoutPanel.BackColor=Color.White;
            flowLayoutPanel.BorderStyle=BorderStyle.Fixed3D;
            flowLayoutPanel.Location=new Point(136, 2);
            flowLayoutPanel.Name="flowLayoutPanel";
            flowLayoutPanel.Size=new Size(176, 459);
            flowLayoutPanel.TabIndex=0;
            // 
            // panel
            // 
            panel.AutoSize=true;
            panel.BorderStyle=BorderStyle.FixedSingle;
            panel.Location=new Point(339, 12);
            panel.Name="panel";
            panel.Padding=new Padding(10);
            panel.Size=new Size(138, 84);
            panel.TabIndex=1;
            panel.Text="Product Details";
            panel.Visible=false;
            // 
            // panel1
            // 
            panel1.BackColor=Color.White;
            panel1.BorderStyle=BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location=new Point(2, 2);
            panel1.Name="panel1";
            panel1.Size=new Size(128, 459);
            panel1.TabIndex=1;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(11, 76);
            label4.Name="label4";
            label4.Size=new Size(59, 15);
            label4.TabIndex=5;
            label4.Text="Pantalons";
            label4.Click+=Pantalon_Click;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(11, 51);
            label6.Name="label6";
            label6.Size=new Size(27, 15);
            label6.TabIndex=7;
            label6.Text="Pull";
            label6.Click+=Pull_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(11, 7);
            label2.Name="label2";
            label2.Size=new Size(62, 15);
            label2.TabIndex=1;
            label2.Text="VêtEments";
            label2.Click+=AllVêtements_Click;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(11, 100);
            label3.Name="label3";
            label3.Size=new Size(67, 15);
            label3.TabIndex=4;
            label3.Text="Chaussures";
            label3.Click+=Chaussure;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(11, 27);
            label1.Name="label1";
            label1.Size=new Size(42, 15);
            label1.TabIndex=0;
            label1.Text="T-Shirt";
            label1.Click+=Tshirt_Click;
            // 
            // Close1
            // 
            Close1.Location=new Point(422, 410);
            Close1.Name="Close1";
            Close1.Size=new Size(55, 36);
            Close1.TabIndex=2;
            Close1.Text="Fermer";
            Close1.UseVisualStyleBackColor=true;
            Close1.Click+=Close_Click;
            // 
            // Delete
            // 
            Delete.Location=new Point(325, 397);
            Delete.Name="Delete";
            Delete.Size=new Size(91, 49);
            Delete.TabIndex=3;
            Delete.Text="Supprimer";
            Delete.UseVisualStyleBackColor=true;
            Delete.Click+=Delete_Click;
            // 
            // showProducts
            // 
            AutoScaleDimensions=new SizeF(96F, 96F);
            AutoScaleMode=AutoScaleMode.Dpi;
            AutoSize=true;
            AutoSizeMode=AutoSizeMode.GrowAndShrink;
            ClientSize=new Size(485, 464);
            Controls.Add(Delete);
            Controls.Add(Close1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel);
            Name="showProducts";
            ShowIcon=false;
            StartPosition=FormStartPosition.CenterScreen;
            Text="showProducts";
            VisibleChanged+=ShowProductsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private Panel panel;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button Close1;
        private Button Delete;
        private Label label4;
        private Label label6;
        private Label label3;
    }
}