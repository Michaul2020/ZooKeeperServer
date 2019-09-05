
using System.Collections.Generic;
using ZooKeeperServer.Models;

namespace ZooKeeperServer.Services
{
    public interface ILabellingService
    {
        IEnumerable<Label> LabelImage(string base64Image);
    }
}