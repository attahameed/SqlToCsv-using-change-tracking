using System.Collections.Generic;

namespace SyncChanges.Core
{
    class ChangeInfo
    {
        public long Version { get; set; }
        public List<Change> Changes { get; private set; } = new List<Change>();
    }
}