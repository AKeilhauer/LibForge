﻿namespace ForgeToolGUI
{
  partial class MeshInspector
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.glControl1 = new OpenTK.GLControl();
      this.SuspendLayout();
      // 
      // glControl1
      // 
      this.glControl1.BackColor = System.Drawing.Color.Black;
      this.glControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.glControl1.Location = new System.Drawing.Point(0, 0);
      this.glControl1.Name = "glControl1";
      this.glControl1.Size = new System.Drawing.Size(721, 678);
      this.glControl1.TabIndex = 0;
      this.glControl1.VSync = false;
      this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
      this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
      this.glControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseDown);
      this.glControl1.MouseLeave += new System.EventHandler(this.glControl1_MouseLeave);
      this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseMove);
      this.glControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseUp);
      this.glControl1.Resize += new System.EventHandler(this.glControl1_Resize);
      // 
      // MeshInspector
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.glControl1);
      this.Name = "MeshInspector";
      this.Size = new System.Drawing.Size(721, 678);
      this.ResumeLayout(false);

    }

    #endregion

    private OpenTK.GLControl glControl1;
  }
}
