namespace ToDoList_Port1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblW = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblE = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblL = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblC = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblO = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblM = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblnameE = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lblnameE);
            this.bunifuGradientPanel1.Controls.Add(this.lblM);
            this.bunifuGradientPanel1.Controls.Add(this.lblO);
            this.bunifuGradientPanel1.Controls.Add(this.lblC);
            this.bunifuGradientPanel1.Controls.Add(this.lblL);
            this.bunifuGradientPanel1.Controls.Add(this.lblE);
            this.bunifuGradientPanel1.Controls.Add(this.lblW);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SkyBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkGray;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(606, 695);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblW
            // 
            this.lblW.AutoEllipsis = true;
            this.lblW.AutoSize = true;
            this.lblW.BackColor = System.Drawing.Color.Transparent;
            this.lblW.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW.ForeColor = System.Drawing.Color.White;
            this.lblW.Location = new System.Drawing.Point(106, 27);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(49, 41);
            this.lblW.TabIndex = 0;
            this.lblW.Text = "W";
            this.lblW.Enter += new System.EventHandler(this.bunifuCustomLabel1_Enter);
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.BackColor = System.Drawing.Color.Transparent;
            this.lblE.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.lblE.ForeColor = System.Drawing.Color.White;
            this.lblE.Location = new System.Drawing.Point(142, 27);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(36, 41);
            this.lblE.TabIndex = 1;
            this.lblE.Text = "E";
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.BackColor = System.Drawing.Color.Transparent;
            this.lblL.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.lblL.ForeColor = System.Drawing.Color.White;
            this.lblL.Location = new System.Drawing.Point(167, 27);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(33, 41);
            this.lblL.TabIndex = 2;
            this.lblL.Text = "L";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.BackColor = System.Drawing.Color.Transparent;
            this.lblC.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.lblC.ForeColor = System.Drawing.Color.White;
            this.lblC.Location = new System.Drawing.Point(190, 27);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(45, 41);
            this.lblC.TabIndex = 3;
            this.lblC.Text = "C";
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.BackColor = System.Drawing.Color.Transparent;
            this.lblO.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.lblO.ForeColor = System.Drawing.Color.White;
            this.lblO.Location = new System.Drawing.Point(221, 27);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(47, 41);
            this.lblO.TabIndex = 4;
            this.lblO.Text = "O";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.BackColor = System.Drawing.Color.Transparent;
            this.lblM.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.lblM.ForeColor = System.Drawing.Color.White;
            this.lblM.Location = new System.Drawing.Point(256, 27);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(49, 41);
            this.lblM.TabIndex = 5;
            this.lblM.Text = "M";
            // 
            // lblnameE
            // 
            this.lblnameE.AutoSize = true;
            this.lblnameE.BackColor = System.Drawing.Color.Transparent;
            this.lblnameE.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.lblnameE.ForeColor = System.Drawing.Color.White;
            this.lblnameE.Location = new System.Drawing.Point(295, 27);
            this.lblnameE.Name = "lblnameE";
            this.lblnameE.Size = new System.Drawing.Size(36, 41);
            this.lblnameE.TabIndex = 6;
            this.lblnameE.Text = "E";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 695);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblW;
        private Bunifu.Framework.UI.BunifuCustomLabel lblE;
        private Bunifu.Framework.UI.BunifuCustomLabel lblM;
        private Bunifu.Framework.UI.BunifuCustomLabel lblO;
        private Bunifu.Framework.UI.BunifuCustomLabel lblC;
        private Bunifu.Framework.UI.BunifuCustomLabel lblL;
        private Bunifu.Framework.UI.BunifuCustomLabel lblnameE;
    }
}

