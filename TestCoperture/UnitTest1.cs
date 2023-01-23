using pp;
namespace TestCoperture
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var p = new Coperture();
            p.Coperture1();
            HashSet<string> set = new HashSet<string>
            {
                "uno",
                "due",
                "tre",
                "cinque"
            };
            Assert.Equal(set,p.fine);
            
        }
    }
}