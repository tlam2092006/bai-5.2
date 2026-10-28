using System.Data;
using Microsoft.Data.SqlClient;

namespace bai_5._2
{
    internal sealed class RegistrationRepository
    {
        private const string DatabaseName = "CourseRegistrationDb";
        private const string MasterConnectionString = "Server=(localdb)\\MSSQLLocalDB;Integrated Security=True;TrustServerCertificate=True;Initial Catalog=master";

        private static readonly string DatabaseConnectionString =
            new SqlConnectionStringBuilder(MasterConnectionString) { InitialCatalog = DatabaseName }.ConnectionString;

        public void Save(CourseRegistration registration)
        {
            EnsureDatabase();
            EnsureTable();

            using var connection = new SqlConnection(DatabaseConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = """
                INSERT INTO dbo.Registrations
                    (FullName, Gender, CourseCode, CourseName, BirthDate, Phone, ReceiveUpdates)
                VALUES
                    (@FullName, @Gender, @CourseCode, @CourseName, @BirthDate, @Phone, @ReceiveUpdates)
                """;
            command.Parameters.Add("@FullName", SqlDbType.NVarChar, 150).Value = registration.FullName;
            command.Parameters.Add("@Gender", SqlDbType.NVarChar, 20).Value = registration.Gender;
            command.Parameters.Add("@CourseCode", SqlDbType.NVarChar, 20).Value = registration.CourseCode;
            command.Parameters.Add("@CourseName", SqlDbType.NVarChar, 150).Value = registration.CourseName;
            command.Parameters.Add("@BirthDate", SqlDbType.Date).Value = registration.BirthDate.Date;
            command.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Value = registration.Phone;
            command.Parameters.Add("@ReceiveUpdates", SqlDbType.Bit).Value = registration.ReceiveUpdates;
            command.ExecuteNonQuery();
        }

        private static void EnsureDatabase()
        {
            using var connection = new SqlConnection(MasterConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = $"IF DB_ID(N'{DatabaseName}') IS NULL CREATE DATABASE [{DatabaseName}]";
            command.ExecuteNonQuery();
        }

        private static void EnsureTable()
        {
            using var connection = new SqlConnection(DatabaseConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = """
                IF OBJECT_ID(N'dbo.Registrations', N'U') IS NULL
                BEGIN
                    CREATE TABLE dbo.Registrations
                    (
                        RegistrationId INT IDENTITY(1,1) PRIMARY KEY,
                        FullName NVARCHAR(150) NOT NULL,
                        Gender NVARCHAR(20) NOT NULL,
                        CourseCode NVARCHAR(20) NOT NULL,
                        CourseName NVARCHAR(150) NOT NULL,
                        BirthDate DATE NOT NULL,
                        Phone NVARCHAR(20) NOT NULL,
                        ReceiveUpdates BIT NOT NULL,
                        RegisteredAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME()
                    )
                END
                """;
            command.ExecuteNonQuery();
        }
    }

    internal sealed record CourseRegistration(
        string FullName,
        string Gender,
        string CourseCode,
        string CourseName,
        DateTime BirthDate,
        string Phone,
        bool ReceiveUpdates);
}
