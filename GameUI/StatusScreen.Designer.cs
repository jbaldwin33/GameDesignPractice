namespace GameUI
{
  partial class StatusScreen
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
      this.lblName = new System.Windows.Forms.Label();
      this.lblName2 = new System.Windows.Forms.Label();
      this.lblLevel = new System.Windows.Forms.Label();
      this.lblLevel2 = new System.Windows.Forms.Label();
      this.lblExperience = new System.Windows.Forms.Label();
      this.lblExperience2 = new System.Windows.Forms.Label();
      this.lblGold = new System.Windows.Forms.Label();
      this.lblGold2 = new System.Windows.Forms.Label();
      this.btnCancel = new System.Windows.Forms.Button();
      this.flowLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Controls.Add(this.lblName);
      this.flowLayoutPanel1.Controls.Add(this.lblName2);
      this.flowLayoutPanel1.Controls.Add(this.lblLevel);
      this.flowLayoutPanel1.Controls.Add(this.lblLevel2);
      this.flowLayoutPanel1.Controls.Add(this.lblExperience);
      this.flowLayoutPanel1.Controls.Add(this.lblExperience2);
      this.flowLayoutPanel1.Controls.Add(this.lblGold);
      this.flowLayoutPanel1.Controls.Add(this.lblGold2);
      this.flowLayoutPanel1.Controls.Add(this.btnCancel);
      this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(8, 8, 0, 0);
      this.flowLayoutPanel1.Size = new System.Drawing.Size(403, 363);
      this.flowLayoutPanel1.TabIndex = 0;
      // 
      // lblName
      // 
      this.lblName.Location = new System.Drawing.Point(11, 8);
      this.lblName.Name = "lblName";
      this.lblName.Padding = new System.Windows.Forms.Padding(4);
      this.lblName.Size = new System.Drawing.Size(100, 30);
      this.lblName.TabIndex = 0;
      this.lblName.Text = "Name:";
      // 
      // lblName2
      // 
      this.lblName2.Location = new System.Drawing.Point(117, 8);
      this.lblName2.Name = "lblName2";
      this.lblName2.Size = new System.Drawing.Size(234, 30);
      this.lblName2.TabIndex = 1;
      // 
      // lblLevel
      // 
      this.lblLevel.Location = new System.Drawing.Point(11, 38);
      this.lblLevel.Name = "lblLevel";
      this.lblLevel.Padding = new System.Windows.Forms.Padding(4);
      this.lblLevel.Size = new System.Drawing.Size(100, 30);
      this.lblLevel.TabIndex = 2;
      this.lblLevel.Text = "Level:";
      // 
      // lblLevel2
      // 
      this.lblLevel2.Location = new System.Drawing.Point(117, 38);
      this.lblLevel2.Name = "lblLevel2";
      this.lblLevel2.Size = new System.Drawing.Size(234, 30);
      this.lblLevel2.TabIndex = 3;
      // 
      // lblExperience
      // 
      this.lblExperience.Location = new System.Drawing.Point(11, 68);
      this.lblExperience.Name = "lblExperience";
      this.lblExperience.Padding = new System.Windows.Forms.Padding(4);
      this.lblExperience.Size = new System.Drawing.Size(100, 30);
      this.lblExperience.TabIndex = 4;
      this.lblExperience.Text = "Experience:";
      // 
      // lblExperience2
      // 
      this.lblExperience2.Location = new System.Drawing.Point(117, 68);
      this.lblExperience2.Name = "lblExperience2";
      this.lblExperience2.Size = new System.Drawing.Size(234, 30);
      this.lblExperience2.TabIndex = 5;
      // 
      // lblGold
      // 
      this.lblGold.Location = new System.Drawing.Point(11, 98);
      this.lblGold.Name = "lblGold";
      this.lblGold.Padding = new System.Windows.Forms.Padding(4);
      this.lblGold.Size = new System.Drawing.Size(100, 30);
      this.lblGold.TabIndex = 6;
      this.lblGold.Text = "Gold:";
      // 
      // lblGold2
      // 
      this.lblGold2.Location = new System.Drawing.Point(117, 98);
      this.lblGold2.Name = "lblGold2";
      this.lblGold2.Size = new System.Drawing.Size(234, 30);
      this.lblGold2.TabIndex = 7;
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(171, 311);
      this.btnCancel.Margin = new System.Windows.Forms.Padding(163, 183, 3, 3);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 29);
      this.btnCancel.TabIndex = 8;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += btnCancel_Click;
      // 
      // StatusScreen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.flowLayoutPanel1);
      this.Name = "StatusScreen";
      this.Text = "StatusScreen";
      this.flowLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblName2;
    private System.Windows.Forms.Label lblLevel;
    private System.Windows.Forms.Label lblLevel2;
    private System.Windows.Forms.Label lblExperience;
    private System.Windows.Forms.Label lblExperience2;
    private System.Windows.Forms.Label lblGold;
    private System.Windows.Forms.Label lblGold2;
    private System.Windows.Forms.Button btnCancel;
  }
}