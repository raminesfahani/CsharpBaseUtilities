﻿using System;

namespace Csharp.Utilities.Base.PathUtilities.Exceptions
{
    public class InvalidDirectorySeperatorCharException : Exception
    {
        public InvalidDirectorySeperatorCharException(string directorySeparator) :
            base($"Invalid Directory Separator was provided: {directorySeparator}")
        {
            DirectorySeparator = directorySeparator;
        }
        public string DirectorySeparator { get; }
    }
}
