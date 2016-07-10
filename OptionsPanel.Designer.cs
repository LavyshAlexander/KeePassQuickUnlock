﻿namespace KeePassQuickUnlock
{
	partial class OptionsPanel
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.infoLabel = new System.Windows.Forms.Label();
			this.validPeriodComboBox = new System.Windows.Forms.ComboBox();
			this.info2Label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// infoLabel
			// 
			this.infoLabel.AutoSize = true;
			this.infoLabel.Location = new System.Drawing.Point(3, 9);
			this.infoLabel.Name = "infoLabel";
			this.infoLabel.Size = new System.Drawing.Size(364, 13);
			this.infoLabel.TabIndex = 4;
			this.infoLabel.Text = "Select the time range after which a QuickUnlock password gets invalidated:";
			// 
			// validPeriodComboBox
			// 
			this.validPeriodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.validPeriodComboBox.FormattingEnabled = true;
			this.validPeriodComboBox.Items.AddRange(new object[] {
            "Unlimited",
            "1 Minute",
            "5 Minutes",
            "10 Minutes",
            "15 Minutes",
            "30 Minutes",
            "1 Hour",
            "2 Hours",
            "6 Hours",
            "12 Hours",
            "1 Day"});
			this.validPeriodComboBox.Location = new System.Drawing.Point(6, 25);
			this.validPeriodComboBox.Name = "validPeriodComboBox";
			this.validPeriodComboBox.Size = new System.Drawing.Size(186, 21);
			this.validPeriodComboBox.TabIndex = 5;
			// 
			// info2Label
			// 
			this.info2Label.AutoSize = true;
			this.info2Label.Location = new System.Drawing.Point(3, 49);
			this.info2Label.Name = "info2Label";
			this.info2Label.Size = new System.Drawing.Size(454, 13);
			this.info2Label.TabIndex = 6;
			this.info2Label.Text = "If the password timed out you need to provide the full credentials to unlock the " +
    "database again.";
			// 
			// OptionsPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.info2Label);
			this.Controls.Add(this.validPeriodComboBox);
			this.Controls.Add(this.infoLabel);
			this.Name = "OptionsPanel";
			this.Size = new System.Drawing.Size(565, 285);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label infoLabel;
		private System.Windows.Forms.ComboBox validPeriodComboBox;
		private System.Windows.Forms.Label info2Label;
	}
}
