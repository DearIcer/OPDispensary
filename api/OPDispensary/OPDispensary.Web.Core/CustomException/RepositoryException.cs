namespace OPDispensary.Web.Core.CustomException;

public interface IRepositoryExceptionException
{
    public string Message { get; }

    public string ErrorCode { get; }

    public object[] ErrorData { get; }
    
    public string Extras { get; }
    
    public DateTime Time { get; }
}
public class RepositoryException : Exception, IRepositoryExceptionException
{
    public string Message { get; }
    public string ErrorCode { get; }
    public object[] ErrorData { get; }
    public string Extras { get; }
    public DateTime Time { get; }
}


