using Microsoft.Data.SqlClient;
using ProjectProduct.Common.Repositories;
using ProjectProduct.DAL.Entities;
using ProjectProduct.DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.DAL.Services
{
    public class StockEntryService : IStockEntryRepository<StockEntry>
    {
        private readonly SqlConnection _connection;
        public StockEntryService(SqlConnection connection)
        {
            _connection = connection;
        }


        public int Create(StockEntry entity)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SP_StockEntry_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(StockEntry.StockOperation), entity.StockOperation);
                    command.Parameters.AddWithValue(nameof(StockEntry.EntryDate), entity.EntryDate);
                    command.Parameters.AddWithValue(nameof(StockEntry.ProductId), entity.ProductId);

                    _connection.Open();
                    return (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    _connection.Close();
                }
            }
        }

        public IEnumerable<StockEntry> Get()
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SP_StockEntry_Get_All";
                command.CommandType = CommandType.StoredProcedure;
                _connection.Open();
                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        yield return reader.ToStockEntry();
                    }
                }
            }
        }

        public StockEntry Get(int id)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SP_StockEntry_Get_By_Id";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(nameof(id), id);
                _connection.Open();
                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    if (reader.Read())
                    {
                        return reader.ToStockEntry();
                    }
                    throw new ArgumentOutOfRangeException(nameof(id));
                }
            }
        }

        public StockEntry GetByProduct(int productId)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SP_StockEntry_Get_By_Product";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(nameof(productId), productId);
                _connection.Open();
                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    if (reader.Read())
                    {
                        return reader.ToStockEntry();
                    }
                    throw new ArgumentOutOfRangeException(nameof(productId));
                }

            }
        }
    }
}
