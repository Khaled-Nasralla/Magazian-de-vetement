namespace Magazian_de_vêtement
{
    partial class Activité
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
            flowLayoutPanel1=new FlowLayoutPanel();
            button1=new Button();
            panel=new Panel();
            button2=new Button();
            button3=new Button();
            button4=new Button();
            button5=new Button();
            label1=new Label();
            totalDeVente=new Panel();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll=true;
            flowLayoutPanel1.BackColor=Color.White;
            flowLayoutPanel1.BorderStyle=BorderStyle.Fixed3D;
            flowLayoutPanel1.Location=new Point(1, 1);
            flowLayoutPanel1.Name="flowLayoutPanel1";
            flowLayoutPanel1.Size=new Size(204, 384);
            flowLayoutPanel1.TabIndex=6;
            // 
            // button1
            // 
            button1.Location=new Point(211, 118);
            button1.Name="button1";
            button1.Size=new Size(106, 42);
            button1.TabIndex=2;
            button1.Text="Supprimé";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=Supprimer_button;
            // 
            // panel
            // 
            panel.Location=new Point(211, 12);
            panel.Name="panel";
            panel.Size=new Size(200, 100);
            panel.TabIndex=0;
            panel.Visible=false;
            // 
            // button2
            // 
            button2.FlatStyle=FlatStyle.System;
            button2.Location=new Point(211, 12);
            button2.Name="button2";
            button2.Size=new Size(106, 52);
            button2.TabIndex=0;
            button2.Text="Actvitie";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=Activite_Click;
            // 
            // button3
            // 
            button3.Location=new Point(211, 70);
            button3.Name="button3";
            button3.Size=new Size(106, 42);
            button3.TabIndex=1;
            button3.Text="Vendu";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=Vendu_Click;
            // 
            // button4
            // 
            button4.Location=new Point(211, 166);
            button4.Name="button4";
            button4.Size=new Size(106, 42);
            button4.TabIndex=3;
            button4.Text="Rendre";
            button4.UseVisualStyleBackColor=true;
            button4.Click+=Rendre_Click;
            // 
            // button5
            // 
            button5.Location=new Point(211, 214);
            button5.Name="button5";
            button5.Size=new Size(106, 42);
            button5.TabIndex=2;
            button5.Text="Fermer";
            button5.UseVisualStyleBackColor=true;
            button5.Click+=Fermer_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(230, 316);
            label1.Name="label1";
            label1.Size=new Size(0, 15);
            label1.TabIndex=0;
            // 
            // totalDeVente
            // 
            totalDeVente.Location=new Point(211, 262);
            totalDeVente.Name="totalDeVente";
            totalDeVente.Size=new Size(106, 123);
            totalDeVente.TabIndex=7;
            // 
            // Activité
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSize=true;
            ClientSize=new Size(468, 388);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Name="Activité";
            Text="Activité Récent";
            Load+=Activité_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Panel panel;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Panel totalDeVente;
    }
}