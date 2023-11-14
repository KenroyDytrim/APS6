
namespace APS6
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Info = new System.Windows.Forms.RichTextBox();
            this.ProxyInfo = new System.Windows.Forms.RichTextBox();
            this.comboUsers = new System.Windows.Forms.ComboBox();
            this.View = new System.Windows.Forms.Button();
            this.ViewProxy = new System.Windows.Forms.Button();
            this.CreateProxy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.Location = new System.Drawing.Point(26, 53);
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Size = new System.Drawing.Size(324, 224);
            this.Info.TabIndex = 0;
            this.Info.Text = "";
            // 
            // ProxyInfo
            // 
            this.ProxyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProxyInfo.Location = new System.Drawing.Point(447, 53);
            this.ProxyInfo.Name = "ProxyInfo";
            this.ProxyInfo.ReadOnly = true;
            this.ProxyInfo.Size = new System.Drawing.Size(324, 224);
            this.ProxyInfo.TabIndex = 1;
            this.ProxyInfo.Text = "";
            // 
            // comboUsers
            // 
            this.comboUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboUsers.FormattingEnabled = true;
            this.comboUsers.Location = new System.Drawing.Point(302, 356);
            this.comboUsers.Name = "comboUsers";
            this.comboUsers.Size = new System.Drawing.Size(202, 33);
            this.comboUsers.TabIndex = 2;
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.View.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.View.Location = new System.Drawing.Point(99, 283);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(157, 40);
            this.View.TabIndex = 3;
            this.View.Text = "Показать";
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // ViewProxy
            // 
            this.ViewProxy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ViewProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewProxy.Location = new System.Drawing.Point(543, 283);
            this.ViewProxy.Name = "ViewProxy";
            this.ViewProxy.Size = new System.Drawing.Size(157, 40);
            this.ViewProxy.TabIndex = 4;
            this.ViewProxy.Text = "Показать";
            this.ViewProxy.UseVisualStyleBackColor = false;
            this.ViewProxy.Click += new System.EventHandler(this.ViewProxy_Click);
            // 
            // CreateProxy
            // 
            this.CreateProxy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CreateProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateProxy.Location = new System.Drawing.Point(99, 349);
            this.CreateProxy.Name = "CreateProxy";
            this.CreateProxy.Size = new System.Drawing.Size(157, 40);
            this.CreateProxy.TabIndex = 5;
            this.CreateProxy.Text = "Создать";
            this.CreateProxy.UseVisualStyleBackColor = false;
            this.CreateProxy.Click += new System.EventHandler(this.CreateProxy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Полученный пользователь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(572, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Proxy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateProxy);
            this.Controls.Add(this.ViewProxy);
            this.Controls.Add(this.View);
            this.Controls.Add(this.comboUsers);
            this.Controls.Add(this.ProxyInfo);
            this.Controls.Add(this.Info);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Info;
        private System.Windows.Forms.RichTextBox ProxyInfo;
        private System.Windows.Forms.ComboBox comboUsers;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button ViewProxy;
        private System.Windows.Forms.Button CreateProxy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

