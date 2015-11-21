using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Infrastructure;
using Dapper;
using SimpleCRUD;

namespace ImportStockDataGUI
{
    class StockNames
    {
        private readonly IDbConnection _connection;

        public StockNames(IDbConnection connection)
        {
            _connection = connection;
        }

        public bool CreateNewStock(Stock stock)
        {
            //Add to stock list
            _connection.Query("InsertIntoStockList", 
                new { symbol = stock.symbol, name = stock.name, exchange = stock.exchange },
                commandType : CommandType.StoredProcedure);
            //Create stock database
            _connection.Query("CreateStockDatabase", new { symbol = stock.symbol}, commandType: CommandType.StoredProcedure);
            //Import stock data
            ImportStocks import = new ImportStocks(_connection);
            import.GetAllTimeStockData(stock.symbol);
            return true;
        }
    }
}
