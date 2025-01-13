using System;

namespace QueryHelpers;

public class OdataToSqlConverter
{
    public OdataToSqlConverter()
    {
        QueryParams = new QueryParameter();
    }

    QueryParameter QueryParams { get; set; }

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

    void LoadQueryParams(string val)
    {
        var qryvals = val.Split('?')[1];
        var queryParams = qryvals.Split('&');

        foreach (var queryParam in queryParams)
        {
            var key = queryParam.Split('=')[0].ToLower().Substring(1);
            var value = queryParam.Split('=')[1];

            switch (key)
            {
                case "filter":
                    QueryParams.Filter = value;
                    break;
                case "select":
                    QueryParams.Select = value;
                    break;
                case "orderby":
                    QueryParams.OrderBy = value;
                    break;
                case "count":
                    QueryParams.Count = value;
                    break;
                case "top":
                    QueryParams.Top = value;
                    break;
                case "skip":
                    QueryParams.Skip = value;
                    break;
                default:
                    break;
            }
        }    
    }
}

class QueryParameter
{
    public string Filter { get; set; }
    public string Select { get; set; }
    public string OrderBy { get; set; }
    public string Count { get; set; }
    public string Top { get; set; }
    public string Skip { get; set; }
}