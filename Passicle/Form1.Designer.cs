using System.Runtime.CompilerServices;

namespace Passicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            title = new Label();
            service = new TextBox();
            key = new TextBox();
            generate = new Button();
            generated = new Label();
            copy = new Button();
            show = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI Black", 28F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(137, 9);
            title.Name = "title";
            title.Size = new Size(207, 62);
            title.TabIndex = 0;
            title.Text = "Passicle";
            title.Click += title_Click;
            // 
            // service
            // 
            service.Location = new Point(137, 135);
            service.Name = "service";
            service.PlaceholderText = "Service / Account Name";
            service.Size = new Size(207, 27);
            service.TabIndex = 1;
            // 
            // key
            // 
            key.Location = new Point(137, 189);
            key.Name = "key";
            key.PasswordChar = '*';
            key.PlaceholderText = "Key";
            key.Size = new Size(207, 27);
            key.TabIndex = 2;
            // 
            // generate
            // 
            generate.FlatStyle = FlatStyle.Popup;
            generate.Location = new Point(137, 255);
            generate.Name = "generate";
            generate.Size = new Size(207, 29);
            generate.TabIndex = 3;
            generate.Text = "Generate";
            generate.UseVisualStyleBackColor = true;
            generate.Click += generate_Click;
            // 
            // generated
            // 
            generated.Location = new Point(87, 298);
            generated.Name = "generated";
            generated.Size = new Size(305, 66);
            generated.TabIndex = 4;
            generated.TextAlign = ContentAlignment.TopCenter;
            // 
            // copy
            // 
            copy.FlatStyle = FlatStyle.Popup;
            copy.Location = new Point(143, 376);
            copy.Name = "copy";
            copy.Size = new Size(94, 29);
            copy.TabIndex = 5;
            copy.Text = "Copy";
            copy.UseVisualStyleBackColor = true;
            copy.Visible = false;
            copy.Click += copy_Click;
            // 
            // show
            // 
            show.FlatStyle = FlatStyle.Popup;
            show.Location = new Point(243, 376);
            show.Name = "show";
            show.Size = new Size(94, 29);
            show.TabIndex = 6;
            show.Text = "Show";
            show.UseVisualStyleBackColor = true;
            show.Visible = false;
            show.Click += show_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(479, 450);
            Controls.Add(show);
            Controls.Add(copy);
            Controls.Add(generated);
            Controls.Add(generate);
            Controls.Add(key);
            Controls.Add(service);
            Controls.Add(title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Passicle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private TextBox service;
        private TextBox key;
        private Button generate;
        private Label generated;
        private Button copy;
        private Button show;
        private string p;
        private bool showing = false;
    }
}