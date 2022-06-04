using Csharp.Utilities.Base.PathUtilities.Exceptions;
using System;
using System.Linq;

namespace Csharp.Utilities.Base.PathUtilities
{
    public static class PathUtilities
    {
        public static char Ds => System.IO.Path.DirectorySeparatorChar;

        /// <summary>
        /// Remove N number of folder from right side of a path
        /// </summary>
        /// <param name="path">Pathname</param>
        /// <param name="folderCount">How many folder needed to be removed from right</param>
        /// <param name="ds">Directory Seperator (Optional: in case of null, it will resolve from Operating System's default during runtime)</param>
        /// <returns></returns>
        public static string RemoveFolder(string path, int folderCount, string ds = null)
        {

            // Validating Directory Separator
            if (ds is null)
                ds = Ds.ToString();
            else if (ds.Length > 1)
                throw new InvalidDirectorySeperatorCharException(ds);

            char dsChar = ds.ToCharArray()[0];

            path = path.TrimEnd(dsChar);
            return $"{string.Join(ds, path.Split(dsChar).Reverse().Skip(folderCount).Reverse())}{dsChar}";
        }
    }
}
