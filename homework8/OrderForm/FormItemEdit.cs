using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;

namespace OrderForm {
  public partial class FormItemEdit : Form {
    public OrderItem OrderItem { get; set; }

    public FormItemEdit() {
      InitializeComponent();
    }

    public FormItemEdit(OrderItem orderItem):this() {
      this.OrderItem = orderItem;
      this.ItemBindingSource.DataSource = orderItem;
      goodsBindingSource.Add(new Goods("1", "apple", 100.0));
      goodsBindingSource.Add(new Goods("2", "egg", 200.0));
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

    }

    private void label4_Click(object sender, EventArgs e) {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
      ItemBindingSource.ResetBindings(false);
    }
  }
}
