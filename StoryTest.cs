using System.IO;
using FluentAssertions;
using NUnit.Framework;

namespace OnceUponATime
{
    [TestFixture]
    public class StoryTest
    {
        [Test]
        public void JsonParserSeriesTest()
        {
            var jp = new JsonParser();
            jp.SetFilename("series/Test/TestParse.json");
            var series = jp.GetSeries();
            series.Story.Should().Be("Test");
            series.Season.Should().Be(1);
            series.SeriesNumber.Should().Be(1);
            series.Filename.Should().Be("series/Test/TestParse.json");
            series.Persons[0].Should().BeEquivalentTo(new Person("Jake", "images/Test/Jake.png"));
            series.Persons[1].Should().BeEquivalentTo(new Person("Tom", "images/Test/Tom.png"));
            series.Persons[2].Should().BeEquivalentTo(new Person("Olivia", "images/Test/Olivia.png"));
        }
    }
}