using System.Data;
using GIT_KOREA_QA_API.Entity.Inspection;
using GIT_KOREA_QA_API.Models.Inspection;
using Oracle.ManagedDataAccess.Client;
using Dapper;
using GIT_KOREA_QA_API.Helper.Database;

namespace GIT_KOREA_QA_API.Repositories.Inspection
{
    public class InspectionRepository : IInspectionRepository
    {
        private readonly string _connectionString;

        public InspectionRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("OracleConnection")!;
        }

        private IDbConnection CreateConnection()
        {
            return new OracleConnection(_connectionString);
        }

        public Task<InspectionResult> GetInspection(InspectionModelRequest request)
        {
            using var connection = CreateConnection();
            connection.Open();



            throw new NotImplementedException();
        }

        public Task<VendorInspectionResult> GetVendor(VendorInspectionModelRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<InspectionResult> SaveInspection(InspectionModelRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<VendorInspectionResult> SaveInspection(VendorInspectionModelRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
