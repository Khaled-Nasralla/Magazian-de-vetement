namespace Magazian_de_vêtement
{
    partial class AreYouSure
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
            button2=new Button();
            label1=new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location=new Point(230, 96);
            button1.Name="btnImporter";
            button1.Size=new Size(98, 31);
            button1.TabIndex=0;
            button1.Text="Oui";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.Location=new Point(334, 96);
            button2.Name="btnsave";
            button2.Size=new Size(94, 31);
            button2.TabIndex=1;
            button2.Text="Non";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(23, 50);
            label1.Name="Sortelabel";
            label1.Size=new Size(313, 15);
            label1.TabIndex=2;
            label1.Text="Vous êtes sûre que vous voulais supprimer cette \"Article\" ?";
            // 
            // AreYouSure
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(440, 138);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name="AreYouSure";
            Text="AreYouSure";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
    }
}