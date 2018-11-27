using System.IO;
using Layout;

namespace Iteration.Papers.GardenFence
{
    public class Paper : Layout.Paper
    {
        public Paper() : base(new Task[]{}, "Garden Fence", "Report to directory for document files: " + Directory.GetCurrentDirectory() + ".") {}
    }
}