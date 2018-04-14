using ActuarialIntelligence.MiningStructureMetaReader.Interfaces;
using Microsoft.AnalysisServices.AdomdClient;
using Microsoft.AnalysisServices.Tabular;

namespace Infrastructure.Connections
{
    public class SSRSConnection : IQueryDataConnection<AdomdDataReader>
    {
        private readonly AdomdConnection connection;
        public SSRSConnection(string connectionString)
        {
            connection = new AdomdConnection(connectionString);
            Server server = new Server();
            server.Connect(connectionString);
            connection.Open();

        }

        public AdomdDataReader LoadData(string dmxQuery)
        {

            Database db = new Database();
            var command = new AdomdCommand(dmxQuery, connection);
            var reader = command.ExecuteReader();

            return reader;
        }

        public void ClearAndDispose()
        {
            connection.Close();
            connection.Dispose();
        }
    }
}
