namespace DuplicateFinder
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
      this.tb_path = new System.Windows.Forms.TextBox();
      this.bt_Action = new System.Windows.Forms.Button();
      this.wb_preview = new System.Windows.Forms.WebBrowser();
      this.lb_preview = new System.Windows.Forms.ListBox();
      this.listView1 = new System.Windows.Forms.ListView();
      this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
      ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
      this.SuspendLayout();
      // 
      // tb_path
      // 
      this.tb_path.Location = new System.Drawing.Point(12, 12);
      this.tb_path.Name = "tb_path";
      this.tb_path.Size = new System.Drawing.Size(205, 20);
      this.tb_path.TabIndex = 0;
      this.tb_path.Text = "D:\\Dropbox\\Camera Uploads";
      // 
      // bt_Action
      // 
      this.bt_Action.Location = new System.Drawing.Point(12, 38);
      this.bt_Action.Name = "bt_Action";
      this.bt_Action.Size = new System.Drawing.Size(75, 23);
      this.bt_Action.TabIndex = 1;
      this.bt_Action.Text = "Action";
      this.bt_Action.UseVisualStyleBackColor = true;
      this.bt_Action.Click += new System.EventHandler(this.bt_Action_Click);
      // 
      // wb_preview
      // 
      this.wb_preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wb_preview.Location = new System.Drawing.Point(383, 67);
      this.wb_preview.MinimumSize = new System.Drawing.Size(20, 20);
      this.wb_preview.Name = "wb_preview";
      this.wb_preview.Size = new System.Drawing.Size(501, 459);
      this.wb_preview.TabIndex = 4;
      // 
      // lb_preview
      // 
      this.lb_preview.FormattingEnabled = true;
      this.lb_preview.Location = new System.Drawing.Point(12, 67);
      this.lb_preview.Name = "lb_preview";
      this.lb_preview.Size = new System.Drawing.Size(365, 459);
      this.lb_preview.TabIndex = 5;
      this.lb_preview.SelectedIndexChanged += new System.EventHandler(this.lb_preview_SelectedIndexChanged);
      // 
      // listView1
      // 
      this.listView1.Location = new System.Drawing.Point(12, 67);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(872, 471);
      this.listView1.TabIndex = 6;
      this.listView1.UseCompatibleStateImageBehavior = false;
      // 
      // fileSystemWatcher1
      // 
      this.fileSystemWatcher1.EnableRaisingEvents = true;
      this.fileSystemWatcher1.SynchronizingObject = this;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(896, 538);
      this.Controls.Add(this.listView1);
      this.Controls.Add(this.lb_preview);
      this.Controls.Add(this.wb_preview);
      this.Controls.Add(this.bt_Action);
      this.Controls.Add(this.tb_path);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tb_path;
    private System.Windows.Forms.Button bt_Action;
    private System.Windows.Forms.WebBrowser wb_preview;
    private System.Windows.Forms.ListBox lb_preview;
    private System.Windows.Forms.ListView listView1;
    private System.IO.FileSystemWatcher fileSystemWatcher1;
  }
}

