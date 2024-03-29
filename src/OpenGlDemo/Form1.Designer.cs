﻿namespace OpenGlDemo
{
    partial class Form1
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
            this.glControl = new OpenGL.GlControl();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // glControl
            // 
            this.glControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.glControl.ColorBits = ((uint)(24u));
            this.glControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.glControl.DepthBits = ((uint)(24u));
            this.glControl.Location = new System.Drawing.Point(0, 0);
            this.glControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glControl.MultisampleBits = ((uint)(0u));
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(1200, 675);
            this.glControl.StencilBits = ((uint)(0u));
            this.glControl.TabIndex = 0;
            this.glControl.ContextCreated += new System.EventHandler<OpenGL.GlControlEventArgs>(this.glControl_ContextCreated);
            this.glControl.ContextDestroying += new System.EventHandler<OpenGL.GlControlEventArgs>(this.glControl_ContextDestroying);
            this.glControl.Render += new System.EventHandler<OpenGL.GlControlEventArgs>(this.glControl_Render);
            this.glControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glControl_KeyDown);
            this.glControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseMove);
            // 
            // openFileDialog
            // 
            this.openFileDialog.RestoreDirectory = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.glControl);
            this.Name = "Form1";
            this.Text = "OpenGL Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private OpenGL.GlControl glControl;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

