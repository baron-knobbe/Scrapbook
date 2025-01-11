using System;

namespace QueryHelpers;

public static class OdataToSqlConverter
{
    public static string Convert(string odataQuery)
    {
        return odataQuery;
    }

    static string ConvertFilter(string filter)
    {
        return filter;
    }

    static string ConvertSelect(string select)
    {
        return select;
    }

    static string ConvertOrderBy(string orderBy)
    {
        return orderBy;
    }

    static string ConvertOperator(string operatorName)
    {
        return operatorName;
    }

    static string ConvertFunction(string val)
    {
        // contains, startswith, endswith, etc.
        return val;
    }
}
