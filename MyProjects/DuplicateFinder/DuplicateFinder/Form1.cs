using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateFinder
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void bt_Action_Click(object sender, EventArgs e)
    {

      List<string> files = Directory.EnumerateFiles(tb_path.Text).ToList();
      List<string> hashs = new List<string>();
      foreach (var item in files)
        hashs.Add(GetFileHash(item));
      var duplicateKeys = hashs.GroupBy(x => x)
                        .Where(group => group.Count() > 1)
                        .Select(group => group.Key);
      foreach (var item in duplicateKeys)
      {
        while (hashs.Contains(item))
        {
          lb_preview.Items.Add(files[hashs.IndexOf(item)]);
          files.RemoveAt(hashs.IndexOf(item));
          hashs.RemoveAt(hashs.IndexOf(item));
        }
      }
    }

    private string GetFileHash(string filename)
    {
      using (var md5 = MD5.Create())
      {
        using (var stream = File.OpenRead(filename))
        {
          return Encoding.Default.GetString(md5.ComputeHash(stream));
        }
      }
    }
    
    private void lb_preview_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lb_preview.SelectedItems.Count == 0) return;
      String filename = lb_preview.SelectedItems[0].ToString();
      if (File.Exists(filename))
        wb_preview.Navigate(filename);
    }
  }
}
