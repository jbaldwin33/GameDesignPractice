namespace GameUI
{
  partial class MainForm
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
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.btnStatusScreen = new System.Windows.Forms.Button();
      this.btnInventoryScreen = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.flowLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Controls.Add(this.btnStatusScreen);
      this.flowLayoutPanel1.Controls.Add(this.btnInventoryScreen);
      this.flowLayoutPanel1.Controls.Add(this.btnCancel);
      this.flowLayoutPanel1.Location = new System.Drawing.Point(630, 12);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(8, 8, 0, 0);
      this.flowLayoutPanel1.Size = new System.Drawing.Size(159, 426);
      this.flowLayoutPanel1.TabIndex = 0;
      // 
      // btnStatusScreen
      // 
      this.btnStatusScreen.Location = new System.Drawing.Point(11, 11);
      this.btnStatusScreen.Name = "btnStatusScreen";
      this.btnStatusScreen.Size = new System.Drawing.Size(130, 40);
      this.btnStatusScreen.TabIndex = 0;
      this.btnStatusScreen.Text = "Status";
      this.btnStatusScreen.UseVisualStyleBackColor = true;
      this.btnStatusScreen.Click += btnStatusScreen_Click;
      // 
      // btnInventoryScreen
      // 
      this.btnInventoryScreen.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.btnInventoryScreen.Location = new System.Drawing.Point(11, 57);
      this.btnInventoryScreen.Name = "btnInventoryScreen";
      this.btnInventoryScreen.Size = new System.Drawing.Size(130, 40);
      this.btnInventoryScreen.TabIndex = 1;
      this.btnInventoryScreen.Text = "Inventory";
      this.btnInventoryScreen.UseVisualStyleBackColor = true;
      this.btnInventoryScreen.Click += btnInventoryScreen_Click;
      // 
      // btnCancel
      // 
      this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.btnCancel.Location = new System.Drawing.Point(11, 103);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(130, 40);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += btnCancel_Click;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.flowLayoutPanel1);
      this.Name = "MainForm";
      this.Text = "Form1";
      this.flowLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Button btnStatusScreen;
    private System.Windows.Forms.Button btnInventoryScreen;
    private System.Windows.Forms.Button btnCancel;
  }
}

