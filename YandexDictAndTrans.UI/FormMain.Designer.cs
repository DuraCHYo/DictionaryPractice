namespace YandexDictAndTrans.UI
{
    partial class FormMain
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this._buttonTrans = new System.Windows.Forms.Button();
      this._buttonDict = new System.Windows.Forms.Button();
      this._textBoxInput = new System.Windows.Forms.TextBox();
      this._textBoxOutput = new System.Windows.Forms.TextBox();
      this._comboBoxLang = new System.Windows.Forms.ComboBox();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // _buttonTrans
      // 
      this._buttonTrans.Location = new System.Drawing.Point(281, 12);
      this._buttonTrans.Name = "_buttonTrans";
      this._buttonTrans.Size = new System.Drawing.Size(111, 44);
      this._buttonTrans.TabIndex = 0;
      this._buttonTrans.Text = "Перевести";
      this._buttonTrans.UseVisualStyleBackColor = true;
      // 
      // _buttonDict
      // 
      this._buttonDict.Location = new System.Drawing.Point(281, 148);
      this._buttonDict.Name = "_buttonDict";
      this._buttonDict.Size = new System.Drawing.Size(111, 44);
      this._buttonDict.TabIndex = 1;
      this._buttonDict.Text = "Найти в словаре";
      this._buttonDict.UseVisualStyleBackColor = true;
      // 
      // _textBoxInput
      // 
      this._textBoxInput.Location = new System.Drawing.Point(12, 12);
      this._textBoxInput.Multiline = true;
      this._textBoxInput.Name = "_textBoxInput";
      this._textBoxInput.Size = new System.Drawing.Size(210, 180);
      this._textBoxInput.TabIndex = 2;
      // 
      // _textBoxOutput
      // 
      this._textBoxOutput.Location = new System.Drawing.Point(459, 12);
      this._textBoxOutput.Multiline = true;
      this._textBoxOutput.Name = "_textBoxOutput";
      this._textBoxOutput.Size = new System.Drawing.Size(210, 180);
      this._textBoxOutput.TabIndex = 3;
      // 
      // _comboBoxLang
      // 
      this._comboBoxLang.FormattingEnabled = true;
      this._comboBoxLang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this._comboBoxLang.Location = new System.Drawing.Point(260, 91);
      this._comboBoxLang.Name = "_comboBoxLang";
      this._comboBoxLang.Size = new System.Drawing.Size(157, 23);
      this._comboBoxLang.TabIndex = 4;
      // 
      // linkLabel1
      // 
      this.linkLabel1.Location = new System.Drawing.Point(165, 205);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(361, 20);
      this.linkLabel1.TabIndex = 5;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "Создано с использованием технологий Яндекс.Переводчика";
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.PeachPuff;
      this.ClientSize = new System.Drawing.Size(681, 234);
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this._comboBoxLang);
      this.Controls.Add(this._textBoxOutput);
      this.Controls.Add(this._textBoxInput);
      this.Controls.Add(this._buttonDict);
      this.Controls.Add(this._buttonTrans);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Переводчик MIREA";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonTrans;
        private System.Windows.Forms.Button _buttonDict;
        private System.Windows.Forms.TextBox _textBoxInput;
        private System.Windows.Forms.TextBox _textBoxOutput;
        private System.Windows.Forms.ComboBox _comboBoxLang;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

