﻿namespace Maxstupo.YdlUi.Forms {
    partial class FormOptions {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            this.cbDefaultPresetLocation = new System.Windows.Forms.CheckBox();
            this.txtDefaultPresetLocation = new System.Windows.Forms.TextBox();
            this.cbPromptSaveOnClose = new System.Windows.Forms.CheckBox();
            this.btnBrowsePresetLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDefaultPresetLocation
            // 
            this.cbDefaultPresetLocation.AutoSize = true;
            this.cbDefaultPresetLocation.Location = new System.Drawing.Point(12, 35);
            this.cbDefaultPresetLocation.Name = "cbDefaultPresetLocation";
            this.cbDefaultPresetLocation.Size = new System.Drawing.Size(148, 17);
            this.cbDefaultPresetLocation.TabIndex = 2;
            this.cbDefaultPresetLocation.Text = "Default Preset Location:";
            this.cbDefaultPresetLocation.UseVisualStyleBackColor = true;
            // 
            // txtDefaultPresetLocation
            // 
            this.txtDefaultPresetLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDefaultPresetLocation.Location = new System.Drawing.Point(166, 33);
            this.txtDefaultPresetLocation.Name = "txtDefaultPresetLocation";
            this.txtDefaultPresetLocation.Size = new System.Drawing.Size(541, 22);
            this.txtDefaultPresetLocation.TabIndex = 3;
            // 
            // cbPromptSaveOnClose
            // 
            this.cbPromptSaveOnClose.AutoSize = true;
            this.cbPromptSaveOnClose.Location = new System.Drawing.Point(12, 12);
            this.cbPromptSaveOnClose.Name = "cbPromptSaveOnClose";
            this.cbPromptSaveOnClose.Size = new System.Drawing.Size(139, 17);
            this.cbPromptSaveOnClose.TabIndex = 4;
            this.cbPromptSaveOnClose.Text = "Prompt save on close?";
            this.cbPromptSaveOnClose.UseVisualStyleBackColor = true;
            // 
            // btnBrowsePresetLocation
            // 
            this.btnBrowsePresetLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowsePresetLocation.Location = new System.Drawing.Point(713, 33);
            this.btnBrowsePresetLocation.Name = "btnBrowsePresetLocation";
            this.btnBrowsePresetLocation.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsePresetLocation.TabIndex = 5;
            this.btnBrowsePresetLocation.Text = "Browse";
            this.btnBrowsePresetLocation.UseVisualStyleBackColor = true;
            this.btnBrowsePresetLocation.Click += new System.EventHandler(this.btnBrowsePresetLocation_Click);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrowsePresetLocation);
            this.Controls.Add(this.cbPromptSaveOnClose);
            this.Controls.Add(this.txtDefaultPresetLocation);
            this.Controls.Add(this.cbDefaultPresetLocation);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOptions_FormClosing);
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbDefaultPresetLocation;
        private System.Windows.Forms.TextBox txtDefaultPresetLocation;
        private System.Windows.Forms.CheckBox cbPromptSaveOnClose;
        private System.Windows.Forms.Button btnBrowsePresetLocation;
    }
}