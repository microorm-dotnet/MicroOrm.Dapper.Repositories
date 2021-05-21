using MicroOrm.Dapper.Repositories.Tests.DatabaseFixture;
using Xunit;
using Xunit.Abstractions;

namespace MicroOrm.Dapper.Repositories.Tests.RepositoriesTests
{
    
    public class MsSql2008RepositoriesTests : RepositoriesTests, IClassFixture<MsSql2008DatabaseFixture>
    {
        public MsSql2008RepositoriesTests(MsSql2008DatabaseFixture msSqlDatabaseFixture, ITestOutputHelper testOutputHelper)
            : base(msSqlDatabaseFixture.Db, testOutputHelper)
        {
        }
        
        // only Databse specific tests
    }
}
