namespace prakticheskaya_rabota
{
    partial class auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.login = new MaterialSkin.Controls.MaterialTextBox();
            this.password = new MaterialSkin.Controls.MaterialTextBox();
            this.action_signin = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login.Depth = 0;
            this.login.Font = new System.Drawing.Font("Roboto", 12F);
            this.login.Hint = "Логин";
            this.login.Location = new System.Drawing.Point(12, 93);
            this.login.MaxLength = 50;
            this.login.MouseState = MaterialSkin.MouseState.OUT;
            this.login.Multiline = false;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(308, 50);
            this.login.TabIndex = 0;
            this.login.Text = "";
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Depth = 0;
            this.password.Font = new System.Drawing.Font("Roboto", 12F);
            this.password.Hint = "Пароль";
            this.password.Location = new System.Drawing.Point(12, 164);
            this.password.MaxLength = 50;
            this.password.MouseState = MaterialSkin.MouseState.OUT;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Password = true;
            this.password.Size = new System.Drawing.Size(308, 50);
            this.password.TabIndex = 1;
            this.password.Text = "";
            // 
            // action_signin
            // 
            this.action_signin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.action_signin.Depth = 0;
            this.action_signin.DrawShadows = true;
            this.action_signin.HighEmphasis = true;
            this.action_signin.Icon = null;
            this.action_signin.Location = new System.Drawing.Point(123, 233);
            this.action_signin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.action_signin.MouseState = MaterialSkin.MouseState.HOVER;
            this.action_signin.Name = "action_signin";
            this.action_signin.Size = new System.Drawing.Size(69, 36);
            this.action_signin.TabIndex = 2;
            this.action_signin.Text = "Войти";
            this.action_signin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.action_signin.UseAccentColor = false;
            this.action_signin.UseVisualStyleBackColor = true;
            this.action_signin.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 296);
            this.Controls.Add(this.action_signin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.KeyPreview = true;
            this.Name = "auth";
            this.Text = "Авторизация";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.auth_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox login;
        private MaterialSkin.Controls.MaterialTextBox password;
        private MaterialSkin.Controls.MaterialButton action_signin;
    }
}

