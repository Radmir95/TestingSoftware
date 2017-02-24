using System.Collections;
using System.Linq;


namespace Set
{
    public class Set
    {

        public ArrayList Elements { get; }

        public Set(ArrayList initList)
        {

            Elements = MakeSet(initList);

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

        private ArrayList MakeSet(ArrayList data)
        {
            var result = data.ToArray().Distinct();
            var returnResult = new ArrayList(result.ToArray());
            return returnResult;
        }

    }
}
