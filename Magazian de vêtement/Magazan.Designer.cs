using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;

namespace Magazian_de_vêtement
{
    partial class Magazan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Magazan));
            magazian=new Label();
            pictureBox1=new PictureBox();
            button1=new Button();
            button2=new Button();
            button3=new Button();
            button4=new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // magazian
            // 
            magazian.AutoSize=true;
            magazian.Location=new Point(163, 163);
            magazian.Name="magazian";
            magazian.Size=new Size(0, 15);
            magazian.TabIndex=0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image=(Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location=new Point(-6, -4);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(657, 411);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=1;
            pictureBox1.TabStop=false;
            // 
            // button1
            // 
            button1.Location=new Point(248, 57);
            button1.Name="button1";
            button1.Size=new Size(189, 49);
            button1.TabIndex=2;
            button1.Text="Ajouter Article";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=btnAjouter_Click;
            // 
            // button2
            // 
            button2.Location=new Point(248, 200);
            button2.Name="button2";
            button2.Size=new Size(189, 49);
            button2.TabIndex=3;
            button2.Text="Tout les Articles";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=btnShowProducts_Click;
            // 
            // button3
            // 
            button3.Location=new Point(248, 280);
            button3.Name="button3";
            button3.Size=new Size(189, 55);
            button3.TabIndex=4;
            button3.Text="Activtie";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=btnActivité_Click;
            // 
            // button4
            // 
            button4.Location=new Point(248, 129);
            button4.Name="button4";
            button4.Size=new Size(189, 49);
            button4.TabIndex=5;
            button4.Text="Vendre";
            button4.UseVisualStyleBackColor=true;
            button4.Click+=btnVendre;
            // 
            // Magazan
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSize=true;
            ClientSize=new Size(646, 404);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(magazian);
            FormBorderStyle=FormBorderStyle.Fixed3D;
            Name="Magazan";
            Text="Magazan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label magazian;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}