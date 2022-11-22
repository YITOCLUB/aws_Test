using Common;
using Services;


namespace Queries;

public partial class Query
{
    [GraphQLName("request_id")]
    [GraphQLDescription("uuid取得調査用 C#のGUIDを使用")]
    public string GetRequestId(
        string? prefix)
    {
        Utils.DebOut($"--■GetRequestId--{prefix}");
        return Utils.GetRequestId($"##{prefix}");
    }
}
