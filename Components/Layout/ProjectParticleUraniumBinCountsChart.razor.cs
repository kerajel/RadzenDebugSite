namespace RadzenDebugSite.Components.Layout;

public partial class ProjectParticleUraniumBinCountsChart
{
    ILookup<string, BinCount> _particleUraniumBinCounts = Enumerable.Empty<(string, BinCount)>()
            .ToLookup(pair => pair.Item1, pair => pair.Item2);

    protected override async Task OnInitializedAsync()
    {
        await Refresh();
    }

    public async Task Refresh()
    {
        var sampleData = new[]
        {
        ("U234", "n.m.", 2),
        ("U234", "< 1", 3),
        ("U234", "1-2", 5),
        ("U234", "2-3", 8),
        ("U234", "3-4", 13),
        ("U234", "4-5", 21),
        ("U234", "5-6", 34),
        ("U234", "6-7", 55),
        ("U234", "7-8", 89),
        ("U234", "8-9", 144),
        ("U234", "> 9", 233),
        ("U235", "n.m.", 1),
        ("U235", "< 1", 2),
        ("U235", "1-2", 4),
        ("U235", "2-3", 8),
        ("U235", "3-4", 16),
        ("U235", "4-5", 32),
        ("U235", "5-6", 64),
        ("U235", "6-7", 128),
        ("U235", "7-8", 256),
        ("U235", "8-9", 512),
        ("U235", "> 9", 1024)
    };

        _particleUraniumBinCounts = sampleData
            .Select(x => new { Isotope = x.Item1, Bin = new BinCount { Name = x.Item2, Count = x.Item3 } })
            .ToLookup(x => x.Isotope, x => x.Bin);

        StateHasChanged();
    }

    public class BinCount
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}