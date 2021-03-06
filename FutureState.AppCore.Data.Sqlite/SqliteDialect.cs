﻿namespace FutureState.AppCore.Data.Sqlite
{
    public class SqliteDialect : IDialect
    {
        public string UseDatabase
        {
            get { return ""; }
        }

        public string CreateTable
        {
            get { return "CREATE TABLE [{0}] ({1});"; }
        }

        public string UpdateTable
        {
            get { return "ALTER TABLE [{0}] ADD {1};"; }
        }

        public string CreateIndex
        {
            get { return "CREATE INDEX [{0}] ON [{1}] ({2});"; }
        }

        public string CreateColumn
        {
            get { return "[{0}] {1} {2}"; }
        }

        public string CheckDatabaseExists
        {
            get { return ""; }
        }

        public string CheckTableExists
        {
            get { return "SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='{0}'"; }
        }

        public string CheckTableColumnExists
        {
            get { return "SELECT SQL FROM sqlite_master WHERE tbl_name='{0}'"; }
        }

        public string CreateDatabase
        {
            get { return ""; }
        }

        public string DropDatabase
        {
            get { return ""; }
        }

        public string InsertInto
        {
            get { return "INSERT INTO [{0}] ({1}) VALUES ({2})"; }
        }

        public string SelectFrom
        {
            get { return "SELECT [{0}].* FROM [{0}] {1}"; }
        }

        public string SelectCountFrom
        {
            get { return "SELECT COUNT([{0}].*) FROM [{0}] {1}"; }
        }

        public string SelectMaxFrom
        {
            get { return "SELECT MAX([{0}].[{2}]) FROM [{0}] {1}"; }
        }

        public string SelectMinFrom
        {
            get { return "SELECT MIN([{0}].[{2}]) FROM [{0}] {1}"; }
        }

        public string SelectSumFrom
        {
            get { return "SELECT SUM([{0}].[{2}]) FROM [{0}] {1}"; }
        }

        public string DeleteFrom
        {
            get { return "DELETE FROM [{0}] {1}"; }
        }

        public string Update
        {
            get { return "UPDATE [{0}] SET {1} {2}"; }
        }

        public string SelectFromJoin
        {
            get { return "SELECT [{0}].* FROM [{0}] {1} {2}"; }
        }

        public string SelectCountFromJoin
        {
            get { return "SELECT COUNT([0].*) FROM [{0}] {1} {2}"; }
        }

        public string SelectMaxFromJoin
        {
            get { return "SELECT MAX([0].[{3}]) FROM [{0}] {1} {2}"; }
        }

        public string SelectMinFromJoin
        {
            get { return "SELECT MIN([0].[{3}]) FROM [{0}] {1} {2}"; }
        }

        public string SelectSumFromJoin
        {
            get { return "SELECT SUM([0].[{3}]) FROM [{0}] {1} {2}"; }
        }

        public string DeleteFromJoin
        {
            get { return "DELETE FROM [{0}] {1} {2}"; }
        }

        public string UpdateJoin
        {
            get { return "UPDATE [{0}] SET {1} {2} {3}"; }
        }

        public string Where
        {
            get { return "WHERE {0}"; }
        }

        public string JoinFields
        {
            get { return "[{0}], [{1}]"; }
        }

        public string JoinParameters
        {
            get { return "@{0}, @{1}"; }
        }

        public string InnerJoin
        {
            get { return "INNER JOIN [{0}] ON {1}"; }
        }

        public string LeftJoin
        {
            get { return "LEFT OUTER JOIN [{0}] ON {1}"; }
        }

        public string OldManyToManyJoin
        {
            get { return "INNER JOIN {0} ON {0}.{1}Id = {2}.Id INNER JOIN {3} ON {0}.{4}Id = {3}.Id"; }
        }

        public string ManyToManyJoin
        {
            get { return "INNER JOIN [{2}] ON [{2}].[{3}] = [{0}].[{1}] INNER JOIN [{4}] ON [{2}].[{5}] = [{4}].[{1}]"; }
        }

        public string SkipTake
        {
            get { return "LIMIT {1} OFFSET {0}"; }
        }

        // Constraints
        public string PrimaryKeyConstraint
        {
            get { return "PRIMARY KEY"; }
        }

        public string ForeignKeyConstraint
        {
            get { return "REFERENCES {2} ({3})"; }
        }

        public string NullableConstraint
        {
            get { return "NULL"; }
        }

        public string NotNullableConstraint
        {
            get { return "NOT NULL"; }
        }

        public string OnDeleteNoActionConstraint
        {
            get { return "ON DELETE NO ACTION"; }
        }

        public string OnUpdateNoActionConstraint
        {
            get { return "ON UPDATE NO ACTION"; }
        }

        public string UniqueConstraint
        {
            get { return "UNIQUE"; }
        }

        public string DefaultBoolConstraint
        {
            get { return "DEFAULT({0})"; }
        }

        public string DefaultIntegerConstraint
        {
            get { return "DEFAULT({0})"; }
        }

        public string DefaultStringConstraint
        {
            get { return "DEFAULT '{0}'"; }
        }

        public string CompositeKeyConstraint
        {
            get { return "PRIMARY KEY ({2}, {3})"; }
        }

        public string CompositeUniqueConstraint
        {
            get { return "UNIQUE ({0}, {1})"; }
        }

        public string ClusteredConstraint
        {
            get { return ""; }
        }

        public string NonClusteredConstraint
        {
            get { return ""; }
        }

        // Data Types
        public string Bool
        {
            get { return "bit"; }
        }

        public string Byte
        {
            get { return "tinyint"; }
        }

        public string ByteArray
        {
            get { return "binary"; }
        }

        public string DateTime
        {
            get { return "datetime"; }
        }

        public string Decimal
        {
            get { return "money"; }
        }

        public string Double
        {
            get { return "float"; }
        }

        public string Guid
        {
            get { return "uniqueidentifier"; }
        }

        public string Integer
        {
            get { return "int"; }
        }

        public string Int64
        {
            get { return "bigint"; }
        }

        public string Int16
        {
            get { return "int"; }
        }

        public string LimitedString
        {
            get { return "nvarchar({0})"; }
        }

        public string MaxString
        {
            get { return "text"; }
        }

        public string Single
        {
            get { return "real"; }
        }

        public string TimeSpan
        {
            get { return "time"; }
        }

        public string OrderBy
        {
            get { return "ORDER BY {0} {1}"; }
        }

        public string Truncate
        {
            get { return "DELETE FROM {0}"; }
        }
    }
}