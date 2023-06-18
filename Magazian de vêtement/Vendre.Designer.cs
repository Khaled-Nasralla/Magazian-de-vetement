namespace Magazian_de_vêtement
{
    partial class Vendre
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
            button1=new Button();
            textBox1=new TextBox();
            flowLayoutPanel1=new FlowLayoutPanel();
            button2=new Button();
            typecompoBox1=new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location=new Point(541, 107);
            button1.Name="button1";
            button1.Size=new Size(109, 50);
            button1.TabIndex=0;
            button1.Text="Rechearcher";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=Rechercher_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor=SystemColors.InactiveBorder;
            textBox1.Location=new Point(519, 28);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(150, 23);
            textBox1.TabIndex=1;
            textBox1.Text="Entrez le nom de article";
            textBox1.MouseClick+=textBox1_MouseClick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll=true;
            flowLayoutPanel1.BackColor=SystemColors.ControlLightLight;
            flowLayoutPanel1.BackgroundImageLayout=ImageLayout.Center;
            flowLayoutPanel1.BorderStyle=BorderStyle.Fixed3D;
            flowLayoutPanel1.Location=new Point(12, 12);
            flowLayoutPanel1.Name="flowLayoutPanel1";
            flowLayoutPanel1.Size=new Size(282, 275);
            flowLayoutPanel1.TabIndex=2;
            // 
            // button2
            // 
            button2.Location=new Point(541, 182);
            button2.Name="button2";
            button2.Size=new Size(109, 55);
            button2.TabIndex=3;
            button2.Text="Vendre";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=Vendre_Click;
            // 
            // typecompoBox1
            // 
            typecompoBox1.FlatStyle=FlatStyle.System;
            typecompoBox1.FormattingEnabled=true;
            typecompoBox1.Items.AddRange(new object[] { "T-shirt", "Pull", "Pantalon", "Chaussures" });
            typecompoBox1.Location=new Point(519, 67);
            typecompoBox1.Name="typecompoBox1";
            typecompoBox1.Size=new Size(150, 23);
            typecompoBox1.TabIndex=4;
            typecompoBox1.Text="Déterminer le type";
            // 
            // Vendre
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(698, 296);
            Controls.Add(typecompoBox1);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle=FormBorderStyle.FixedDialog;
            Name="Vendre";
            Text="Vendre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private ComboBox typecompoBox1;
    }
}