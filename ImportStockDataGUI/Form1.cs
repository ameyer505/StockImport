using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Infrastructure;

namespace ImportStockDataGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_integratedSecurity.Checked == true)
            {
                tb_username.Text = "";
                tb_password.Text = "";
                tb_username.Enabled = false;
                tb_password.Enabled = false;
            }
            else
            {
                tb_username.Enabled = true;
                tb_password.Enabled = true;
            }
        }

        private void cbImportAllStocks_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_importAllStocks.Checked == true)
            {
                tb_symbol.Text = "";
                tb_symbol.Enabled = false;
            }
            else
            {
                tb_symbol.Enabled = true;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            tb_log.Text = string.Empty;
            SqlConnection conn = new SqlConnection();
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = tb_server.Text;
            sb.InitialCatalog = tb_database.Text;
            if (cb_integratedSecurity.Checked == true)
            {
                sb.IntegratedSecurity = true;
            }
            else
            {
                sb.IntegratedSecurity = false;
                sb.UserID = tb_username.Text;
                sb.Password = tb_password.Text;
            }
            conn.ConnectionString = sb.ToString();

            ImportStocks import = new ImportStocks(conn);
            if(cb_importAllStocks.Checked == true)
            {
                IEnumerable<Stock> stocks = import.GetStocks();
                foreach (Stock stock in stocks)
                {
                    tb_log.AppendText(DateTime.Now + " - Processing: " + stock.symbol + "\n");
                    if (rb_allTime.Checked == true)
                        import.GetAllTimeStockData(stock.symbol);
                    else
                        import.GetWeekStockData(stock.symbol);
                    tb_log.AppendText(DateTime.Now + " - Processed: " + stock.symbol + "\n");
                }
            }
            else
            {
                tb_log.AppendText(DateTime.Now + " - Processing: "+ tb_symbol.Text+"\n");
                if (rb_allTime.Checked == true)
                    import.GetAllTimeStockData(tb_symbol.Text);
                else
                    import.GetWeekStockData(tb_symbol.Text);
                tb_log.AppendText(DateTime.Now + " - Processed: " + tb_symbol.Text + "\n");
            }
            tb_log.AppendText(DateTime.Now + " - ***FINISHED PROCESSING***");
        }

        private void btnAddNewStock_Click(object sender, EventArgs e)
        {
            tb_log.Text = string.Empty;
            SqlConnection conn = new SqlConnection();
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = tb_server.Text;
            sb.InitialCatalog = tb_database.Text;
            if (cb_integratedSecurity.Checked == true)
            {
                sb.IntegratedSecurity = true;
            }
            else
            {
                sb.IntegratedSecurity = false;
                sb.UserID = tb_username.Text;
                sb.Password = tb_password.Text;
            }
            conn.ConnectionString = sb.ToString();

            tb_log.AppendText(DateTime.Now + " - Processing: " + tb_newSymbol.Text + "\n");

            StockNames stockNames = new StockNames(conn);
            Stock s = new Stock();
            s.symbol = tb_newSymbol.Text;
            s.name = tb_newName.Text;
            s.exchange = cb_exchange.SelectedItem.ToString();
            stockNames.CreateNewStock(s);

            tb_log.AppendText(DateTime.Now + " - Processed: " + tb_newSymbol.Text + "\n");
            tb_log.AppendText(DateTime.Now + " - ***FINISHED PROCESSING***");
        }
    }
}
