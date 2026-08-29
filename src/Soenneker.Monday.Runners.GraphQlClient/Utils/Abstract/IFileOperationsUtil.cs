using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Monday.Runners.GraphQlClient.Utils.Abstract;

public interface IFileOperationsUtil
{
    /// <summary>
    /// Processes the pending work managed by the File Operations.
    /// </summary>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task that completes when the full processing workflow has finished.</returns>
    ValueTask Process(CancellationToken cancellationToken = default);
}
