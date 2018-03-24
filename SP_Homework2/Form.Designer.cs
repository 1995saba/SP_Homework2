namespace SP_Homework2
{
    partial class Form
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
            this.fromPathButton = new System.Windows.Forms.Button();
            this.toPathButton = new System.Windows.Forms.Button();
            this.fromPathTextBox = new System.Windows.Forms.TextBox();
            this.toPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.copyButton = new System.Windows.Forms.Button();
            this.fromOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // fromPathButton
            // 
            this.fromPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromPathButton.Location = new System.Drawing.Point(334, 35);
            this.fromPathButton.Name = "fromPathButton";
            this.fromPathButton.Size = new System.Drawing.Size(99, 23);
            this.fromPathButton.TabIndex = 0;
            this.fromPathButton.Text = "Выбрать файл";
            this.fromPathButton.UseVisualStyleBackColor = true;
            this.fromPathButton.Click += new System.EventHandler(this.FromPathButton_Click);
            // 
            // toPathButton
            // 
            this.toPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toPathButton.Location = new System.Drawing.Point(334, 86);
            this.toPathButton.Name = "toPathButton";
            this.toPathButton.Size = new System.Drawing.Size(99, 23);
            this.toPathButton.TabIndex = 1;
            this.toPathButton.Text = "Выбрать файл";
            this.toPathButton.UseVisualStyleBackColor = true;
            this.toPathButton.Click += new System.EventHandler(this.ToPathButton_Click);
            // 
            // fromPathTextBox
            // 
            this.fromPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromPathTextBox.Location = new System.Drawing.Point(70, 37);
            this.fromPathTextBox.Name = "fromPathTextBox";
            this.fromPathTextBox.Size = new System.Drawing.Size(247, 20);
            this.fromPathTextBox.TabIndex = 2;
            // 
            // toPathTextBox
            // 
            this.toPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toPathTextBox.Location = new System.Drawing.Point(70, 88);
            this.toPathTextBox.Name = "toPathTextBox";
            this.toPathTextBox.Size = new System.Drawing.Size(247, 20);
            this.toPathTextBox.TabIndex = 3;
            this.toPathTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToPathTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Откуда";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Куда";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(24, 143);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(293, 23);
            this.progressBar.TabIndex = 6;
            // 
            // copyButton
            // 
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyButton.Location = new System.Drawing.Point(334, 143);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(99, 23);
            this.copyButton.TabIndex = 7;
            this.copyButton.Text = "Копировать";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 187);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toPathTextBox);
            this.Controls.Add(this.fromPathTextBox);
            this.Controls.Add(this.toPathButton);
            this.Controls.Add(this.fromPathButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form";
            this.Text = "Копирование документа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fromPathButton;
        private System.Windows.Forms.Button toPathButton;
        private System.Windows.Forms.TextBox fromPathTextBox;
        private System.Windows.Forms.TextBox toPathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.OpenFileDialog fromOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog toOpenFileDialog;
    }
}

