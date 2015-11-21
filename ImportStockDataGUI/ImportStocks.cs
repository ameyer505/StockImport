using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Dapper;
using SimpleCRUD;
using Infrastructure;
using System.Data.SqlClient;
using System.Net;
using System.IO;

namespace ImportStockDataGUI
{
    class ImportStocks
    {
        private readonly IDbConnection _connection;

        public ImportStocks(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Stock> GetStocks()
        {
            return _connection.GetList<Stock>();
        }

        public bool GetAllTimeStockData(string symbol)
        {
            try {
                _connection.Query("CreateStockDatabase", new { symbol = symbol }, commandType: CommandType.StoredProcedure);

                //Get data from Yahoo Finance
                string url = @"http://ichart.yahoo.com/table.csv?s=" + symbol;
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string skip = reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');
                        StockHistoricalData shd = new StockHistoricalData();
                        shd.date = DateTime.Parse(values[0]);
                        shd.open = Double.Parse(values[1]);
                        shd.high = Double.Parse(values[2]);
                        shd.low = Double.Parse(values[3]);
                        shd.close = Double.Parse(values[4]);
                        shd.volume = Int32.Parse(values[5]);
                        shd.adjClose = Double.Parse(values[6]);

                        _connection.Query("InsertStockData", new
                        {
                            symbol = symbol,
                            date = shd.date,
                            open = shd.open,
                            high = shd.high,
                            low = shd.low,
                            close = shd.close,
                            volume = shd.volume,
                            adjclose = shd.adjClose
                        }, commandType: CommandType.StoredProcedure);
                    }

                }
            }
            catch(Exception ex)
            {

            }
            return true;
        }

        public bool GetWeekStockData(string symbol)
        {
            try {
                DateTime weekAgo = DateTime.Now.AddDays(-5);
                int day = weekAgo.Day;
                int month = weekAgo.Month - 1;
                int year = weekAgo.Year;

                //Get data from Yahoo Finance
                string url = @"http://ichart.yahoo.com/table.csv?s=" + symbol + @"&a=" + month + @"&b=" + day + @"&c=" + year;
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string skip = reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');
                        StockHistoricalData shd = new StockHistoricalData();
                        shd.date = DateTime.Parse(values[0]);
                        shd.open = Double.Parse(values[1]);
                        shd.high = Double.Parse(values[2]);
                        shd.low = Double.Parse(values[3]);
                        shd.close = Double.Parse(values[4]);
                        shd.volume = Int32.Parse(values[5]);
                        shd.adjClose = Double.Parse(values[6]);

                        _connection.Query("InsertStockData", new
                        {
                            symbol = symbol,
                            date = shd.date,
                            open = shd.open,
                            high = shd.high,
                            low = shd.low,
                            close = shd.close,
                            volume = shd.volume,
                            adjclose = shd.adjClose
                        }, commandType: CommandType.StoredProcedure);
                    }
                }
            }
            catch(Exception ex)
            {

            }
            return true;
        }
    }
}
