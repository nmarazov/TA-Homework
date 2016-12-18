namespace School.Common
{
    using System;
    using System.Collections.Generic;

    public class Validator
    {
        public static void NullCheck(object obj, string message = null)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(message);
            }
        }

        public static bool IsPartOfCollection<T>(IEnumerable<T> collection, T collectionMember)
        {
            NullCheck(collection, "Collection");
            NullCheck(collectionMember, "CollectionMember");

            foreach (var member in collection)
            {
                if (member.Equals(collectionMember))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
