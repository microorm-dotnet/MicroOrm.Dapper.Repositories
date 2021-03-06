﻿using MicroOrm.Dapper.Repositories.Tests.DatabaseFixture;
using Xunit;
using Xunit.Abstractions;

namespace MicroOrm.Dapper.Repositories.Tests.RepositoriesTests
{
    public class MsSql2019RepositoriesTests : RepositoriesTests, IClassFixture<MsSql2019DatabaseFixture>
    {
        public MsSql2019RepositoriesTests(MsSql2019DatabaseFixture msSqlDatabaseFixture, ITestOutputHelper testOutputHelper)
            : base(msSqlDatabaseFixture.Db, testOutputHelper)
        {
        }

        // only Databse specific tests
    }
}
