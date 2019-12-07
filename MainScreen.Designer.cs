namespace WhereIsMyCursor
{
  partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.positionX = new System.Windows.Forms.Label();
            this.positionY = new System.Windows.Forms.Label();
            this.positionX_Value = new System.Windows.Forms.Label();
            this.positionY_Value = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.colorValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // positionX
            // 
            this.positionX.AutoSize = true;
            this.positionX.Location = new System.Drawing.Point(14, 14);
            this.positionX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.positionX.Name = "positionX";
            this.positionX.Size = new System.Drawing.Size(136, 20);
            this.positionX.TabIndex = 0;
            this.positionX.Text = "Mouse Position X:";
            // 
            // positionY
            // 
            this.positionY.AutoSize = true;
            this.positionY.Location = new System.Drawing.Point(14, 48);
            this.positionY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.positionY.Name = "positionY";
            this.positionY.Size = new System.Drawing.Size(136, 20);
            this.positionY.TabIndex = 1;
            this.positionY.Text = "Mouse Position Y:";
            // 
            // positionX_Value
            // 
            this.positionX_Value.AutoSize = true;
            this.positionX_Value.Location = new System.Drawing.Point(160, 14);
            this.positionX_Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.positionX_Value.Name = "positionX_Value";
            this.positionX_Value.Size = new System.Drawing.Size(18, 20);
            this.positionX_Value.TabIndex = 2;
            this.positionX_Value.Text = "0";
            // 
            // positionY_Value
            // 
            this.positionY_Value.AutoSize = true;
            this.positionY_Value.Location = new System.Drawing.Point(160, 48);
            this.positionY_Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.positionY_Value.Name = "positionY_Value";
            this.positionY_Value.Size = new System.Drawing.Size(18, 20);
            this.positionY_Value.TabIndex = 3;
            this.positionY_Value.Text = "0";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(231, 14);
            this.color.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(50, 20);
            this.color.TabIndex = 4;
            this.color.Text = "Color:";
            // 
            // colorValue
            // 
            this.colorValue.AutoSize = true;
            this.colorValue.Location = new System.Drawing.Point(291, 14);
            this.colorValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorValue.Name = "colorValue";
            this.colorValue.Size = new System.Drawing.Size(50, 20);
            this.colorValue.TabIndex = 5;
            this.colorValue.Text = "Color!";
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 84);
            this.Controls.Add(this.colorValue);
            this.Controls.Add(this.color);
            this.Controls.Add(this.positionY_Value);
            this.Controls.Add(this.positionX_Value);
            this.Controls.Add(this.positionY);
            this.Controls.Add(this.positionX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Viewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Where is my Cursor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label positionX;
    private System.Windows.Forms.Label positionY;
    private System.Windows.Forms.Label positionX_Value;
    private System.Windows.Forms.Label positionY_Value;
    private System.Windows.Forms.Label color;
    private System.Windows.Forms.Label colorValue;
  }
}

