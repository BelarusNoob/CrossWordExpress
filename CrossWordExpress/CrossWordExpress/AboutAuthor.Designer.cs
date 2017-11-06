namespace CrossWordExpress
{
    partial class AboutAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutAuthor));
            this.label1 = new System.Windows.Forms.Label();
            this.FBbutton = new System.Windows.Forms.Button();
            this.VKbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 175);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // FBbutton
            // 
            this.FBbutton.BackColor = System.Drawing.Color.Transparent;
            this.FBbutton.BackgroundImage = global::CrossWordExpress.Properties.Resources._1496937226_facebook;
            this.FBbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.FBbutton.FlatAppearance.BorderSize = 0;
            this.FBbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FBbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FBbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FBbutton.ForeColor = System.Drawing.Color.Transparent;
            this.FBbutton.Location = new System.Drawing.Point(61, 187);
            this.FBbutton.Name = "FBbutton";
            this.FBbutton.Size = new System.Drawing.Size(40, 40);
            this.FBbutton.TabIndex = 2;
            this.FBbutton.UseVisualStyleBackColor = false;
            this.FBbutton.Click += new System.EventHandler(this.FBbutton_Click);
            // 
            // VKbutton
            // 
            this.VKbutton.BackColor = System.Drawing.Color.Transparent;
            this.VKbutton.BackgroundImage = global::CrossWordExpress.Properties.Resources.vk;
            this.VKbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VKbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.VKbutton.FlatAppearance.BorderSize = 0;
            this.VKbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.VKbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.VKbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VKbutton.ForeColor = System.Drawing.Color.Transparent;
            this.VKbutton.Location = new System.Drawing.Point(15, 187);
            this.VKbutton.Name = "VKbutton";
            this.VKbutton.Size = new System.Drawing.Size(40, 40);
            this.VKbutton.TabIndex = 2;
            this.VKbutton.UseVisualStyleBackColor = false;
            this.VKbutton.Click += new System.EventHandler(this.VKbutton_Click);
            // 
            // AboutAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 241);
            this.Controls.Add(this.FBbutton);
            this.Controls.Add(this.VKbutton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Об авторе";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VKbutton;
        private System.Windows.Forms.Button FBbutton;
    }
}