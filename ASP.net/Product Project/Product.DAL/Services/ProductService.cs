using Microsoft.Data.SqlClient;
using ProjectProduct.Common.Repositories;
using ProjectProduct.DAL.Entities;
using ProjectProduct.DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.DAL.Services
{
    public class ProductService : IProductRepository<Product>
    {
        private readonly SqlConnection _connection;

        public ProductService(SqlConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Product> Get()
        {
            using (SqlCommand command = _connection.CreateCommand())
            {

                command.CommandText = "SP_Product_Get_All";
                command.CommandType = CommandType.StoredProcedure;
                _connection.Open();
                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        yield return reader.ToProduct();
                    }
                }
            }
        }

        public Product Get(int productId)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = "SP_Product_Get_By_Id";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(nameof(productId), productId);
                _connection.Open();
                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    if (reader.Read())
                    {
                        return reader.ToProduct();
                    }
                    throw new ArgumentOutOfRangeException(nameof(productId));
                }
            }
        }

        public int Create(Product entity)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SP_Product_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(Product.ProductId), entity.ProductId);
                    command.Parameters.AddWithValue(nameof(Product.Name), entity.Name);
                    command.Parameters.AddWithValue(nameof(Product.Description), (object?)entity.Description ?? DBNull.Value);
                    command.Parameters.AddWithValue(nameof(Product.CurrentPrice), entity.CurrentPrice);
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

        public void Update(int productId, Product newData)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SP_Product_Update";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(productId), productId);
                    command.Parameters.AddWithValue(nameof(Product.Name), newData.Name);
                    command.Parameters.AddWithValue(nameof(Product.Description), (object?)newData.Description ?? DBNull.Value);
                    command.Parameters.AddWithValue(nameof(Product.CurrentPrice), newData.CurrentPrice);
                    _connection.Open();
                    command.ExecuteNonQuery();

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

        public void Delete(int productId)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SP_Product_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(productId), productId);
                    _connection.Open();
                    command.ExecuteNonQuery();

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

        public int GetStock(int productId)
        {
            using (SqlCommand command = _connection.CreateCommand())
            {
                try
                {

                    command.CommandText = "SP_Product_Get_Stock";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(nameof(productId), productId);
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
    }
}
