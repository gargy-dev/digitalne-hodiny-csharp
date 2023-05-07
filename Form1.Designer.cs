namespace korabsky_digitalne_hodiny
{
    partial class Form_HO_PK
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
            this.panel_hodiny = new System.Windows.Forms.Panel();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_uprava = new System.Windows.Forms.Button();
            this.label_dvojbodka2 = new System.Windows.Forms.Label();
            this.label_dvojbodka1 = new System.Windows.Forms.Label();
            this.label_nadpis_hodiny = new System.Windows.Forms.Label();
            this.casovac = new System.Windows.Forms.Timer(this.components);
            this.label_hodiny = new System.Windows.Forms.Label();
            this.textBox_hodiny = new System.Windows.Forms.TextBox();
            this.label_minuty = new System.Windows.Forms.Label();
            this.label_sekundy = new System.Windows.Forms.Label();
            this.textBox_minuty = new System.Windows.Forms.TextBox();
            this.textBox_sekundy = new System.Windows.Forms.TextBox();
            this.chyby = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_hodiny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chyby)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_hodiny
            // 
            this.panel_hodiny.Controls.Add(this.textBox_sekundy);
            this.panel_hodiny.Controls.Add(this.textBox_minuty);
            this.panel_hodiny.Controls.Add(this.label_sekundy);
            this.panel_hodiny.Controls.Add(this.label_minuty);
            this.panel_hodiny.Controls.Add(this.textBox_hodiny);
            this.panel_hodiny.Controls.Add(this.label_hodiny);
            this.panel_hodiny.Controls.Add(this.button_reset);
            this.panel_hodiny.Controls.Add(this.button_start);
            this.panel_hodiny.Controls.Add(this.button_uprava);
            this.panel_hodiny.Controls.Add(this.label_dvojbodka2);
            this.panel_hodiny.Controls.Add(this.label_dvojbodka1);
            this.panel_hodiny.Controls.Add(this.label_nadpis_hodiny);
            this.panel_hodiny.Location = new System.Drawing.Point(55, 46);
            this.panel_hodiny.Margin = new System.Windows.Forms.Padding(4);
            this.panel_hodiny.Name = "panel_hodiny";
            this.panel_hodiny.Size = new System.Drawing.Size(445, 236);
            this.panel_hodiny.TabIndex = 0;
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_reset.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_reset.ForeColor = System.Drawing.Color.Red;
            this.button_reset.Location = new System.Drawing.Point(308, 176);
            this.button_reset.Margin = new System.Windows.Forms.Padding(4);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(100, 28);
            this.button_reset.TabIndex = 6;
            this.button_reset.Text = "&RESET";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_start.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_start.ForeColor = System.Drawing.Color.LawnGreen;
            this.button_start.Location = new System.Drawing.Point(53, 176);
            this.button_start.Margin = new System.Windows.Forms.Padding(4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(100, 28);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "&ŠTART";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_uprava
            // 
            this.button_uprava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_uprava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_uprava.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_uprava.ForeColor = System.Drawing.Color.Orange;
            this.button_uprava.Location = new System.Drawing.Point(182, 176);
            this.button_uprava.Margin = new System.Windows.Forms.Padding(4);
            this.button_uprava.Name = "button_uprava";
            this.button_uprava.Size = new System.Drawing.Size(100, 28);
            this.button_uprava.TabIndex = 5;
            this.button_uprava.Text = "&UPRAVIŤ";
            this.button_uprava.UseVisualStyleBackColor = false;
            this.button_uprava.Click += new System.EventHandler(this.button_uprava_Click);
            // 
            // label_dvojbodka2
            // 
            this.label_dvojbodka2.AutoSize = true;
            this.label_dvojbodka2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dvojbodka2.Location = new System.Drawing.Point(285, 105);
            this.label_dvojbodka2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dvojbodka2.Name = "label_dvojbodka2";
            this.label_dvojbodka2.Size = new System.Drawing.Size(24, 41);
            this.label_dvojbodka2.TabIndex = 8;
            this.label_dvojbodka2.Text = ":";
            // 
            // label_dvojbodka1
            // 
            this.label_dvojbodka1.AutoSize = true;
            this.label_dvojbodka1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dvojbodka1.Location = new System.Drawing.Point(159, 105);
            this.label_dvojbodka1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dvojbodka1.Name = "label_dvojbodka1";
            this.label_dvojbodka1.Size = new System.Drawing.Size(24, 41);
            this.label_dvojbodka1.TabIndex = 7;
            this.label_dvojbodka1.Text = ":";
            // 
            // label_nadpis_hodiny
            // 
            this.label_nadpis_hodiny.AutoSize = true;
            this.label_nadpis_hodiny.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nadpis_hodiny.Location = new System.Drawing.Point(116, 20);
            this.label_nadpis_hodiny.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nadpis_hodiny.Name = "label_nadpis_hodiny";
            this.label_nadpis_hodiny.Size = new System.Drawing.Size(233, 41);
            this.label_nadpis_hodiny.TabIndex = 0;
            this.label_nadpis_hodiny.Text = "Digitálne hodiny";
            // 
            // casovac
            // 
            this.casovac.Enabled = true;
            this.casovac.Interval = 1000;
            this.casovac.Tick += new System.EventHandler(this.casovac_Tick);
            // 
            // label_hodiny
            // 
            this.label_hodiny.AutoSize = true;
            this.label_hodiny.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_hodiny.Location = new System.Drawing.Point(78, 78);
            this.label_hodiny.Name = "label_hodiny";
            this.label_hodiny.Size = new System.Drawing.Size(54, 24);
            this.label_hodiny.TabIndex = 12;
            this.label_hodiny.Text = "&hodiny";
            this.label_hodiny.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_hodiny
            // 
            this.textBox_hodiny.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox_hodiny.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_hodiny.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_hodiny.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_hodiny.Location = new System.Drawing.Point(75, 105);
            this.textBox_hodiny.MaxLength = 2;
            this.textBox_hodiny.Multiline = true;
            this.textBox_hodiny.Name = "textBox_hodiny";
            this.textBox_hodiny.Size = new System.Drawing.Size(59, 51);
            this.textBox_hodiny.TabIndex = 1;
            this.textBox_hodiny.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_hodiny.TextChanged += new System.EventHandler(this.textBox_hodiny_TextChanged);
            this.textBox_hodiny.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hodiny_KeyPress);
            // 
            // label_minuty
            // 
            this.label_minuty.AutoSize = true;
            this.label_minuty.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_minuty.Location = new System.Drawing.Point(207, 78);
            this.label_minuty.Name = "label_minuty";
            this.label_minuty.Size = new System.Drawing.Size(56, 24);
            this.label_minuty.TabIndex = 16;
            this.label_minuty.Text = "&minúty";
            this.label_minuty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_sekundy
            // 
            this.label_sekundy.AutoSize = true;
            this.label_sekundy.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_sekundy.Location = new System.Drawing.Point(326, 78);
            this.label_sekundy.Name = "label_sekundy";
            this.label_sekundy.Size = new System.Drawing.Size(65, 24);
            this.label_sekundy.TabIndex = 17;
            this.label_sekundy.Text = "&sekundy";
            this.label_sekundy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_minuty
            // 
            this.textBox_minuty.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox_minuty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_minuty.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_minuty.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_minuty.Location = new System.Drawing.Point(203, 105);
            this.textBox_minuty.MaxLength = 2;
            this.textBox_minuty.Multiline = true;
            this.textBox_minuty.Name = "textBox_minuty";
            this.textBox_minuty.Size = new System.Drawing.Size(59, 51);
            this.textBox_minuty.TabIndex = 2;
            this.textBox_minuty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_minuty.TextChanged += new System.EventHandler(this.textBox_minuty_TextChanged);
            this.textBox_minuty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_minuty_KeyPress);
            // 
            // textBox_sekundy
            // 
            this.textBox_sekundy.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox_sekundy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_sekundy.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_sekundy.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_sekundy.Location = new System.Drawing.Point(328, 105);
            this.textBox_sekundy.MaxLength = 2;
            this.textBox_sekundy.Multiline = true;
            this.textBox_sekundy.Name = "textBox_sekundy";
            this.textBox_sekundy.Size = new System.Drawing.Size(59, 51);
            this.textBox_sekundy.TabIndex = 3;
            this.textBox_sekundy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_sekundy.TextChanged += new System.EventHandler(this.textBox_sekundy_TextChanged);
            this.textBox_sekundy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_sekundy_KeyPress);
            // 
            // chyby
            // 
            this.chyby.ContainerControl = this;
            // 
            // Form_HO_PK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::korabsky_digitalne_hodiny.Properties.Resources.pozadie;
            this.ClientSize = new System.Drawing.Size(555, 323);
            this.Controls.Add(this.panel_hodiny);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_HO_PK";
            this.Text = "Digitálne hodiny";
            this.Load += new System.EventHandler(this.Form_HO_PK_Load);
            this.panel_hodiny.ResumeLayout(false);
            this.panel_hodiny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chyby)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_hodiny;
        private System.Windows.Forms.Label label_nadpis_hodiny;
        private System.Windows.Forms.Button button_uprava;
        private System.Windows.Forms.Label label_dvojbodka2;
        private System.Windows.Forms.Label label_dvojbodka1;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer casovac;
        private System.Windows.Forms.TextBox textBox_hodiny;
        private System.Windows.Forms.Label label_hodiny;
        private System.Windows.Forms.TextBox textBox_minuty;
        private System.Windows.Forms.Label label_sekundy;
        private System.Windows.Forms.Label label_minuty;
        private System.Windows.Forms.TextBox textBox_sekundy;
        private System.Windows.Forms.ErrorProvider chyby;
    }
}

