namespace KeccakHash
{
    partial class KeccakHash
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
            this.EnterTextField = new System.Windows.Forms.TextBox();
            this.EnterTextLabel = new System.Windows.Forms.Label();
            this.HashTextLabel = new System.Windows.Forms.Label();
            this.HashTextField = new System.Windows.Forms.TextBox();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.AutoUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.HashLengthList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EnterTextField
            // 
            this.EnterTextField.AcceptsTab = true;
            this.EnterTextField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterTextField.Location = new System.Drawing.Point(55, 150);
            this.EnterTextField.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.EnterTextField.Multiline = true;
            this.EnterTextField.Name = "EnterTextField";
            this.EnterTextField.Size = new System.Drawing.Size(1065, 122);
            this.EnterTextField.TabIndex = 1;
            this.EnterTextField.TextChanged += new System.EventHandler(this.EnterTextField_TextChanged);
            // 
            // EnterTextLabel
            // 
            this.EnterTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterTextLabel.AutoSize = true;
            this.EnterTextLabel.Location = new System.Drawing.Point(51, 115);
            this.EnterTextLabel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 12);
            this.EnterTextLabel.Name = "EnterTextLabel";
            this.EnterTextLabel.Size = new System.Drawing.Size(288, 16);
            this.EnterTextLabel.TabIndex = 1;
            this.EnterTextLabel.Text = "Текст, который необходимо закодировать:";
            this.EnterTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnterTextLabel.Click += new System.EventHandler(this.EnterTextLabel_Click);
            // 
            // HashTextLabel
            // 
            this.HashTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HashTextLabel.AutoSize = true;
            this.HashTextLabel.Location = new System.Drawing.Point(51, 380);
            this.HashTextLabel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 12);
            this.HashTextLabel.Name = "HashTextLabel";
            this.HashTextLabel.Size = new System.Drawing.Size(103, 16);
            this.HashTextLabel.TabIndex = 2;
            this.HashTextLabel.Text = "Хэш значение:";
            this.HashTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HashTextLabel.Click += new System.EventHandler(this.HashTextLabel_Click);
            // 
            // HashTextField
            // 
            this.HashTextField.AcceptsTab = true;
            this.HashTextField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HashTextField.Location = new System.Drawing.Point(55, 414);
            this.HashTextField.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.HashTextField.Multiline = true;
            this.HashTextField.Name = "HashTextField";
            this.HashTextField.Size = new System.Drawing.Size(1065, 122);
            this.HashTextField.TabIndex = 3;
            this.HashTextField.TextChanged += new System.EventHandler(this.HashTextField_TextChanged);
            // 
            // EncodeButton
            // 
            this.EncodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EncodeButton.AutoSize = true;
            this.EncodeButton.Location = new System.Drawing.Point(55, 291);
            this.EncodeButton.Margin = new System.Windows.Forms.Padding(7, 12, 7, 6);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(153, 28);
            this.EncodeButton.TabIndex = 4;
            this.EncodeButton.Text = "Закодировать";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // AutoUpdateCheckBox
            // 
            this.AutoUpdateCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AutoUpdateCheckBox.AutoSize = true;
            this.AutoUpdateCheckBox.Location = new System.Drawing.Point(235, 297);
            this.AutoUpdateCheckBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AutoUpdateCheckBox.Name = "AutoUpdateCheckBox";
            this.AutoUpdateCheckBox.Size = new System.Drawing.Size(234, 20);
            this.AutoUpdateCheckBox.TabIndex = 5;
            this.AutoUpdateCheckBox.Text = "авто обновление хэш-значения";
            this.AutoUpdateCheckBox.UseVisualStyleBackColor = true;
            this.AutoUpdateCheckBox.CheckedChanged += new System.EventHandler(this.AutoUpdateCheckBox_CheckedChanged);
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(49, 35);
            this.MainLabel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 12);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(128, 33);
            this.MainLabel.TabIndex = 6;
            this.MainLabel.Text = "Keccak-";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HashLengthList
            // 
            this.HashLengthList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HashLengthList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.HashLengthList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HashLengthList.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HashLengthList.FormattingEnabled = true;
            this.HashLengthList.ItemHeight = 32;
            this.HashLengthList.Items.AddRange(new object[] {
            "512",
            "384",
            "256",
            "224",
            "128"});
            this.HashLengthList.Location = new System.Drawing.Point(170, 36);
            this.HashLengthList.Margin = new System.Windows.Forms.Padding(5);
            this.HashLengthList.Name = "HashLengthList";
            this.HashLengthList.Size = new System.Drawing.Size(84, 32);
            this.HashLengthList.TabIndex = 0;
            this.HashLengthList.SelectedIndexChanged += new System.EventHandler(this.HashLengthList_SelectedIndexChanged);
            // 
            // KeccakHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1179, 567);
            this.Controls.Add(this.HashLengthList);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.AutoUpdateCheckBox);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.HashTextField);
            this.Controls.Add(this.HashTextLabel);
            this.Controls.Add(this.EnterTextLabel);
            this.Controls.Add(this.EnterTextField);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1195, 606);
            this.MinimumSize = new System.Drawing.Size(795, 606);
            this.Name = "KeccakHash";
            this.Text = "Keccak Hash";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterTextField;
        private System.Windows.Forms.Label EnterTextLabel;
        private System.Windows.Forms.Label HashTextLabel;
        private System.Windows.Forms.TextBox HashTextField;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.CheckBox AutoUpdateCheckBox;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.ListBox HashLengthList;
    }
}

