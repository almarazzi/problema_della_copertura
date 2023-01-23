namespace pp
{
    internal class Coperture
    {
        // public Dictionary<string,HashSet<string>> stati { get; private set; }
       
        public HashSet<string> fine { get; private set; } = new HashSet<string>();
        public void Coperture1()
        {

            var stati = new Dictionary<string, HashSet<string>>();
            stati.Add("uno", new HashSet<string>
            {
                "id",
                "nv",
                "ut"
            });
            stati.Add("due", new HashSet<string>
             {
                "wa",
                "id",
                "mt"
            });
            stati.Add("tre", new HashSet<string>
            {
                "or",
                "nv",
                "ca"
            });
            stati.Add("quattro", new HashSet<string>
            {
                "nv",
                "ut"
            });
            stati.Add("cinque", new HashSet<string>
            {
                "ca",
                "az"
            });

            var c = 0;
            
            var stativisti = new HashSet<string>();
            while (c < 5)
            {
                var p = stati.MaxBy(x => x.Value.Except(stativisti).Count()).Key;
                fine.Add(p);

                foreach (var i in stati.MaxBy(x => x.Value.Except(stativisti).Count()).Value)
                {
                    stativisti.Add(i);
                }
                c++;
            }
            
        }
       
    }
}
