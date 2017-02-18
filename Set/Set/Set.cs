using System.Collections;


namespace Set
{
    public class Set
    {

        public ArrayList Elements { get; }

        public Set(ArrayList initList)
        {
            Elements = initList;
        }

        public Set()
        {
            Elements = new ArrayList();
        }

        public Set Union(ArrayList secondSetArrayList)
        {

            var result = Elements;

            foreach (var elem in secondSetArrayList)
            {
                if (!result.Contains(elem))
                {
                    result.Add(elem);
                }
            }

            return new Set(result);

        }

    }
}
