using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Monday.Runners.GraphQlClient.Utils.Abstract;

public interface IFileOperationsUtil
{
    ValueTask Process(CancellationToken cancellationToken = default);
}
