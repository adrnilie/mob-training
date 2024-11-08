namespace GildedRose.Tests;

public class ApprovalTests
{
    [Test]
    public Task GildedRoseScenarios()
    {
        var names = new[] { "Aged Brie", "Sulfuras, Hand of Ragnaros", "Backstage passes to a TAFKAL80ETC concert", "Unknown" };
        var sellIns = new[] { -1, 0, 5, 6, 10, 11 };
        var qualities = new[] { 0, 1, 49, 50 };

        return Combination().Verify(PerformUpdateQuality, names, sellIns, qualities);
    }

    private static string PerformUpdateQuality(string name, int sellIn, int quality)
    {
        var items = new[] { new Item { Name=name, SellIn = sellIn, Quality = quality } };

        var sut = new GildedRose(items);
        sut.UpdateQuality();

        return items[0].ToString();
    }
}