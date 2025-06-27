using System;
using System.IO;

namespace bwhelp
{
    public class FileChecker
    {
        /// <summary>
        /// Verify if "bwver" exists for calling like a "About Box"
        /// </summary>
        /// <returns>true if exists, false if not.</returns>
        public static bool BwverExists()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(currentDirectory, "bwver");
            return File.Exists(filePath);
        }
    }
}